using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;

public partial class _default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
             if (Session["AdminID"] != null)
            {

               
                BindExamTitle();
                
            if (Request.QueryString["QuestionId"] != null)
            {
               

              QuestionMst obj = QuestionMstManager.Select(Convert.ToInt32(Request.QueryString["QuestionId"]));

            

             ddlExamTitle.SelectedValue = Convert.ToString(obj.TopicId);
                     
              txtQuestion.Text = obj.Question;
              txtAnswer1.Text = obj.Option1;
              txtAnswer2.Text = obj.Option2;
              txtAnswer3.Text = obj.Option3;
              txtAnswer4.Text = obj.Option4;
              txtAnswer5.Text = obj.Option5;
              txtAnswer6.Text = obj.Option6;
              if (obj.CorrectAnswer == "1")  {    rbtnAnswer1.Checked = true;     }

              else if (obj.CorrectAnswer == "2")   { rbtnAnswer2.Checked = true;    }

              else if (obj.CorrectAnswer == "3")   {  rbtnAnswer3.Checked = true;   }
              else if (obj.CorrectAnswer == "4") { rbtnAnswer4.Checked = true; }
              else if (obj.CorrectAnswer == "5") { rbtnAnswer5.Checked = true; }

              else   {  rbtnAnswer6.Checked = true;   }

            

            }
            }
             else
             {
                 Response.Redirect("ADMINLOGIN.aspx");

             }
        }

    }

    public void BindExamTitle()
    {

        ddlExamTitle.Items.Clear();
        ddlExamTitle.DataTextField = "Title";
        ddlExamTitle.DataValueField = "TitleId";
        ddlExamTitle.DataSource = ExamTitleMstManager.GetAll();



        ddlExamTitle.DataBind();
        ddlExamTitle.Items.Insert(0, "Select");

    }

    
   
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        QuestionMst Obj = new QuestionMst();

        Obj.QuestionId = Convert.ToInt32(Request.QueryString["QuestionId"]);
        Obj.Question = txtQuestion.Text;
        Obj.Option1 = txtAnswer1.Text;
        Obj.Option2 = txtAnswer2.Text;
        Obj.Option3 = txtAnswer3.Text;
        Obj.Option4 = txtAnswer4.Text;
        Obj.Option5 = txtAnswer5.Text;
        Obj.Option6 = txtAnswer6.Text;
        Obj.TopicId= Convert.ToInt32(ddlExamTitle.SelectedValue);

        Obj.UpdatedBy = 1;
        Obj.UpdatedOn = DateTime.Now;
        if (rbtnAnswer1.Checked)
        {
            Obj.CorrectAnswer = "1";
        }
        else if (rbtnAnswer2.Checked)
        {
            Obj.CorrectAnswer = "2";
        }
        else if (rbtnAnswer3.Checked)
        {
            Obj.CorrectAnswer = "3";
        }
        else if (rbtnAnswer4.Checked)
        {
            Obj.CorrectAnswer = "4";
        }
        else if (rbtnAnswer5.Checked)
        {
            Obj.CorrectAnswer = "5";
        }
        else
        {
            Obj.CorrectAnswer = "6";
        }


        Obj.Hint = "";
        Obj.Deactive = false;

        QuestionMstManager.QuestionMstOperationResult result = QuestionMstManager.Update(Obj);

        if (result == QuestionMstManager.QuestionMstOperationResult.QuestionMst_ADDED)
        {

            lblMessage.Text = "Question Updated Successfully";

            Response.Redirect("ListQuestion.aspx");


         

       }
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("~/Default.aspx");
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {

        Session.RemoveAll();
        Response.Redirect("~/Default.aspx");
    }

    protected void ImageButton1_Click2(object sender, ImageClickEventArgs e)
    {

        Session.RemoveAll();
        Response.Redirect("~/Default.aspx");

    }
}
