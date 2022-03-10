using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;

public partial class Admin_AddLevel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (!IsPostBack)
            {
                BindMainTitle();
                BindSubtitle();
                lblMessage.Text = "";
            }
            lblMessage.Text = "";
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }
    public void BindMainTitle()
    {
        ddlMainTitle.DataTextField = "FunctionName";
        ddlMainTitle.DataValueField = "Functionid";
        ddlMainTitle.DataSource = FunctionMstManager.GetAll();
        ddlMainTitle.DataBind();

        ddlMainTitle.Items.Insert(0, "Select");

    }
    public void BindSubtitle()
    {

        gvSubTitle.DataSource = LevelMstManager.ListSubTitle();
        gvSubTitle.DataBind();

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            LevelMst objlevel = new LevelMst();
            if (ddlMainTitle.SelectedValue != "Select")
            {
                objlevel.Functionid = Convert.ToInt32(ddlMainTitle.SelectedValue);

                objlevel.Levelname = "Level" + txtSubTitle.Text;
                objlevel.InsertedBy = 1;
                objlevel.InsertedOn = System.DateTime.Now;
                int levelid = Convert.ToInt32(LevelMstManager.Add(objlevel));
                if (levelid == 1)
                {
                    lblMessage.Text = "Successfully Added";
                }
                else
                {
                    lblMessage.Text = "Already Exist";
                }
                BindSubtitle();

            }
            else
            {
                lblMessage.Text = "Select Main Title";
                return;
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
           
            


    }
    protected void gvSubTitle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int SubID;
            SubID = Convert.ToInt32(e.CommandArgument.ToString());
            if (e.CommandName == "Delete")
            {
                LevelMstManager.Delete(SubID);
                lblMessage.Text = "Successfully Deleted";
            }
            
            BindSubtitle();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }
    protected void gvSubTitle_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void gvSubTitle_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvSubTitle.PageIndex = e.NewPageIndex;
        BindSubtitle();
    }
    protected void ddlMainTitle_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}