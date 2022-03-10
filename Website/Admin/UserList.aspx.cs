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
using System.Data.SqlClient;
using System.Collections.Generic;
using BusinessL;

public partial class Admin_AddMainTitle : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
            lbltitle.Text = "";
        }
         lbltitle.Text = "";
        

    }
  

    public void BindGrid()
    {
         lbltitle.Text = "";

         List<User_Mst> objuser = User_MstManager.GetAll(true);
        if (objuser.Count> 0)
        {
            gvMainTitle.DataSource = objuser;
            gvMainTitle.DataBind();
        }
        else
        {
            lbltitle.Text = "No Data Found";
        }
    }
    protected void gvMainTitle_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvMainTitle.PageIndex = e.NewPageIndex;
        BindGrid();

    }
    protected void gvMainTitle_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvMainTitle_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
       
        gvMainTitle.EditIndex = -1;
        BindGrid();
        
         
    }
    protected void gvMainTitle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int UserId;
      
        
        if (e.CommandName == "Delete")
        {

            UserId = Convert.ToInt32(e.CommandArgument.ToString());

            User_MstManager.Delete(UserId);
           
           
        }
        lbltitle.Text = "Successfully Deleted";
         


    }
}
