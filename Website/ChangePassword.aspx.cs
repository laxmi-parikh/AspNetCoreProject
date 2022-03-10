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
using System.Net.Mail;
using System.Text;

public partial class ForgetPassword : System.Web.UI.Page
{

    //string successpage = "success.html";

    // name of failture page
  //  string failurepage = "failure.html";

    // email to - id of receipient
    //string emailTo = "highlandsrainshine@gmail.com";
    string emailTo;

    // subject to Mail head
    string mailsubject = "Armstrong Training";

    //string Password;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtemail.Text = string.Empty;
            lblMsg.Text = string.Empty;
        }
        lblMsg.Text = string.Empty;

    }
    //protected void btn_Submit_Click(object sender, EventArgs e)
    //{

    //    RegisteredMember obj = RegisteredMemberManager.GetPassword(Convert.ToString(txtemail.Text));
    //    if (obj != null)
    //    {
    //        Password = obj.Password;

    //        if (SuccessMail())
    //        {
    //            lblMsg.Text = "Your Password has been Email you, Please Check your inbox";
    //            txtemail.Text = string.Empty;
    //        }
    //        else
    //        {
    //            lblMsg.Text = "Invalid UserName";
    //            txtemail.Text = string.Empty;
    //        }

    //    }
    //    else
    //    {
    //        lblMsg.Text = "Invalid UserName";
    //        txtemail.Text = string.Empty;
    //    }
       



    //}
    public void SendMailMessage(string strSubject, string body, string recepient, String CC)
    {
        //MailMessage mMailMessage = new MailMessage();
        //mMailMessage.Subject = strSubject;
        //mMailMessage.To.Add(recepient);
        //if (CC != "")
        //{
        //    mMailMessage.CC.Add(new MailAddress(CC));
        //}
        //mMailMessage.Body = body;
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
        string str = "<b>Your New Password is :</b><br/>";//MakeBody();
        str += "Email &nbsp;:&nbsp;" + txtemail.Text + "<br/>";
        str += "Password &nbsp;:&nbsp;" + txtNewPassword.Text + "<br/>";
        string subject = mailsubject;
        string Email = emailTo;
        SendMailMessage(subject, str, Email, "");
        return true;
    }

    private string MakeBody()
    {
        StringBuilder str = new StringBuilder();

        str.Append("<tr><th colspan='2' align='left> Your Password is</th><br/></tr>");
        //foreach (HeaderValue hv in collection)
        //{
            str.Append("<tr><td>Email </td>&nbsp;&nbsp; <td> :  </td><td><pre> " + txtemail.Text + "</td></pre>");
            str.Append("</tr>");
            str.Append("<br>");
            str.Append("<tr><td>Password </td>&nbsp;&nbsp; <td> :  </td><td><pre> " + txtNewPassword.Text + "</td></pre>");
            str.Append("</tr>");
            str.Append("<br>");
       // }
        str.Append("</table>");
        string _body = str.ToString();
        return _body;
    }

    protected void btn_Submit_Click1(object sender, EventArgs e)
    {
        
        User_Mst obj = new User_Mst();
        if (obj != null)
        {

            obj.EmailId = Convert.ToString(txtemail.Text);
            obj.Password = Convert.ToString(txtNewPassword.Text);
         //User_MstManager.

            emailTo = obj.EmailId;
            if (SuccessMail())
            {
                lblMsg.Text = "Your Password has been Email you, Please Check your inbox";
                txtemail.Text = string.Empty;
                txtNewPassword.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            else
            {
                lblMsg.Text = "Invalid UserName";
                txtemail.Text = string.Empty;
                txtNewPassword.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }

        }
        else
        {
            lblMsg.Text = "Invalid UserName";
            txtemail.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
       


    }
}
