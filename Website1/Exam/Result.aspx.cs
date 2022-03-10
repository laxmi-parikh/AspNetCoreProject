using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using BusinessL;
using System.Net.Mail;
using System.Text;
using iTextSharp.text;

public partial class USER_Result : System.Web.UI.Page 
{
    string date;
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["SettingId"] != null && Request.QueryString["SessionId"] != null && Session["UserId"] != null)
            {
                //Exam_Mst obj=Exam_MstManager.

                InterviewMst objuser = InterviewMstManager.Select(Convert.ToInt32(Session["UserId"]));
                if (objuser != null)
                {
                    lblName.Text = objuser.Name;
                }
                Settingone objset = SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SettingId"]));
                if (objset != null)
                {
                    lblExam.Text = objset.TitleForExam;
                    //if (objset.MainId==0)
                    //{
                    //    lblMainTitle.Text = "Sales and NonSales";
                    //    lblSubTitle.Text = "Sales and NonSales"; 
                    //}
                    //else
                    //{
                    //FunctionMst objfunction = new FunctionMst();
                   // LevelMst objlevel = new LevelMst();
                   // objfunction = FunctionMstManager.Select(Convert.ToInt32(objset.FunctionId));

                    //lblMainTitle.Text = objfunction.FunctionName;
                    //MainTitleManager.Select(Convert.ToInt32(SubTitleManager.Select(Convert.ToInt32(objset.SubId)).MainID)).Title.ToString();

                   // objlevel = LevelMstManager.Select(Convert.ToInt32(objset.LevelId));
                   // lblSubTitle.Text = objlevel.Levelname;
                    //SubTitleManager.Select(Convert.ToInt32(objset.SubId)).SubTitle1;
                    //}
                    lblSetmarks.Text = Convert.ToString(SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SettingId"])).Setmarks);

                    lbltQuestion.Text = Convert.ToString(SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SettingId"])).QuestionSet);
                    lblDate.Text = DateTime.Today.ToString("dd - MM - yyyy");
                    date = objset.End_Date.ToString("dd-MM-yyyy");
                }
                DataSet objExam = Exam_MstManager.GetResultByGuid(Request.QueryString["SessionId"]);
                if (objExam.Tables.Count > 0)
                {
                    //lbltQuestion.Text = objExam.Tables[0].Rows[0][1].ToString();
                    lblTtAQuestion.Text = objExam.Tables[0].Rows[0][1].ToString();
                    lblPercentage.Text = objExam.Tables[0].Rows[0][3].ToString();
                    lblcorrectanswer.Text = objExam.Tables[0].Rows[0][4].ToString();
                    if (lblTtAQuestion.Text != "")
                    {
                        lblNttlquestion.Text = Convert.ToString(Convert.ToInt32(lbltQuestion.Text) - Convert.ToInt32(lblTtAQuestion.Text));
                    }
                    else
                    {
                        lblTtAQuestion.Text = "NA";
                        lblNttlquestion.Text = Convert.ToString(Convert.ToInt32(lbltQuestion.Text));
                    }
                }
                if (lblPercentage.Text != "")
                {
                    if (Convert.ToInt32(lblPercentage.Text) >= objset.PassScore)
                    {
                        lblgrade.Text = objset.PassScoreMsg;
                    }
                    else
                    {
                        lblgrade.Text = objset.FailScoreMsg;
                    }
                }
                else
                {
                    lblgrade.Text = "NA";
                }

               // Settingone objset = SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SettingId"]));

                if (Session["UserId"] != null)
                {
                    if (lblcorrectanswer.Text == "" || lblcorrectanswer.Text == "0")
                    {
                        Result_Mst obj = new Result_Mst();
                        if (obj != null)
                        {
                            obj.StudentId = Convert.ToInt32(Session["UserId"]);
                            obj.SubjectId = 0;
                            obj.SetID = Convert.ToInt32(Request.QueryString["SettingId"]);

                            obj.TotalQuestion = Convert.ToInt32(lbltQuestion.Text);
                            obj.CorrectAnswer = Convert.ToInt32(0);
                            obj.WrongAnswer = Convert.ToInt32(0);
                            x = Convert.ToInt32(0);
                            y = Convert.ToInt32(0);
                            ans = Convert.ToString(0);
                            obj.Status = string.Format("{0:n}", ans);
                            // obj.Detail = Convert.ToString(str);
                            Result_MstManager.Add(obj);

                        }
                     

                    }
                    //else

                    //    if (Convert.ToInt32(lblPercentage.Text) <= objset.PassScore)
                    //    {
                    //        Result_Mst obj = new Result_Mst();
                    //        if (obj != null)
                    //        {
                    //            obj.StudentId = Convert.ToInt32(Session["UserId"]);
                    //            obj.SubjectId = Convert.ToInt32(Request.QueryString["SubID"]);
                    //            obj.SetID = Convert.ToInt32(Request.QueryString["SettingId"]);

                    //            obj.TotalQuestion = Convert.ToInt32(lbltQuestion.Text);
                    //            obj.CorrectAnswer = Convert.ToInt32(lblcorrectanswer.Text);
                    //            obj.WrongAnswer = Convert.ToInt32(Convert.ToInt32(lbltQuestion.Text) - Convert.ToInt32(lblcorrectanswer.Text));
                    //            x = Convert.ToInt32(lblcorrectanswer.Text);
                    //            y = Convert.ToInt32(lbltQuestion.Text);
                    //            ans = Convert.ToString((Convert.ToDecimal(x) / Convert.ToDecimal(y)) * 100);
                    //            obj.Status = string.Format("{0:n}", ans);
                    //            // obj.Detail = Convert.ToString(str);
                    //            Result_MstManager.Add(obj);

                    //        }
                         

                    //    }
                        else
                        {
                            //str = MakeBody();
                            //if (lblcorrectanswer.Text != "" || lblcorrectanswer.Text != "0")
                            //{
                            

                            Result_Mst obj = new Result_Mst();
                            if (obj != null)
                            {
                                obj.StudentId = Convert.ToInt32(Session["UserId"]);
                                obj.SubjectId = Convert.ToInt32(0);
                                obj.SetID = Convert.ToInt32(Request.QueryString["SettingId"]);

                                obj.TotalQuestion = Convert.ToInt32(lbltQuestion.Text);
                                obj.CorrectAnswer = Convert.ToInt32(lblcorrectanswer.Text);
                                obj.WrongAnswer = Convert.ToInt32(Convert.ToInt32(lbltQuestion.Text) - Convert.ToInt32(lblcorrectanswer.Text));
                                x = Convert.ToInt32(lblcorrectanswer.Text);
                                y = Convert.ToInt32(lbltQuestion.Text);
                                ans = Convert.ToString((Convert.ToDecimal(x) / Convert.ToDecimal(y)) * 100);


                                obj.Status = string.Format("{0:n}", ans);
                                // obj.Detail = Convert.ToString(str);

                                Result_MstManager.Add(obj);
                               // SuccessMail();

                               // Makepdf();

                            }
                            //}
                            //string subject = " Armstrong Training Test";
                            //string Email = User_MstManager.Select(Convert.ToInt32(Session["UserId"])).EmailId;
                            //SendMailMessage(subject, str, Email, "");

                        }


                    //if (lblPercentage.Text != "")
                    //{
                    //    if (Convert.ToInt32(lblPercentage.Text) >= objset.PassScore)
                    //    {

                    //        DataSet ds = SettingoneManager.Setupdate(Convert.ToInt32(Session["UserId"]), Convert.ToInt32(Request.QueryString["SubID"]));

                    //        List<Settingone> objone = SettingoneManager.GetAllByLevelId2(Convert.ToInt32(Session["UserId"]));

                    //        //  DataSet ds1 = SettingoneManager.GetSettingonebySubIdFor(Convert.ToInt32(Session["UserId"]));
                    //        if (ds.Tables[0].Rows.Count == objone.Count)
                    //       // {

                    //            //User_MstManager.Update(Convert.ToInt32(Session["UserId"]));

                    //        //}
                    //    }
                    //    else
                    //    {
                    //        lblgrade.Text = objset.FailScoreMsg;
                    //        cmdtryagain.Visible = true;
                    //    }
                    //}
                    //else
                    //{
                    //    lblgrade.Text = "NA";
                    //}

                }
            }
        }
    }
   
    public void SendMailMessage(string strSubject, String body, String recepient, String CC)
    {
        MailMessage mMailMessage = new MailMessage();
        mMailMessage.Subject = strSubject;
        mMailMessage.To.Add(recepient);
        if (CC != "")
        {
            mMailMessage.CC.Add(new MailAddress(CC));
        }
        mMailMessage.Body = body;
        mMailMessage.From = new MailAddress("support@thaneguide.com");
        mMailMessage.IsBodyHtml = true;
        mMailMessage.Priority = MailPriority.Normal;
        SmtpClient mSmtpClient = new SmtpClient();
        mSmtpClient.Host = "smtp.thaneguide.com";
        mSmtpClient.Port = 25;

        mSmtpClient.Credentials = new System.Net.NetworkCredential("support@thaneguide.com", "uccpr71");
        mSmtpClient.Send(mMailMessage);

        //MailMessage mMailMessage = new MailMessage();
        //mMailMessage.Subject = strSubject;
        //mMailMessage.To.Add(recepient);
        //if (CC != "")
        //{
        //    mMailMessage.CC.Add(new MailAddress(CC));
        //}
        //mMailMessage.Body = body;
        //mMailMessage.From = new MailAddress("helpdeskindia@armstrong.com");
        //mMailMessage.IsBodyHtml = true;
        //mMailMessage.Priority = MailPriority.Normal;
        //SmtpClient mSmtpClient = new SmtpClient();

        //mSmtpClient.Host = "mail.armstrong.com";
        //mSmtpClient.Port = 25;
        //mSmtpClient.Credentials = new System.Net.NetworkCredential("genmumhelpdeskindia", "mjk_786", "PACRIM");
        //mSmtpClient.UseDefaultCredentials = false;
        //mSmtpClient.Send(mMailMessage);


    }
    string ans;
    int x = 0, y = 0;
    //private Boolean SuccessMail()
    //{

    //       Makepdf();

    //     return true;
    //}

   
    public void Makepdf()
    {
       
        /*From here the new code for sending the result via mail started*/
        StringBuilder str = new StringBuilder();
        MailMessage mMailMessage = new MailMessage();
        str.Append("<table width='673' height='736' border='0' align='center' cellpadding='0' cellspacing='0' id='Table_01'>");
        str.Append("<tr><td colspan='7' align='center'><img src=cid:Image1 width='673' height='7' alt=''></td></tr>");
        //str.Append("<tr><td colspan='3'>&nbsp;</td></tr>");
   
        str.Append("<tr><td rowspan='15'><img src=cid:Image8 width='8' height='800' alt=''></td><td colspan='5' align='right' valign='bottom'><br/><img src=cid:Image10 width='20%'  alt=''></td><td rowspan='15' align='right'><img src=cid:Image9 width='8' height='800' alt=''></td></tr>");
        str.Append("<tr><td rowspan='13'>&nbsp;</td><td colspan='3'align='center'><img src=cid:Image2 width='565' height='116' alt=''></td><td rowspan='13'>&nbsp;</td></tr>");
        str.Append("<tr><td colspan='3'align='center'><img src=cid:Image3 width='565' height='30' alt=''></td></tr>");
        str.Append("<tr><td colspan='3'align='center'>&nbsp;</td></tr>");
        str.Append("<tr><td height='39' colspan='3' align='center' valign='middle'><font size='6' font-weight='normal'>" + lblName.Text + "</font></td></tr>");
        str.Append("<tr><td colspan='3'>&nbsp;</td></tr>");
        str.Append("<tr><td colspan='3' align='center'><img src=cid:Image4 width='565' height='21' alt=''></td></tr>");
        str.Append("<tr><td colspan='3'>&nbsp;</td></tr>");
        str.Append("<tr><td height='27' colspan='3' align='center' valign='middle' ><font size='4' font-weight='normal'>" + lblExam.Text + "</font></td></tr>");
        str.Append("<tr><td height='23' colspan='3' align='center' valign='middle' ><font size='3' font-weight='normal'>Grade:" + lblPercentage.Text + "%</font></td></tr>");
        str.Append("<tr><td colspan='3'><br/><br/><br/><br/><br/><br/><br/><br/><br/></td></tr>");
        str.Append("<tr><td height='20' colspan='3' align='right' valign='middle'>   " + lblDate.Text + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td></tr>");
        str.Append("<tr><td>&nbsp;</td><td align='right'><img src=cid:Image5 width='160' height='24' alt=''></td><td>&nbsp;</td></tr>");
        str.Append("<tr><td colspan='3' align='center'><img src=cid:Image6 width='565' height='137' alt=''></td></tr>");
        str.Append("<tr><td colspan='3'>&nbsp;</td></tr>");
        str.Append("<tr><td colspan='7'><img src=cid:Image7 width='673' height='8' alt=''></td></tr>");
        str.Append("</table>");


        AlternateView view = null;
        view = AlternateView.CreateAlternateViewFromString(str.ToString(), Encoding.Default, "text/html");

        LinkedResource resource = null, resource1 = null, resource2 = null, resource3 = null, resource4 = null, resource5 = null, resource6 = null, resource7 = null, resource8 = null, resource9 = null;

        resource = new LinkedResource((Server.MapPath("image/certificate_01.jpg")));
        resource1 = new LinkedResource((Server.MapPath("image/certificate_06.jpg")));
        resource2 = new LinkedResource((Server.MapPath("image/certificate_08.jpg")));
        resource3 = new LinkedResource((Server.MapPath("image/certificate_11.jpg")));
        resource4 = new LinkedResource((Server.MapPath("image/certificate_20.jpg")));
        resource5 = new LinkedResource((Server.MapPath("image/certificate_22.jpg")));
        resource6 = new LinkedResource((Server.MapPath("image/certificate_24.jpg")));
        resource7 = new LinkedResource((Server.MapPath("image/certificate_02.jpg")));
        resource8 = new LinkedResource((Server.MapPath("image/certificate_04.jpg")));
        resource9 = new LinkedResource((Server.MapPath("image/logo.jpg")));
        

        
        resource.ContentId = "Image1";
        resource1.ContentId = "Image2";
        resource2.ContentId = "Image3";
        resource3.ContentId = "Image4";
        resource4.ContentId = "Image5";
        resource5.ContentId = "Image6";
        resource6.ContentId = "Image7";
        resource7.ContentId = "Image8";
        resource8.ContentId = "Image9";
        resource9.ContentId = "Image10";
        

        view.LinkedResources.Add(resource);
        view.LinkedResources.Add(resource1);
        view.LinkedResources.Add(resource2);
        view.LinkedResources.Add(resource3);
        view.LinkedResources.Add(resource4);
        view.LinkedResources.Add(resource5);
        view.LinkedResources.Add(resource6);
        view.LinkedResources.Add(resource7);
        view.LinkedResources.Add(resource8);
        view.LinkedResources.Add(resource9);

        mMailMessage.AlternateViews.Add(view);
        
        string Email = User_MstManager.Select(Convert.ToInt32(Session["UserId"])).EmailId;

        mMailMessage.Subject = "Armstrong Training Test";
     //   mMailMessage.To.Add("laxmi@ucc-india.com");
       
     // //  mMailMessage.To.Add(Email);
     //   //mMailMessage.To.Add(obj.Emailaddress);
     //   //mMailMessage.Attachments.Add(new Attachment(Path));
     //   //mMailMessage.Body = str.ToString();// "check the attachment";
     //  mMailMessage.From = new MailAddress("support@thaneguide.com");
     //  // mMailMessage.From = new MailAddress("helpdeskindia@armstrong.com");
     //   mMailMessage.IsBodyHtml = true;
     //   mMailMessage.Priority = MailPriority.Normal;
      SmtpClient mSmtpClient = new SmtpClient();
     ////   mSmtpClient.Host = "mail.armstrong.com";
     //  // mSmtpClient.Port = 25;
     //  // mSmtpClient.Credentials = new System.Net.NetworkCredential("genmumhelpdeskindia", "mjk_786", "PACRIM");
     //   mSmtpClient.Host = "smtp.thaneguide.com";
     //   mSmtpClient.Port = 25;

     //   mSmtpClient.Credentials = new System.Net.NetworkCredential("support@thaneguide.com", "uccpr71");
     //  mSmtpClient.Send(mMailMessage);
     //  // mSmtpClient.SendAsync(mMailMessage,"complete");


        List<EmailaddressbookMst> listemail = new List<EmailaddressbookMst>();
        listemail = EmailaddressbookMstManager.GetAll();
        foreach (EmailaddressbookMst obj in listemail)
        {
            mMailMessage.Subject = "Armstrong Training Test";
            //mMailMessage.To.Add("dev@ucc-india.com");
            mMailMessage.To.Clear();
            mMailMessage.To.Add(obj.Emailaddress);
            //mMailMessage.To.Add(obj.Emailaddress);
            //mMailMessage.Attachments.Add(new Attachment(Path));
            //mMailMessage.Body = str.ToString();// "check the attachment";
            //mMailMessage.From = new MailAddress("support@thaneguide.com");
            mMailMessage.From = new MailAddress("helpdeskindia@armstrong.com");
            mMailMessage.IsBodyHtml = true;
            mMailMessage.Priority = MailPriority.Normal;
            //mSmtpClient = new SmtpClient();
            mSmtpClient.Host = "mail.armstrong.com";
            mSmtpClient.Port = 25;
            mSmtpClient.Credentials = new System.Net.NetworkCredential("genmumhelpdeskindia", "mjk_786", "PACRIM");
            //mSmtpClient.Host = "smtp.thaneguide.com";
            //mSmtpClient.Port = 25;

            //mSmtpClient.Credentials = new System.Net.NetworkCredential("support@thaneguide.com", "uccpr71");
            mSmtpClient.Send(mMailMessage);
        }
    
    }
    
    //private void Cancel()
    //{
        
    //}
    //private string MakeBody1()
    //{
    //    StringBuilder str = new StringBuilder();

    //    // foreach (HeaderValue hv in collection)
    //    // {
    //    str.Append("<table border='0' cellspacing='0' cellpadding='0' align='left'><tr><td>Dear &nbsp; " + lblName.Text + "</td>");
    //    str.Append("</tr>");
    //    str.Append("<tr><td>You have Not Attempted Exam . Last Date Of Exam Is &nbsp;" + date + "&nbsp;</td></tr>");
    //    str.Append("<br>");
    //    // }
    //    str.Append("</table>");
    //    string _body = str.ToString();
    //    return _body;
    //}
    //private string MakeBody()
    //{
    //    StringBuilder str = new StringBuilder();

    //    // foreach (HeaderValue hv in collection)
    //    // {
    //    str.Append("<table width='633' border='0' cellspacing='0' cellpadding='0'>");
    //    str.Append("<tr>");
    //    str.Append(" <td width='15' height='30' align='left' valign='middle'><img src='image/arrow.gif' width='8' height='9' /></td>");
    //    str.Append(" <td width='618' align='left' valign='middle' class='pink_text1'>Results</td>");
    //    str.Append(" </tr>");

    //    str.Append("<tr>");
    //    str.Append("<td height='10' colspan='2' align='left' valign='top'><img src='image/big_line.gif' width='633' height='1' /></td>");
    //    str.Append("</tr>");
    //    str.Append("<tr>");
    //    str.Append("<td height='250' colspan='2' align='left' valign='top'><table width='633' border='1' cellpadding='0' cellspacing='0' bordercolor='#5c5c5c' bgcolor='#eeeeee'>");
    //    str.Append(" <tr>");
    //    str.Append(" <td height='231' align='left' valign='top'><table width='633' height='231' border='0' cellspacing='0' cellpadding='0'>");
    //    str.Append("<tr height='30px'>");
    //    str.Append(" <td width='25' class='top_pinktab'> <img src='image/arrow.gif' width='8' height='9' /></td>");

    //    str.Append("<td width='608' colspan='2' class='top_pinktab' valign='middle'><span class='white_hd' >Armstrong Training Test<br /> </span></td>");
    //    str.Append("  </tr>");
    //    str.Append(" <tr>");
    //    str.Append("  <td height='40'>&nbsp;</td>");
    //    str.Append(" <td width='304' align='left' valign='bottom' colspan='2' >");
    //    str.Append(" <table width='90%' border='0' cellspacing='0' cellpadding='0'>");

    //    str.Append("  <tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append(" <tr>");
    //    str.Append("<td width='173' class='font_text2'>Name :</td>");

    //    str.Append(" <td width='100' class='form_font'>");
    //    str.Append(lblName.Text);
    //    str.Append(" </td>");
    //    str.Append(" </tr>");
    //    str.Append(" <tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append("<tr>");
    //    str.Append(" <td width='173' class='font_text2'>Category :</td>");

    //    str.Append("<td width='100' class='form_font'>");
    //    str.Append(lblMainTitle.Text);
    //    str.Append(" </td>");
    //    str.Append("</tr>");

    //    str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append("<tr>");
    //    str.Append("<td width='173' class='font_text2'>Sub Category :</td>");

    //    str.Append("<td width='100' class='form_font'>");
    //    str.Append(lblSubTitle.Text);
    //    str.Append("</td>");
    //    str.Append(" </tr>");
    //    str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append("  <tr>");
    //    str.Append("  <td width='173' class='font_text2'>Exam Name :</td>");

    //    str.Append(" <td width='100' class='form_font'>");
    //    str.Append(lblExam.Text);
    //    str.Append("</td>");
    //    str.Append("</tr>");

    //    str.Append(" <tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append(" <tr>");
    //    str.Append("<td width='173' class='font_text2'>Date :</td>");

    //    str.Append("<td width='100' class='form_font'>");
    //    str.Append(lblDate.Text);
    //    str.Append(" </td>");
    //    str.Append("</tr>");
    //    str.Append(" <tr><td colspan='2'>&nbsp;</td></tr>");

    //    str.Append(" <tr>");
    //    str.Append(" <td width='173' class='font_text2'>Marks :</td>");

    //    str.Append(" <td width='100' class='form_font'>");
    //    str.Append(lblSetmarks.Text);
    //    str.Append("</td>");
    //    str.Append(" </tr>");
    //    str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append(" <tr>");
    //    str.Append("<td width='173' class='font_text2'>Total Questions :</td>");

    //    str.Append("<td width='100' class='form_font'>");
    //    str.Append(lbltQuestion.Text);
    //    str.Append("  </td>");
    //    str.Append(" </tr>");
    //    str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append("<tr>");
    //    str.Append(" <td width='173' class='font_text2'>Total Attempt Questions :</td>");
    //    str.Append("<td width='100' class='form_font'>");
    //    str.Append(lblTtAQuestion.Text);
    //    str.Append("&nbsp;</td>");
    //    str.Append("</tr>");
    //    str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append("<tr>");
    //    str.Append(" <td width='173' class='font_text2'>Total Non-attempt Questions :</td>");
    //    str.Append("<td width='100' class='form_font'>");
    //    str.Append(lblNttlquestion.Text);
    //    str.Append("</td>");
    //    str.Append(" </tr>");
    //    str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append("<tr>");
    //    str.Append("<td width='173' class='font_text2'>Correct Answer :</td>");
    //    str.Append(" <td width='100' class='form_font'>");
    //    str.Append(lblcorrectanswer.Text);
    //    str.Append("</td>");
    //    str.Append(" </tr>");
    //    str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");

    //    str.Append("<tr>");
    //    str.Append(" <td width='173' class='font_text2'>Percentage :</td>");
    //    str.Append(" <td width='100' class='form_font'>");
    //    str.Append(lblPercentage.Text + "%");
    //    str.Append("</td>");
    //    str.Append(" </tr>");
    //    str.Append(" <tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append("<tr>");
    //    str.Append("<td width='173' class='font_text2'>Grade :</td>");
    //    str.Append("<td width='100' class='form_font'>");
    //    str.Append(lblgrade.Text);
    //    str.Append(" </td>");
    //    str.Append(" </tr>");
    //    str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
    //    str.Append("</table></td>");

    //    str.Append("</tr>");



    //    str.Append("</table></td>");
    //    str.Append(" </tr>");
    //    str.Append("</table></td>");
    //    str.Append("</tr>");
    //    str.Append("</table>");
    //    str.Append("</tr>");
    //    str.Append("<br>");
    //    // }
    //    str.Append("</table>");
    //    string _body = str.ToString();
    //    return _body;
    //}
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Default.aspx"); 

    }
    protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
    {
        Session.Abandon();
        Session.RemoveAll();
        Response.Redirect("Login.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("History.aspx"); 
    }
    protected void cmdtryagain_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void imgdownloadebook_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Downloadebook.aspx");
    }
}
