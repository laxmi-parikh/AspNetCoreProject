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

public partial class Admin_AddMainTitle : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbltitle.Text = "";
            BindGrid();
            DBind();
            
        
        }
        lbltitle.Text = "";

    }
    public void DBind()
    {
        DataSet fds = FunctionMstManager.Listfunction();
        Dropdrown(ddlfunction, "FunctionName", "Functionid", fds);
        ddlfunction.Items.Insert(0, "Select");
        ddllevel.Items.Add("Select");

    }
    public void Dropdrown(DropDownList ddl, string text, string value, DataSet ds)
    {
        ddl.DataTextField = text;
        ddl.DataValueField = value;
        ddl.DataSource = ds;
        ddl.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int MainId;
        try
        {
            MainTitle Objtype = new MainTitle();
            Objtype.Title = txtMainTitle.Text;
            Objtype.Insertedby = Convert.ToInt32(Session["AdminID"]);
            Objtype.Functionid = Convert.ToInt32(ddlfunction.SelectedValue);
            Objtype.Levelid = Convert.ToInt32(ddllevel.SelectedValue);
            Objtype.Technical = Convert.ToString(ddlfunction.SelectedItem);
            //if (rbt1Sales.Checked)
            //{
            //    Objtype.Technical = "Sales";
            //}
            //else if (rbtnonsales.Checked)
            //{
            //    Objtype.Technical = "NonSales";
            //}
            //else
            //{
            //    Objtype.Technical = "All";
            //}

            MainId = Convert.ToInt32(MainTitleManager.Add(Objtype));
            if (MainId > 0)
            {
                lbltitle.Text = "Successfully Added";
                txtMainTitle.Text = string.Empty;
            }
            else
            {
                lbltitle.Text = "Already Exists";
                txtMainTitle.Text = string.Empty;
            }


        BindGrid();
    }
    catch (Exception ex)
{
    lbltitle.Text=ex.Message.ToString();
}

    }

    public void BindGrid()
    {
       
        gvMainTitle.DataSource = MainTitleManager.GetAll();
        gvMainTitle.DataBind();
        
    }
    protected void gvMainTitle_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvMainTitle.PageIndex = e.NewPageIndex;
        BindGrid();
        lbltitle.Text = "";


    }
    protected void gvMainTitle_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvMainTitle_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ////GridViewRow row =  (gvMainTitle).FindControl[e.RowIndex];
        //GridViewRow row = (GridViewRow)gvMainTitle.Rows[e.RowIndex];
        //Label lbl = (Label)row.FindControl("SrNo");
        //con.Open();
        //SqlCommand cmd = new SqlCommand("delete from List_MainTitle  where SrNo = "+lbl.Text+ "", con);
        //cmd.ExecuteNonQuery();
        //con.Close();
        //BindGrid();
        gvMainTitle.EditIndex = -1;
        BindGrid();
        
         
    }
    protected void gvMainTitle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int MainId;
      
        
        if (e.CommandName == "Delete")
        {

            MainId = Convert.ToInt32(e.CommandArgument.ToString());
            MainTitleManager.Delete(MainId);
           
        }
        lbltitle.Text = "Successfully Deleted";
         


    }
    protected void ddlfunction_SelectedIndexChanged(object sender, EventArgs e)
    {
        int functionid = Convert.ToInt32(ddlfunction.SelectedValue);

        DataSet ds = LevelMstManager.listlevel(functionid);

        if (ds.Tables.Count != 0)
        {
            ddllevel.Items.Clear();
            Dropdrown(ddllevel, "Levelname", "Levelid", ds);
            ddllevel.Items.Insert(0, "Select");
        }
        else
        {
            ddllevel.Items.Clear();
            ddllevel.Items.Add("Select");
        }


    }
}
