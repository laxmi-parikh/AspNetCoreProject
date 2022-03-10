using System;
using System.Collections;
using System.Configuration;
using System.Data;
// using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
// using System.Xml.Linq;
using BusinessL;
using System.Data.SqlClient;
public partial class Admin_AddSubTitle : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindMainTitle();
            BindSubtitle();
            lblMessage.Text = "";  
        }
        lblMessage.Text = "";  

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

       
        try
        {

        SubTitle ObjType = new SubTitle();
            if(ddlMainTitle.SelectedValue!="Select")
            {
             ObjType.MainID = Convert.ToInt32(ddlMainTitle.SelectedValue);
            } else
            {
                lblMessage.Text = "Select Main Title";
                return;
            }
        ObjType.SubTitle1 = txtSubTitle.Text;
      
        ObjType.Insertedby = 1;

        int ID = SubTitleManager.Add(ObjType);

        if (ID > 0)
        {
            lblMessage.Text = "Successfully Added";
            BindSubtitle();
            txtSubTitle.Text = string.Empty;
        }
        else
        {
            lblMessage.Text = "Already Exist";
            BindSubtitle();
            txtSubTitle.Text = string.Empty;
        }

        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
           
        }     



    }
   

    public void BindMainTitle()
    {
        ddlMainTitle.DataTextField = "Title";
        ddlMainTitle.DataValueField = "MainID";
        ddlMainTitle.DataSource = MainTitleManager.GetAll();
        ddlMainTitle.DataBind();

        ddlMainTitle.Items.Insert(0, "Select");
        
    }

    public void BindSubtitle()
    {
       
        gvSubTitle.DataSource = SubTitleManager.ListSubTitle();
        gvSubTitle.DataBind();
    
    }


    protected void gvSubTitle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int SubID;

        SubID = Convert.ToInt32(e.CommandArgument.ToString());

        if (e.CommandName == "Delete")
        {
            
            SubTitleManager.Delete(SubID);

                   
        }
        lblMessage.Text = "Successfully Deleted";
        BindSubtitle();
        

        
    }
    protected void gvSubTitle_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvSubTitle.PageIndex = e.NewPageIndex;
        BindSubtitle();
        lblMessage.Text = "";  
    }
    protected void gvSubTitle_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        gvSubTitle.EditIndex = -1;
        BindSubtitle();

    }
    protected void ddlMainTitle_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

