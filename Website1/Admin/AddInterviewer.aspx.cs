using System;
using System.Web.UI.WebControls;
using BusinessL;

public partial class Admin_AddFunction : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                lbltitle.Text = "";
                BindGrid();

            }
            lbltitle.Text = "";
        }
        catch (Exception ex)
        {
            lbltitle.Text = ex.Message;
        }
    }
    public void BindGrid()
    {
        gvFunction.DataSource = InterviewMstManager.GetAll();
        gvFunction.DataBind();
    }
    protected void gvFunction_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvFunction.PageIndex = e.NewPageIndex;
        BindGrid();
    }

    protected void gvFunction_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void gvFunction_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int MainId;


            if (e.CommandName == "Delete")
            {

                MainId = Convert.ToInt32(e.CommandArgument.ToString());
                InterviewMstManager.Delete(MainId);
                lbltitle.Text = "Successfully Deleted";
            }
           
        }
        catch (Exception ex)
        {
            lbltitle.Text = ex.Message;
        }
        BindGrid();
    }
    protected void gvFunction_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            InterviewMst objint = new InterviewMst();
            if (objint != null)
            {
                objint.Name = txtName.Text;
                objint.Interview =Convert.ToInt32(DropDownList1.SelectedValue);
                objint.UserName = txtuserName.Text;
                objint.Password =txtPassword.Text;
                objint.ApplyForPosition = txtPosition.Text;

                objint.inductionId = 0;

                int i = Convert.ToInt32(InterviewMstManager.Add(objint));
                if (i > 0)
                {
                    lbltitle.Text = "Successfully Added";
                     
                }
                else
                {
                    lbltitle.Text = "Already Exists";

                }
            }

           
            BindGrid();
        }
        catch (Exception ex)
        {
            lbltitle.Text = ex.Message;
        }
    }
    protected void gvFunction_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        foreach (GridViewRow row in gvFunction.Rows)
        {


            Label lblInterview = (Label)row.FindControl("lblInterview");
            Label lblInterviewer = (Label)row.FindControl("lblInterviewer");

            if (lblInterview.Text == "1")
            {
                lblInterviewer.Text = "Interview";

            }
            else if (lblInterview.Text == "2")
            {
                lblInterviewer.Text = "Induction";
            }
            else
            {
                lblInterviewer.Text = "";
            }


           

        }
    }
}