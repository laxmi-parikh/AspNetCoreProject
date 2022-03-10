using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;
using System.Text;
using System.Net.Mail;
using System.IO;




public partial class Admin_Default2 : System.Web.UI.Page
{
    //string TQ,AQ,naq,ca,p,G;
    //string Email;

    DataTable dt;
    //int a;

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
        if (Request.QueryString["SetId"]!=null)
        {

            Settingone objset=SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SetId"]));
            if(objset!=null)
            {
        lblExamTitle.Text =objset.TitleForExam;
                if(objset.Interview==0)
                {
                lblName.Text=User_MstManager.Select(Convert.ToInt32(Request.QueryString["UserId"])).FirstName +" "+User_MstManager.Select(Convert.ToInt32(Request.QueryString["UserId"])).LastName;
                }else{
                       lblName.Text=InterviewMstManager.Select(Convert.ToInt32(Request.QueryString["UserId"])).Name;
         

                }
           // 
        //List<Result_Mst> objResult = Result_MstManager.GetResultReport(Convert.ToInt32(Request.QueryString["SettingId"]));
       
        DataSet objResult = Exam_MstManager.GetStudentHistory(Convert.ToInt32(Request.QueryString["UserId"]),Convert.ToInt32(Request.QueryString["SetId"]));

        if (objResult.Tables.Count>0)
        {

           gvMainTitle.DataSource = objResult;
            gvMainTitle.DataBind();

           
           
        }
       else
        {
           lbltitle.Text = "No Data Found";
        }
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
    //protected void gvMainTitle_SelectedIndexChanged(object sender, EventArgs e)
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

    //        //CheckBox Checkbox1 = (CheckBox)row.FindControl("CheckBox1");
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
    //        //if (Checkbox1.Checked)
    //       // {
    //            if (SuccessMail() == true)
    //            {


    //                Cancel();
    //                lbltitle.Text = "Mail has been Sent Successfully ";


    //            //}
    //        //
    //        }




    //    }
    //    BindGrid();


    //}
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
            Label lbloption1 = (Label)row.FindControl("lbloption1");
            Label lbloption2 = (Label)row.FindControl("lbloption2");
            Label lbloption3 = (Label)row.FindControl("lbloption3");
            Label lbloption4 = (Label)row.FindControl("lbloption4");
            Label lbloption5 = (Label)row.FindControl("lbloption5");
            Label lbloption6 = (Label)row.FindControl("lbloption6");
            Panel Panel_1 = (Panel)row.FindControl("Panel_1");
            Panel Panel2 = (Panel)row.FindControl("Panel2");
            Panel Panel3 = (Panel)row.FindControl("Panel3");
            Panel Panel4 = (Panel)row.FindControl("Panel4");
            Panel Panel5 = (Panel)row.FindControl("Panel5");
            Panel Panel6 = (Panel)row.FindControl("Panel6");


            if (lbloption1.Text == "" || lbloption1.Text == null)
            {
                Panel_1.Visible = false;

            }
            else
            {
                Panel_1.Visible = true;
            }
            if (lbloption2.Text == "" || lbloption2.Text == null)
            {
                Panel2.Visible = false;

            }
            else
            {
                Panel2.Visible = true;
            }
            if (lbloption3.Text == "" || lbloption3.Text == null)
            {
                Panel3.Visible = false;

            }
            else
            {
                Panel3.Visible = true;
            }
            if (lbloption4.Text == "" || lbloption4.Text == null)
            {
                Panel4.Visible = false;

            }
            else
            {
                Panel4.Visible = true;
            }
            if (lbloption5.Text == "" || lbloption5.Text == null)
            {
                Panel5.Visible = false;

            }
            else
            {
                Panel5.Visible = true;
            }
            if (lbloption6.Text == "" || lbloption6.Text == null)
            {
                Panel6.Visible = false;

            }
            else
            {
                Panel6.Visible = true;
            }



        }
           


          

    }


 


    protected void btnExport_Click(object sender, EventArgs e)
    {
        

    }
    

    private void ShowPdf(string strS)
    {
        Response.ClearContent();
        Response.ClearHeaders();
        Response.ContentType = "application/pdf";
        Response.AddHeader
        ("Content-Disposition", "attachment; filename=" + strS);
        Response.TransmitFile(strS);
        Response.End();
        //Response.WriteFile(strS);
        Response.Flush();
        Response.Clear();

    }


    public override void VerifyRenderingInServerForm(Control control)
    {
        return;
    }


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

   

    DataSet obj;
    protected void Button1_Click(object sender, EventArgs e)
    {

       obj = SettingoneManager.GetallTitle(Convert.ToInt32(Request.QueryString["SettingId"]));
       // obj = Exam_MstManager.GetResultReport(Convert.ToInt32(Request.QueryString["SettingId"]));
         if(obj.Tables[0].Rows.Count>0)

         {
             dt = obj.Tables[0];

             ExportDataSetToExcel(obj, "ArmstrongExcelReport");
             //ExportDataSetToExcel(obj.Tables[0],"filename");
         }

      


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
  
    protected void btn_send_Click(object sender, EventArgs e)
    {
        if (SuccessMail() == true)
        {

            Cancel();


            lbltitle.Text = "Message Sent Successfully";
        }

        panel1.Visible = false;

    }
    protected void btn_Mail_Click(object sender, EventArgs e)
    {
        panel1.Visible = true;

    }
    private string GridViewToHtml(GridView gv)
    {
        StringBuilder sb = new StringBuilder();
        StringWriter sw = new StringWriter(sb);
        HtmlTextWriter hw = new HtmlTextWriter(sw);
        gv.RenderControl(hw);
        return sb.ToString();
    }
    public void SendMailMessage(string strSubject, String recepient, String CC)
    {
        //MailMessage mMailMessage = new MailMessage();
        //mMailMessage.Subject = strSubject;
        //mMailMessage.To.Add(recepient);


        //if (CC != "")
        //{
        //    mMailMessage.CC.Add(new MailAddress(CC));
        //}
        //mMailMessage.Body = GridViewToHtml(gvMainTitle);
        //mMailMessage.From = new MailAddress("support@thaneguide.com");
        //mMailMessage.IsBodyHtml = true;
        //mMailMessage.Priority = MailPriority.Normal;
        //SmtpClient mSmtpClient = new SmtpClient();
        //mSmtpClient.Host = "smtp.thaneguide.com";
        //mSmtpClient.Port = 25;

        //mSmtpClient.Credentials = new System.Net.NetworkCredential("support@thaneguide.com", "uccpr71");
        //mSmtpClient.Send(mMailMessage);

       ///////////// -----

        MailMessage mMailMessage = new MailMessage();
        mMailMessage.Subject = strSubject;
        mMailMessage.To.Add(recepient);
        if (CC != "")
        {
            mMailMessage.CC.Add(new MailAddress(CC));
        }
        mMailMessage.Body = GridViewToHtml(gvMainTitle);
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

        // string str = MakeBody();
        string subject = txtSubject.Text;
        string Email = txtMailto.Text;



        SendMailMessage(subject, Email, "");
        return true;
    }

    void Cancel()
    {
        txtMailto.Text = string.Empty;
        txtSubject.Text = string.Empty;
    }
    protected void btn_Mail_Click1(object sender, EventArgs e)
    {
       panel1.Visible = true;
     //
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ExamTitleReport1.aspx?SettingId=" + Request.QueryString["SettingId"]);
    }
}
