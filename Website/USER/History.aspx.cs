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
using System.Data.SqlClient;
using BusinessL;
using System.Collections.Generic;

public partial class USER_WelCome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("~/Login.aspx");

            }
            else
            {
                lblMessage.Text = "";

                User_Mst objuser = User_MstManager.Select(Convert.ToInt32(Session["UserId"]));
                if (objuser != null)
                {
                    lblUsername.Text = objuser.FirstName + " " + objuser.LastName;
                }


                BindMainTitle();

            }
            lblMessage.Text = "";


        }
        //if (Session["UserId"] == null)
        //{
        //    Response.Redirect("~/Login.aspx");

        //}


    }
    //public void BindMainTitle()
    //{

    //    if (Session["UserId"] != null)
    //    {
    //        try
    //        {

    //            User_Mst objuser = User_MstManager.Select(Convert.ToInt32(Session["UserId"]));
    //            if (objuser != null)
    //            {
    //                lblUsername.Text = objuser.FirstName + " " + objuser.LastName;



    //                ddlCategory.Items.Clear();
    //                ddlCategory.DataTextField = "Title";
    //                ddlCategory.DataValueField = "MainID";


    //                ddlCategory.DataSource = MainTitleManager.GetAllByTechical(objuser.Technical);
    //                ddlCategory.DataBind();
    //                ddlCategory.Items.Insert(0, "Select");
    //                ddlMainTitle0.Items.Insert(0, "Select");

    //                // Session["UserId"]



    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            lblMessage.Text = ex.Message.ToString();
    //        }
    //    }
    //    else
    //    {
    //        Response.Redirect("~/Login.aspx");
    //    }


    //}

    //protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //     if (Session["UserId"] != null)
    //    {



    //        if (ddlCategory.SelectedItem.Text == "Select")
    //        {
    //            lblMessage.Text = "Select Category";
    //           // gvExam.Visible = false;
    //           // return;



    //        }
    //        else
    //        {
    //            ddlMainTitle0.Items.Clear();
    //            ddlMainTitle0.DataTextField = "SubTitle";
    //            ddlMainTitle0.DataValueField = "SubID";
    //            ddlMainTitle0.DataSource = SubTitleManager.ListAllSubTitleByMainID(Convert.ToInt32(ddlCategory.SelectedValue));
    //            ddlMainTitle0.DataBind();
    //            ddlMainTitle0.Items.Insert(0, "Select");
    //            lblMessage.Text = "";

    //        }



    //    }
    //     else
    //     {
    //         Response.Redirect("~/Login.aspx");
    //     }

    //}



    void BindMainTitle()
    {

        List<Result_Mst> objone = Result_MstManager.GetHistory(Convert.ToInt32(Session["UserId"]));
        if (objone.Count > 0)
        {
            gvExam.Visible = true;
            gvExam.DataSource = objone;
            gvExam.DataBind();
        }
        else
        {
            lblMessage.Text = "No Data Found";
        }

    }

    protected void gvExam_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    //protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    //{
    //    if (ddlCategory.SelectedValue != "Select" && ddlMainTitle0.SelectedValue !="Select")
    //    {
    //        List<Settingone> objone = SettingoneManager.GetAllBySubId1(Convert.ToInt32(ddlMainTitle0.SelectedValue),Convert.ToInt32(Session["UserId"]));
    //        if (objone != null)
    //        {
    //            gvExam.Visible = true;
    //            gvExam.DataSource = objone;
    //            gvExam.DataBind();

    //        }
    //        else
    //        {
    //            gvExam.Visible = false;
    //            if (ddlCategory.SelectedValue == "Select")
    //            {
    //                lblMessage.Text = "Select Main Title";
    //            }
    //            else if (ddlMainTitle0.SelectedValue == "Select")
    //            {
    //                lblMessage.Text = "Select Sub Title";
    //            }
    //            else
    //            {
    //                lblMessage.Text = "Select Main Title and Sub Title";
    //            }

    //        }
    //    }


    //}
    protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
    {
        Session.Abandon();
        Session.RemoveAll();
        Response.Redirect("~/Default.aspx");
    }
    protected void gvExam_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvExam.PageIndex = e.NewPageIndex;
        BindMainTitle();

    }
    int b, a;
    
    protected void gvExam_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        foreach (GridViewRow row in gvExam.Rows)
        {

            Label lblExamTitle = (Label)row.FindControl("lblExamTitle");
            Label lblExamTitle1 = (Label)row.FindControl("lblExamTitle1");
            //Label lblStartDate = (Label)row.FindControl("lblStartDate");
            //Label lblEndDate = (Label)row.FindControl("lblEndDate");
            Label lblSettingId = (Label)row.FindControl("lblSetId");
          //  Label lblDate = (Label)row.FindControl("lblDate");
            Label lblMarks = (Label)row.FindControl("lblMarks");
            Label lblMarksobt = (Label)row.FindControl("lblMarksobt");
            Label lblpercentage = (Label)row.FindControl("lblpercentage");
            Label lblGrade = (Label)row.FindControl("lblGrade");
            Label lblCorrect=(Label)row.FindControl("lblCorrect");
            Label lbltotalQuestion = (Label)row.FindControl("lbltotalQuestion");

            Panel panel1 = (Panel)row.FindControl("panel1");
            Panel panel2 = (Panel)row.FindControl("panel2");
            
            lblExamTitle.Text = Convert.ToString(SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).TitleForExam);
            lblExamTitle1.Text = lblExamTitle.Text;
            lblMarks.Text = Convert.ToString(SettingoneManager.Select(Convert .ToInt32(lblSettingId.Text)).Setmarks);

            if (Convert.ToInt32(lblCorrect.Text) != 0)
            {
                a = (Convert.ToInt32(lblMarks.Text) / Convert.ToInt32(lbltotalQuestion.Text));
                a = a * Convert.ToInt32(lblCorrect.Text);
                lblMarksobt.Text = a.ToString();
            }
            else
                lblMarksobt.Text = "0";

            b =Convert.ToInt32(lblCorrect.Text) *100/ Convert.ToInt32(lbltotalQuestion.Text);
            lblpercentage.Text=b.ToString()+"%";
            if (b>=Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).PassScore) )
            {
                lblGrade.Text = SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).PassScoreMsg;
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                lblGrade.Text = SettingoneManager.Select(Convert.ToInt32(lblSettingId.Text)).FailScoreMsg;
                panel1.Visible =false;
                panel2.Visible = true;
            }









        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("WelCome.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("History.aspx"); 
    }
    protected void imgdownloadebook_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Downloadebook.aspx");
    }
}