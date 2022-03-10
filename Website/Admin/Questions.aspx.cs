using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;

public partial class Admin_Questions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["AdminID"] != null)
            {
                BindMainTitle();
            }
            else
            {
                Response.Redirect("ADMINLOGIN.aspx");

            }


        }
    }
    protected void iBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

        string name = e.ToString();
        //rbtnAnswer1.Text;

    }
    protected void rBtnGraph_CheckedChanged(object sender, EventArgs e)
    {

    }

    public void BindMainTitle()
    {
        if (ddlMainTitle.SelectedValue != "0")
        {
            ddlMainTitle.DataTextField = "Title";
            ddlMainTitle.DataValueField = "MainID";
            ddlMainTitle.DataSource = MainTitleManager.GetAll();


            ddlMainTitle.DataBind();
            ddlMainTitle.Items.Insert(0, "Select");
        }
        else
        {
            lblMessage.Text = "";
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        // int QusetionId;
        try
        {

            QuestionMst Obj = new QuestionMst();
            if (txtQuestion.Text != null && txtAnswer1.Text != null && txtAnswer2.Text != null && txtAnswer3.Text != null && txtAnswer4.Text != null)
            {

                Obj.Question = txtQuestion.Text;
                Obj.Option1 = txtAnswer1.Text;
                Obj.Option2 = txtAnswer2.Text;
                Obj.Option3 = txtAnswer3.Text;
                Obj.Option4 = txtAnswer4.Text;
                if (ddlMainTitle.SelectedValue == "Select")
                {
                    lblMessage.Text = "Select MainTitle";
                    return;

                }
                else
                {
                    Obj.SubjectId = Convert.ToInt32(ddlMainTitle.SelectedValue);

                }
                if (ddlMainTitle0.SelectedValue == "Select")
                {
                    lblMessage.Text = "Select Sub Title";
                    return;
                }
                else
                {
                    Obj.LessonId = Convert.ToInt32(ddlMainTitle0.SelectedValue);

                }
                Obj.InsertedBy = 1;
                Obj.InsertedOn = DateTime.Now;

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
                else
                {
                    lblMessage.Text = "Please Insert Question & Answer";
                    return;
                }


                Obj.Hint = "";
                Obj.Deactive = false;

                int ID = QuestionMstManager.Add(Obj);

                if (ID > 0)
                {


                    txtQuestion.Text = "";
                    txtAnswer1.Text = "";
                    txtAnswer2.Text = "";
                    txtAnswer3.Text = "";
                    txtAnswer4.Text = "";
                    txtQuestion.Focus();
                    lblMessage.Text = "Successfully Added";


                }
                else
                {
                    txtQuestion.Text = "";
                    txtAnswer1.Text = "";
                    txtAnswer2.Text = "";
                    txtAnswer3.Text = "";
                    txtAnswer4.Text = "";
                    txtQuestion.Focus();
                    lblMessage.Text = "Already Exist";
                }
            }
            else
            {
                lblMessage.Text = "Insert Qusetion & answer ";
            }

        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }


        // Response.Redirect("ListQuestion.aspx");


    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

        //try
        //{



        //    SubTitle ObjType = new SubTitle();
        //    ObjType.MainID = Convert.ToInt32(ddlMainTitle.SelectedValue);



        //    ObjType.Insertedby = 1;

        //    int ID = SubTitleManager.Add(ObjType);

        //    if (ID > 0)
        //    {
        //        lblMessage.Text = "Exam TiTle Added Successfully";

        //    }
        //    else
        //    {
        //        lblMessage.Text = "Exam TiTle Already Exist";
        //    }

        //}
        //catch (Exception)
        //{
        //    lblMessage.Text = "Error";

        //}




    }
    protected void ddlMainTitle_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlMainTitle.SelectedValue == "Select")
        {
            lblMessage.Text = "select Main Title";
            ddlMainTitle0.Items.Clear();
            ddlMainTitle0.Items.Insert(0, "Select");

        }
        else
        {
            ddlMainTitle0.Items.Clear();
            ddlMainTitle0.DataTextField = "SubTitle";
            ddlMainTitle0.DataValueField = "SubID";
            ddlMainTitle0.DataSource = SubTitleManager.ListAllSubTitleByMainID(Convert.ToInt32(ddlMainTitle.SelectedValue));
            ddlMainTitle0.DataBind();

            ddlMainTitle0.Items.Insert(0, "Select");

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
}