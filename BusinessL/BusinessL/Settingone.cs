using System;
using System.Collections.Generic;
using System.Text;
//using Bll;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL
{
   //Date : 27/4/2011
    //Description : Business class
    public class Settingone
    {

        
#region Private Properties
 	
	private int _SettingId;
	private int _FunctionId;
	private int _LevelId;
	private Decimal _Timelimit;
	private int _NumberofQuestionperpage;
	private int _PassScore;
	private string _PassScoreMsg;
	private string _FailScoreMsg;
	private int _Insertedby;
	private DateTime _Insertedon;
	private int _Updatedby;
	private DateTime _Updatedon;
	private int _Deactive;
	private int _Setmarks;
    private string _QuestionSet;
    private string _TitleForExam;
    private DateTime _Start_Date;
    private DateTime _End_Date;


    private string _Commentest;

    
    public int Manual { get; set; }
    public int TitleId { get; set; }

    public int Interview { get; set; }
 
 #endregion
 #region Public Properties


    public string Commentest
    {
        get { return _Commentest; }
        set { _Commentest = value; }
    }
  
    public DateTime Start_Date
    {
        get
        {
            return _Start_Date;
        }
        set
        {
            _Start_Date = value;
        }
    }
    public DateTime End_Date
    {
        get
        {
            return _End_Date;
        }
        set
        {
            _End_Date = value;
        }
    }
    public string TitleForExam
    {
        get { return _TitleForExam; }
        set { _TitleForExam = value; }
    }

    public string QuestionSet
    {
        get { return _QuestionSet; }
        set { _QuestionSet = value; }
    }
	public int SettingId
	{
		get
		{
			return _SettingId;
		}
		set
		{
			_SettingId = value;
		}
	}

	public int FunctionId
	{
		get
		{
			return _FunctionId;
		}
		set
		{
			_FunctionId = value;
		}
	}

	public int LevelId
	{
		get
		{
			return _LevelId;
		}
		set
		{
			_LevelId = value;
		}
	}

	public Decimal Timelimit
	{
		get
		{
			return _Timelimit;
		}
		set
		{
			_Timelimit = value;
		}
	}

	public int NumberofQuestionperpage
	{
		get
		{
			return _NumberofQuestionperpage;
		}
		set
		{
			_NumberofQuestionperpage = value;
		}
	}

	public int PassScore
	{
		get
		{
			return _PassScore;
		}
		set
		{
			_PassScore = value;
		}
	}

	public string PassScoreMsg
	{
		get
		{
			return _PassScoreMsg;
		}
		set
		{
			_PassScoreMsg = value;
		}
	}

	public string FailScoreMsg
	{
		get
		{
			return _FailScoreMsg;
		}
		set
		{
			_FailScoreMsg = value;
		}
	}

	public int Insertedby
	{
		get
		{
			return _Insertedby;
		}
		set
		{
			_Insertedby = value;
		}
	}

	public DateTime Insertedon
	{
		get
		{
			return _Insertedon;
		}
		set
		{
			_Insertedon = value;
		}
	}

	public int Updatedby
	{
		get
		{
			return _Updatedby;
		}
		set
		{
			_Updatedby = value;
		}
	}

	public DateTime Updatedon
	{
		get
		{
			return _Updatedon;
		}
		set
		{
			_Updatedon = value;
		}
	}

	public int Deactive
	{
		get
		{
			return _Deactive;
		}
		set
		{
			_Deactive = value;
		}
	}

	public int Setmarks
	{
		get
		{
			return _Setmarks;
		}
		set
		{
			_Setmarks = value;
		}
	}

 
 #endregion
    }
    public class SettingoneManager
    {
        public enum SettingoneOperationResult
        {
            Settingone_EXISTS,
            Settingone_ADDED
        }
        //public const string USER_EXISTS = "Settingone_EXISTS";
        //public const string USER_ADDED = "Settingone_ADDED";
        private SettingoneDAL objSettingoneDAL = new SettingoneDAL();

        public static SettingoneOperationResult Add(Settingone objSettingone)
        {

            int returnValue = SettingoneDAL.Add(objSettingone);
            if (returnValue == 0)
                return SettingoneOperationResult.Settingone_EXISTS;
            else
                return SettingoneOperationResult.Settingone_ADDED;
        }
        public static SettingoneOperationResult Update(Settingone objSettingone)
        {
            int returnValue = SettingoneDAL.Update(objSettingone);
            if (returnValue == 0)
                return SettingoneOperationResult.Settingone_EXISTS;
            else
                return SettingoneOperationResult.Settingone_ADDED;
        }
        public static void Delete(int SettingoneId)
        {
            SettingoneDAL.Delete(SettingoneId);
        }
        public static Settingone Select(int SettingoneId)
        {
            return SettingoneDAL.Select(SettingoneId);
        }
         public static Settingone SelectbyLevelId(int LevelId)
        {
            return SettingoneDAL.SelectbyLevelId(LevelId);
        }
         public static Settingone GetcountuserbySetting(int SetId)
         {
             return SettingoneDAL.GetcountuserbySetting(SetId);
         }

         public static Settingone GetcountuserAttemptbySetting(int SetId)
         {
             return SettingoneDAL.GetcountuserAttemptbySetting(SetId);
         }

        
        public static List<Settingone> GetAll()
        {
            return SettingoneDAL.GetAll();
        }
        public static List<Settingone> GetAll(int userid)
        {
            return SettingoneDAL.GetAll(userid);
        }
        public static List<Settingone> GetAllByLevelId(int LevelId)
        {
            return SettingoneDAL.GetAllByLevelId(LevelId);
        }

        public static List<Settingone> GetAllByLevelId1(int LevelId, int UserId)
        {
            return SettingoneDAL.GetAllByLevelId1(LevelId,UserId);
        }

        public static List<Settingone> GetAllByLevelId2(int UserId)
        {
            return SettingoneDAL.GetAllByLevelId2(UserId);
        }

        public static List<Settingone> Getinterview(int Id,int userId)
        {
            return SettingoneDAL.Getinterview(Id,userId);
        }

        public static List<Settingone> Getinterviewlist(int Id)
        {
            return SettingoneDAL.Getinterviewlist(Id);
        }
         
        public static List<Settingone> GetAllByLevelIdCommon(int UserId)
        {
            return SettingoneDAL.GetAllByLevelIdCommon(UserId);
        }
       

        public static DataSet GetReport()
        {
            DataSet dr;

            dr = DataConnector.GetDataSet("usp_GetReport");

            return dr;
        }

        public static DataSet GetExamTimeTable(int FunctionId,int LevelId)
        {
            DataSet dr;

            dr = DataConnector.GetDataSet("usp_GetExamTable "+FunctionId+","+LevelId);

            return dr;
        }

       

         public static DataSet GetSettingonebyLevelIdFor(int UserId)
        {
            DataSet dr;

            dr = DataConnector.GetDataSet("Usp_GetSettingonebySubIdFor " +UserId);

            return dr;
        }
         public static DataSet Setupdate(int UserId,int LevelId)
        {
            DataSet dr;

            dr = DataConnector.GetDataSet("usp_Setupdate "+UserId+","+LevelId);

            return dr;
        }
         public static DataSet GetmaxSettingone()
        {
            DataSet dr;

            dr = DataConnector.GetDataSet("usp_GetmaxSettingone");

            return dr;
        }
        
       

      //  usp_Setupdate(@UserId int,@LevelId int)
        

        public static int GetCount(int setid)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_countattempsmade";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@setid", setid);
            comm.Parameters.Add(p);
            

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));
        }
        public static int GetCount(string ExamTitle)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_getcountofuserfortitleforexam";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@ExamTitle", ExamTitle);
            comm.Parameters.Add(p);


            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));
        }
         public static DataSet  GetReportByDate(DateTime starttime ,DateTime EndTime)
         
         
         {
            DataSet dr;

            dr = DataConnector.GetDataSet("usp_GetReportByDate '"+starttime+"','"+EndTime+"'");

            return dr;
        }//(@StartDate1 DateTime,@EndDate1 DateTime)
       // (@SettingId int)

          public static DataSet GetallTitle(int SettingId)
         
          
         {
            DataSet dr;

            dr = DataConnector.GetDataSet("usp_GetallTitle "+ SettingId);

            return dr;
        }
        
    }

    public class SettingoneDAL
    {
        internal static int Add(Settingone objSettingone)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_AddSettingone";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

          SqlParameter  p = new SqlParameter("@FunctionId", objSettingone.FunctionId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@LevelId", objSettingone.LevelId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Timelimit", objSettingone.Timelimit);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@NumberofQuestionperpage", objSettingone.NumberofQuestionperpage);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@PassScore", objSettingone.PassScore);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@PassScoreMsg", objSettingone.PassScoreMsg);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@FailScoreMsg", objSettingone.FailScoreMsg);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Insertedby", objSettingone.Insertedby);
	 comm.Parameters.Add(p);
     p = new SqlParameter("@QuestionSet", objSettingone.QuestionSet);
   comm.Parameters.Add(p);
   p = new SqlParameter("@TitleForExam", objSettingone.TitleForExam);
    comm.Parameters.Add(p);
    p = new SqlParameter("@TitleId", objSettingone.TitleId);
    comm.Parameters.Add(p);

  p = new SqlParameter("@Setmarks", objSettingone.Setmarks);
	 comm.Parameters.Add(p);
     p = new SqlParameter("@Start_Date", objSettingone.Start_Date);
     comm.Parameters.Add(p);
     p = new SqlParameter("@End_Date", objSettingone.End_Date);
     comm.Parameters.Add(p);

     p = new SqlParameter("@commontest", objSettingone.Commentest);
     comm.Parameters.Add(p);
     p = new SqlParameter("@Manual", objSettingone.Manual);
     comm.Parameters.Add(p);
     p = new SqlParameter("@interview", objSettingone.Interview);
     comm.Parameters.Add(p);


            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int Update(Settingone objSettingone)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateSettingone";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@SettingId", objSettingone.SettingId);
	 comm.Parameters.Add(p);
     p = new SqlParameter("@FunctionId", objSettingone.FunctionId);
     comm.Parameters.Add(p);
     p = new SqlParameter("@LevelId", objSettingone.LevelId);
     comm.Parameters.Add(p);
     p = new SqlParameter("@Timelimit", objSettingone.Timelimit);
     comm.Parameters.Add(p);
     p = new SqlParameter("@NumberofQuestionperpage", objSettingone.NumberofQuestionperpage);
     comm.Parameters.Add(p);
     p = new SqlParameter("@PassScore", objSettingone.PassScore);
     comm.Parameters.Add(p);
     p = new SqlParameter("@PassScoreMsg", objSettingone.PassScoreMsg);
     comm.Parameters.Add(p);
     p = new SqlParameter("@FailScoreMsg", objSettingone.FailScoreMsg);
     comm.Parameters.Add(p);
     p = new SqlParameter("@Updatedby", objSettingone.Updatedby);
     comm.Parameters.Add(p);
     p = new SqlParameter("@QuestionSet", objSettingone.QuestionSet);
     comm.Parameters.Add(p);
     p = new SqlParameter("@TitleForExam", objSettingone.TitleForExam);
     comm.Parameters.Add(p);
     //p = new SqlParameter("@Updatedon", objSettingone.Updatedon);
     //   comm.Parameters.Add(p);
 
     p = new SqlParameter("@Setmarks", objSettingone.Setmarks);
     comm.Parameters.Add(p);
     p = new SqlParameter("@Start_Date", objSettingone.Start_Date);
     comm.Parameters.Add(p);
     p = new SqlParameter("End_Date", objSettingone.End_Date);
     comm.Parameters.Add(p);


     return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int SettingoneId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteSettingone";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@SettingoneId", SettingoneId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }


        internal static Settingone Select(int SettingoneId)
        {
            SqlCommand comm = new SqlCommand();
            Settingone objSettingone = null;           
            comm.CommandText = "usp_selectSettingone";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@SettingoneId", SettingoneId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSettingone = new Settingone();
                    objSettingone.SettingId= DataHelper.GetInt(dataReader, "SettingId"); 
objSettingone.FunctionId= DataHelper.GetInt(dataReader, "FunctionId"); 
objSettingone.LevelId= DataHelper.GetInt(dataReader, "LevelId"); 
objSettingone.Timelimit= DataHelper.GetDecimal(dataReader, "Timelimit"); 
objSettingone.NumberofQuestionperpage= DataHelper.GetInt(dataReader, "NumberofQuestionperpage"); 
objSettingone.PassScore= DataHelper.GetInt(dataReader, "PassScore"); 
objSettingone.PassScoreMsg= DataHelper.GetString(dataReader, "PassScoreMsg"); 
objSettingone.FailScoreMsg= DataHelper.GetString(dataReader, "FailScoreMsg"); 
objSettingone.Insertedby= DataHelper.GetInt(dataReader, "Insertedby"); 
objSettingone.Insertedon= DataHelper.GetDateTime(dataReader, "Insertedon"); 
objSettingone.Updatedby= DataHelper.GetInt(dataReader, "Updatedby"); 
objSettingone.Updatedon= DataHelper.GetDateTime(dataReader, "Updatedon"); 
objSettingone.Deactive= DataHelper.GetInt(dataReader, "Deactive"); 
objSettingone.Setmarks= DataHelper.GetInt(dataReader, "Setmarks");
objSettingone.TitleForExam = DataHelper.GetString(dataReader, "TitleForExam");
objSettingone.QuestionSet = DataHelper.GetString(dataReader, "QuestionSet");
objSettingone.Start_Date = DataHelper.GetDateTime(dataReader, "Start_Date");
objSettingone.End_Date = DataHelper.GetDateTime(dataReader, "End_Date");
objSettingone.Commentest = DataHelper.GetString(dataReader, "Commontest");
objSettingone.Manual = DataHelper.GetInt(dataReader, "Manual");
objSettingone.TitleId = DataHelper.GetInt(dataReader, "TitleId");
objSettingone.Interview = DataHelper.GetInt(dataReader, "Interview"); 




              


                    
                }
            }

            return objSettingone;

        }

        //
        internal static Settingone SelectbyLevelId(int LevelId)
        {
            SqlCommand comm = new SqlCommand();
            Settingone objSettingone = null;
            comm.CommandText = "Usp_GetSettingonebySubId";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@LevelId", LevelId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSettingone = new Settingone();
                    objSettingone.SettingId = DataHelper.GetInt(dataReader, "SettingId");
                    objSettingone.FunctionId = DataHelper.GetInt(dataReader, "FunctionId");
                    objSettingone.LevelId = DataHelper.GetInt(dataReader, "LevelId");
                    objSettingone.Timelimit = DataHelper.GetDecimal(dataReader, "Timelimit");
                    objSettingone.NumberofQuestionperpage = DataHelper.GetInt(dataReader, "NumberofQuestionperpage");
                    objSettingone.PassScore = DataHelper.GetInt(dataReader, "PassScore");
                    objSettingone.PassScoreMsg = DataHelper.GetString(dataReader, "PassScoreMsg");
                    objSettingone.FailScoreMsg = DataHelper.GetString(dataReader, "FailScoreMsg");
                    objSettingone.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    objSettingone.Insertedon = DataHelper.GetDateTime(dataReader, "Insertedon");
                    objSettingone.Updatedby = DataHelper.GetInt(dataReader, "Updatedby");
                    objSettingone.Updatedon = DataHelper.GetDateTime(dataReader, "Updatedon");
                    objSettingone.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    objSettingone.Setmarks = DataHelper.GetInt(dataReader, "Setmarks");
                    objSettingone.TitleForExam = DataHelper.GetString(dataReader, "TitleForExam");
                    objSettingone.QuestionSet = DataHelper.GetString(dataReader, "QuestionSet");
                    objSettingone.Start_Date = DataHelper.GetDateTime(dataReader, "Start_Date");
                    objSettingone.End_Date = DataHelper.GetDateTime(dataReader, "End_Date");
                    objSettingone.Commentest = DataHelper.GetString(dataReader, "Commontest");
                    objSettingone.Manual = DataHelper.GetInt(dataReader, "Manual");
                    objSettingone.TitleId = DataHelper.GetInt(dataReader, "TitleId");
                    objSettingone.Interview = DataHelper.GetInt(dataReader, "Interview"); 




                }
            }

            return objSettingone;

        }

        internal static Settingone GetcountuserbySetting(int SetId)
        {
            SqlCommand comm = new SqlCommand();
            Settingone objSettingone = null;
            comm.CommandText = "usp_GetcountuserbySetting";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@SettingId", SetId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSettingone = new Settingone();
                    objSettingone.SettingId = DataHelper.GetInt(dataReader, "Usercount");
                   

              




                }
            }

            return objSettingone;

        }

        internal static Settingone GetcountuserAttemptbySetting(int SetId)
        {
            SqlCommand comm = new SqlCommand();
            Settingone objSettingone = null;
            comm.CommandText = "usp_GetcountuserAttemptbySetting";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@SettingId", SetId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSettingone = new Settingone();
                    objSettingone.SettingId = DataHelper.GetInt(dataReader, "UserAttempt");







                }
            }

            return objSettingone;

        }


        
        public static List<Settingone> GetAllByLevelId(int LevelId)
        {
            SqlCommand comm = new SqlCommand();
            Settingone objSettingone = null;
            List<Settingone> SettingoneList = new List<Settingone>();
            comm.CommandText = "Usp_GetSettingonebySubId";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@LevelId", LevelId);
            comm.Parameters.Add(p);


            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSettingone = new Settingone();
                    objSettingone.SettingId = DataHelper.GetInt(dataReader, "SettingId");
                    objSettingone.FunctionId = DataHelper.GetInt(dataReader, "FunctionId");
                    objSettingone.LevelId = DataHelper.GetInt(dataReader, "LevelId");
                    objSettingone.Timelimit = DataHelper.GetDecimal(dataReader, "Timelimit");
                    objSettingone.NumberofQuestionperpage = DataHelper.GetInt(dataReader, "NumberofQuestionperpage");
                    objSettingone.PassScore = DataHelper.GetInt(dataReader, "PassScore");
                    objSettingone.PassScoreMsg = DataHelper.GetString(dataReader, "PassScoreMsg");
                    objSettingone.FailScoreMsg = DataHelper.GetString(dataReader, "FailScoreMsg");
                    objSettingone.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    objSettingone.Insertedon = DataHelper.GetDateTime(dataReader, "Insertedon");
                    objSettingone.Updatedby = DataHelper.GetInt(dataReader, "Updatedby");
                    objSettingone.Updatedon = DataHelper.GetDateTime(dataReader, "Updatedon");
                    objSettingone.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    objSettingone.Setmarks = DataHelper.GetInt(dataReader, "Setmarks");
                    objSettingone.TitleForExam = DataHelper.GetString(dataReader, "TitleForExam");
                    objSettingone.QuestionSet = DataHelper.GetString(dataReader, "QuestionSet");
                    objSettingone.Commentest = DataHelper.GetString(dataReader, "Commontest");
                    objSettingone.Manual = DataHelper.GetInt(dataReader, "Manual");
                    objSettingone.TitleId = DataHelper.GetInt(dataReader, "TitleId"); 
                    SettingoneList.Add(objSettingone);
                }
            }

            return SettingoneList;

        }

        public static List<Settingone> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            Settingone objSettingone = null;
            List<Settingone> SettingoneList = new List<Settingone>();
            comm.CommandText = "usp_GetAllSettingone";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSettingone = new Settingone();
                    objSettingone.SettingId= DataHelper.GetInt(dataReader, "SettingId"); 
objSettingone.FunctionId= DataHelper.GetInt(dataReader, "FunctionId"); 
objSettingone.LevelId= DataHelper.GetInt(dataReader, "LevelId"); 
objSettingone.Timelimit= DataHelper.GetDecimal(dataReader, "Timelimit"); 
objSettingone.NumberofQuestionperpage= DataHelper.GetInt(dataReader, "NumberofQuestionperpage"); 
objSettingone.PassScore= DataHelper.GetInt(dataReader, "PassScore"); 
objSettingone.PassScoreMsg= DataHelper.GetString(dataReader, "PassScoreMsg"); 
objSettingone.FailScoreMsg= DataHelper.GetString(dataReader, "FailScoreMsg"); 
objSettingone.Insertedby= DataHelper.GetInt(dataReader, "Insertedby"); 
objSettingone.Insertedon= DataHelper.GetDateTime(dataReader, "Insertedon"); 
objSettingone.Updatedby= DataHelper.GetInt(dataReader, "Updatedby"); 
objSettingone.Updatedon= DataHelper.GetDateTime(dataReader, "Updatedon"); 
objSettingone.Deactive= DataHelper.GetInt(dataReader, "Deactive"); 
objSettingone.Setmarks= DataHelper.GetInt(dataReader, "Setmarks");
objSettingone.TitleForExam = DataHelper.GetString(dataReader, "TitleForExam");
objSettingone.QuestionSet = DataHelper.GetString(dataReader, "QuestionSet");
objSettingone.Start_Date = DataHelper.GetDateTime(dataReader, "Start_Date");
objSettingone.End_Date = DataHelper.GetDateTime(dataReader, "End_Date");
objSettingone.Commentest = DataHelper.GetString(dataReader, "Commontest");
objSettingone.Manual = DataHelper.GetInt(dataReader, "Manual");
objSettingone.TitleId = DataHelper.GetInt(dataReader, "TitleId");
objSettingone.Interview = DataHelper.GetInt(dataReader, "Interview"); 

                    SettingoneList.Add(objSettingone);
                }
            }

            return SettingoneList;

        }
        public static List<Settingone> GetAll(int userid)
        {
            SqlCommand comm = new SqlCommand();
            Settingone objSettingone = null;
            List<Settingone> SettingoneList = new List<Settingone>();
            comm.CommandText = "usp_countattemptsperlevel";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@userid", userid);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSettingone = new Settingone();
                    objSettingone.SettingId = DataHelper.GetInt(dataReader, "SettingId");
                    //objSettingone.FunctionId = DataHelper.GetInt(dataReader, "FunctionId");
                    //objSettingone.LevelId = DataHelper.GetInt(dataReader, "LevelId");
                    //objSettingone.Timelimit = DataHelper.GetDecimal(dataReader, "Timelimit");
                    //objSettingone.NumberofQuestionperpage = DataHelper.GetInt(dataReader, "NumberofQuestionperpage");
                    //objSettingone.PassScore = DataHelper.GetInt(dataReader, "PassScore");
                    //objSettingone.PassScoreMsg = DataHelper.GetString(dataReader, "PassScoreMsg");
                    //objSettingone.FailScoreMsg = DataHelper.GetString(dataReader, "FailScoreMsg");
                    //objSettingone.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    //objSettingone.Insertedon = DataHelper.GetDateTime(dataReader, "Insertedon");
                    //objSettingone.Updatedby = DataHelper.GetInt(dataReader, "Updatedby");
                    //objSettingone.Updatedon = DataHelper.GetDateTime(dataReader, "Updatedon");
                    //objSettingone.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    //objSettingone.Setmarks = DataHelper.GetInt(dataReader, "Setmarks");
                    objSettingone.TitleForExam = DataHelper.GetString(dataReader, "TitleForExam");
                    //objSettingone.QuestionSet = DataHelper.GetString(dataReader, "QuestionSet");
                    //objSettingone.Start_Date = DataHelper.GetDateTime(dataReader, "Start_Date");
                    //objSettingone.End_Date = DataHelper.GetDateTime(dataReader, "End_Date");
                    //objSettingone.Technical = DataHelper.GetString(dataReader, "Technical");




                    SettingoneList.Add(objSettingone);
                }
            }

            return SettingoneList;

        }

 public static List<Settingone> GetAllByLevelId2(int UserId)
        {
            SqlCommand comm = new SqlCommand();
            Settingone objSettingone = null;
            List<Settingone> SettingoneList = new List<Settingone>();
            comm.CommandText = "Usp_GetSettingonebySubId2";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter   p = new SqlParameter("@UserId", @UserId);
            comm.Parameters.Add(p);



            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSettingone = new Settingone();
                    objSettingone.SettingId = DataHelper.GetInt(dataReader, "SettingId");
                    objSettingone.FunctionId = DataHelper.GetInt(dataReader, "FunctionId");
                    objSettingone.LevelId = DataHelper.GetInt(dataReader, "LevelId");
                    objSettingone.Timelimit = DataHelper.GetDecimal(dataReader, "Timelimit");
                    objSettingone.NumberofQuestionperpage = DataHelper.GetInt(dataReader, "NumberofQuestionperpage");
                    objSettingone.PassScore = DataHelper.GetInt(dataReader, "PassScore");
                    objSettingone.PassScoreMsg = DataHelper.GetString(dataReader, "PassScoreMsg");
                    objSettingone.FailScoreMsg = DataHelper.GetString(dataReader, "FailScoreMsg");
                    objSettingone.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    objSettingone.Insertedon = DataHelper.GetDateTime(dataReader, "Insertedon");
                    objSettingone.Updatedby = DataHelper.GetInt(dataReader, "Updatedby");
                    objSettingone.Updatedon = DataHelper.GetDateTime(dataReader, "Updatedon");
                    objSettingone.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    objSettingone.Setmarks = DataHelper.GetInt(dataReader, "Setmarks");
                    objSettingone.TitleForExam = DataHelper.GetString(dataReader, "TitleForExam");
                    objSettingone.QuestionSet = DataHelper.GetString(dataReader, "QuestionSet");
                    objSettingone.Start_Date = DataHelper.GetDateTime(dataReader, "Start_Date");
                    objSettingone.End_Date = DataHelper.GetDateTime(dataReader, "End_Date");
                    objSettingone.Commentest = DataHelper.GetString(dataReader, "Commontest");
                    objSettingone.Manual = DataHelper.GetInt(dataReader, "Manual");

                    objSettingone.TitleId = DataHelper.GetInt(dataReader, "TitleId");

                    objSettingone.Interview = DataHelper.GetInt(dataReader, "Interview"); 
                    SettingoneList.Add(objSettingone);
                }
            }

            return SettingoneList;

        }

        


           public static List<Settingone> Getinterviewlist(int Id)
        {
            SqlCommand comm = new SqlCommand();
            Settingone objSettingone = null;
            List<Settingone> SettingoneList = new List<Settingone>();
            comm.CommandText = "usp_getinterviewlist";
            comm.CommandType = System.Data.CommandType.StoredProcedure;


            SqlParameter p = new SqlParameter("@Id",Id);
            comm.Parameters.Add(p);
           

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSettingone = new Settingone();
                    objSettingone.SettingId = DataHelper.GetInt(dataReader, "SettingId");
                    objSettingone.FunctionId = DataHelper.GetInt(dataReader, "FunctionId");
                    objSettingone.LevelId = DataHelper.GetInt(dataReader, "LevelId");
                    objSettingone.Timelimit = DataHelper.GetDecimal(dataReader, "Timelimit");
                    objSettingone.NumberofQuestionperpage = DataHelper.GetInt(dataReader, "NumberofQuestionperpage");
                    objSettingone.PassScore = DataHelper.GetInt(dataReader, "PassScore");
                    objSettingone.PassScoreMsg = DataHelper.GetString(dataReader, "PassScoreMsg");
                    objSettingone.FailScoreMsg = DataHelper.GetString(dataReader, "FailScoreMsg");
                    objSettingone.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    objSettingone.Insertedon = DataHelper.GetDateTime(dataReader, "Insertedon");
                    objSettingone.Updatedby = DataHelper.GetInt(dataReader, "Updatedby");
                    objSettingone.Updatedon = DataHelper.GetDateTime(dataReader, "Updatedon");
                    objSettingone.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    objSettingone.Setmarks = DataHelper.GetInt(dataReader, "Setmarks");
                    objSettingone.TitleForExam = DataHelper.GetString(dataReader, "TitleForExam");
                    objSettingone.QuestionSet = DataHelper.GetString(dataReader, "QuestionSet");
                    objSettingone.Start_Date = DataHelper.GetDateTime(dataReader, "Start_Date");
                    objSettingone.End_Date = DataHelper.GetDateTime(dataReader, "End_Date");
                    objSettingone.Commentest = DataHelper.GetString(dataReader, "Commontest");
                    objSettingone.Manual = DataHelper.GetInt(dataReader, "Manual");

                    objSettingone.TitleId = DataHelper.GetInt(dataReader, "TitleId");

                    objSettingone.Interview = DataHelper.GetInt(dataReader, "Interview"); 
                    SettingoneList.Add(objSettingone);
                }
            }

            return SettingoneList;

        }
 public static List<Settingone> Getinterview(int Id, int userId)
        {
            SqlCommand comm = new SqlCommand();
            Settingone objSettingone = null;
            List<Settingone> SettingoneList = new List<Settingone>();
            comm.CommandText = "usp_getinterview";
            comm.CommandType = System.Data.CommandType.StoredProcedure;


            SqlParameter p = new SqlParameter("@Id",Id);
            comm.Parameters.Add(p);
            p = new SqlParameter("@userId", userId);
            comm.Parameters.Add(p);
    

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSettingone = new Settingone();
                    objSettingone.SettingId = DataHelper.GetInt(dataReader, "SettingId");
                    objSettingone.FunctionId = DataHelper.GetInt(dataReader, "FunctionId");
                    objSettingone.LevelId = DataHelper.GetInt(dataReader, "LevelId");
                    objSettingone.Timelimit = DataHelper.GetDecimal(dataReader, "Timelimit");
                    objSettingone.NumberofQuestionperpage = DataHelper.GetInt(dataReader, "NumberofQuestionperpage");
                    objSettingone.PassScore = DataHelper.GetInt(dataReader, "PassScore");
                    objSettingone.PassScoreMsg = DataHelper.GetString(dataReader, "PassScoreMsg");
                    objSettingone.FailScoreMsg = DataHelper.GetString(dataReader, "FailScoreMsg");
                    objSettingone.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    objSettingone.Insertedon = DataHelper.GetDateTime(dataReader, "Insertedon");
                    objSettingone.Updatedby = DataHelper.GetInt(dataReader, "Updatedby");
                    objSettingone.Updatedon = DataHelper.GetDateTime(dataReader, "Updatedon");
                    objSettingone.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    objSettingone.Setmarks = DataHelper.GetInt(dataReader, "Setmarks");
                    objSettingone.TitleForExam = DataHelper.GetString(dataReader, "TitleForExam");
                    objSettingone.QuestionSet = DataHelper.GetString(dataReader, "QuestionSet");
                    objSettingone.Start_Date = DataHelper.GetDateTime(dataReader, "Start_Date");
                    objSettingone.End_Date = DataHelper.GetDateTime(dataReader, "End_Date");
                    objSettingone.Commentest = DataHelper.GetString(dataReader, "Commontest");
                    objSettingone.Manual = DataHelper.GetInt(dataReader, "Manual");

                    objSettingone.TitleId = DataHelper.GetInt(dataReader, "TitleId");

                    objSettingone.Interview = DataHelper.GetInt(dataReader, "Interview"); 
                    SettingoneList.Add(objSettingone);
                }
            }

            return SettingoneList;

        }

 public static List<Settingone> GetAllByLevelIdCommon(int UserId)
 {
     SqlCommand comm = new SqlCommand();
     Settingone objSettingone = null;
     List<Settingone> SettingoneList = new List<Settingone>();
     comm.CommandText = "Usp_GetSettingonebySubIdCommon";
     comm.CommandType = System.Data.CommandType.StoredProcedure;

     SqlParameter p = new SqlParameter("@UserId", @UserId);
     comm.Parameters.Add(p);



     using (IDataReader dataReader = DataConnector.GetDataReader(comm))
     {
         while (dataReader.Read())
         {
             objSettingone = new Settingone();
             objSettingone.SettingId = DataHelper.GetInt(dataReader, "SettingId");
             objSettingone.FunctionId = DataHelper.GetInt(dataReader, "FunctionId");
             objSettingone.LevelId = DataHelper.GetInt(dataReader, "LevelId");
             objSettingone.Timelimit = DataHelper.GetDecimal(dataReader, "Timelimit");
             objSettingone.NumberofQuestionperpage = DataHelper.GetInt(dataReader, "NumberofQuestionperpage");
             objSettingone.PassScore = DataHelper.GetInt(dataReader, "PassScore");
             objSettingone.PassScoreMsg = DataHelper.GetString(dataReader, "PassScoreMsg");
             objSettingone.FailScoreMsg = DataHelper.GetString(dataReader, "FailScoreMsg");
             objSettingone.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
             objSettingone.Insertedon = DataHelper.GetDateTime(dataReader, "Insertedon");
             objSettingone.Updatedby = DataHelper.GetInt(dataReader, "Updatedby");
             objSettingone.Updatedon = DataHelper.GetDateTime(dataReader, "Updatedon");
             objSettingone.Deactive = DataHelper.GetInt(dataReader, "Deactive");
             objSettingone.Setmarks = DataHelper.GetInt(dataReader, "Setmarks");
             objSettingone.TitleForExam = DataHelper.GetString(dataReader, "TitleForExam");
             objSettingone.QuestionSet = DataHelper.GetString(dataReader, "QuestionSet");
             objSettingone.Start_Date = DataHelper.GetDateTime(dataReader, "Start_Date");
             objSettingone.End_Date = DataHelper.GetDateTime(dataReader, "End_Date");
             objSettingone.Commentest = DataHelper.GetString(dataReader, "Commontest");
             objSettingone.Manual = DataHelper.GetInt(dataReader, "Manual");
             objSettingone.TitleId = DataHelper.GetInt(dataReader, "TitleId");

             objSettingone.Interview = DataHelper.GetInt(dataReader, "Interview"); 
             SettingoneList.Add(objSettingone);
         }
     }

     return SettingoneList;

 }
        

        public static List<Settingone> GetAllByLevelId1(int LevelId,int UserId)
        {
            SqlCommand comm = new SqlCommand();
            Settingone objSettingone = null;
            List<Settingone> SettingoneList = new List<Settingone>();
            comm.CommandText = "Usp_GetSettingonebySubId1";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@SubId", LevelId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@UserId", @UserId);
            comm.Parameters.Add(p);



            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSettingone = new Settingone();
                    objSettingone.SettingId = DataHelper.GetInt(dataReader, "SettingId");
                    objSettingone.FunctionId = DataHelper.GetInt(dataReader, "FunctionId");
                    objSettingone.LevelId = DataHelper.GetInt(dataReader, "LevelId");
                    objSettingone.Timelimit = DataHelper.GetDecimal(dataReader, "Timelimit");
                    objSettingone.NumberofQuestionperpage = DataHelper.GetInt(dataReader, "NumberofQuestionperpage");
                    objSettingone.PassScore = DataHelper.GetInt(dataReader, "PassScore");
                    objSettingone.PassScoreMsg = DataHelper.GetString(dataReader, "PassScoreMsg");
                    objSettingone.FailScoreMsg = DataHelper.GetString(dataReader, "FailScoreMsg");
                    objSettingone.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    objSettingone.Insertedon = DataHelper.GetDateTime(dataReader, "Insertedon");
                    objSettingone.Updatedby = DataHelper.GetInt(dataReader, "Updatedby");
                    objSettingone.Updatedon = DataHelper.GetDateTime(dataReader, "Updatedon");
                    objSettingone.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    objSettingone.Setmarks = DataHelper.GetInt(dataReader, "Setmarks");
                    objSettingone.TitleForExam = DataHelper.GetString(dataReader, "TitleForExam");
                    objSettingone.QuestionSet = DataHelper.GetString(dataReader, "QuestionSet");
                    objSettingone.Start_Date = DataHelper.GetDateTime(dataReader, "Start_Date");
                    objSettingone.End_Date = DataHelper.GetDateTime(dataReader, "End_Date");
                    objSettingone.Commentest = DataHelper.GetString(dataReader, "Commontest");
                    objSettingone.Manual = DataHelper.GetInt(dataReader, "Manual");

                    objSettingone.TitleId = DataHelper.GetInt(dataReader, "TitleId");
                    objSettingone.Interview = DataHelper.GetInt(dataReader, "Interview"); 

                    SettingoneList.Add(objSettingone);
                }
            }

            return SettingoneList;

        }
        //Usp_GetSettingonebyLevelId1(@LevelId int,@UserId int)
    }

}





