using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;
using System.IO;

public partial class Admin_FileUpload : System.Web.UI.Page
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
        gvFunction.DataSource = FileUploadMstManager.GetAll();
        gvFunction.DataBind();
        ddlfunction.Items.Clear();
        ddlfunction.DataTextField = "FunctionName";
        ddlfunction.DataValueField = "Functionid";
        ddlfunction.DataSource = FunctionMstManager.GetAll();
        ddlfunction.DataBind();
        ddlfunction.Items.Insert(0, "Select");
        ddllevel.Items.Insert(0, "Select");

       
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        FileUploadMst objfile = new FileUploadMst();
        objfile.Functionid = Convert.ToInt32(ddlfunction.SelectedValue);
        objfile.Levelid = Convert.ToInt32(ddllevel.SelectedValue);
        objfile.FileTile = txttitle.Text;
        objfile.InsertedOn = System.DateTime.Now;
       
        string filename = "";
        if (flfile.HasFile)
        {
            int filelen = flfile.PostedFile.ContentLength;
            filename = flfile.FileName;
           
                flfile.PostedFile.SaveAs(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\Ebook\\" + filename);
                objfile.FileName = filename;
                objfile.InsertedBy = Convert.ToInt32(Session["AdminID"]);
            int result = Convert.ToInt32(FileUploadMstManager.Add(objfile));
            if (result != 0)
                lbltitle.Text = "Successfully Added";
            BindGrid();
            txttitle.Text = string.Empty;
        }
        else
        {
            lbltitle.Text = "Upload the file.";
        }
        
    }
    protected void gvFunction_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvFunction.PageIndex = e.NewPageIndex;
        BindGrid();
    }
    protected void gvFunction_RowDeleting(object sender, GridViewDeleteEventArgs e)
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
                FileUploadMstManager.Delete(MainId);
            }
            lbltitle.Text = "Successfully Deleted";
        }
        catch (Exception ex)
        {
            lbltitle.Text = ex.Message;
        }
        BindGrid();
    }
    protected void ddlfunction_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlfunction.SelectedValue == "Select")
        {

            lbltitle.Text = "Select Function";
            ddlfunction.DataTextField = "FunctionName";
            ddlfunction.DataValueField = "Functionid";
            ddlfunction.DataSource = FunctionMstManager.GetAll();
            ddlfunction.DataBind();
            ddlfunction.Items.Insert(0, "Select");

        }
        else
        {

            ddllevel.Items.Clear();
            ddllevel.DataTextField = "Levelname";
            ddllevel.DataValueField = "Levelid";
            ddllevel.DataSource = LevelMstManager.listlevel(Convert.ToInt32(ddlfunction.SelectedValue));
            //SubTitleManager.ListAllSubTitleByMainID(Convert.ToInt32(ddlMainTitle.SelectedValue));
            ddllevel.DataBind();

            ddllevel.Items.Insert(0, "Select");

        }

    }
}