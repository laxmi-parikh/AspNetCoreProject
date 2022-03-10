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
using System.Collections.Generic;
using BusinessL;

public partial class Admin_AddMainTitle : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
        
        }


    }
  

    public void BindGrid()
    {
        ddlfuntion.DataTextField = "Functionname";
        ddlfuntion.DataValueField = "functionid";
        ddlfuntion.DataSource = FunctionMstManager.GetAll();
        ddlfuntion.DataBind();
        ddlfuntion.Items.Insert(0, "Select");
        User_Mst objuser = User_MstManager.Select(Convert.ToInt32(Request.QueryString["UserId"]));
        if (objuser != null)
        {
            txtEmployeeCode.Text = objuser.EmployeeCode;
            txtEmail.Text = objuser.EmailId;
            txtFirstName.Text = objuser.FirstName;
            txtLName.Text = objuser.LastName;
            txtMName.Text = objuser.MiddleName;
            txtMobileNo.Text = objuser.MoblieNumber;
            objuser.Gender = objuser.Gender.Trim();
            if (objuser.Gender == "M")
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnFemale.Checked = true;
            }
            ddlfuntion.SelectedValue = objuser.Technical;
            
        }
      
       
    }

    protected void gvMainTitle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int UserId;
      
        
        if (e.CommandName == "Delete")
        {

            UserId = Convert.ToInt32(e.CommandArgument.ToString());

            User_MstManager.Delete(UserId);
           
           
        }
        lbltitle.Text = "Successfully Deleted";
         


    }
    protected void iBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {

         User_Mst Obj = new User_Mst();
         Obj.UserId = Convert.ToInt32(Request.QueryString["UserId"]);
         Obj.EmployeeCode = txtEmployeeCode.Text;

         Obj.FirstName = txtFirstName.Text;
         Obj.LastName = txtLName.Text;
         Obj.MiddleName = txtMName.Text;
         Obj.EmailId = txtEmail.Text;
         Obj.MoblieNumber = txtMobileNo.Text;
         if (rbtnFemale.Checked)
         {
             Obj.Gender = "F";
         }
         else
         {
             Obj.Gender = "M";
         }

        // Obj.Password = txtPassword.Text;
         Obj.Technical = ddlfuntion.SelectedValue;
      
         //if (rbtnNonSales.Checked)
         //{
         //    Obj.Technical = "NonSales";
         //}
         //else
         //{
         //    Obj.Technical = "Sales";
         //}

          User_MstManager.Update(Obj);

       lbltitle.Text = "Successfully Updated";


      
         
  

    }
}
