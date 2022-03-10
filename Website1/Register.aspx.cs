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

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataSet fds = FunctionMstManager.Listfunction();
            Binddropdownlist(ddlmember, "FunctionName", "Functionid", fds);
            ddlmember.Items.Insert(0, "select");
        }
    }
    public void Binddropdownlist(DropDownList ddl, string text, string value, DataSet ds)
    {
        ddl.DataTextField = text;
        ddl.DataValueField = value;
        ddl.DataSource = ds;
        ddl.DataBind();
    }
    protected void iBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
         User_Mst Obj = new User_Mst();

        if(ddlmember.Text!="select")
         {
         Obj.EmployeeCode = txtEmployeeCode.Text;

         Obj.FirstName = txtFirstName.Text;
         Obj.LastName = txtLName.Text;
         Obj.MiddleName = txtMName.Text;
         Obj.EmailId = txtEmail.Text;
         Obj.MoblieNumber = txtMobileNo.Text;
         if (rbtnFemale.Checked)
         {
             Obj.Gender = "F";
         }
         else
         {
             Obj.Gender = "M";
         }

         Obj.Password = txtPassword.Text;
         Obj.PinCode = "";
         Obj.Place = "";
         Obj.PostalAddress = "";
         Obj.Qualification = "";
         Obj.Rid = "";
         Obj.StateId =0;
         Obj.Taluka = "";
         Obj.UserId = 0;
         Obj.UserName = "";
         Obj.UserRoleId = 0;
         Obj.ParentMobile = "";
         Obj.JoiningKitOn = "";


         string technical = ddlmember.Text;
       
         Obj.Technical = ddlmember.Text;

      int Id=  User_MstManager.Add(Obj);


      if (Id > 0)
      {
          Session["UserID"] = Id;
          lblMessage.Text = "Register Successfully";
          Response.Redirect("~/User/Welcome.aspx");
            
      }
      else
      {
          lblMessage.Text = "Email ID Already Exist";
       
      }

        }
        else
        {
            lblMessage.Text="Please Select Member";
        }

         
    }
}
