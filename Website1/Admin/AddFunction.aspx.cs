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
        gvFunction.DataSource = FunctionMstManager.GetAll();
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
                FunctionMstManager.Delete(MainId);
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
            FunctionMst objfunction = new FunctionMst();
            objfunction.FunctionName = txtfunction.Text;
            objfunction.InsertedBy = 1;
            objfunction.InsertedOn = System.DateTime.Now;
            int result = Convert.ToInt32(FunctionMstManager.Add(objfunction));
            if (result > 0)
            {
                lbltitle.Text = "Successfully Added";
                txtfunction.Text = string.Empty;
            }
            else
            {
                lbltitle.Text = "Already Exists";
                txtfunction.Text = string.Empty;
            }
            BindGrid();
        }
        catch (Exception ex)
        {
            lbltitle.Text = ex.Message;
        }
    }
}