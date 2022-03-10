using System;
using BusinessL;
using System.Text;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int a;
        if(!IsPostBack)
        {
            if(Request.QueryString["id"]!=null)
            {
        //id='+obj+'
         User_Mst objuser = User_MstManager.Select(Convert.ToInt32(Request.QueryString["id"]));
            if (objuser != null)
            {

                  lblName.Text = objuser.FirstName + " " + objuser.LastName;
              // lbl Email = objuser.EmailId;
               lblMainTitle.Text  = MainTitleManager.Select(Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SetId"])).FunctionId)).Title;
               lblSubTitle.Text = SubTitleManager.Select(Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SetId"])).LevelId)).SubTitle1;
               lblExam.Text= SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SetId"])).TitleForExam;
             lblSetmarks.Text = SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SetId"])).Setmarks.ToString();
                Result_Mst objresult = Result_MstManager.SelectResult(Convert.ToInt32(Request.QueryString["id"]), Convert.ToInt32(Request.QueryString["SetId"]), Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SetId"])).LevelId));
                if (objresult != null)
                {
                   lblDate.Text= objresult.InsertedOn.ToString("dd-MMM-yyyy");
                  lbltQuestion.Text = objresult.TotalQuestion.ToString();
                    lblTtAQuestion.Text= Convert.ToString(objresult.WrongAnswer + objresult.CorrectAnswer);
                    lblNttlquestion.Text = Convert.ToString(objresult.TotalQuestion - Convert.ToInt32(lblTtAQuestion.Text));
                    lblcorrectanswer.Text= objresult.CorrectAnswer.ToString();
                    if (objresult.TotalQuestion == 0)
                    {
                        a = 0;
                    }
                    else
                    {
                        a = (objresult.CorrectAnswer * 100) / objresult.TotalQuestion;
                    }

                    lblPercentage.Text = Convert.ToString(a) + "";
                    if (a >= Convert.ToInt32(SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SetId"])).PassScore))
                    {
                        lblgrade.Text = SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SetId"])).PassScoreMsg;
                    }
                    else
                    {
                       lblgrade.Text= SettingoneManager.Select(Convert.ToInt32(Request.QueryString["SetId"])).FailScoreMsg;
                    }


                }

            }
    }}
}


   
    }
