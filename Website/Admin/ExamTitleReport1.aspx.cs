using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;
using System.Collections.Generic;
using iTextSharp.text;
using System.IO;
using System.Text;
using System.Net.Mail;


public partial class Admin_Default2 : System.Web.UI.Page
{
    string UN,C ,SC,Exam,M,D,TQ,AQ,naq,ca,p,G;
    string Email;

//    DataTable dt;
    int a;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
            //ExportToPDF();
          
             
        }

    }
    public void BindGrid()
    {
        if (Request.QueryString["SettingId"]!=null)
        {

            
        lblExamTitle.Text = SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SettingId"])).TitleForExam;

        //List<Result_Mst> objResult = Result_MstManager.GetResultReport(Convert.ToInt32(Request.QueryString["SettingId"]));
        DataSet objResult = Exam_MstManager.GetResultReport1(Convert.ToInt32(Request.QueryString["SettingId"]));

        if (objResult.Tables.Count > 0)
        {

           gvMainTitle.DataSource = objResult;
            gvMainTitle.DataBind();

           
           
        }
       else
        {
           lbltitle.Text = "No Data Found";
        }
        }else
        {
            Response.Redirect("ExamReport.aspx");
        }
    }
    protected void gvMainTitle_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvMainTitle.PageIndex = e.NewPageIndex;
        BindGrid();

    }
    protected void gvMainTitle_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (GridViewRow row in gvMainTitle.Rows)
        {
            Label lblSettingId = (Label)row.FindControl("lblSettingId");
            Label lblUser = (Label)row.FindControl("lblUserName");
            Label lblUserId = (Label)row.FindControl("lblUserId");
            //Label lblanswer = (Label)row.FindControl("lblanswer");
            //Label lblUserName = (Label)row.FindControl("lblUserName");
            Label lblQulified = (Label)row.FindControl("lblQulified");
            Label lblPassPercentage = (Label)row.FindControl("lblPassPercentage");

            //CheckBox Checkbox1 = (CheckBox)row.FindControl("CheckBox1");
            User_Mst objuser = User_MstManager.Select(Convert.ToInt32(lblUserId.Text));
            if (objuser != null)
            {
                UN = lblUser.Text;
                Email = objuser.EmailId;
                 Exam = SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).TitleForExam;

                G=lblPassPercentage.Text;


               //// C = MainTitleManager.Select(Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).MainId)).Title;
             //   SC = SubTitleManager.Select(Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).SubId)).SubTitle1;
               
                //M = SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).Setmarks.ToString();
                Result_Mst objresult = Result_MstManager.SelectResult(Convert.ToInt32(lblUserId.Text), Convert.ToInt32(lblSettingId.Text), Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).LevelId));
                if (objresult != null)
                {


                    D = objresult.InsertedOn.ToString("dd-MMM-yyyy");
                   // TQ = objresult.TotalQuestion.ToString();
                   // AQ = Convert.ToString(objresult.WrongAnswer + objresult.CorrectAnswer);
                    //naq = Convert.ToString(objresult.TotalQuestion - Convert.ToInt32(AQ));
                   // ca = objresult.CorrectAnswer.ToString();
                    //if (objresult.TotalQuestion == 0)
                    //{
                    //    a = 0;
                    //}
                    //else
                    //{
                    //    a = (objresult.CorrectAnswer * 100) / objresult.TotalQuestion;
                    //}

                    //p = Convert.ToString(a) + "%";
                    //if (a >= Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).PassScore))
                    //{
                    //    G = SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).PassScoreMsg;
                    //}
                    //else
                    //{
                    //    G = SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).FailScoreMsg;
                    //}


                }
                //,Exam,M,D,TQ,AQ,naq,ca,p,G;
            }
           // if (Checkbox1.Checked)
           // {
           // if (SuccessMail() == true)
           // {

            Makepdf();
               // Cancel();
               

            //}
            
           //}




        }
        BindGrid();


    }
    protected void gvMainTitle_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        gvMainTitle.EditIndex = -1;
        BindGrid();


    }
    protected void gvMainTitle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //int MainId;


        //if (e.CommandName == "Delete")
        //{

        //    MainId = Convert.ToInt32(e.CommandArgument.ToString());
        //    MainTitleManager.Delete(MainId);

        //}
        //lbltitle.Text = "Successfully Deleted";



    }
    protected void gvMainTitle_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      
        foreach (GridViewRow row in gvMainTitle.Rows)
        {

     
            Label lblQulified = (Label)row.FindControl("lblQulified");
            
            //Panel panel1 = (Panel)row.FindControl("panel1");
            //if (lblQulified.Text == "DisQualified")
            //{
            //    panel1.Visible = false;
            //}
            //else
            //{
            //    panel1.Visible = true;

            //}

        
            }

      
          
    }


 


    //protected void btnExport_Click(object sender, EventArgs e)
    //{
    //    string strFile; ///"SrNo", , "No. of Attempted", "No. of user not attempted"


    //    //
    //    HtmlForm form = new HtmlForm();
    //    form.Controls.Add(gvMainTitle);
    //    StringBuilder sb = new StringBuilder();

    //    StringWriter sw = new StringWriter(sb);
    //    HtmlTextWriter hTextWriter = new HtmlTextWriter(sw);

    //    form.Controls[0].RenderControl(hTextWriter);
    //    string html = sb.ToString();
    //    Document Doc = new Document();

    //    strFile = DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" + DateTime.Today.Year.ToString() + "_" + DateTime.Now.Second.ToString() + "_" + "Detail.pdf";


    //    // FileUpload F=new FileUpload();
    //    // F.SaveAs(AppDomain.CurrentDomain.BaseDirectory.ToString() + ");

    //    PdfWriter.GetInstance(Doc, new FileStream((Request.PhysicalApplicationPath + "//Admin/PdfFile/" + strFile), FileMode.Create));

    //    //PdfWriter.GetInstance
    //    //(Doc, new FileStream(Request.FilePath  
    //    //(Environment.SpecialFolder.Desktop)
    //    //+ "Armstrong.pdf", FileMode.Create));


    //    Doc.Open();

    //    Chunk c = new Chunk
    //    ("Armstrong Training \n",
    //    FontFactory.GetFont("Verdana", 15));
    //    Paragraph p = new Paragraph();
    //    p.Alignment = Element.ALIGN_CENTER;
    //    p.Add(c);
    //    Chunk chunk1 = new Chunk
    //    ("\n",
    //    FontFactory.GetFont("Verdana", 8));
    //    Paragraph p1 = new Paragraph();
    //    p1.Alignment = Element.ALIGN_RIGHT;
    //    p1.Add(chunk1);

    //    Doc.Add(p);
    //    Doc.Add(p1);

    //    System.Xml.XmlTextReader xmlReader =
    //    new System.Xml.XmlTextReader(new StringReader(html));
    //    HtmlParser.Parse(Doc, xmlReader);

    //    Doc.Close();
    //    string Path = Server.MapPath("PdfFile\\" + strFile);


    //    //if (Path.GetExtension(Arg) == ".pdf")
    //    //{
    //    //     string pdfPath = Server.MapPath("ProductPdf/" + Arg);

    //    //     Byte[] buffer = client.DownloadData(pdfPath);
    //    //     Response.ContentType = "application/pdf";
    //    //     Response.AddHeader("content-length", buffer.Length.ToString());
    //    //     Response.BinaryWrite(buffer);


    //    Response.Redirect("pdfFiles.aspx?lblUrl=" + Path);
    //    //}
    //    //    Environment.GetFolderPath
    //    //(Environment.SpecialFolder.Desktop)
    //    //+ "\\PdfFile/Armstrong.pdf";


    //    ////ShowPdf(Path);

    //}
    

    //private void ShowPdf(string strS)
    //{
    //    Response.ClearContent();
    //    Response.ClearHeaders();
    //    Response.ContentType = "application/pdf";
    //    Response.AddHeader
    //    ("Content-Disposition", "attachment; filename=" + strS);
    //    Response.TransmitFile(strS);
    //    Response.End();
    //    //Response.WriteFile(strS);
    //    Response.Flush();
    //    Response.Clear();

    //}




    private string getHTML(GridView gv)
    {
        StringBuilder sb = new StringBuilder();
        StringWriter textwriter = new StringWriter(sb);
        HtmlTextWriter htmlwriter = new HtmlTextWriter(textwriter);
        gv.RenderControl(htmlwriter);
        htmlwriter.Flush();
        textwriter.Flush();
        htmlwriter.Dispose();
        textwriter.Dispose();
        return sb.ToString();
    }

    //public override void VerifyRenderingInServerForm(Control control)
    //{
    //    //return;
    //}

    //protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    //{
    //    foreach (GridViewRow row in gvMainTitle.Rows)
    //    {
    //        Label lblSettingId = (Label)row.FindControl("lblSettingId");
    //        Label lblUser = (Label)row.FindControl("lblUser");
    //        Label lblQuestion = (Label)row.FindControl("lblQuestion");
    //        Label lblanswer = (Label)row.FindControl("lblanswer");
    //        Label lblUserName = (Label)row.FindControl("lblUserName");
    //        Label lblQulified = (Label)row.FindControl("lblQulified");
    //        Label lblPassPercentage = (Label)row.FindControl("lblPassPercentage");

    //        CheckBox Checkbox1 = (CheckBox)row.FindControl("CheckBox1");
    //        User_Mst objuser = User_MstManager.Select(Convert.ToInt32(lblUser.Text));
    //        if (objuser != null)
    //        {
    //            UN = objuser.FirstName + " " + objuser.LastName;
    //            Email = objuser.EmailId;
    //            C = MainTitleManager.Select(Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).MainId)).Title;
    //            SC = SubTitleManager.Select(Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).SubId)).SubTitle1;
    //            Exam = SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).TitleForExam;
    //            M = SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).Setmarks.ToString();
    //            Result_Mst objresult = Result_MstManager.SelectResult(Convert.ToInt32(lblUser.Text), Convert.ToInt32(lblSettingId.Text), Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).SubId));
    //            if (objresult != null)
    //            {
    //                D = objresult.InsertedOn.ToString("dd-MMM-yyyy");
    //                TQ = objresult.TotalQuestion.ToString();
    //                AQ = Convert.ToString(objresult.WrongAnswer + objresult.CorrectAnswer);
    //                naq = Convert.ToString(objresult.TotalQuestion - Convert.ToInt32(AQ));
    //                ca = objresult.CorrectAnswer.ToString();
    //                if (objresult.TotalQuestion == 0)
    //                {
    //                    a = 0;
    //                }
    //                else
    //                {
    //                    a = (objresult.CorrectAnswer * 100) / objresult.TotalQuestion;
    //                }

    //                p = Convert.ToString(a) + "%";
    //                if (a >= Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).PassScore))
    //                {
    //                    G = SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).PassScoreMsg;
    //                }
    //                else
    //                {
    //                    G = SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).FailScoreMsg;
    //                }


    //            }
    //            //,Exam,M,D,TQ,AQ,naq,ca,p,G;
    //        }
    //        if (Checkbox1.Checked)
    //        {
    //            if (SuccessMail() == true)
    //            {


    //                Cancel();
    //                lbltitle.Text = "Mail has been Sent Successfully ";


    //            }

    //        }




    //    }
    //    BindGrid();

       
    //}

    public void SendMailMessage(string strSubject, String body, String recepient, String CC)
    {
        //MailMessage mMailMessage = new MailMessage();
        //mMailMessage.Subject = strSubject;
        //mMailMessage.To.Add(recepient);
        //if (CC != "")
        //{
        //    mMailMessage.CC.Add(new MailAddress(CC));
        //}
        ////mMailMessage.Body = body;
        //mMailMessage.From = new MailAddress("support@thaneguide.com");
        //mMailMessage.IsBodyHtml = true;
        //mMailMessage.Priority = MailPriority.Normal;
        //SmtpClient mSmtpClient = new SmtpClient();
        //mSmtpClient.Host = "smtp.thaneguide.com";
        //mSmtpClient.Port = 25;

        //mSmtpClient.Credentials = new System.Net.NetworkCredential("support@thaneguide.com", "uccpr71");
        //mSmtpClient.Send(mMailMessage);

        MailMessage mMailMessage = new MailMessage();
        mMailMessage.Subject = strSubject;
        mMailMessage.To.Add(recepient);
        if (CC != "")
        {
            mMailMessage.CC.Add(new MailAddress(CC));
        }
        mMailMessage.Body = body;
        mMailMessage.From = new MailAddress("helpdeskindia@armstrong.com");
        mMailMessage.IsBodyHtml = true;
        mMailMessage.Priority = MailPriority.Normal;
        SmtpClient mSmtpClient = new SmtpClient();

        mSmtpClient.Host = "mail.armstrong.com";
        mSmtpClient.Port = 25;
        mSmtpClient.Credentials = new System.Net.NetworkCredential("genmumhelpdeskindia", "mjk_786", "PACRIM");
        mSmtpClient.UseDefaultCredentials = false;
        mSmtpClient.Send(mMailMessage);


    }

    private Boolean SuccessMail()
    {

        string str = MakeBody();

        string subject = " Armstrong Training Test";

        SendMailMessage(subject, str, Email, "");
        return true;


    }

    private void Cancel()
    {

    }

    private string MakeBody()
    {
        StringBuilder str = new StringBuilder();

        // foreach (HeaderValue hv in collection)
        // {
        str.Append("<table width='633' border='0' cellspacing='0' cellpadding='0'>");
        str.Append("<tr>");
        str.Append(" <td width='15' height='30' align='left' valign='middle'><img src='image/arrow.gif' width='8' height='9' /></td>");
        str.Append(" <td width='618' align='left' valign='middle' class='pink_text1'>Results</td>");
        str.Append(" </tr>");

        str.Append("<tr>");
        str.Append("<td height='10' colspan='2' align='left' valign='top'><img src='image/big_line.gif' width='633' height='1' /></td>");
        str.Append("</tr>");
        str.Append("<tr>");
        str.Append("<td height='250' colspan='2' align='left' valign='top'><table width='633' border='1' cellpadding='0' cellspacing='0' bordercolor='#5c5c5c' bgcolor='#eeeeee'>");
        str.Append(" <tr>");
        str.Append(" <td height='231' align='left' valign='top'><table width='633' height='231' border='0' cellspacing='0' cellpadding='0'>");
        str.Append("<tr height='30px'>");
        str.Append(" <td width='25' class='top_pinktab'> <img src='image/arrow.gif' width='8' height='9' /></td>");

        str.Append("<td width='608' colspan='2' class='top_pinktab' valign='middle'><span class='white_hd' >Armstrong Training Test<br /> </span></td>");
        str.Append("  </tr>");
        str.Append(" <tr>");
        str.Append("  <td height='40'>&nbsp;</td>");
        str.Append(" <td width='304' align='left' valign='bottom' colspan='2' >");
        str.Append(" <table width='90%' border='0' cellspacing='0' cellpadding='0'>");

        str.Append("  <tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append(" <tr>");
        str.Append("<td width='173' class='font_text2'>Name :</td>");

        str.Append(" <td width='100' class='form_font'>");
        str.Append(UN);
        str.Append(" </td>");
        str.Append(" </tr>");
        str.Append(" <tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append("<tr>");
        str.Append(" <td width='173' class='font_text2'>Category :</td>");

        str.Append("<td width='100' class='form_font'>");
        str.Append(C);
        str.Append(" </td>");
        str.Append("</tr>");

        str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append("<tr>");
        str.Append("<td width='173' class='font_text2'>Sub Category :</td>");

        str.Append("<td width='100' class='form_font'>");
        str.Append(SC);
        str.Append("</td>");
        str.Append(" </tr>");
        str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append("  <tr>");
        str.Append("  <td width='173' class='font_text2'>Exam Name :</td>");

        str.Append(" <td width='100' class='form_font'>");
        str.Append(Exam);
        str.Append("</td>");
        str.Append("</tr>");

        str.Append(" <tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append(" <tr>");
        str.Append("<td width='173' class='font_text2'>Date :</td>");

        str.Append("<td width='100' class='form_font'>");
        str.Append(D);
        str.Append(" </td>");
        str.Append("</tr>");
        str.Append(" <tr><td colspan='2'>&nbsp;</td></tr>");

        str.Append(" <tr>");
        str.Append(" <td width='173' class='font_text2'>Marks :</td>");

        str.Append(" <td width='100' class='form_font'>");
        str.Append(M);
        str.Append("</td>");
        str.Append(" </tr>");
        str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append(" <tr>");
        str.Append("<td width='173' class='font_text2'>Total Questions :</td>");

        str.Append("<td width='100' class='form_font'>");
        str.Append(TQ);
        str.Append("  </td>");
        str.Append(" </tr>");
        str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append("<tr>");
        str.Append(" <td width='173' class='font_text2'>Total Attempt Questions :</td>");
        str.Append("<td width='100' class='form_font'>");
        str.Append(AQ);
        str.Append("&nbsp;</td>");
        str.Append("</tr>");
        str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append("<tr>");
        str.Append(" <td width='173' class='font_text2'>Total Non-attempt Questions :</td>");
        str.Append("<td width='100' class='form_font'>");
        str.Append(naq);
        str.Append("</td>");
        str.Append(" </tr>");
        str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append("<tr>");
        str.Append("<td width='173' class='font_text2'>Correct Answer :</td>");
        str.Append(" <td width='100' class='form_font'>");
        str.Append(ca);
        str.Append("</td>");
        str.Append(" </tr>");
        str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");

        str.Append("<tr>");
        str.Append(" <td width='173' class='font_text2'>Percentage :</td>");
        str.Append(" <td width='100' class='form_font'>");
        str.Append(p);
        str.Append("</td>");
        str.Append(" </tr>");
        str.Append(" <tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append("<tr>");
        str.Append("<td width='173' class='font_text2'>Grade :</td>");
        str.Append("<td width='100' class='form_font'>");
        str.Append(G);
        str.Append(" </td>");
        str.Append(" </tr>");
        str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
        str.Append("</table></td>");

        str.Append("</tr>");



        str.Append("</table></td>");
        str.Append(" </tr>");
        str.Append("</table></td>");
        str.Append("</tr>");
        str.Append("</table>");
        str.Append("</tr>");
        str.Append("<br>");
        // }
        str.Append("</table>");
        string _body = str.ToString();
        return _body;
    }



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
        str.Append("<tr><td height='39' colspan='3' align='center' valign='middle'><font size='6' font-weight='normal'>" + UN + "</font></td></tr>");
        str.Append("<tr><td colspan='3'>&nbsp;</td></tr>");
        str.Append("<tr><td colspan='3' align='center'><img src=cid:Image4 width='565' height='21' alt=''></td></tr>");
        str.Append("<tr><td colspan='3'>&nbsp;</td></tr>");
        str.Append("<tr><td height='27' colspan='3' align='center' valign='middle' ><font size='4' font-weight='normal'>" + Exam + "</font></td></tr>");
        str.Append("<tr><td height='23' colspan='3' align='center' valign='middle' ><font size='3' font-weight='normal'>Grade:" +G + "%</font></td></tr>");
        str.Append("<tr><td colspan='3'><br/><br/><br/><br/><br/><br/><br/><br/><br/></td></tr>");
        str.Append("<tr><td height='20' colspan='3' align='right' valign='middle'>   " + D + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td></tr>");
        str.Append("<tr><td>&nbsp;</td><td align='right'><img src=cid:Image5 width='160' height='24' alt=''></td><td>&nbsp;</td></tr>");
        str.Append("<tr><td colspan='3' align='center'><img src=cid:Image6 width='565' height='137' alt=''></td></tr>");
        str.Append("<tr><td colspan='3'>&nbsp;</td></tr>");
        str.Append("<tr><td colspan='7'><img src=cid:Image7 width='673' height='8' alt=''></td></tr>");
        str.Append("</table>");


        AlternateView view = null;
        view = AlternateView.CreateAlternateViewFromString(str.ToString(), Encoding.Default, "text/html");

        LinkedResource resource = null, resource1 = null, resource2 = null, resource3 = null, resource4 = null, resource5 = null, resource6 = null, resource7 = null, resource8 = null, resource9 = null;

        resource = new LinkedResource((Server.MapPath("images/certificate_01.jpg")));
        resource1 = new LinkedResource((Server.MapPath("images/certificate_06.jpg")));
        resource2 = new LinkedResource((Server.MapPath("images/certificate_08.jpg")));
        resource3 = new LinkedResource((Server.MapPath("images/certificate_11.jpg")));
        resource4 = new LinkedResource((Server.MapPath("images/certificate_20.jpg")));
        resource5 = new LinkedResource((Server.MapPath("images/certificate_22.jpg")));
        resource6 = new LinkedResource((Server.MapPath("images/certificate_24.jpg")));
        resource7 = new LinkedResource((Server.MapPath("images/certificate_02.jpg")));
        resource8 = new LinkedResource((Server.MapPath("images/certificate_04.jpg")));
        resource9 = new LinkedResource((Server.MapPath("images/logo.jpg")));



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

     
         mMailMessage.Subject = "Armstrong Training Test";
          //mMailMessage.To.Add("laxmi@ucc-india.com");
         mMailMessage.To.Add(Email);
         mMailMessage.Body = str.ToString();

       ////////////---ucc-india.com \\\\\\\\\\\\\\\



         mMailMessage.From = new MailAddress("support@thaneguide.com");
         mMailMessage.IsBodyHtml = true;
         mMailMessage.Priority = MailPriority.Normal;
         SmtpClient mSmtpClient = new SmtpClient();
         mSmtpClient.Host = "smtp.thaneguide.com";
         mSmtpClient.Port = 25;

         mSmtpClient.Credentials = new System.Net.NetworkCredential("support@thaneguide.com", "uccpr71");
         mSmtpClient.Send(mMailMessage);
        ////////////////////////////////////////////////



        // MailMessage mMailMessage = new MailMessage();
        // mMailMessage.Subject = strSubject;
        // mMailMessage.To.Add(recepient);
        // if (CC != "")
         //{
         //    mMailMessage.CC.Add(new MailAddress(CC));
        // }
        // mMailMessage.Body = body;

        /////////////-----------/////////////////


         //mMailMessage.From = new MailAddress("helpdeskindia@armstrong.com");
         //mMailMessage.IsBodyHtml = true;
         //mMailMessage.Priority = MailPriority.Normal;
         //SmtpClient mSmtpClient = new SmtpClient();

         //mSmtpClient.Host = "mail.armstrong.com";
         //mSmtpClient.Port = 25;
         //mSmtpClient.Credentials = new System.Net.NetworkCredential("genmumhelpdeskindia", "mjk_786", "PACRIM");
         //mSmtpClient.UseDefaultCredentials = false;
         //mSmtpClient.Send(mMailMessage);

        lbltitle.Text = "Mail has been Sent Successfully ";

      
        }

    
    
   
    public void ExportDataSetToExcel(DataSet ds, string filename)
    {
        HttpResponse response = HttpContext.Current.Response;

        // first let's clean up the response.object   
        response.Clear();
        response.Charset = "";

        // set the response mime type for excel   
        response.ContentType = "application/vnd.ms-excel";
        response.AddHeader("Content-Disposition", "attachment;filename=\"" + filename + ".xls\"");

        // create a string writer   
        using (StringWriter sw = new StringWriter())
        {
            using (HtmlTextWriter htw = new HtmlTextWriter(sw))
            {
                // instantiate a datagrid   
                DataGrid dg = new DataGrid();
                dg.DataSource = ds.Tables[0];

                dg.DataBind();
                dg.RenderControl(htw);
                response.Write(sw.ToString());
                response.End();
            }
        }

       // panel.Visible = false;

    }
  
   
}
