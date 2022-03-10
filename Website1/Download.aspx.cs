using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessL;
public partial class Download : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DBind();
    }
    public void DBind()
    {
        gvExam.DataSource = FileUploadMstManager.GetAll(true);
            gvExam.DataBind();
    }
    protected void gvExam_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvExam.PageIndex = e.NewPageIndex;
        DBind();
    }
}