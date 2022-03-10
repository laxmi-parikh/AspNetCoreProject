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

public partial class USER_USER : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
      
        if (Session["UserId"] == null)
        {
            Response.Redirect("Login.aspx");

        }
        

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session.Abandon();
        Session.RemoveAll();
        Response.Redirect("Login.aspx");
    }
}
