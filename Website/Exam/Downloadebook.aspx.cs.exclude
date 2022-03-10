using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;

public partial class USER_Downloadebook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                
                User_Mst objuser = User_MstManager.Select(Convert.ToInt32(Session["UserId"]));
                if (objuser != null)
                {
                    lblUsername.Text = objuser.FirstName + " " + objuser.LastName;
                }
                BindMainTitle();
            }
            
        }
        if (Session["UserId"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
    void BindMainTitle()
    {
        User_Mst objuser = User_MstManager.Select(Convert.ToInt32(Session["UserId"]));
        List<FileUploadMst> objfileuploadList = FileUploadMstManager.GetAll_1(Convert.ToInt32(objuser.Technical), Convert.ToInt32(Session["level"]));
        if (objfileuploadList.Count > 0)
        {
            gvExam.Visible = true;
            gvExam.DataSource = objfileuploadList;
            gvExam.DataBind();
        }
        else
        {
            gvExam.Visible = false;
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("WelCome.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("History.aspx");
    }
    protected void imgdownloadebook_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Downloadebook.aspx");
    }
    protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
    {
        Session.Abandon();
        Session.RemoveAll();
        Response.Redirect("~/Default.aspx");
    }
    protected void gvExam_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvExam.PageIndex = e.NewPageIndex;
        BindMainTitle();
    }
}