using System;
using System.Collections.Generic;
using System.Text;
//using Bll;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL

{
   //Date : 14/12/2010
    //Description : Business class
    public class Exam_Mst
    {

        
    #region Private Properties
 	
	private int _ExamId;
	private int _SubjectId;
	private string _StudentId;
	private int _QuestionId;
	private int _GivenAnswer;
	private int _StudentAnswer;
	private string _TimeAllowed;
    private int _SetId;
    private string _Guid;

   
 
 #endregion
    #region Public Properties
    public int SetId
    {
        get { return _SetId; }
        set { _SetId = value; }
    }
	public int ExamId
	{
		get
		{
			return _ExamId;
		}
		set
		{
			_ExamId = value;
		}
	}

	public int SubjectId
	{
		get
		{
			return _SubjectId;
		}
		set
		{
			_SubjectId = value;
		}
	}

	public string StudentId
	{
		get
		{
			return _StudentId;
		}
		set
		{
			_StudentId = value;
		}
	}

	public int QuestionId
	{
		get
		{
			return _QuestionId;
		}
		set
		{
			_QuestionId = value;
		}
	}

    public string Guid
    {
        get { return _Guid; }
        set { _Guid = value; }
    }


	public int GivenAnswer
	{
		get
		{
			return _GivenAnswer;
		}
		set
		{
			_GivenAnswer = value;
		}
	}

	public int StudentAnswer
	{
		get
		{
			return _StudentAnswer;
		}
		set
		{
			_StudentAnswer = value;
		}
	}

	public string TimeAllowed
	{
		get
		{
			return _TimeAllowed;
		}
		set
		{
			_TimeAllowed = value;
		}
	}

 
 #endregion
    }
    public class Exam_MstManager
    {
        public enum Exam_MstOperationResult
        {
            Exam_Mst_EXISTS,
            Exam_Mst_ADDED
        }
        //public const string USER_EXISTS = "Exam_Mst_EXISTS";
        //public const string USER_ADDED = "Exam_Mst_ADDED";
        private Exam_MstDAL objExam_MstDAL = new Exam_MstDAL();

        public static Exam_MstOperationResult Add(Exam_Mst objExam_Mst)
        {

            int returnValue = Exam_MstDAL.Add(objExam_Mst);
            if (returnValue == 0)
                return Exam_MstOperationResult.Exam_Mst_EXISTS;
            else
                return Exam_MstOperationResult.Exam_Mst_ADDED;
        }
        public static Exam_MstOperationResult Update(Exam_Mst objExam_Mst)
        {
            int returnValue = Exam_MstDAL.Update(objExam_Mst);
            if (returnValue == 0)
                return Exam_MstOperationResult.Exam_Mst_EXISTS;
            else
                return Exam_MstOperationResult.Exam_Mst_ADDED;
        }
        public static void Delete(int Exam_MstId)
        {
            Exam_MstDAL.Delete(Exam_MstId);
        }
        public static Exam_Mst Select(int Exam_MstId)
        {
            return Exam_MstDAL.Select(Exam_MstId);
        }
        public static List<Exam_Mst> GetAll()
        {
            return Exam_MstDAL.GetAll();
        }
        public static DataSet GetResultByGuid(string Guid)
        {

            return Exam_MstDAL.GetResultByGuid1(Guid);
        }

        public static DataSet GetExamDetailGuid(string Guid,int QuestionId)
        {

            return Exam_MstDAL.GetExamDetailGuid(Guid,QuestionId);
        }

        public static DataSet GetResultReport(int SettingId)
        {

            return Exam_MstDAL.GetResultReport(SettingId);
        }
        public static DataSet GetResultReport1(int SettingId)
        {

            return Exam_MstDAL.GetResultReport1(SettingId);
        }

        public static DataSet GetResultReport_new(int Id)
        {

            return Exam_MstDAL.GetResultReport_new(Id);
        }

        public static DataSet GetStudentHistory(int userId, int SetId)
        {

            return Exam_MstDAL.GetStudentHistory(userId,SetId);
        }
        
        
        
    }

    public class Exam_MstDAL
    {
        internal static int Add(Exam_Mst objExam_Mst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_AddExam";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

          SqlParameter  p = new SqlParameter("@SubjectId", objExam_Mst.SubjectId);
	      comm.Parameters.Add(p);
          p = new SqlParameter("@StudentId", objExam_Mst.StudentId);
	      comm.Parameters.Add(p);
          p = new SqlParameter("@QuestionId", objExam_Mst.QuestionId);
	         comm.Parameters.Add(p);
          p = new SqlParameter("@GivenAnswer", objExam_Mst.GivenAnswer);
	         comm.Parameters.Add(p);
          p = new SqlParameter("@StudentAnswer", objExam_Mst.StudentAnswer);
	         comm.Parameters.Add(p);
          p = new SqlParameter("@TimeAllowed", objExam_Mst.TimeAllowed);
	         comm.Parameters.Add(p);
          p = new SqlParameter("@SetId", objExam_Mst.SetId);
          comm.Parameters.Add(p);
          // New Parameter Added  
          p = new SqlParameter("@guid", objExam_Mst.Guid);
            comm.Parameters.Add(p);
          
            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }



        internal static int Update(Exam_Mst objExam_Mst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateExam_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@ExamId", objExam_Mst.ExamId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@SubjectId", objExam_Mst.SubjectId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@StudentId", objExam_Mst.StudentId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@QuestionId", objExam_Mst.QuestionId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@GivenAnswer", objExam_Mst.GivenAnswer);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@StudentAnswer", objExam_Mst.StudentAnswer);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@TimeAllowed", objExam_Mst.TimeAllowed);
	 comm.Parameters.Add(p);
     p = new SqlParameter("@SetId", objExam_Mst.SetId);
     comm.Parameters.Add(p);
            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int Exam_MstId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteExam_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Exam_MstId", Exam_MstId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static Exam_Mst Select(int Exam_MstId)
        {
            SqlCommand comm = new SqlCommand();
            Exam_Mst objExam_Mst = null;           
            comm.CommandText = "usp_selectExam_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Exam_MstId", Exam_MstId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objExam_Mst = new Exam_Mst();
                    objExam_Mst.ExamId= DataHelper.GetInt(dataReader, "ExamId"); 
objExam_Mst.SubjectId= DataHelper.GetInt(dataReader, "SubjectId"); 
objExam_Mst.StudentId= DataHelper.GetString(dataReader, "StudentId"); 
objExam_Mst.QuestionId= DataHelper.GetInt(dataReader, "QuestionId"); 
objExam_Mst.GivenAnswer= DataHelper.GetInt(dataReader, "GivenAnswer"); 
objExam_Mst.StudentAnswer= DataHelper.GetInt(dataReader, "StudentAnswer"); 
objExam_Mst.TimeAllowed= DataHelper.GetString(dataReader, "TimeAllowed");

objExam_Mst.SetId = DataHelper.GetInt(dataReader, "SetId"); 
                    
                }
            }

            return objExam_Mst;

        }

        public static List<Exam_Mst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            Exam_Mst objExam_Mst = null;
            List<Exam_Mst> Exam_MstList = new List<Exam_Mst>();
            comm.CommandText = "usp_GetAllExam_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objExam_Mst = new Exam_Mst();
                    objExam_Mst.ExamId= DataHelper.GetInt(dataReader, "ExamId"); 
                    objExam_Mst.SubjectId= DataHelper.GetInt(dataReader, "SubjectId"); 
                    objExam_Mst.StudentId= DataHelper.GetString(dataReader, "StudentId"); 
                    objExam_Mst.QuestionId= DataHelper.GetInt(dataReader, "QuestionId"); 
                    objExam_Mst.GivenAnswer= DataHelper.GetInt(dataReader, "GivenAnswer"); 
                    objExam_Mst.StudentAnswer= DataHelper.GetInt(dataReader, "StudentAnswer"); 
                    objExam_Mst.TimeAllowed= DataHelper.GetString(dataReader, "TimeAllowed");

                    objExam_Mst.SetId = DataHelper.GetInt(dataReader, "SetId"); 

                    Exam_MstList.Add(objExam_Mst);
                }
            }

            return Exam_MstList;

        }


        public static DataSet GetResultByGuid1(string Guid)
        {
            return DataConnector.GetDataSet("usp_GetResultByGuid '" + Guid + "'");
        }
       // usp_GetResultByGuid(@Guid nvarchar(100))


        public static DataSet GetExamDetailGuid(string Guid,int QuestionId)
        {
            return DataConnector.GetDataSet("usp_GetExamDetailGuid '" + Guid + "','"+ QuestionId +"'" );
        }
        //usp_GetExamDetailGuid(@Guid nvarchar(100))
        //usp_GetResultReport  //old
        public static DataSet GetResultReport(int SettingId)
        {
            return DataConnector.GetDataSet("usp_GetResultReport " + SettingId);
        }
         public static DataSet GetResultReport1(int SettingId)
        {
            return DataConnector.GetDataSet("usp_GetResultReport1 " + SettingId);
        }

         public static DataSet GetResultReport_new(int Id)
        {
            return DataConnector.GetDataSet("usp_GetResultReport_new "+Id);
        }

     

        public static DataSet GetStudentHistory(int userId,int SetId)
        {
            return DataConnector.GetDataSet("usp_GetStudentHistory "+userId+","+SetId);
        }
    }

}





