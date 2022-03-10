using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BusinessL;

public partial class Admin_Emailaddressbook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                btnSubmit.Text = "Update";
                BindTextbox(Convert.ToInt32(Request.QueryString["id"]));
            }
            DBind();
        }
    }
    public void BindTextbox(int id)
    {
        EmailaddressbookMst objemail = new EmailaddressbookMst();
        objemail = EmailaddressbookMstManager.Select(id);
        txtdesignation.Text = objemail.Designation;
        txtemailid.Text = objemail.Emailaddress;
        txtfunction.Text = objemail.personname;
    }
    public void DBind()
    {
        gvFunction.DataSource = EmailaddressbookMstManager.GetAll();
        gvFunction.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        EmailaddressbookMst objemail = new EmailaddressbookMst();
        if (btnSubmit.Text == "Add")
        {
            objemail.personname = txtfunction.Text;
            objemail.Designation = txtdesignation.Text;
            objemail.Emailaddress = txtemailid.Text;
            objemail.InsertedBy = Convert.ToInt32(Session["AdminID"]);
            objemail.InsertedOn = System.DateTime.Now;
            int result = Convert.ToInt32(EmailaddressbookMstManager.Add(objemail));
            if (result == 1)
                lbltitle.Text = "Information added.....";
        }
        else
        {
            objemail.emailid = Convert.ToInt32(Request.QueryString["id"]);
            objemail.personname = txtfunction.Text;
            objemail.Designation = txtdesignation.Text;
            objemail.Emailaddress = txtemailid.Text;
            objemail.UpdatedBy = Convert.ToInt32(Session["AdminID"]);
            objemail.UpdatedOn = System.DateTime.Now;
            int output = Convert.ToInt32(EmailaddressbookMstManager.Update(objemail));
            if (output == 1)
                lbltitle.Text = "Information has been updated....";
            btnSubmit.Text = "Add";
        }
        txtdesignation.Text = "";
        txtemailid.Text = "";
        txtfunction.Text = "";
        DBind();
    }
    protected void gvFunction_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvFunction_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void gvFunction_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int MainId;


            if (e.CommandName == "Delete")
            {

                MainId = Convert.ToInt32(e.CommandArgument.ToString());
                EmailaddressbookMstManager.Delete(MainId);
            }
            lbltitle.Text = "Successfully Deleted";
        }
        catch (Exception ex)
        {
            lbltitle.Text = ex.Message;
        }
        DBind();
    }
    protected void gvFunction_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvFunction.PageIndex = e.NewPageIndex;
        DBind();
    }
}
