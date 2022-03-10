using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;
using System.IO;
using System.Data.OleDb;

public partial class _default : System.Web.UI.Page
{
    //string ImagePath = "";
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
      //  if (ddlExamTitle.SelectedValue != "0")
        //{
           ddlExamTitle.DataTextField = "Title";
           ddlExamTitle.DataValueField = "TitleId";
           ddlExamTitle.DataSource = ExamTitleMstManager.GetAll();
           


           ddlExamTitle.DataBind();
           ddlExamTitle.Items.Insert(0, "Select");
        //}
       // else
        //{
          //  lblMessage.Text = "";
       // }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        int QusetionId;
        try
        {

            QuestionMst Obj = new QuestionMst();

            if (txtQuestion.Text != null && txtAnswer1.Text != null || txtQuestion.Text !="" && txtAnswer1.Text != "")
            {

                Obj.InsertedBy = 1;
                Obj.Hint = "";
                Obj.Deactive = false;

                Obj.TopicId = Convert.ToInt32(ddlExamTitle.SelectedValue);
                Obj.Question = txtQuestion.Text;
                Obj.Option1 = txtAnswer1.Text;
                Obj.Option2 = txtAnswer2.Text;

                Obj.Option3 = txtAnswer3.Text;
                Obj.Option4 = txtAnswer4.Text;
                Obj.Option5 = txtAnswer5.Text;
                Obj.Option6 = txtAnswer6.Text;
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
                else if (rbtnAnswer6.Checked)
                {
                    Obj.CorrectAnswer = "6";
                }
                else
                {
                    lblMessage.Text = "Please Insert Question & Answer";
                    return;
                }



                int ID = QuestionMstManager.Add(Obj);

                if (ID > 0)
                {


                    txtQuestion.Text = "";
                    txtAnswer1.Text = "";
                    txtAnswer2.Text = "";
                    txtAnswer3.Text = "";
                    txtAnswer4.Text = "";
                    txtAnswer5.Text = "";
                    txtAnswer6.Text = "";
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
                    txtAnswer5.Text = "";
                    txtAnswer6.Text = "";
                    txtQuestion.Focus();
                    lblMessage.Text = "Already Exist";
                }
            }
            else
            {
                lblMessage.Text = "Please Questions and Answers";
            }
           

        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }


        // Response.Redirect("ListQuestion.aspx");


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


    //protected void imgcmdsubmit_Click(object sender, EventArgs e)
    //{

    //}
    //protected void cmddownload_Click(object sender, EventArgs e)
    //{

    //}

    /////

    protected string valid(OleDbDataReader myreader, int stval)//if any columns are found null then they are replaced by zero
    {
        object val = myreader[stval];
        if (val != DBNull.Value)
            return val.ToString();
        else
            return Convert.ToString(0);
    }
    private void DownloadFile(string fname, bool forceDownload)
    {
        string path = MapPath(fname);
        string name = Path.GetFileName(path);
        string ext = Path.GetExtension(path);
        string type = "";
        // set known types based on file extension  
        if (ext != null)
        {
            switch (ext.ToLower())
            {
                case ".htm":
                case ".html":
                    type = "text/HTML";
                    break;

                case ".txt":
                    type = "text/plain";
                    break;

                case ".doc":
                case ".rtf":
                    type = "Application/msword";
                    break;
            }
        }
        if (forceDownload)
        {
            Response.AppendHeader("content-disposition",
                "attachment; filename=" + name);
        }
        if (type != "")
            Response.ContentType = type;
        Response.WriteFile(path);
        Response.End();
    }
    protected void cmddownload_Click(object sender, EventArgs e)
    {
        string filepath = "../QuestionSetFormat/QuestionSet.xls";
        DownloadFile(filepath, true);
    }
    FileUpload fup = new FileUpload();
   

    protected void imgcmdsubmit_Click(object sender, EventArgs e)
    {
        QuestionMst Obj = new QuestionMst();
        OleDbConnection oconn = null;
        try
        {
            string filename = "";
            if (ddlExamTitle.SelectedValue != null)
            {
                if (fuexcel.HasFile)
                {

                    if (Path.GetExtension(fuexcel.FileName) == ".xls")
                    {



                        string path = "";
                        //path = Server.MapPath(fuexcel.PostedFile.FileName);
                        path = Path.GetFullPath(fuexcel.FileName).ToString();
                        filename = System.DateTime.Now.Day + "_" + fuexcel.FileName;
                        fuexcel.SaveAs(AppDomain.CurrentDomain.BaseDirectory.ToString() + "/QuestionSetExcel/" + filename);
                        string filepath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "/QuestionSetExcel/" + filename;
                        oconn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0");
                        OleDbCommand ocmd = new OleDbCommand("select * from [OthermemberMst$]", oconn);
                        oconn.Open();
                        OleDbDataReader odr = ocmd.ExecuteReader();


                        path = Path.GetFullPath(fuexcel.FileName).ToString();

                        while (odr.Read())
                        {



                            if (valid(odr, 0) != "0")
                            {
                                //string db = valid(odr, 4);
                                //DateTime dob = Convert.ToDateTime(db);
                                ////string dob1 = dob.ToString();
                                //string db1 = valid(odr, 5);
                                //DateTime dos = Convert.ToDateTime(db1);
                                //string dos1 = dos.ToString();
                                //new BusinessComponent.StudentEnrollment().InsertStudentEnrollment(100,
                                //            StudentId, valid(odr, 0), valid(odr, 1), valid(odr, 2), valid(odr, 3),
                                //            dob, dos, valid(odr, 6),
                                //            valid(odr, 7), valid(odr, 8),
                                //            valid(odr, 9), valid(odr, 10), valid(odr, 11),
                                //            valid(odr, 12), valid(odr, 13),
                                //            valid(odr, 14),
                                //            valid(odr, 15),
                                //            valid(odr, 16), foodn, gendern, swimmern, valid(odr, 19), 0, imagename);


                                if (Obj != null)
                                {

                                    Obj.CorrectAnswer = valid(odr, 7);


                                    Obj.InsertedBy = 1;
                                    Obj.Hint = "";
                                    Obj.Deactive = false;

                                    Obj.TopicId = Convert.ToInt32(ddlExamTitle.SelectedValue);
                                    Obj.Question = valid(odr, 0);
                                    Obj.Option1 = valid(odr, 1);
                                    Obj.Option2 = valid(odr, 2);

                                    Obj.Option3 = valid(odr, 3);
                                    Obj.Option4 = valid(odr, 4);
                                    Obj.Option5 = valid(odr, 5);
                                    Obj.Option6 = valid(odr, 6);

                                    QuestionMstManager.Add(Obj);



                                }


                            }

                        }
                        oconn.Close();


                        lblMessage.Text = "Data Uploaded Sucessfully";
                        //DBind();

                    }
                    else
                    {
                        lblMessage.Text = "Upload the file with .xls extention";
                    }
                }
                
                else
                {
                    lblMessage.Text = "Upload the Excel File";
                }
            }
            else
            {
                lblMessage.Text = "Please Select Title /Topics";
            }


        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
            oconn.Close();
        }

    }



}
