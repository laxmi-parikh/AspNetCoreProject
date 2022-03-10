using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;
using System.Collections.Generic;


public partial class _default : System.Web.UI.Page
{
   // string ImagePath = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Session["AdminID"] != null)
            {
                BindMainTitle();
                //Dbindfunction();
                panel1.Visible = false;

                


            }
            else
            {
                Response.Redirect("ADMINLOGIN.aspx");

            }


        }

       
    }



    public void BindMainTitle()
    {
        DataSet fds = FunctionMstManager.Listfunction();
        Binddropdownlist(ddlMainTitle, "FunctionName", "Functionid", fds);
       
        ddlMainTitle.Items.Insert(0, "Select");
        DropDownList1.Items.Insert(0, "Select");

        ddlQuestionSetTitle.DataTextField = "Title";
        ddlQuestionSetTitle.DataValueField = "TitleId";
        ddlQuestionSetTitle.DataSource = ExamTitleMstManager.GetAll();

        ddlQuestionSetTitle.DataBind();
        ddlQuestionSetTitle.Items.Insert(0, "Select");

        

         

    }
    public void BindSubtitle(int MainID)
    {

        if (MainID>0)
        {
            DropDownList1.Items.Clear();
            DataSet Ds = SubTitleManager.ListAllSubTitleByMainID(MainID);

            DropDownList1.DataSource = Ds.Tables[0];
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "SubTitle";
            DropDownList1.DataValueField = "SubID";
            DropDownList1.Items.Insert(0, "Select");

        }

    }
    protected void ddlMainTitle_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (ddlMainTitle.SelectedValue != "Select" && ddlMainTitle.SelectedValue != null)
        {
            //DropDownList1.Items.Clear();
            //DropDownList1.DataTextField = "SubTitle";
            //DropDownList1.DataValueField = "SubId";
            //DropDownList1.DataSource = SubTitleManager.ListAllSubTitleByMainID(Convert.ToInt32(ddlMainTitle.SelectedValue));
            //DropDownList1.DataBind();
            DataSet lds = LevelMstManager.listlevel(Convert.ToInt32(ddlMainTitle.SelectedValue));
            Binddropdownlist(DropDownList1, "Levelname", "Levelid", lds);
            DropDownList1.Items.Insert(0, "Select"); 
            //DropDownList1.Items.Insert(0, "Select");
        }

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        // Settingo

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        int id;

        Settingone obj = new Settingone();
       
        if (dropdownvalidation())
        {
            if (rbtn_Manual.Checked)
            {
                obj.Manual = 1; //Manually
            }
            else
            {
                obj.Manual = 0; //randomally
            }
            if (DropDownList2.SelectedValue != "0")
            {
                obj.FunctionId = Convert.ToInt32(0);
                obj.LevelId = Convert.ToInt32(0);
            }
            else
            {
                obj.FunctionId = Convert.ToInt32(ddlMainTitle.SelectedValue);
                obj.LevelId = Convert.ToInt32(DropDownList1.SelectedValue);
            }
            obj.Interview = Convert.ToInt32(DropDownList2.SelectedValue);
            obj.Timelimit = decimal.Parse(txtsettime.Text);
            obj.NumberofQuestionperpage =0; //Convert.ToInt32(ddlqset.SelectedValue);
            obj.PassScore = Convert.ToInt32(txtsetpercentage.Text);
            obj.PassScoreMsg = txtpassmsg.Text;
            if (rbtn_common.Checked)
            {
                obj.Commentest = "1";
            }
            else
            {
                obj.Commentest = "0";
            }
           
              obj.FailScoreMsg = txtfailmsg.Text;
            obj.Setmarks = Convert.ToInt32(txtmarks.Text);
            obj.Updatedby = 1;
            obj.TitleId = Convert.ToInt32(ddlQuestionSetTitle.SelectedValue);
            /*if (chk1.Checked || chk2.Checked || Chk3.Checked)
            {*/
                //DataSet ds = QuestionMstManager.ListExamQuestion(Convert.ToInt32(ddlMainTitle.SelectedValue), Convert.ToInt32(DropDownList1.SelectedValue));
               // if (ds.Tables[0].Rows.Count > 0)
               // {
                   // if (ds.Tables[0].Rows.Count >= Convert.ToInt32(txtTotalQuestion.Text))
                   // {
                        obj.QuestionSet = txtTotalQuestion.Text;
                    //}
                   // else
                    //{
                       ////// lblMsg.Text = "you can not insert Total No. Question  more than " + ds.Tables[0].Rows.Count;
                      //  return;
                   // }
               // }
                //else
                //{
                   // lblMsg.Text = "No Questions set,Please Select another SubTilte";
                   // return;
               // }
            /*}
            else
            {
                obj.QuestionSet = txtTotalQuestion.Text;
            }*/
            obj.TitleForExam = txtTitle.Text;
            obj.Start_Date = Convert.ToDateTime(DateTime.Now);
            obj.End_Date = Convert.ToDateTime(DateTime.Now);



            id = Convert.ToInt32(SettingoneManager.Add(obj));

            if (id > 0)
            {
                txtsettime.Text = string.Empty;
                
                txtTotalQuestion.Text = string.Empty;
                txtsetpercentage.Text = "";
                txtpassmsg.Text = "";
                txtfailmsg.Text = "";
                txtmarks.Text = "";
                rbtn_random.Checked = true; 
                lblMsg.Text = "Successfully Added";

            }
            else
            {
                lblMsg.Text = "Already  Exists";
                txtsettime.Text = string.Empty;
               // txtTitle.Text = string.Empty;
                txtTotalQuestion.Text = string.Empty;
                txtsetpercentage.Text = "";
                txtpassmsg.Text = "";
                txtfailmsg.Text = "";
                txtmarks.Text = "";
                rbtn_random.Checked = true; 
            }
        }
    }
    public bool dropdownvalidation()
    {
        bool temp = false;
        if (DropDownList1.SelectedValue != "0" && ddlMainTitle.SelectedValue != "0")
        {
            temp = true;
        }
        
        return temp;
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("~/Default.aspx");

    }
  
    protected void ddlfunction_SelectedIndexChanged(object sender, EventArgs e)
    {
        //DataSet lds = LevelMstManager.listlevel(Convert.ToInt32(ddlfunction.SelectedValue));
        //Binddropdownlist(ddlLevel, "Levelname", "Levelid", lds);
        //ddlLevel.Items.Insert(0, "Select"); 
    }
    protected void ddlLevel_SelectedIndexChanged(object sender, EventArgs e)
    {
        //DataSet mds = MainTitleManager.ListMaintitle(ddlfunction.Text, Convert.ToInt32(ddlLevel.SelectedValue));
        //Binddropdownlist(ddlMainTitle, "Title", "MainID", mds);
        //ddlMainTitle.Items.Insert(0, "Select");
    }
    public void Dbindfunction()
    {
        //DataSet fds = FunctionMstManager.Listfunction();
        //Binddropdownlist(ddlfunction, "FunctionName", "Functionid", fds);
        //ddlfunction.Items.Insert(0, "Select");
    }
    public void Binddropdownlist(DropDownList ddl, string text, string value, DataSet ds)
    {
        ddl.DataTextField = text;
        ddl.DataValueField = value;
        ddl.DataSource = ds;
        ddl.DataBind();
    }


    DataSet d;
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        d = SettingoneManager.GetmaxSettingone();
              QuestionSet objset = new QuestionSet();
        foreach (GridViewRow row in gvQuestion.Rows)
        {

            Label lblQuestion = (Label)row.FindControl("lblQuestion");
            CheckBox CheckBox1 = (CheckBox)row.FindControl("CheckBox1");
        
            if (CheckBox1.Checked)
            {
                objset.QuestionId = Convert.ToInt32(lblQuestion.Text);
                objset.SettingId=Convert.ToInt32(d.Tables[0].Rows[0][0]);
                objset.TitleId = Convert.ToInt32(ddlQuestionSetTitle.SelectedValue);
                QuestionSetManager.Add(objset);
              

            }
            else
            {

                //objset.QuestionId = Convert.ToInt32(lblQuestion.Text);
                //objset.SettingId = Convert.ToInt32(d.Tables[0].Rows[0][0]);
                //objset.TitleId = Convert.ToInt32(ddlQuestionSetTitle.SelectedValue);
                //QuestionSetManager.Add(objset);

                QuestionSetManager.deleteQuestionsetnew(Convert.ToInt32(ddlQuestionSetTitle.SelectedValue), Convert.ToInt32(d.Tables[0].Rows[0][0]), Convert.ToInt32(lblQuestion.Text));

            }


           




        }
      
              


    }
    protected void gvQuestion_RowDataBound(object sender, GridViewRowEventArgs e)
    {
         d = SettingoneManager.GetmaxSettingone();
              
              foreach (GridViewRow row in gvQuestion.Rows)
              {

                  Label lblQuestion = (Label)row.FindControl("lblQuestion");
                  CheckBox CheckBox1 = (CheckBox)row.FindControl("CheckBox1");

                  if (QuestionSetManager.selectQuestionsetnew1(Convert.ToInt32(ddlQuestionSetTitle.SelectedValue), Convert.ToInt32(d.Tables[0].Rows[0][0]), Convert.ToInt32(lblQuestion.Text))!= null)
                  {
                      if (QuestionSetManager.selectQuestionsetnew1(Convert.ToInt32(ddlQuestionSetTitle.SelectedValue), Convert.ToInt32(d.Tables[0].Rows[0][0]), Convert.ToInt32(lblQuestion.Text)).QuestionId == Convert.ToInt32(lblQuestion.Text))
                      {
                          CheckBox1.Checked = true;
                      }
                      else
                      {
                          CheckBox1.Checked = false;
                      }
                  }

                  if (rbtn_Manual.Checked)
                  {
                      List<QuestionSet> objquestionset = QuestionSetManager.GetselectedQuestionsetnew(Convert.ToInt32(ddlQuestionSetTitle.SelectedValue), Convert.ToInt32(d.Tables[0].Rows[0][0]));
                      if (objquestionset.Count > 0)
                      {

                          txtTotalQuestion.Text = Convert.ToString(objquestionset.Count);

                      }
                      else
                      {
                          txtTotalQuestion.Text = "";
                      }
                  }

              }



    }
    protected void gvQuestion_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvQuestion.PageIndex = e.NewPageIndex;
        Bindgrid();

        

    }
    protected void gvQuestion_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
  
    protected void rbtn_random_CheckedChanged(object sender, EventArgs e)
    {
        panel1.Visible = false;

    }

    void Bindgrid()
    { 
       
        DataSet ds = QuestionMstManager.ListExamQuestion3(Convert.ToInt32(ddlQuestionSetTitle.SelectedValue));
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
    protected void rbtn_Manual_CheckedChanged(object sender, EventArgs e)
    {
        panel1.Visible = true;
       
        if (ddlQuestionSetTitle.SelectedValue == "Select")
        {
            gvQuestion.Visible = false;
            lblMsg.Text = "Select Title/Topic";
            panel1.Visible = false;
        }
        else
        {

            Bindgrid();
           

        }


    }
}
