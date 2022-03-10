using System;
using System.Collections;
using System.Configuration;
using System.Data;
////// using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
////// using System.Xml.Linq;
using BusinessL;
using System.Text;

public partial class Admin_ExamSetting : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["AdminID"] != null)
            {
                // BindMainTitle();
                Dbindfunction();
            }
            else
            {
                Response.Redirect("ADMINLOGIN.aspx");

            }
        }
    }
    public void Dbindfunction()
    {
        DataSet fds = FunctionMstManager.Listfunction();
        Binddropdownlist(ddlfunction, "FunctionName", "Functionid", fds);
        ddlfunction.Items.Insert(0, "Select");
    }
    public void Binddropdownlist(DropDownList ddl, string text, string value, DataSet ds)
    {
        ddl.DataTextField = text;
        ddl.DataValueField = value;
        ddl.DataSource = ds;
        ddl.DataBind();
    }
    public void BindMainTitle()
    {
        //ddlMainTitle.Items.Clear();

        //    ddlMainTitle.DataTextField = "Title";
        //    ddlMainTitle.DataValueField = "MainID";
        //    ddlMainTitle.DataSource = MainTitleManager.GetAllByTechical("Sales");
        //    ddlMainTitle.DataBind();


        //ddlMainTitle.Items.Insert(0, "Select");
        //DropDownList1.Items.Insert(0, "Select");
    }
    public void BindSubtitle(int MainID)
    {

        if (MainID > 0)
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
            DropDownList1.Items.Clear();
            DropDownList1.DataTextField = "SubTitle";
            DropDownList1.DataValueField = "SubId";
            DropDownList1.DataSource = SubTitleManager.ListAllSubTitleByMainID(Convert.ToInt32(ddlMainTitle.SelectedValue));
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Select");
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
        //if (chk1.Checked)
        //{

        //    if (ddlMainTitle.SelectedValue != "Select" && ddlMainTitle.SelectedValue != "")
        //    {
        //        obj.MainId = Convert.ToInt32(ddlMainTitle.SelectedValue);
        //    }
        //    else
        //    {
        //        lblMsg.Text = "select Main Title";
        //        return;
        //    }

        //    if (DropDownList1.SelectedValue != "" && DropDownList1.SelectedValue != "Select")
        //    {
        //        obj.SubId = Convert.ToInt32(DropDownList1.SelectedValue);
        //    }
        //    else
        //    {
        //        lblMsg.Text = "select Sub Title";
        //        return;

        //    }

        //    obj.Technical = "Sales";
        //}
        //else if (chk2.Checked)
        //{
        //    if (ddlMainTitle.SelectedValue != "Select" && ddlMainTitle.SelectedValue != "")
        //    {
        //        obj.MainId = Convert.ToInt32(ddlMainTitle.SelectedValue);
        //    }
        //    else
        //    {
        //        lblMsg.Text = "select Main Title";
        //        return;
        //    }

        //    if (DropDownList1.SelectedValue != "" && DropDownList1.SelectedValue != "Select")
        //    {
        //        obj.SubId = Convert.ToInt32(DropDownList1.SelectedValue);
        //    }
        //    else
        //    {
        //        lblMsg.Text = "select Sub Title";
        //        return;

        //    }
        //    obj.Technical = "NonSales";

        //}
        //else
        //{
        //    if (ddlMainTitle.SelectedValue != "Select" && ddlMainTitle.SelectedValue != "")
        //    {
        //        obj.MainId = Convert.ToInt32(ddlMainTitle.SelectedValue);
        //    }
        //    else
        //    {
        //        lblMsg.Text = "select Main Title";
        //        return;
        //    }

        //    if (DropDownList1.SelectedValue != "" && DropDownList1.SelectedValue != "Select")
        //    {
        //        obj.SubId = Convert.ToInt32(DropDownList1.SelectedValue);
        //    }
        //    else
        //    {
        //        lblMsg.Text = "select Sub Title";
        //        return;

        //    }


        //    obj.Technical = "All";


        //}

        obj.Timelimit = decimal.Parse(txtsettime.Text);
        obj.NumberofQuestionperpage = 0; //Convert.ToInt32(ddlqset.SelectedValue);
        obj.PassScore = Convert.ToInt32(txtsetpercentage.Text);
        obj.PassScoreMsg = txtpassmsg.Text;


        obj.FailScoreMsg = txtfailmsg.Text;
        obj.Setmarks = Convert.ToInt32(txtmarks.Text);
        obj.Insertedby = 1;

        //if (chk1.Checked || chk2.Checked || Chk3.Checked)
        //{
        //    DataSet ds = QuestionMstManager.ListExamQuestion(Convert.ToInt32(ddlMainTitle.SelectedValue), Convert.ToInt32(DropDownList1.SelectedValue));
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        if (ds.Tables[0].Rows.Count >= Convert.ToInt32(txtTotalQuestion.Text))
        //        {
        //            obj.QuestionSet = txtTotalQuestion.Text;
        //        }
        //        else
        //        {
        //            lblMsg.Text = "you can not insert Total No. Question  more than " + ds.Tables[0].Rows.Count;
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        lblMsg.Text = "No Questions set,Please Select another SubTilte";
        //        return;
        //    }
        //}
        //else
        //{
        //    obj.QuestionSet = txtTotalQuestion.Text;
        //}
        obj.TitleForExam = txtTitle.Text;


        obj.Start_Date = Convert.ToDateTime(txtstartdate.Text.ToString());
        obj.End_Date = Convert.ToDateTime(txtenddate.Text.ToString());



        id = Convert.ToInt32(SettingoneManager.Add(obj));

        if (id > 0)
        {
            txtsettime.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtTotalQuestion.Text = string.Empty;
            txtsetpercentage.Text = "";
            txtpassmsg.Text = "";
            txtfailmsg.Text = "";
            txtmarks.Text = "";
            txtstartdate.Text = "";
            txtenddate.Text = "";
            txtenddate.Text = "";
            txtstartdate.Text = "";
            lblMsg.Text = "Successfully Added";

        }
        else
        {
            lblMsg.Text = "Already  Exists";
            txtsettime.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtTotalQuestion.Text = string.Empty;
            txtsetpercentage.Text = "";
            txtpassmsg.Text = "";
            txtfailmsg.Text = "";
            txtmarks.Text = "";
            txtstartdate.Text = "";
            txtenddate.Text = "";
            txtenddate.Text = "";
            txtstartdate.Text = "";
        }
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("~/Default.aspx");

    }
    protected void chk1_CheckedChanged(object sender, EventArgs e)
    {
        ddlMainTitle.Items.Clear();

        ddlMainTitle.DataTextField = "Title";
        ddlMainTitle.DataValueField = "MainID";
        ddlMainTitle.DataSource = MainTitleManager.GetAllByTechical("Sales");
        ddlMainTitle.DataBind();


        ddlMainTitle.Items.Insert(0, "Select");
        DropDownList1.Items.Insert(0, "Select");
        DropDownList1.Items.Clear();
        //chk2.Checked = false;
        //Chk3.Checked = false;
        ddlMainTitle.Visible = true;
        DropDownList1.Visible = true;
        Label1.Visible = true;
        Label2.Visible = true;


    }
    protected void chk2_CheckedChanged(object sender, EventArgs e)
    {
        ddlMainTitle.Items.Clear();

        ddlMainTitle.DataTextField = "Title";
        ddlMainTitle.DataValueField = "MainID";
        ddlMainTitle.DataSource = MainTitleManager.GetAllByTechical("NonSales");
        ddlMainTitle.DataBind();


        ddlMainTitle.Items.Insert(0, "Select");
        DropDownList1.Items.Insert(0, "Select");
        DropDownList1.Items.Clear();
        //chk1.Checked = false;
        //Chk3.Checked = false;
        ddlMainTitle.Visible = true;
        DropDownList1.Visible = true;
        Label1.Visible = true;
        Label2.Visible = true;



    }
    protected void Chk3_CheckedChanged(object sender, EventArgs e)
    {
        ddlMainTitle.Items.Clear();

        ddlMainTitle.DataTextField = "Title";
        ddlMainTitle.DataValueField = "MainID";
        ddlMainTitle.DataSource = MainTitleManager.GetAllByTechical("All");
        ddlMainTitle.DataBind();


        ddlMainTitle.Items.Insert(0, "Select");
        DropDownList1.Items.Insert(0, "Select");
        DropDownList1.Items.Clear();
        //chk1.Checked = false;
        //chk2.Checked = false;
        ddlMainTitle.Visible = true;
        DropDownList1.Visible = true;
        Label1.Visible = true;
        Label2.Visible = true;

    }
    protected void ddlfunction_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet lds = LevelMstManager.listlevel(Convert.ToInt32(ddlfunction.SelectedValue));
        Binddropdownlist(ddlLevel, "Levelname", "Levelid", lds);
        ddlLevel.Items.Insert(0, "Select"); 
    }
    protected void ddlLevel_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet mds = MainTitleManager.ListMaintitle(ddlfunction.Text, Convert.ToInt32(ddlLevel.SelectedValue));
        Binddropdownlist(ddlMainTitle, "Title", "MainID", mds);
        ddlMainTitle.Items.Insert(0, "Select");
    }
}