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
using System.Net;
using System.IO;


public partial class PdfFiles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if(!IsPostBack)
        {
       
        WebClient client = new WebClient();

        if (Request.QueryString["lblUrl"] != null)
        {
            try
            {
                string Arg = Convert.ToString(Request.QueryString["lblUrl"]);

                //Path.GetExtension = Arg;
                // if (Path.GetExtension(Arg) == "pdf")
                // {
               // string pdfPath = Server.MapPath(Arg);

                Byte[] buffer = client.DownloadData(Arg);
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-length", buffer.Length.ToString());
                Response.BinaryWrite(buffer);
                // }
                //else
                //{

                //}

                //String sFileName = Convert.ToString(e.CommandArgument);
                //String sFullPath = String.Empty;
                //sFullPath = Server.MapPath("ProductPdf/" + sFileName);
                //if (sFullPath != null && sFullPath.Length > 4)
                //{
                //  //if (sFullPath.Contains(@"\"))
                //  // {
                //        if (File.Exists(sFullPath))
                //        {
                //            FileInfo _file4View = new FileInfo(sFullPath);
                //           Response.Buffer = false;
                //          Response.Clear();
                //            String sContentType = "";
                //            switch (Path.GetExtension(sFullPath).ToLower())
                //            {
                //                case ".dwf":
                //                    sContentType = "Application/x-dwf";
                //                    break;
                //                case ".pdf":
                //                    sContentType = "Application/pdf";
                //                    break;
                //                case ".docx":
                //                case ".doc":
                //                    sContentType = "Application/vnd.ms-word";
                //                    break;
                //                case ".ppt":
                //                case ".pps":
                //                    sContentType = "Application/vnd.ms-powerpoint";
                //                    break;
                //                case ".xlsx":
                //                case ".xls":
                //                    sContentType = "Application/vnd.ms-excel";
                //                    break;
                //                default:
                //                    sContentType = "Application/octet-stream";
                //                    break;
                //            }
                //           Response.ContentType = sContentType;
                //            MemoryStream _Stream = new MemoryStream();
                //            //StreamWriter _writer = new StreamWriter(_Stream); 
                //            FileStream _fileStream = new FileStream(sFullPath, FileMode.Open, FileAccess.Read);
                //            long fileLength = _fileStream.Length;
                //            Byte[] _byte = new Byte[(int)fileLength];
                //            _fileStream.Read(_byte, 0, (int)fileLength);
                //            _fileStream.Close();

                //            Response.BinaryWrite(_byte);
                //        }
                //    }
                //}

            }
            catch (Exception ex)
            {

                // this.lblMsg.Text =
                ex.Message.ToString();
            }
        }
        }
    }
}
