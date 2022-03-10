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
using System.Net.Mail;
using BusinessL;
using System.Net.Mime;
using System.Collections.Generic;
using System.Text;
using System.IO;

using System.Collections.ObjectModel;

public partial class Default2 : System.Web.UI.Page
{
    //string Attachement;
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsg.Text = string.Empty;
        if (!Page.IsPostBack)
        {
            lblMsg.Text = string.Empty;
            if (Request.QueryString["id"] != null)
            {
                lblEmail.Text = User_MstManager.Select(Convert.ToInt32(Request.QueryString["id"])).EmailId;
            }

            if (Request.QueryString["Datatable"] != null)
            {
               
                //gv1.DataSource = Session["Data"].ToString();
               // gv1.DataBind();
               //strFilename1 = MakeBody(Session["Data"].ToString());
            }
           // txtMsg.Text = MakeBody1();
            MakeBody1();

        } 

    }

    //private string getHTML(GridView gv)
    //{
    //    StringBuilder sb = new StringBuilder();
    //    StringWriter textwriter = new StringWriter(sb);
    //    HtmlTextWriter htmlwriter = new HtmlTextWriter(textwriter);
    //    gv.RenderControl(htmlwriter);
    //    htmlwriter.Flush();
    //    textwriter.Flush();
    //    htmlwriter.Dispose();
    //    textwriter.Dispose();
    //    return sb.ToString();
    //}
    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        try
        {


            //strFilename = Server.MapPath(FileUpload1.FileName);
            //if (FileUpload1.HasFile)
            //{

            //    FileUpload1.SaveAs(AppDomain.CurrentDomain.BaseDirectory.ToString()+" "+ strFilename);
            //}
     
            //Booking objbk = new Booking();
            
                if (SuccessMail() == true)
                {
                    //if (Request.QueryString["id1"] != null)
                    //{
                    //    objbk.BookingId = Convert.ToInt32(Request.QueryString["id1"]);

                    //    BookingManager.DisallowBooking(objbk);
                    //}

                    Cancel();

                    lblMsg.Text = "Message Sent succefully";
                }
          
            
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message.ToString();
        }
    
       
       
    }


    public void SendMailMessage(string strSubject, String body, String recepient, String CC,String Attachement )
    {
        //MailMessage mMailMessage = new MailMessage();
        //mMailMessage.Subject = strSubject;
        //mMailMessage.To.Add(recepient);
        

       // Attachment data = new Attachment(attached,MediaTypeNames.Application.Octet);
        //// Add time stamp information for the file.
      //  ContentDisposition disposition = data.ContentDisposition;
        //disposition.CreationDate = System.IO.File.GetCreationTime(attached);
      //  disposition.ModificationDate = System.IO.File.GetLastWriteTime(attached);
       // disposition.ReadDate = System.IO.File.GetLastAccessTime(attached);
        //// Add the file attachment to this e-mail message.
      //  mMailMessage.Attachments.Add(data);

       // mMailMessage.Attachments = attached;
        //if (CC != "")
        //{
        //    mMailMessage.CC.Add(new MailAddress(CC));
        //}
        //mMailMessage.Body = body;
        //mMailMessage.From = new MailAddress("laxmi@ucc-india.com");
        //mMailMessage.IsBodyHtml = true;
        //mMailMessage.Priority = MailPriority.Normal;
        //SmtpClient mSmtpClient = new SmtpClient();
        //mSmtpClient.Host = "smtp.ucc-india.com";
        //mSmtpClient.Port = 25;
        //mSmtpClient.Timeout = 1000000;
        //mSmtpClient.EnableSsl = true;
        //mSmtpClient.UseDefaultCredentials = false;



        //mSmtpClient.Credentials = new System.Net.NetworkCredential("laxmi@ucc-india.com","laxmi123");
        //mSmtpClient.Send(mMailMessage);

        

    }

    private Boolean SuccessMail()
    {
       
        string str = MakeBody();
        string subject = txtSubject.Text;
        string Email =lblEmail.Text ;



        SendMailMessage(subject, str, Email, "","");
        return true;
    }

    private void Cancel()
    {
        lblEmail.Text = "";
      //  txtMsg.Text = "";
        txtSubject.Text = "";
        
      

    }
    private void MakeBody1()
    {
        StringBuilder str = new StringBuilder();

        // foreach (HeaderValue hv in collection)
        // {
        str.Append("<table border='0' cellspacing='0' cellpadding='0' align='left'><tr><td><pre> " + "test mail"+ "</td></pre>");
        str.Append("</tr>");
        str.Append("<br>");
        // }
        str.Append("</table>");
        //txtMsg.Text= str.ToString();
        //return _body;
    }
    private string MakeBody()
    {
        StringBuilder str = new StringBuilder();

        // foreach (HeaderValue hv in collection)
        // {
        str.Append("<table border='0' cellspacing='0' cellpadding='0' align='left'><tr><td><pre> " + "messagetextbox "+ "</td></pre>");
        str.Append("</tr>");
        str.Append("<br>");
        // }
        str.Append("</table>");
        string _body = str.ToString();
        return _body;
    }
}
