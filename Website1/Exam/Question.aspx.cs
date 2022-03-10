using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;

public partial class USER_Question : System.Web.UI.Page
{
   
  
//    string ImagePath;
    int values;

    protected void Page_Load(object sender, EventArgs e)
    {

        //Master.FindControl("tblHeading").Visible = false;
         if (!IsPostBack)
        {
            if (Session["UserId"] != null)
            {
                string guid = Guid.NewGuid().ToString().ToUpper() + Session["UserId"].ToString();
                lblGuid.Text = Label1.Text = guid.Replace("-", "");

                Session["Guid"] = lblGuid.Text;
                Session.Remove("StartTime");
                if (Session["StartTime"] == null)
                    Session["StartTime"] = DateTime.Now;
                if (Request.QueryString["SettingId"] != null)
                {
                    DataSet dsQuestionList = QuestionMstManager.ListExamQuestionbysettingIdInterview(Convert.ToInt32(Request.QueryString["SettingId"]));
                    values = dsQuestionList.Tables[0].Rows.Count;
                    Session["Ds"] = dsQuestionList;
                    GridView1.DataSource = dsQuestionList.Tables[0];
                    GridView1.DataBind();
                    Settingone obset = SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SettingId"]));
                    if (obset != null)
                    {
                        lblTotalTime.Text = obset.Timelimit + " Min";
                        lblMarks.Text = obset.Setmarks.ToString();
                        lblRemainingQuestion.Text = obset.QuestionSet;

                    }
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindData(Convert.ToInt32(Request.QueryString["SubId"]));

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
    }
    
    void BindData(int SubjectID)
    {
        DataSet ds = User_MstManager.GETQUESTIONSET(SubjectID, Convert.ToInt32(Session["UserId"]));
        if (ds != null)
        {
            if (ds.Tables.Count > 0)
            {


                    Session["Ds"] = ds;
                    
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                    //ibtnNext.Visible = true;
                  //  iBtnFinish.Visible = false;
                    BindRemainingQuestion();
            }
            else
            {
                //ibtnNext .Visible = false;
               // iBtnFinish.Visible = false;
                Timer1.Enabled = false;
                lblMessage.Text = "<h2>Set Already Used</h2>";
                //TimedPanel.Visible = false;

            }
        }
    }

    
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

      
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lblQuestionNo = (Label)e.Row.FindControl("lblQuestionNo");
            int Pageno = Convert.ToInt32(GridView1.PageIndex) + 1;
            lblQuestionNo.Text = Pageno.ToString();

                    Label lblQuestionId = (Label)e.Row.FindControl("lblQuestionId");
                    RadioButton RadioButton1 = (RadioButton)e.Row.FindControl("RadioButton1");
                    RadioButton RadioButton2 = (RadioButton)e.Row.FindControl("RadioButton2");
                    RadioButton RadioButton3 = (RadioButton)e.Row.FindControl("RadioButton3");
                    RadioButton RadioButton4 = (RadioButton)e.Row.FindControl("RadioButton4");
                    RadioButton RadioButton5 = (RadioButton)e.Row.FindControl("RadioButton5");
                    RadioButton RadioButton6= (RadioButton)e.Row.FindControl("RadioButton6");
                    Label lblOption1 = (Label)e.Row.FindControl("lblOption1");
                    Label lblOption2 = (Label)e.Row.FindControl("lblOption2");
                    Label lblOption3 = (Label)e.Row.FindControl("lblOption3");
                    Label lblOption4= (Label)e.Row.FindControl("lblOption4");
                    Label lblOption5 = (Label)e.Row.FindControl("lblOption5");
                    Label lblOption6 = (Label)e.Row.FindControl("lblOption6");

                   // Label lblCorrect = (Label)row.FindControl("lblCorrect");
                    if (lblOption1.Text == null || lblOption1.Text == "0" || lblOption1.Text == "")
                    {
                        RadioButton1.Visible = false;
                        lblOption1.Visible = false;
                    }

                    if (lblOption2.Text == null || lblOption2.Text == "0" || lblOption2.Text == "")
                    {
                        RadioButton2.Visible = false;
                        lblOption2.Visible = false;
                    }
                    if (lblOption3.Text == null || lblOption3.Text == "0" || lblOption3.Text == "")
                    {
                        RadioButton3.Visible = false;
                        lblOption3.Visible = false;
                    }
                    if (lblOption4.Text == null || lblOption4.Text == "0" || lblOption4.Text == "")
                    {
                        RadioButton4.Visible = false;
                        lblOption4.Visible = false;
                    }



                    if (lblOption5.Text == null || lblOption5.Text == "0" || lblOption5.Text == "")
                    {
                        RadioButton5.Visible = false;
                        lblOption5.Visible = false;
                    }
                    if (lblOption6.Text == null || lblOption6.Text == "0" || lblOption6.Text == "")
                    {
                        RadioButton6.Visible = false;
                        lblOption6.Visible = false;
                    }
                    if (Session["Guid"] != null)
                    {


                        DataSet obj = Exam_MstManager.GetExamDetailGuid(Session["Guid"].ToString(), Convert.ToInt32(lblQuestionId.Text));
                        if (obj.Tables[0].Rows.Count > 0)
                        {
                            
                            if (obj.Tables[0].Rows[0][5].ToString() == "1")
                            {
                                RadioButton1.Checked = true;
                            }
                            else if (obj.Tables[0].Rows[0][5].ToString() == "2")
                            {
                                RadioButton2.Checked = true;
                            }
                            else if (obj.Tables[0].Rows[0][5].ToString() == "3")
                            {
                                RadioButton3.Checked = true;
                            }
                            else if (obj.Tables[0].Rows[0][5].ToString() == "4")
                            {
                                RadioButton4.Checked = true;
                            }
                            else if (obj.Tables[0].Rows[0][5].ToString() == "5")
                            {
                                RadioButton5.Checked = true;
                            }
                            else if (obj.Tables[0].Rows[0][5].ToString() == "6")
                            {
                                RadioButton6.Checked = true;
                            }
                            if (values != obj.Tables[0].Rows.Count)
                            {
                                Response.Redirect("Result.aspx?SubID=" + Session["SubID"].ToString() + "&SettingId=" + Request.QueryString["SettingId"].ToString() + "&SessionId=" + lblGuid.Text);     
                                //iBtnFinish0.Visible = true;
                            }
                            else
                            {
                                iBtnFinish0.Visible = false;
                            }

                        }

                     

                        
                        

                    }

            

        }

    }


    public void BindRemainingQuestion()
    {
        DataSet ds=(DataSet)Session["Ds"];

        lblRemainingQuestion.Text = ds.Tables[0].Rows.Count.ToString();

    
    }



    protected void Button1_Click(object sender, EventArgs e)
    {

      //  Exam_Mst objExam = new Exam_Mst();

      //  foreach (GridViewRow rowin in GridView1.Rows)
      //  {
      //      Label lblQuestionId = (Label)rowin.FindControl("lblQuestionId");
      //      RadioButton RadioButton1 = (RadioButton)rowin.FindControl("RadioButton1");
      //      RadioButton RadioButton2 = (RadioButton)rowin.FindControl("RadioButton2");
      //      RadioButton RadioButton3 = (RadioButton)rowin.FindControl("RadioButton3");
      //      RadioButton RadioButton4 = (RadioButton)rowin.FindControl("RadioButton4");
      //      Label lblCorrect = (Label)rowin.FindControl("lblCorrect");
      //      Label SetId = (Label)rowin.FindControl("SetId");

            

      //      Session["SetID"] = SetId.Text;

      //      objExam.SubjectId = Convert.ToInt32(Request.QueryString["SubId"]);
      //      objExam.StudentId = Session["UserId"].ToString();
      //      objExam.GivenAnswer = Convert.ToInt32(lblCorrect.Text);
      //      objExam.QuestionId = Convert.ToInt32(lblQuestionId.Text);

      //      if (RadioButton1.Checked == true)
      //      {
      //          objExam.StudentAnswer = 1;
      //      }
      //      else if (RadioButton2.Checked == true)
      //      {
      //          objExam.StudentAnswer = 2;
      //      }
      //      else if (RadioButton3.Checked == true)
      //      {
      //          objExam.StudentAnswer = 3;
      //      }
      //      else if (RadioButton4.Checked == true)
      //      {
      //          objExam.StudentAnswer = 4;
      //      }
      //      else
      //      {
      //          objExam.StudentAnswer = 0;
      //      }

      //      objExam.TimeAllowed = "1";// Convert.ToString(Session["StartTime"]);

      //      objExam.SetId = Convert.ToInt32(SetId.Text);
      //      objExam.Guid = lblGuid.Text;
      //      Exam_MstManager.Add(objExam);




      //  }
      ////  BindRemainingQuestion();



      //  int i = GridView1.PageIndex + 1;
         
      //  if (i <= GridView1.PageCount)
      //  {


      //      GridView1.PageIndex = i;
          

      //      if (Session["Ds"] != null)
      //      {

      //          DataSet Ds = (DataSet)Session["Ds"];
      //          GridView1.DataSource = Ds.Tables[0];
      //          GridView1.DataBind();

      //          if (Ds.Tables[0].Rows.Count == 0)
      //          {
      //              GridView1.Visible = false;
      //              iBtnPrevious.Visible = false;
      //              ibtnNext.Visible = false;
      //             // iBtnFinish.Visible = true;
      //              Timer1.Enabled = false;
      //              LblTime.Text = "00";
      //          }
      //      }

      //      //if (i == GridView1.PageCount)
      //      //{
      //      //    btnNext.Visible = false;
      //      //    btnFinish .Visible = true;


      //      //}

      //      //  btnlast.Enabled = true;

      //      //   btnprevious.Enabled = true;

      //      //  btnfirst.Enabled = true;

      //  }
      //  else
      //  {
      //      // Response.Redirect("ResultPCB.aspx?Id=2&SetID="+Session["SetID"].ToString ());
      //  }


    }



    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

        //string where = "Radiobutton";
        //Exam_Mst objExam = new Exam_Mst();


        //foreach (GridViewRow row in GridView1.Rows)
        //{

        //    Label cid = (Label)row.FindControl("lblMemberID");


        //    Label lblQuestionId = (Label)row.FindControl("lblQuestionId");
        //    RadioButton RadioButton1 = (RadioButton)row.FindControl("RadioButton1");
        //    RadioButton RadioButton2 = (RadioButton)row.FindControl("RadioButton2");
        //    RadioButton RadioButton3 = (RadioButton)row.FindControl("RadioButton3");
        //    RadioButton RadioButton4 = (RadioButton)row.FindControl("RadioButton4");
        //    Label lblCorrect = (Label)row.FindControl("lblCorrect");
        //    Label SubID = (Label)row.FindControl("SubID");
        //    Session["SubID"] = SubID.Text;

        //    objExam.SubjectId = Convert.ToInt32(SubID.Text);
        //    objExam.StudentId = Session["UserId"].ToString();
        //    objExam.GivenAnswer = Convert.ToInt32(lblCorrect.Text);
        //    objExam.QuestionId = Convert.ToInt32(lblQuestionId.Text);

        //    if (RadioButton1.Checked == true)
        //    {
        //        objExam.StudentAnswer = 1;
        //    }
        //    else if (RadioButton2.Checked == true)
        //    {
        //        objExam.StudentAnswer = 2;
        //    }
        //    else if (RadioButton3.Checked == true)
        //    {
        //        objExam.StudentAnswer = 3;
        //    }
        //    else if (RadioButton4.Checked == true)
        //    {
        //        objExam.StudentAnswer = 4;
        //    }
        //    else
        //    {
        //        objExam.StudentAnswer = 0;
        //    }

        //    objExam.TimeAllowed = "1";// Convert.ToString(Session["StartTime"]);

        //    objExam.SetId = Convert.ToInt32(Request.QueryString["SettingId"]);
        //    objExam.Guid = lblGuid.Text;
        //    Exam_MstManager.Add(objExam);


        //    //DataSet ds = (DataSet)Session["Ds"];
        //    //foreach (DataRow dr in ds.Tables[0].Rows)
        //    //{

        //    //    if (dr["QuestionId"].ToString() == lblQuestionId.Text)
        //    //    {
        //    //       // dr.Delete();
        //    //    }


        //    //}
        //    //ds.AcceptChanges();
        //    //Session["Ds"] = ds;


        //    BindRemainingQuestion();


        //    int i = GridView1.PageIndex + 1;
        //    if (i <= GridView1.PageCount)
        //    {




        //        GridView1.PageIndex = i;

        //        if (Session["Ds"] != null)
        //        {

        //            DataSet Ds = (DataSet)Session["Ds"];
        //            GridView1.DataSource = Ds.Tables[0];
        //            GridView1.DataBind();
        //            if (Ds.Tables[0].Rows.Count == 0)
        //            {
        //                GridView1.Visible = false;
        //                //iBtnPrevious.Visible = false;
        //                //ibtnNext.Visible = false;
        //                iBtnFinish.Visible = true;
        //                divExam.Visible = true;
        //                // iBtnFinish0.Visible = true;
        //            }

        //        }
        //        //////////////////////////////////////////////////////////////////////////////////////////////
        //        // if (values == GridView1.PageCount)
        //        // {
        //        //     //btnNext.Visible = false;
        //        //     iBtnFinish0.Visible = true;
        //        //     //  btnResult.Visible = true;
        //        //}
        //        //  btnlast.Enabled = true;

        //        // btnprevious.Enabled = true;

        //        // btnfirst.Enabled = true;
        //        /////////////////////////////////////////////////////////////////////////////////////////
        //    }
        //    /////////////////////////////////////////////////////////////////////////////////////////////
        //    if (Session["Ds"] != null)
        //    {

        //        DataSet Ds = (DataSet)Session["Ds"];
        //        DataTable Dt = Ds.Tables[0];
        //        //DataRow Datarow = Dt.Rows[0];
        //        //Dt.Rows.Remove(Datarow);
        //        //Dt.AcceptChanges();
        //        GridView1.DataSource = Dt;
        //        GridView1.DataBind();
        //    }

        //}
    }


    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (Session["UserId"] != null)
        {
            DateTime EndTime;
            TimeSpan RemainingTime;
            int TotalMinitue;
            Settingone obj = SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SettingId"]));

            if (obj != null)
            {
                TotalMinitue = Convert.ToInt32(obj.Timelimit);//(lblTotalTime.Text);


                EndTime = ((DateTime)(Session["StartTime"])).AddMinutes(TotalMinitue);
                RemainingTime = (EndTime - DateTime.Now);
                LblTime.Text = RemainingTime.Hours.ToString() + ":" + RemainingTime.Minutes.ToString() + ":" + RemainingTime.Seconds.ToString("00");
                if (DateTime.Now >= EndTime || RemainingTime.Hours.ToString("00")=="00" && RemainingTime.Minutes.ToString("00") == "00" && RemainingTime.Seconds.ToString("00") == "00")
                {
                    //Response.Redirect("EndTest.aspx"); 

                    
               
                    LblTime.Text = "Time Over";
                    //// ibtnNext.Visible = false;
                    //// iBtnPrevious.Visible = false;
                    //// iBtnFinish.Visible = false;
                    ////// divExam.Visible = true;
                    //// GridView1.Visible = false;
                    //// ibtnNext.Visible = false;
                    ////// iBtnFinish.Visible = false;
                    //// Timer1.Enabled = false;
                    //// iBtnFinish0.Visible = true;

                    
                    Response.Redirect("Result.aspx?SubID="+ Request.QueryString["SubId"].ToString() + "&SettingId=" + Request.QueryString["SettingId"].ToString() + "&SessionId=" + lblGuid.Text);

                }
            }
        }
    }


    protected void btnPrevious_Click1(object sender, EventArgs e)
    {
        BindRemainingQuestion();
    }


    protected void lnkBtnResult_Click(object sender, EventArgs e)
    {
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }


    protected void iBtnFinish_Click(object sender, ImageClickEventArgs e)
    {
                Exam_Mst objExam = new Exam_Mst();

       
                foreach (GridViewRow row in GridView1.Rows)
                {

                    Label cid = (Label)row.FindControl("lblMemberID");


                    Label lblQuestionId = (Label)row.FindControl("lblQuestionId");
                    RadioButton RadioButton1 = (RadioButton)row.FindControl("RadioButton1");
                    RadioButton RadioButton2 = (RadioButton)row.FindControl("RadioButton2");
                    RadioButton RadioButton3 = (RadioButton)row.FindControl("RadioButton3");
                    RadioButton RadioButton4 = (RadioButton)row.FindControl("RadioButton4");
                    Label lblCorrect = (Label)row.FindControl("lblCorrect");
                   // Label SubID =(Label) Request.QueryString["SubId"].ToString();              //(Label)row.FindControl("SubID");
                    Session["SubID"] = Request.QueryString["SubId"].ToString();

                    objExam.SubjectId = Convert.ToInt32(Request.QueryString["SubId"].ToString());
                    objExam.StudentId = Session["UserId"].ToString();
                    objExam.GivenAnswer = Convert.ToInt32(lblCorrect.Text);
                    objExam.QuestionId = Convert.ToInt32(lblQuestionId.Text);

                    if (RadioButton1.Checked == true)
                    {
                        objExam.StudentAnswer = 1;
                    }
                    else if (RadioButton2.Checked == true)
                    {
                        objExam.StudentAnswer = 2;
                    }
                    else if (RadioButton3.Checked == true)
                    {
                        objExam.StudentAnswer = 3;
                    }
                    else if (RadioButton4.Checked == true)
                    {
                        objExam.StudentAnswer = 4;
                    }
                    else
                    {
                        return;
                       // objExam.StudentAnswer = 0;
                    }

                    objExam.TimeAllowed = "1";// Convert.ToString(Session["StartTime"]);

                    objExam.SetId = Convert.ToInt32(Request.QueryString["SettingId"]);
                    objExam.Guid = lblGuid.Text;
                    Exam_MstManager.Add(objExam);


                    //DataSet ds = (DataSet)Session["Ds"];
                    //foreach (DataRow dr in ds.Tables[0].Rows)
                    //{

                    //    if (dr["QuestionId"].ToString() == lblQuestionId.Text)
                    //    {
                    //       // dr.Delete();
                    //    }


                    //}
                    //ds.AcceptChanges();
                    //Session["Ds"] = ds;


                    BindRemainingQuestion();


                    int i = GridView1.PageIndex + 1;
                    if (i <= GridView1.PageCount)
                    {




                        GridView1.PageIndex = i;

                        if (Session["Ds"] != null)
                        {

                            DataSet Ds = (DataSet)Session["Ds"];
                            GridView1.DataSource = Ds.Tables[0];
                            GridView1.DataBind();
                            if (Ds.Tables[0].Rows.Count == 0)
                            {
                                GridView1.Visible = false;
                                //iBtnPrevious.Visible = false;
                                //ibtnNext.Visible = false;
                                iBtnFinish.Visible = true;
                                divExam.Visible = true;
                                // iBtnFinish0.Visible = true;
                            }

                        }



                        //////////////////////////////////////////////////////////////////////////////////////////////
                        // if (values == GridView1.PageCount)
                        // {
                        //     //btnNext.Visible = false;

                        //     iBtnFinish0.Visible = true;
                        //     //  btnResult.Visible = true;


                        //}





                        //  btnlast.Enabled = true;

                        // btnprevious.Enabled = true;

                        // btnfirst.Enabled = true;
                        /////////////////////////////////////////////////////////////////////////////////////////


                    }

                    /////////////////////////////////////////////////////////////////////////////////////////////
                    if (Session["Ds"] != null)
                    {

                        DataSet Ds = (DataSet)Session["Ds"];
                        DataTable Dt = Ds.Tables[0];
                        //DataRow Datarow = Dt.Rows[0];

                        //Dt.Rows.Remove(Datarow);
                        //Dt.AcceptChanges();
                        GridView1.DataSource = Dt;
                        GridView1.DataBind();
                    }

                }
        
    }

    protected void ibtnNext_Click(object sender, ImageClickEventArgs e)
    {
         int i = GridView1.PageIndex + 1;
         if (i >= 0)
         {




             GridView1.PageIndex = i;

             if (Session["Ds"] != null)
             {

                 DataSet Ds = (DataSet)Session["Ds"];
                 GridView1.DataSource = Ds.Tables[0];
                 GridView1.DataBind();


             }
         }
        

        //int i = GridView1.PageIndex + 1;

        //if (i <= GridView1.PageCount)
        //{



        //    GridView1.PageIndex = i;


        //    if (Session["Ds"] != null)
        //    {

        //        DataSet Ds = (DataSet)Session["Ds"];
        //        GridView1.DataSource = Ds.Tables[0];
        //        GridView1.DataBind();

        //        if (Ds.Tables[0].Rows.Count == 0)
        //        {
        //            GridView1.Visible = false;
        //            iBtnPrevious .Visible = false;
                 
        //            Timer1.Enabled = false;
        //            LblTime.Text = "00";
        //        }
        //    }

        //    if (i == GridView1.PageCount)
        //    {

        //        GridView1.PageIndex = 1;
             
              
        //    }
        //    else
        //    {
        //        ibtnNext.Visible = true ;
            
            
        //    }

           

        //}
        //else
        //{
        //    GridView1.PageIndex = i;


        //    if (Session["Ds"] != null)
        //    {

        //        DataSet Ds = (DataSet)Session["Ds"];


        //        if (Ds.Tables[0].Rows.Count > 0)
        //        {
        //            GridView1.PageIndex = 1;
        //        }

        //        GridView1.DataSource = Ds.Tables[0];
        //        GridView1.DataBind();

        //        if (Ds.Tables[0].Rows.Count == 0)
        //        {
        //            GridView1.Visible = false;
        //            iBtnPrevious.Visible = false;
        //            ibtnNext.Visible = false;
        //            //iBtnFinish .Visible = true;
        //            Timer1.Enabled = false;
        //            LblTime.Text = "00";
        //            iBtnFinish0.Visible = false;
        //        }
        //    }
        //}


    }

    protected void iBtnPrevious_Click(object sender, ImageClickEventArgs e)
    {
        int i = GridView1.PageIndex - 1;
        if (i >= 0)
        {




            GridView1.PageIndex = i;

            if (Session["Ds"] != null)
            {

                DataSet Ds = (DataSet)Session["Ds"];
                GridView1.DataSource = Ds.Tables[0];
                GridView1.DataBind();


            }

            //if (i == GridView1.PageCount)
            //{

            //    GridView1.Visible = false;
            //    divExam.Visible = true;
            //}
        }


    }

    protected void iBtnFinish0_Click(object sender, ImageClickEventArgs e)
    {
        //Response.Redirect("Result.aspx?SubID=" + Session["SubID"].ToString() + "&SettingId=" + Request.QueryString["SettingId"].ToString() + "&SessionId=" + lblGuid.Text);     

    }
}
