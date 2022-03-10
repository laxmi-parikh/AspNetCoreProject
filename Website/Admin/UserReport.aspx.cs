using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;
public partial class Admin_UserReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            lbltitle.Text = "";
            if (!IsPostBack)
            {
                lbltitle.Text = "";
                DBind();
            }
        }
        catch (Exception ex)
        {
            lbltitle.Text = ex.Message;
        }
    }
    public void DBind()
    {
       
      
        ddlusername.DataTextField = "fullname";
        ddlusername.DataValueField = "userid";
        ddlusername.DataSource = User_MstManager.getusername();
        ddlusername.DataBind();
        ddlusername.Items.Insert(0, "Select");

    }
    protected void gvFunction_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvFunction.PageIndex = e.NewPageIndex;
        BindGrid(Convert.ToInt32(ddlusername.SelectedValue));
    }
    protected void ddlusername_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlusername.SelectedItem.Text != "Select")
        {
            int userid = Convert.ToInt32(ddlusername.SelectedValue);

            BindGrid(userid);

            User_Mst objuser = User_MstManager.Select(userid);
            if (objuser.Technical != "")
            {
                List<FunctionMst> listfunction = new List<FunctionMst>();

                listfunction = FunctionMstManager.GetAll();

                if (listfunction.Count > 0)
                {
                    foreach (FunctionMst function in listfunction)
                    {
                        if (function.Functionid == Convert.ToInt32(objuser.Technical))
                        {
                            lbltechnical.Text = function.FunctionName;
                        }
                    }
                }
            }
        }
      


    }
    public void BindGrid(int userid)
    {
        gvFunction.DataSource = User_MstManager.getuserreport(userid);
        gvFunction.DataBind();
    }

}