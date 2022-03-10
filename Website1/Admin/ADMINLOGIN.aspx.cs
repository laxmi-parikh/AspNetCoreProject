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

public partial class Admin_ADMINLOGIN : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {


        User_Mst obj = User_MstManager.GetAdmin(Login1.UserName, Login1.Password);
        if (obj != null && Login1.Password.Equals(obj.Password))
        {
           Session["AdminID"] = 1;
            Response.Redirect("Default.aspx");
        }
        else
        {
            Login1.FailureText = "Invalid UserName and Password";
        }
       

        //  if (Login1.UserName =="admin" && Login1.Password =="admin123")
        //{
        //    Session["AdminID"] = 1;
        //    Response.Redirect("Default.aspx");
  
        //}
        //else
        //{
        //    Login1.FailureText = "Invalid Password";
        //}


    }
}
