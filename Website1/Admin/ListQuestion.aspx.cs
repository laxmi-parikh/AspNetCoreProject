using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;


public partial class Admin_ListQuestion : System.Web.UI.Page
{
     protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           //BindQuestion();
            BindMainTitle();
            lblMsg.Text = "";
        }
        lblMsg.Text = "";
    }

     public void BindMainTitle()
     {

         ddlExamTitle.DataTextField = "Title";
         ddlExamTitle.DataValueField = "TitleId";
         ddlExamTitle.DataSource = ExamTitleMstManager.GetAll();



         ddlExamTitle.DataBind();
         ddlExamTitle.Items.Insert(0, "Select");

     }
    private void BindQuestion()
    {

        if (ddlExamTitle.SelectedValue == "Select")
        {
            gvQuestion.Visible = false;
            lblMsg.Text = "Select Exam Title";
          
        }
        else
        {
            DataSet ds = QuestionMstManager.ListExamQuestion3(Convert.ToInt32(ddlExamTitle.SelectedValue));
            if (ds.Tables[0].Rows.Count > 0)
            {
                gvQuestion.Visible = true;
                gvQuestion.DataSource = ds.Tables[0];
                gvQuestion.DataBind();
            }
            else
            {
                gvQuestion.Visible = false;

                lblMsg.Text = "No Data Available";
               
               
            }
           
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvQuestion.PageIndex = e.NewPageIndex;
        BindQuestion();
    }
    protected void gvQuestion_RowCommand(object sender, GridViewCommandEventArgs e)
    {
         int QuestionId;


         if (e.CommandName == "Delete")
         {

             QuestionId = Convert.ToInt32(e.CommandArgument.ToString());
             Question_MstManager.Delete(QuestionId);

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
    //protected void ddlMainTitle_SelectedIndexChanged(object sender, EventArgs e)
    //{
      
    //    if (ddlMainTitle.SelectedItem.Text == "Select")
    //    {
    //        lblMsg.Text = "Select Function";
          
    //        gvQuestion.Visible = false;
    //    }
    //    else
    //    {
    //        ddlSubTitle.Items.Clear();
    //        gvQuestion.Visible = false;
    //        ddlSubTitle.DataTextField = "Levelname";
    //        ddlSubTitle.DataValueField = "Levelid";
    //        ddlSubTitle.DataSource = LevelMstManager.listlevel(Convert.ToInt32(ddlMainTitle.SelectedValue)); 
    //        ddlSubTitle.DataBind();
    //        lblMsg.Text = "";

    //        ddlSubTitle.Items.Insert(0, "Select");
            


    //    }



    //}
    protected void btn_Submit_Click(object sender, ImageClickEventArgs e)
    {
        BindQuestion();

    }




    //protected void ddlSubTitle_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //    if (ddlSubTitle.SelectedItem.Text == "Select")
    //    {
    //        lblMsg.Text = "Select Level";

    //        gvQuestion.Visible = false;
    //    }
    //    else
    //    {

    //        ddlExamTitle.Items.Clear();
    //        gvQuestion.Visible = false;
    //        ddlExamTitle.DataTextField = "TitleForExam";
    //        ddlExamTitle.DataValueField = "SettingId";
    //        ddlExamTitle.DataSource = SettingoneManager.GetAllBySubId(Convert.ToInt32(ddlSubTitle.SelectedValue));
    //        ddlExamTitle.DataBind();
    //        lblMsg.Text = "";

    //        ddlExamTitle.Items.Insert(0, "Select");



    //    }


    //}
}


  
    


  

       


    

