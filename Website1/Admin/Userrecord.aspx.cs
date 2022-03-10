using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using BusinessL;

public partial class Admin_Userrecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            lbltitle.Text = "";
            if (!IsPostBack)
            {
                lbltitle.Text = "";
                BindGrid();

            }
            
        }
        catch (Exception ex)
        {
            lbltitle.Text = ex.Message;
        }
    }
    public void BindGrid()
    {
        User_Mst objuser = User_MstManager.Select(Convert.ToInt32(Request.QueryString["UserId"]));
        List<FunctionMst> listfunction = new List<FunctionMst>();
        listfunction = FunctionMstManager.GetAll();
        foreach (FunctionMst function in listfunction)
        {
            if (function.Functionid == Convert.ToInt32(objuser.Technical))
            {
                lbltechnical.Text = function.FunctionName;
            }
        }
        lblfullname.Text = objuser.FirstName + " " + objuser.LastName;

        gvFunction.DataSource = SettingoneManager.GetAll(Convert.ToInt32(Request.QueryString["UserId"]));
        gvFunction.DataBind();
        if (gvFunction.Rows.Count == 0)
            lbltitle.Text = "No exam given.";
    }
    protected void gvFunction_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvFunction.PageIndex = e.NewPageIndex;
        BindGrid();
    }
    protected void gvFunction_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
}