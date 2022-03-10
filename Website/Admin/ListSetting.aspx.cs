using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;
using System.Collections.Generic;
using iTextSharp.text;
using System.IO;
using System.Net.Mail;


public partial class Admin_ListQuestion : System.Web.UI.Page
{
    string EmailId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           // BindQuestion();
            BindMainTitle();
           
        
        }
    }

    private void BindQuestion()

    {
        if (ddlSubTitle.SelectedValue != "Select")
        {
            List<Settingone> objlist = SettingoneManager.GetAllByLevelId(Convert.ToInt32(ddlSubTitle.SelectedValue));
            if (objlist != null)
            {
                gvQuestion.Visible = true;
                //gvQuestion.DataSource = QuestionMstManager.GetAll();


                gvQuestion.DataSource = objlist;
                gvQuestion.DataBind();
                lblMsg.Text = "";
            }
            else
            {
                lblMsg.Text = "No Data Available";
                gvQuestion.Visible = false;
            }
        }
        else
        {
            gvQuestion.Visible = false;
            lblMsg.Text = "Select Sub Title";
            
        }
    }



    public void BindMainTitle()
    {

        ddlMainTitle.DataTextField = "FunctionName";
        ddlMainTitle.DataValueField = "Functionid";
        ddlMainTitle.DataSource = FunctionMstManager.GetAll();


        ddlMainTitle.DataBind();
        ddlMainTitle.Items.Insert(0, "Select");
        ddlSubTitle.Items.Insert(0, "Select");


    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvQuestion.PageIndex = e.NewPageIndex;
        BindQuestion();
    }
    protected void gvQuestion_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int SettingId;


         if (e.CommandName == "Delete")
         {

             SettingId = Convert.ToInt32(e.CommandArgument.ToString());
             SettingoneManager.Delete(SettingId);

         }
       
    }
   

    protected void gvQuestion_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        gvQuestion.EditIndex = -1;
        BindQuestion();

    }
    protected void gvQuestion_RowDataBound(object sender, GridViewRowEventArgs e)
    {
       


    }

    protected void gvQuestion_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlMainTitle_SelectedIndexChanged(object sender, EventArgs e)
    {
       

       
        if (ddlMainTitle.SelectedItem.Text == "Select")
        {
            lblMsg.Text = "Select Main Title";
            return;
            gvQuestion.Visible = false;
        }
        else
        {
            ddlSubTitle.Items.Clear();
            gvQuestion.Visible = true;
            ddlSubTitle.DataTextField = "Levelname";
            ddlSubTitle.DataValueField = "Levelid";
            ddlSubTitle.DataSource = LevelMstManager.listlevel(Convert.ToInt32(ddlMainTitle.SelectedValue));
                //SubTitleManager.ListAllSubTitleByMainID(Convert.ToInt32(ddlMainTitle.SelectedValue));
            ddlSubTitle.DataBind();
            lblMsg.Text = "";

            ddlSubTitle.Items.Insert(0, "Select");

        }
        

        
    }
    protected void btn_Submit_Click(object sender, ImageClickEventArgs e)
    {
        BindQuestion();

    }
    DataSet ds;
    string BindTimetable()
    {
        if (ddlMainTitle.SelectedValue != null && ddlSubTitle.SelectedValue != null)
        {
            ds = SettingoneManager.GetExamTimeTable(Convert.ToInt16(ddlMainTitle.SelectedValue), Convert.ToInt16(ddlSubTitle.SelectedValue));

            return ExportDataSet(ds);
        }
        else
        {
            return "";
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {


        List<User_Mst> objuser = User_MstManager.GetAll();

        for (int i = 0; i < objuser.Count; i++)
        {
            if (objuser[i].EmailId != null || objuser[i].EmailId != " ")
            {
                EmailId = objuser[i].EmailId;

                if (SuccessMail() == true)
                {

                    Cancel();


                    lblMsg.Text = "Message Sent Successfully";
                }
            }

       }

        CheckBox1.Checked = false;
          

    

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
        //mMailMessage.Body = "<b>Armstrong Exam Time Table</b> <br/><br/>" + BindTimetable();
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
        mMailMessage.Body = "<b>Armstrong Exam Time Table</b> <br/><br/>" + BindTimetable();
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
        string subject = "Armstrong Exam Time Table";
        string Email = EmailId;



        SendMailMessage(subject, Email, "");
        return true;
    }

    void Cancel()
    {
        //txtMailto.Text = string.Empty;
        //txtSubject.Text = string.Empty;
    }

    public string ExportDataSet(DataSet ds)
    {
       // HttpResponse response = HttpContext.Current.Response;

        // first let's clean up the response.object   
       // response.Clear();
       // response.Charset = "";

        // set the response mime type for excel   
       // response.ContentType = "application/vnd.ms-excel";
       // response.AddHeader("Content-Disposition", "attachment;filename=\"" + filename + "\"");

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
               // response.Write(sw.ToString());
               // response.End();

                return sw.ToString();

            }
        }

        // panel.Visible = false;

    }
}


  
    


  

       


    

