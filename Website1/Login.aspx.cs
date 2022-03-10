using System;
using System.Collections;
using System.Configuration;
using System.Data;
// using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
// using System.Xml.Linq;
using BusinessL;
//using BarterCommon.BLL;
//using Bhairav.Settings;
//using Bhairav.Settings.Utils;
//using Bhairav.CountryState;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
         

        }
    }



    protected void iBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        User_Mst objUserMst = null;
        if (User_MstManager.CheckAuthentication(txtUserName.Text ,txtPassword.Text , out objUserMst))
        {
          
            FormsAuthentication.SetAuthCookie(objUserMst.UserName, false);

            Session["UserId"] = objUserMst.UserId;

            Response.Redirect("~/USER/WelCome.aspx");

            //Response.Redirect("~/USER/Default.aspx?UserId="+objUserMst.UserId);

          
        }
        else
        {
           
           lblMessage.Text = "Invalid Login/Password";
        }
    }
}
