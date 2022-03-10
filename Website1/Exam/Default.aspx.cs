using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;
using System.Collections.Generic;
using System.Data;
public partial class USER_WelCome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("Login.aspx");
               
            }
            else
            {
                lblMessage.Text = "";


                InterviewMst objuser = InterviewMstManager.Select(Convert.ToInt32(Session["UserId"]));
                if (objuser != null)
                {
                    lblUsername.Text = objuser.Name;
                    if (objuser.Interview ==1)
                    {
                        lblFunct.Text = "Interview";
                        
                        
                    }
                    else
                    {
                        lblFunct.Text = "Induction";
                        
                       
                    }
                }


                BindMainTitle();
               
            }
            lblMessage.Text = ""; 
      
        
        }
        if (Session["UserId"] == null)
        {
           Response.Redirect("Login.aspx");

        }
        

    }
    

    string level;

    void BindMainTitle()
    {

        //DataSet ds = SettingoneManager.GetSettingonebyLevelIdFor(Convert.ToInt32(Session["UserId"]));
        //if (ds.Tables[0].Rows.Count > 0)
        //{

        //    lblFunction.Text = Convert.ToString(FunctionMstManager.Select(Convert.ToInt32(ds.Tables[0].Rows[0][1])).FunctionName);
        //    lblLevel.Text = Convert.ToString(LevelMstManager.Select(Convert.ToInt32(ds.Tables[0].Rows[0][2])).Levelname);
        //    Session["level"] = Convert.ToString(Convert.ToInt32(ds.Tables[0].Rows[0][2]));


        //}

          List<Settingone> objone = SettingoneManager.Getinterview(Convert.ToInt32(InterviewMstManager.Select(Convert.ToInt32(Session["UserId"])).Interview),Convert.ToInt32(Session["UserId"]));

        
          if (objone.Count>0)
          {
              gvExam.Visible = true;
              gvExam.DataSource = objone;
              gvExam.DataBind();
          }
          else
          {
              lblMessage.Text = "No Data Found";
              gvExam.Visible = false;
              Label3.Visible = true;
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
        Response.Redirect("Login.aspx");
    }
    protected void gvExam_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvExam.PageIndex = e.NewPageIndex;
        BindMainTitle();

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
