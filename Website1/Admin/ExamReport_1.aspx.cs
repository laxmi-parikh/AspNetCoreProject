using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;
using System.Net.Mail;
using System.IO;
using System.Net;
using System.Text;


public partial class Admin_Default2 : System.Web.UI.Page
{
//    string Datatable;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
            panel1.Visible = false;
        }


    }
    public void BindGrid()
    {
     //  List<Settingone> objsetting = SettingoneManager.GetAll();
      DataSet objsetting = SettingoneManager.GetReport();

      gvMainTitle.DataSource = SettingoneManager.GetReport();
      gvMainTitle.DataBind();

        //if (objsetting.Tables.Count>0)
      if (gvMainTitle.Rows.Count != 0)
        {

            //gvMainTitle.DataSource = objsetting.Tables[0];
            //gvMainTitle.DataBind();
           
        }
        else
        {
            lbltitle.Text = "No Data Found";
        }
    }
    protected void gvMainTitle_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvMainTitle.PageIndex = e.NewPageIndex;
        BindGrid();

    }
    protected void gvMainTitle_SelectedIndexChanged(object sender, EventArgs e)
    {

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
        //try
        //{
        //    foreach (GridViewRow row in gvMainTitle.Rows)
        //    {
        //        if (row.RowType == DataControlRowType.DataRow)
        //        {
        //            //    //Label lblUserRegister = (Label)row.FindControl("lblUserRegister");
        //            Label lblUserNotAttempt = (Label)row.FindControl("lblUserNotAttempt");
        //            Label lblUserAttempt = (Label)row.FindControl("lblUserAttempt");
        //            Label lblQuestion = (Label)row.FindControl("lblQuestion");
        //            Label lblSettingId = (Label)row.FindControl("lblSettingId");

        //            int? countusergivenexam = 0;
        //            countusergivenexam = SettingoneManager.GetCount(Convert.ToInt32(lblSettingId.Text));
        //            lblUserAttempt.Text = countusergivenexam.ToString();

        //            int? countuserforexam = 0;
        //            countuserforexam = SettingoneManager.GetCount(lblQuestion.Text);
        //            lblUserNotAttempt.Text = countuserforexam.ToString();

        //        }
                //    List<User_Mst> objUser = User_MstManager.GetAll();
                //    if (objUser.Count != null)
                //    {
                //        // lblUserRegister.Text = objUser.Count.ToString();
                //    }

                //    Settingone obj1 = SettingoneManager.GetcountuserbySetting(Convert.ToInt32(lblSettingId.Text));
                //    if (obj1 != null)
                //    {
                //        lblUserRegister1.Text = obj1.SettingId.ToString();



                //        Settingone obj2 = SettingoneManager.GetcountuserAttemptbySetting(Convert.ToInt32(lblSettingId.Text));
                //        if (obj2 != null)
                //        {
                //            lblUserAttempt.Text = obj2.SettingId.ToString();
                //            lblUserNotAttempt.Text = Convert.ToString(Convert.ToInt32(lblUserRegister1.Text) - Convert.ToInt32(lblUserAttempt.Text));

                //        }

                //    }


        //    }
        //}
        //catch (NullReferenceException ex)
        //{
        //}
      
    }
    //void bindAttached()
    //{
    //    Response.Clear();
    //    Response.AddHeader("content-disposition", "attachment;filename=FileName.xls");
    //    Response.Charset = "";
    //    Response.ContentType = "application/vnd.xls";
    //    System.IO.StringWriter stringWrite = new System.IO.StringWriter();
    //    System.Web.UI.HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
    //    divExport.RenderControl(htmlWrite);
    //    Response.Write(stringWrite.ToString());
    //    Response.End();
    //}

  // ;
    protected void btnExport_Click(object sender, EventArgs e)
    {


              //  string strFile; ///"SrNo", , "No. of Attempted", "No. of user not attempted"


                //
        ////        HtmlForm form = new HtmlForm();
        ////form.Controls.Add(gvMainTitle);
        ////StringBuilder sb = new StringBuilder();

        ////StringWriter sw = new StringWriter(sb);
        ////HtmlTextWriter hTextWriter = new HtmlTextWriter(sw);

        ////form.Controls[0].RenderControl(hTextWriter);
        ////string html = sb.ToString();
        ////Document Doc = new Document();

        ////strFile = DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" + DateTime.Today.Year.ToString() + "_" + DateTime.Now.Second.ToString()+"_" + "Armstrong.pdf";


        ////     // FileUpload F=new FileUpload();
        ////       // F.SaveAs(AppDomain.CurrentDomain.BaseDirectory.ToString() + ");

        ////PdfWriter.GetInstance(Doc, new FileStream((Request.PhysicalApplicationPath + "//Admin/PdfFile/" + strFile), FileMode.Create));

        ////        //PdfWriter.GetInstance
        ////        //(Doc, new FileStream(Request.FilePath  
        ////        //(Environment.SpecialFolder.Desktop)
        ////        //+ "Armstrong.pdf", FileMode.Create));


        ////Doc.Open();

        ////Chunk c = new Chunk
        ////("Armstrong Training \n",
        ////FontFactory.GetFont("Verdana", 15));
        ////Paragraph p = new Paragraph();
        ////p.Alignment = Element.ALIGN_CENTER;
        ////p.Add(c);
        ////Chunk chunk1 = new Chunk
        ////("\n",
        ////FontFactory.GetFont("Verdana", 8));
        ////Paragraph p1 = new Paragraph();
        ////p1.Alignment = Element.ALIGN_RIGHT;
        ////p1.Add(chunk1);

        ////Doc.Add(p);
        ////Doc.Add(p1);

        ////System.Xml.XmlTextReader xmlReader =
        ////new System.Xml.XmlTextReader(new StringReader(html));
        ////HtmlParser.Parse(Doc, xmlReader);

        ////Doc.Close();
        ////string Path = Server.MapPath("PdfFile\\" + strFile);


        //////if (Path.GetExtension(Arg) == ".pdf")
        //////{
        ////    //     string pdfPath = Server.MapPath("ProductPdf/" + Arg);

        ////    //     Byte[] buffer = client.DownloadData(pdfPath);
        ////    //     Response.ContentType = "application/pdf";
        ////    //     Response.AddHeader("content-length", buffer.Length.ToString());
        ////    //     Response.BinaryWrite(buffer);


        ////    Response.Redirect("pdfFiles.aspx?lblUrl="+ Path);
        //////}
        //////    Environment.GetFolderPath
        //////(Environment.SpecialFolder.Desktop)
        //////+ "\\PdfFile/Armstrong.pdf";


        ////////ShowPdf(Path);


}
    //public override void VerifyRenderingInServerForm(Control control)
    //{

    //    //base.VerifyRenderingInServerForm(control);

    //}




    

    private void ShowPdf(string strS)
    {
        WebClient client = new WebClient();
        Response.ClearContent();
        Response.ClearHeaders();
        Byte[] buffer = client.DownloadData(strS);
        Response.ContentType = "application/pdf";
        Response.AddHeader
        ("content-length", buffer.Length.ToString());

        Response.BinaryWrite(buffer);
        //Response.TransmitFile(strS);
        Response.End();
        //Response.WriteFile(strS);
        Response.Flush();
        Response.Clear();

       

    }



   // protected void Button1_Click(object sender, EventArgs e)
    //{
        //Label1.Text = getHTML(gvMainTitle);

       // Session["Data"] = Label1.Text.ToString();
      //  Response.Redirect("email.aspx?Datatable="+1);
       // Datatable = Label1.Text;
   // }

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

    public override void VerifyRenderingInServerForm(Control control)
    {
        return;
    }


    protected void btnexportExcel_Click(object sender, EventArgs e)
    {
        panel2.Visible = true;
        panel1.Visible = false;

    }

    private string GridViewToHtml(GridView gv)
    {
        StringBuilder sb = new StringBuilder();
        StringWriter sw = new StringWriter(sb);
        HtmlTextWriter hw = new HtmlTextWriter(sw);
        gv.RenderControl(hw);
        return sb.ToString();
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        panel1.Visible = true;
        panel2.Visible = false;


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
        string subject =txtSubject.Text;
        string Email = txtMailto.Text;



        SendMailMessage(subject,Email, "");
        return true;
    }

    void Cancel()
    {
        txtMailto.Text = string.Empty;
        txtSubject.Text = string.Empty;
    }
    protected void btn_send_Click(object sender, EventArgs e)
    {

        if (SuccessMail() == true)
        {
           
            Cancel();


            lbltitle.Text = "Message Sent Successfully";
        }

        panel1.Visible =false;
        panel2.Visible = false;
          

    }
    DataTable dt; DataSet obj;
    protected void btn_Export_Click(object sender, EventArgs e)
    {
       // GridViewExportUtil.Export("Customers.xls", this.gvMainTitle);

        //DataTable dt = new DataTable();
       
        obj = SettingoneManager.GetReportByDate(Convert.ToDateTime(txtstartdate.Text), Convert.ToDateTime(txtenddate.Text));
         if(obj.Tables[0].Rows.Count>0)

         {
             dt = obj.Tables[0];

             ExportDataSetToExcel(obj, "ArmstrongExcelReport");
             //ExportDataSetToExcel(obj.Tables[0],"filename");
         }

         panel2.Visible = false;

       // exportDataTableToExcel (dt, "C:\\Employee.xls");
     

    }

//       public static void CreateWorkbook(DataSet ds, String path)
//{
//    XmlDataDocument xmlDataDoc = new XmlDataDocument(ds);
//    XslTransform xt = new XslTransform();
//     StreamReader reader =new StreamReader(typeof (WorkbookEngine).Assembly.GetManifestResourceStream(typeof (WorkbookEngine), "Excel.xsl"));
//    XmlTextReader xRdr = new XmlTextReader(reader);
//    xt.Load(xRdr, null, null);

//    StringWriter sw = new StringWriter();
//    xt.Transform(xmlDataDoc, null, sw, null);
//    string str;





//    StreamWriter myWriter = new StreamWriter (path + "\\Report.xls");
//    myWriter.Write(sw.ToString());
//    myWriter.Close();
//}

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

        panel2.Visible = false;

    }
  


//Example

//

}


    

