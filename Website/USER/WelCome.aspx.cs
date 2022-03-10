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
                Response.Redirect("~/Login.aspx");
               
            }
            else
            {
                lblMessage.Text = "";

                User_Mst objuser = User_MstManager.Select(Convert.ToInt32(Session["UserId"]));
                if (objuser != null)
                {
                    lblUsername.Text = objuser.FirstName + " " + objuser.LastName;

                    lblFunct.Text = FunctionMstManager.Select(Convert.ToInt32(objuser.Technical)).FunctionName;
                }


                BindMainTitle();
               
            }
            lblMessage.Text = ""; 
      
        
        }
        if (Session["UserId"] == null)
        {
           Response.Redirect("~/Login.aspx");

        }
        

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

    string level;

    void BindMainTitle()
    {

        DataSet ds = SettingoneManager.GetSettingonebyLevelIdFor(Convert.ToInt32(Session["UserId"]));
        if (ds.Tables[0].Rows.Count > 0)
        {

            lblFunction.Text = "&nbsp;Function &nbsp;:&nbsp;" +Convert.ToString(FunctionMstManager.Select(Convert.ToInt32(ds.Tables[0].Rows[0][1])).FunctionName);
            lblLevel.Text = "&nbsp;Level &nbsp;:&nbsp;" + Convert.ToString(LevelMstManager.Select(Convert.ToInt32(ds.Tables[0].Rows[0][2])).Levelname);
            Session["level"] = Convert.ToString(Convert.ToInt32(ds.Tables[0].Rows[0][2]));


        }

          List<Settingone> objone = SettingoneManager.GetAllByLevelId2(Convert.ToInt32(Session["UserId"]));

        
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

          List<Settingone> objone1 = SettingoneManager.GetAllByLevelIdCommon(Convert.ToInt32(Session["UserId"]));


          if (objone1.Count > 0)
          {
              GridView1.Visible = true;
              GridView1.DataSource = objone1;
              GridView1.DataBind();
          }
          else
          {
              GridView1.Visible = false;
              Label1.Visible = true;
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
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        GridView1.PageIndex = e.NewPageIndex;
        BindMainTitle();
    }
}
