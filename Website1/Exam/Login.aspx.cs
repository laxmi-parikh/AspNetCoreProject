﻿using System;
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

        InterviewMst objUserMst =InterviewMstManager.GetInterviewlogin(txtUserName.Text, txtPassword.Text);
        

            if (objUserMst != null)
            {

                Session["UserId"] = objUserMst.InterviewId;

                Response.Redirect("~/Exam/Default.aspx");

                //Response.Redirect("~/USER/Default.aspx?UserId="+objUserMst.UserId);
            } else{
                lblMessage.Text = "Invalid Login/Password";
            }

          
        
       
    }
}
