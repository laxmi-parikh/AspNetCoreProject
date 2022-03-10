using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;
using System.Data;
using System.IO;

public partial class Admin_UserReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                lbltitle.Text = "";
               
                    lbltitle.Text = "";
                    DBind();
                    btn_Excel.Visible = false;
              
            }
            catch (Exception ex)
            {
                lbltitle.Text = ex.Message;
            }
        }
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        return;
    }


    public void DBind()
    {


        ddlusername.DataTextField = "FunctionName";
        ddlusername.DataValueField = "Functionid";
        ddlusername.DataSource = FunctionMstManager.GetAll();
        ddlusername.DataBind();
        ddlusername.Items.Insert(0, "Select");

    }
    protected void gvFunction_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvFunction.PageIndex = e.NewPageIndex;
        BindGrid();
    }
    //protected void ddlusername_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    //if (ddlusername.SelectedItem.Text != "Select")
    //    //{
    //    //    int userid = Convert.ToInt32(ddlusername.SelectedValue);

    //    //    BindGrid(userid);

    //        //User_Mst objuser = User_MstManager.Select(userid);
    //        //if (objuser.Technical != "")
    //        //{
    //        //    List<FunctionMst> listfunction = new List<FunctionMst>();

    //        //    listfunction = FunctionMstManager.GetAll();

    //        //    if (listfunction.Count > 0)
    //        //    {
    //        //        foreach (FunctionMst function in listfunction)
    //        //        {
    //        //            if (function.Functionid == Convert.ToInt32(objuser.Technical))
    //        //            {
    //        //                lbltechnical.Text = function.FunctionName;
    //        //            }
    //        //        }
    //        //    }
    //        //}
    //   // }
      


    //}
    public void BindGrid()
    {
        if (ddlusername.SelectedValue != null)
        {
           // DataSet ds = User_MstManager.GetUserByFunctionId(Convert.ToInt32(ddlusername.SelectedValue));
            //if (ds.Tables[0].Rows.Count > 0)
            //{
             gvFunction.DataSource = User_MstManager.GetUserByFunctionId(Convert.ToInt32(ddlusername.SelectedValue));
                gvFunction.DataBind();

                btn_Excel.Visible = true;
            //}
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindGrid();
    }
    protected void gvFunction_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        foreach (GridViewRow row in gvFunction.Rows)
        {

            if (row.RowType == DataControlRowType.DataRow)
            {
                Label lblUserId = (Label)row.FindControl("lblUserId");

                GridView Grid= (GridView)row.FindControl("GridView1");

                Grid.DataSource = User_MstManager.GetallDetail(Convert.ToInt32(lblUserId.Text), Convert.ToInt32(ddlusername.SelectedValue));
                Grid.DataBind();
                //
            }
        }

    }

    public void ExportDataSetToExcel(DataSet ds, string filename)
    {
        HttpResponse response = HttpContext.Current.Response;

        // first let's clean up the response.object   
        response.Clear();
        response.Charset = "";

        // set the response mime type for excel   
        response.ContentType = "application/vnd.ms-excel";
        response.AddHeader("Content-Disposition", "attachment;filename=\"" + filename + ".xls\"");

        // create a string writer   
        using (StringWriter sw = new StringWriter())
        {
            using (HtmlTextWriter htw = new HtmlTextWriter(sw))
            {
                // instantiate a datagrid   
                DataGrid dg = new DataGrid();
                dg.DataSource = ds.Tables[0];

                dg.DataBind();
                dg.RenderControl(htw);
                response.Write(sw.ToString());
                response.End();
            }
        }

        // panel.Visible = false;

    }
    DataSet obj;
    protected void btn_Excel_Click(object sender, EventArgs e)
    {
        // ExportDataSetToExcel(,)
        if (ddlusername.SelectedValue != null)
        {
            obj = User_MstManager.GetallDetail1(Convert.ToInt32(ddlusername.SelectedValue));
            // obj = Exam_MstManager.GetResultReport(Convert.ToInt32(Request.QueryString["SettingId"]));
            if (obj.Tables[0].Rows.Count > 0)
            {
                //dt = obj.Tables[0];

                ExportDataSetToExcel(obj, "ArmstrongExcelReport");
                //ExportDataSetToExcel(obj.Tables[0],"filename");
            }
        }
    }
}