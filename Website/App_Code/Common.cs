using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
using System.Text;
using System.Net;

public class Common
{

/// <summary>
/// Summary description for Common
/// </summary>
    public Common()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static void PrintError(Exception e, Label lbl)
    {
        lbl.Text = "Exception Occured :" + e.Message.ToString();
    }
    public static void FillDate(DropDownList DDlDate, DropDownList DDlMonth, DropDownList DDlYear, string strValueField, string strDefault, string strDefaultValue)
    {
        for (int i = 1; i < 32; i++)
        {
            DDlDate.Items.Add(i.ToString());
        }

        for (int i = 2008; i <= Convert.ToInt32(DateTime.Today.Year.ToString()) + 4; i++)
        {
            DDlYear.Items.Add(i.ToString());
        }
        DDlMonth.Items.Add("Jan");
        DDlMonth.Items.Add("Feb");
        DDlMonth.Items.Add("Mar");
        DDlMonth.Items.Add("Apr");
        DDlMonth.Items.Add("May");
        DDlMonth.Items.Add("Jun");
        DDlMonth.Items.Add("Jul");
        DDlMonth.Items.Add("Aug");
        DDlMonth.Items.Add("Sep");
        DDlMonth.Items.Add("Oct");
        DDlMonth.Items.Add("Nov");
        DDlMonth.Items.Add("Dec");
        if (strDefaultValue != "")
        {
            ListItem item = new ListItem(strDefault, strDefaultValue);
            DDlDate.Items.Insert(0, item);
            DDlMonth.Items.Insert(0, item);
            DDlYear.Items.Insert(0, item);
        }
    }
    public static void CheckAdminSessionValid(string strSession)
    {
        bool flag1 = strSession == "";
    }

    //public static void FillCheckBoxList(CheckBoxList cblist, IDataReader dr, string strTextField, string strValueField)
    //{
    //    cblist.DataSource = dr;
    //    cblist.DataTextField = strTextField;
    //    cblist.DataValueField = strValueField;
    //    cblist.DataBind();
    //}

    public static void FillReader(System.Web.UI.WebControls.DropDownList cmb, IDataReader dr, string strTextField, string strValueField, string strDefault, string strDefaultValue)
     {
        cmb.DataSource = dr;
        cmb.DataTextField = strTextField;
        cmb.DataValueField = strValueField;
        cmb.DataBind();
        //if (strDefaultValue = "")
        //{
        System.Web.UI.WebControls.ListItem item = new ListItem(strDefault, strDefaultValue);
        cmb.Items.Insert(0, item);
        //}
    }

    public static void sendSmsfromMobile(string Strmessage, string strMobile)
    {
        String DeleteItem = ",";

        if (strMobile.Contains(DeleteItem))
        {
            String[] aData = strMobile.Split(',');
            String strMobileNew = String.Empty;
            foreach (String data in aData)
            {
                strMobileNew = data;
                strMobileNew = strMobileNew.Trim();
                if (strMobileNew.Length == 10)
                {
                    SendSmsMessage(Strmessage, strMobileNew);
                }
            }
        }
        else
        {
            if (strMobile.Length == 10)
            {
                SendSmsMessage(Strmessage, strMobile);
            }
        }
    }

    public static void SendMailMessage(String body, String recepient, String cc,String Bcc, string StrSubject)
    {
        MailMessage mMailMessage = new MailMessage();
        //'mMailMessage.From = New MailAddress(from)
        mMailMessage.To.Add(new MailAddress(recepient));
        if (cc != "")
        {
            mMailMessage.CC.Add(new MailAddress(cc));
        }
        if (Bcc != "")
        {
            mMailMessage.Bcc.Add(new MailAddress(Bcc));
        }
        mMailMessage.Subject = StrSubject;
        mMailMessage.Body = body;
        mMailMessage.IsBodyHtml = true;
        mMailMessage.Priority = MailPriority.Normal;
        SmtpClient mSmtpClient = new SmtpClient();
        mSmtpClient.Send(mMailMessage);
    }

    /// These will  Send the smsMessage text to smsMobile no of 10 digit.
    /// <summary>
    /// These will  Send the smsMessage text to smsMobile no of 10 digit.
    /// </summary>
    public static void SendSmsMessage(string smsMsg, string smsMobile)
    {
        string mobileNo = "91" + smsMobile;
        //http://sms.smsxyz.com/sms/sendsms.sms?username=thaneguide&password=Pwd&clientid=000000&gsmsenderid=GB-Alibag&cdmasenderid=9999999999&mobilenumber=919999999999&smsmessage=Mumbai"
        string strUsername = System.Configuration.ConfigurationManager.AppSettings["username"].ToString();
        string strKeyword = System.Configuration.ConfigurationManager.AppSettings["Keyword"].ToString();
        string strclientid = System.Configuration.ConfigurationManager.AppSettings["clientid"].ToString();
        string strgsmsenderid = System.Configuration.ConfigurationManager.AppSettings["gsmsenderid"].ToString();
        string strcdmasenderid = System.Configuration.ConfigurationManager.AppSettings["cdmasenderid"].ToString();

        String postData = "username=" + strUsername;
        postData += "&password=" + strKeyword;
        postData += "&clientid=" + strclientid;
        postData += "&gsmsenderid=" + strgsmsenderid;
        postData += "&cdmasenderid=" + strcdmasenderid;
        postData += ("&mobilenumber=" + mobileNo);
        postData += ("&smsmessage='" + HttpUtility.UrlEncode(smsMsg) + "'");
        //smsKeyword
        byte[] data1 = Encoding.ASCII.GetBytes(postData);
        // Preparing web request
        HttpWebRequest myRequest1 = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("http://sms.smsxyz.com/sms/sendsms.sms?");
        myRequest1.Method = "POST";
        myRequest1.ContentType = "application/x-www-form-urlencoded";
        myRequest1.ContentLength = data1.Length;
        System.IO.Stream newStream1 = myRequest1.GetRequestStream();
        // Sending the data
        newStream1.Write(data1, 0, data1.Length);
        newStream1.Close();
    }

    public static string GetRandomUserName(int length)
    {
        char[] chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        string UserName = string.Empty;
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            int x = random.Next(1, chars.Length);
            //Don't Allow Repetation of Characters      
            if (!UserName.Contains(chars.GetValue(x).ToString()))
                UserName += chars.GetValue(x);
            else
                i--;
        }
        return UserName;
    }
    public static string GetRandomPassword(int length)
    {
        char[] chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();
        string password = string.Empty;
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            int x = random.Next(1, chars.Length);
            //Don't Allow Repetation of Characters      
            if (!password.Contains(chars.GetValue(x).ToString()))
                password += chars.GetValue(x);
            else
                i--;
        }
        return password;
    }
    public static void FillPrice(DropDownList DDlCrore, DropDownList ddlLacs, DropDownList ddlThousand, string strDefault, string strDefaultValue)
    {
        DDlCrore.Items.Clear();
        ddlLacs.Items.Clear();
        ddlThousand.Items.Clear();
        for (int i = 1; i < 100; i++)
        {
            DDlCrore.Items.Add(i.ToString());
            ddlLacs.Items.Add(i.ToString());
            ddlThousand.Items.Add(i.ToString());
        }
        ListItem item = new ListItem(strDefault, strDefaultValue);
        DDlCrore.Items.Insert(0, item);
        ddlLacs.Items.Insert(0, item);
        ddlThousand.Items.Insert(0, item);
    }

    /// This will Add value 0 lakhs to 100 cr no for prices
    /// <summary>
    /// This will Add value 0 lakhs to 100 cr no for prices
    /// </summary>    
    public static void Fillprice(DropDownList DDlpriceFrom, DropDownList DDlpriceTo, DropDownList ddlINRfrom, DropDownList ddlINRTo, string strDefault, string strDefaultValue)
    {
        DDlpriceFrom.Items.Clear();
        DDlpriceTo.Items.Clear();
        ddlINRfrom.Items.Clear();
        ddlINRTo.Items.Clear();
        for (int i = 0; i < 100; i++)
        {
            DDlpriceFrom.Items.Add(i.ToString());
            DDlpriceTo.Items.Add(i.ToString());
        }
        ddlINRTo.Items.Add(new ListItem("-Select-", ""));
        ddlINRTo.Items.Add(new ListItem("Thousands", "1"));
        ddlINRTo.Items.Add(new ListItem("Lakhs", "2"));
        ddlINRTo.Items.Add(new ListItem("Crores", "3"));
        ddlINRfrom.Items.Add(new ListItem("-Select-", ""));
        ddlINRfrom.Items.Add(new ListItem("Thousands", "1"));
        ddlINRfrom.Items.Add(new ListItem("Lakhs", "2"));
        ddlINRfrom.Items.Add(new ListItem("Crores", "3"));
    }

    /// This will Add value 1 lakhs to 100 cr no for prices
    /// <summary>
    /// This will Add value 1 lakhs to 100 cr no for prices
    /// </summary>    
    public static void FillBuyerprice(DropDownList DDlpriceFrom, DropDownList DDlpriceTo, DropDownList ddlINRfrom, DropDownList ddlINRTo, string strDefault, string strDefaultValue)
    {
        DDlpriceFrom.Items.Clear();
        DDlpriceTo.Items.Clear();
        ddlINRfrom.Items.Clear();
        ddlINRTo.Items.Clear();
        for (int i = 1; i < 100; i++)
        {
            DDlpriceFrom.Items.Add(i.ToString());
            DDlpriceTo.Items.Add(i.ToString());
        }
        ddlINRTo.Items.Add(new ListItem("-Select-", ""));
        ddlINRTo.Items.Add(new ListItem("Thousands", "1"));
        ddlINRTo.Items.Add(new ListItem("Lakhs", "2"));
        ddlINRTo.Items.Add(new ListItem("Crores", "3"));
        ddlINRfrom.Items.Add(new ListItem("-Select-", ""));
        ddlINRfrom.Items.Add(new ListItem("Thousands", "1"));
        ddlINRfrom.Items.Add(new ListItem("Lakhs", "2"));
        ddlINRfrom.Items.Add(new ListItem("Crores", "3"));
    }

    /// This will Add value 1 to 20 no for bed
    /// <summary>
    /// This will Add value 1 to 20 no for bed
    /// </summary>
    public static void FillBeds(DropDownList DDlBed, string strDefault, string strDefaultValue)
    {
        DDlBed.Items.Clear();
        for (int i = 1; i < 20; i++)
        {
            DDlBed.Items.Add(i.ToString());
        }
        ListItem item = new ListItem(strDefault, strDefaultValue);
        DDlBed.Items.Insert(0, item);
    }
    public static string GetPrice(string strPriceInCrores, string strPriceInlakhs, string strPriceInThousand)
    {
        string strPrice = "0";
        //For Crores
        if (strPriceInCrores != "0")
        {
            strPrice = strPriceInCrores + " <b>Crores</b> ";
        }
        //For lacs
        if (strPriceInlakhs != "0")
        {
            if (strPrice != "0")
            {
                strPrice = strPrice + " " + strPriceInlakhs + " <b>lac</b>";
            }
            else
            {
                strPrice = strPriceInlakhs + " <b>lac</b>";
            }
        }
        if (strPriceInThousand != "0")
        {
            if (strPrice != "0")
            {
                strPrice = strPrice + " " + strPriceInThousand + " <b>Thousands</b>";
            }
            else
            {
                strPrice = strPriceInThousand + " <b>Thousands</b>";
            }
        }
        return strPrice;
    }
}
