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

public partial class front : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["totalexamminute"] = "1";



        if (Request.QueryString["SettingId"] != null)
        {

            System.Data.DataSet questinmst = BusinessL.QuestionMstManager.ListExamQuestionbysettingIdInterview(Convert.ToInt32(Request.QueryString["SettingId"]));

            int values = questinmst.Tables[0].Rows.Count;

            
            Session["questinmst"] = questinmst;
        }

       
    }
}
