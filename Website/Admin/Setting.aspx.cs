using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;



public partial class _default : System.Web.UI.Page
{
   // string ImagePath = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Session["AdminID"] != null)
            {
               
            }
            else
            {
                Response.Redirect("ADMINLOGIN.aspx");

            }


        }

       
    }
    
  
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        int id;

        ExamTitleMst objExamTitle = new ExamTitleMst();
        if (objExamTitle != null)
        {
            objExamTitle.Title = txtTitle.Text;
            id=Convert.ToInt32(ExamTitleMstManager.Add(objExamTitle));
            if (id > 0)
            {
                lblMsg.Text = "Successfully Added";
            }
            else
            {
                lblMsg.Text = "Already Exists";
            }
        }
        

       
    }
  
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("~/Default.aspx");

    }
     
    
   
}
