using System;
using System.Collections.Generic;
using System.Text;
//using Bll;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL
{
   
    public class Subject_Mst
    {

        
#region Private Properties
 	
	private int _Subject_id;
	private string _Subject_Code;
	private string _Subject_Name;
 
 #endregion
 #region Public Properties
 	
	public int Subject_id
	{
		get
		{
			return _Subject_id;
		}
		set
		{
			_Subject_id = value;
		}
	}

	public string Subject_Code
	{
		get
		{
			return _Subject_Code;
		}
		set
		{
			_Subject_Code = value;
		}
	}

	public string Subject_Name
	{
		get
		{
			return _Subject_Name;
		}
		set
		{
			_Subject_Name = value;
		}
	}

 
 #endregion
    }
    public class Subject_MstManager
    {
        public enum Subject_MstOperationResult
        {
            Subject_Mst_EXISTS,
            Subject_Mst_ADDED
        }
        //public const string USER_EXISTS = "Subject_Mst_EXISTS";
        //public const string USER_ADDED = "Subject_Mst_ADDED";
        private Subject_MstDAL objSubject_MstDAL = new Subject_MstDAL();

        public static Subject_MstOperationResult Add(Subject_Mst objSubject_Mst)
        {

            int returnValue = Subject_MstDAL.Add(objSubject_Mst);
            if (returnValue == 0)
                return Subject_MstOperationResult.Subject_Mst_EXISTS;
            else
                return Subject_MstOperationResult.Subject_Mst_ADDED;
        }
        public static Subject_MstOperationResult Update(Subject_Mst objSubject_Mst)
        {
            int returnValue = Subject_MstDAL.Update(objSubject_Mst);
            if (returnValue == 0)
                return Subject_MstOperationResult.Subject_Mst_EXISTS;
            else
                return Subject_MstOperationResult.Subject_Mst_ADDED;
        }
        public static void Delete(int Subject_Id)
        {
            Subject_MstDAL.Delete(Subject_Id);
        }
        public static Subject_Mst Select(int Subject_Id)
        {
            return Subject_MstDAL.Select(Subject_Id);
        }
        public static List<Subject_Mst> GetAll()
        {
            return Subject_MstDAL.GetAll();
        }

       
        public static DataSet GetPhysicTest()
        {
            DataSet dr;

            dr = DataConnector.GetDataSet("usp_GetPhysicTest ");


            return dr;

        }
    }

    public class Subject_MstDAL
    {
        internal static int Add(Subject_Mst objSubject_Mst)
        {int SubjectId;
        try
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_AddSubject";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Subject_Code", objSubject_Mst.Subject_Code);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Subject_Name", objSubject_Mst.Subject_Name);
            comm.Parameters.Add(p);

            SubjectId = Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        catch (Exception ex)
        {
            throw ex;
        }
        return SubjectId;

        }
        internal static int Update(Subject_Mst objSubject_Mst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateSubject";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@Subject_id", objSubject_Mst.Subject_id);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Subject_Code", objSubject_Mst.Subject_Code);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Subject_Name", objSubject_Mst.Subject_Name);
	 comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int Subject_Id)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_DeleteSubject";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Subject_Id", Subject_Id);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static Subject_Mst Select(int Subject_Id)
        {
            SqlCommand comm = new SqlCommand();
            Subject_Mst objSubject_Mst = null;
            comm.CommandText = "usp_SelectSubject";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Subject_Id", Subject_Id);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSubject_Mst = new Subject_Mst();
                    objSubject_Mst.Subject_id= DataHelper.GetInt(dataReader, "Subject_id"); 
objSubject_Mst.Subject_Code= DataHelper.GetString(dataReader, "Subject_Code"); 
objSubject_Mst.Subject_Name= DataHelper.GetString(dataReader, "Subject_Name"); 


                    
                }
            }

            return objSubject_Mst;

        }

        public static List<Subject_Mst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            Subject_Mst objSubject_Mst = null;
            List<Subject_Mst> Subject_MstList = new List<Subject_Mst>();
            comm.CommandText = "usp_GetAllSubject";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSubject_Mst = new Subject_Mst();
                    objSubject_Mst.Subject_id= DataHelper.GetInt(dataReader, "Subject_id"); 
objSubject_Mst.Subject_Code= DataHelper.GetString(dataReader, "Subject_Code"); 
objSubject_Mst.Subject_Name= DataHelper.GetString(dataReader, "Subject_Name"); 


                    Subject_MstList.Add(objSubject_Mst);
                }
            }

            return Subject_MstList;

        }
    }

    //-------------------------------------

    public class Lesson_Mst
    {


        #region Private Properties

        private int _LessonId;
        private int _LNo;
        private int _SubjectId;
        private string _Topics;
        private int _InsertedBy;
        private DateTime _InsertedOn;
        private string _UpdatedBy;
        private DateTime _UpdatedOn;
        private bool _Deactive;

        #endregion
        #region Public Properties

        public int LessonId
        {
            get
            {
                return _LessonId;
            }
            set
            {
                _LessonId = value;
            }
        }

        public int LNo
        {
            get
            {
                return _LNo;
            }
            set
            {
                _LNo = value;
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

        public string Topics
        {
            get
            {
                return _Topics;
            }
            set
            {
                _Topics = value;
            }
        }

        public int InsertedBy
        {
            get
            {
                return _InsertedBy;
            }
            set
            {
                _InsertedBy = value;
            }
        }

        public DateTime InsertedOn
        {
            get
            {
                return _InsertedOn;
            }
            set
            {
                _InsertedOn = value;
            }
        }

        public string UpdatedBy
        {
            get
            {
                return _UpdatedBy;
            }
            set
            {
                _UpdatedBy = value;
            }
        }

        public DateTime UpdatedOn
        {
            get
            {
                return _UpdatedOn;
            }
            set
            {
                _UpdatedOn = value;
            }
        }

        public bool Deactive
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


        #endregion
    }
    public class Lesson_MstManager
    {
        public enum Lesson_MstOperationResult
        {
            Lesson_Mst_EXISTS,
            Lesson_Mst_ADDED
        }
        //public const string USER_EXISTS = "Lesson_Mst_EXISTS";
        //public const string USER_ADDED = "Lesson_Mst_ADDED";
        private Lesson_MstDAL objLesson_MstDAL = new Lesson_MstDAL();

        public static Lesson_MstOperationResult Add(Lesson_Mst objLesson_Mst)
        {

            int returnValue = Lesson_MstDAL.Add(objLesson_Mst);
            if (returnValue == 0)
                return Lesson_MstOperationResult.Lesson_Mst_EXISTS;
            else
                return Lesson_MstOperationResult.Lesson_Mst_ADDED;
        }
        public static Lesson_MstOperationResult Update(Lesson_Mst objLesson_Mst)
        {
            int returnValue = Lesson_MstDAL.Update(objLesson_Mst);
            if (returnValue == 0)
                return Lesson_MstOperationResult.Lesson_Mst_EXISTS;
            else
                return Lesson_MstOperationResult.Lesson_Mst_ADDED;
        }
        public static void Delete(int LessonId)
        {
            Lesson_MstDAL.Delete(LessonId);
        }
        public static Lesson_Mst Select(int LessonId)
        {
            return Lesson_MstDAL.Select(LessonId);
        }
        public static List<Lesson_Mst> GetAll()
        {
            return Lesson_MstDAL.GetAll();
        }

        //
        public static List<Lesson_Mst> GetLessonBySubjectId(int SubjectId)
        {
            return Lesson_MstDAL.GetLessonBySubjectId(SubjectId);
        }
    }

    public class Lesson_MstDAL
    {
        internal static int Add(Lesson_Mst objLesson_Mst)
        {
            int LessonId;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "usp_AddLesson";
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@LNo", objLesson_Mst.LNo);
                comm.Parameters.Add(p);
                p = new SqlParameter("@SubjectId", objLesson_Mst.SubjectId);
                comm.Parameters.Add(p);
                p = new SqlParameter("@Topics", objLesson_Mst.Topics);
                comm.Parameters.Add(p);
                p = new SqlParameter("@InsertedBy", objLesson_Mst.InsertedBy);
                comm.Parameters.Add(p);



                LessonId= Convert.ToInt32(DataConnector.ExecuteScalar(comm));
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return LessonId;
        }
        internal static int Update(Lesson_Mst objLesson_Mst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateLesson";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@LessonId", objLesson_Mst.LessonId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@LNo", objLesson_Mst.LNo);
            comm.Parameters.Add(p);
            p = new SqlParameter("@SubjectId", objLesson_Mst.SubjectId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Topics", objLesson_Mst.Topics);
            comm.Parameters.Add(p);
           
            p = new SqlParameter("@UpdatedBy", objLesson_Mst.UpdatedBy);
            comm.Parameters.Add(p);
           
            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int LessonId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_DeleteLesson";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@LessonId", LessonId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static Lesson_Mst Select(int LessonId)
        {
            SqlCommand comm = new SqlCommand();
            Lesson_Mst objLesson_Mst = null;
            comm.CommandText = "usp_SelectLesson";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@LessonId", LessonId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objLesson_Mst = new Lesson_Mst();
                    objLesson_Mst.LessonId = DataHelper.GetInt(dataReader, "LessonId");
                    objLesson_Mst.LNo = DataHelper.GetInt(dataReader, "LNo");
                    objLesson_Mst.SubjectId = DataHelper.GetInt(dataReader, "SubjectId");
                    objLesson_Mst.Topics = DataHelper.GetString(dataReader, "Topics");
                    objLesson_Mst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objLesson_Mst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objLesson_Mst.UpdatedBy = DataHelper.GetString(dataReader, "UpdatedBy");
                    objLesson_Mst.UpdatedOn = DataHelper.GetDateTime(dataReader, "UpdatedOn");
                    objLesson_Mst.Deactive = DataHelper.GetBoolean(dataReader, "Deactive");



                }
            }

            return objLesson_Mst;

        }

        public static List<Lesson_Mst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            Lesson_Mst objLesson_Mst = null;
            List<Lesson_Mst> Lesson_MstList = new List<Lesson_Mst>();
            comm.CommandText = "usp_GetAllLesson";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objLesson_Mst = new Lesson_Mst();
                    objLesson_Mst.LessonId = DataHelper.GetInt(dataReader, "LessonId");
                    objLesson_Mst.LNo = DataHelper.GetInt(dataReader, "LNo");
                    objLesson_Mst.SubjectId = DataHelper.GetInt(dataReader, "SubjectId");
                    objLesson_Mst.Topics = DataHelper.GetString(dataReader, "Topics");
                    objLesson_Mst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objLesson_Mst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objLesson_Mst.UpdatedBy = DataHelper.GetString(dataReader, "UpdatedBy");
                    objLesson_Mst.UpdatedOn = DataHelper.GetDateTime(dataReader, "UpdatedOn");
                    objLesson_Mst.Deactive = DataHelper.GetBoolean(dataReader, "Deactive");


                    Lesson_MstList.Add(objLesson_Mst);
                }
            }

            return Lesson_MstList;

        }

        //
        public static List<Lesson_Mst> GetLessonBySubjectId(int SubjectId)
        {
            SqlCommand comm = new SqlCommand();
            Lesson_Mst objLesson_Mst = null;
            List<Lesson_Mst> Lesson_MstList = new List<Lesson_Mst>();
            comm.CommandText = "usp_GetLessonBySubjectId";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@SubjectId",SubjectId);
                  comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objLesson_Mst = new Lesson_Mst();
                    objLesson_Mst.LessonId = DataHelper.GetInt(dataReader, "LessonId");
                    objLesson_Mst.LNo = DataHelper.GetInt(dataReader, "LNo");
                    objLesson_Mst.SubjectId = DataHelper.GetInt(dataReader, "SubjectId");
                    objLesson_Mst.Topics = DataHelper.GetString(dataReader, "Topics");
                    objLesson_Mst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objLesson_Mst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objLesson_Mst.UpdatedBy = DataHelper.GetString(dataReader, "UpdatedBy");
                    objLesson_Mst.UpdatedOn = DataHelper.GetDateTime(dataReader, "UpdatedOn");
                    objLesson_Mst.Deactive = DataHelper.GetBoolean(dataReader, "Deactive");


                    Lesson_MstList.Add(objLesson_Mst);
                }
            }

            return Lesson_MstList;

        }
    }

    //-----------------------------

    public class Question_Mst
    {


        #region Private Properties

        private int _QuestionId;
        private int _SubjectId;
        private int _LessonId;
        private string _Question;
        private string _Option1;
        private string _Option2;
        private string _Option3;
        private string _Option4;
        private string _CorrectAnswer;
        private int _InsertedBy;
        private DateTime _InsertedOn;
        private int _UpdatedBy;
        private DateTime _UpdatedOn;
        private bool _Deactive;
        private string _ImageStatus;

       

        #endregion
        #region Public Properties
        public string ImageStatus
        {
            get { return _ImageStatus; }
            set { _ImageStatus = value; }
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

        public int LessonId
        {
            get
            {
                return _LessonId;
            }
            set
            {
                _LessonId = value;
            }
        }
        public string Question
        {
            get
            {
                return _Question;
            }
            set
            {
                _Question = value;
            }
        }

        public string Option1
        {
            get
            {
                return _Option1;
            }
            set
            {
                _Option1 = value;
            }
        }

        public string Option2
        {
            get
            {
                return _Option2;
            }
            set
            {
                _Option2 = value;
            }
        }

        public string Option3
        {
            get
            {
                return _Option3;
            }
            set
            {
                _Option3 = value;
            }
        }

        public string Option4
        {
            get
            {
                return _Option4;
            }
            set
            {
                _Option4 = value;
            }
        }

        public   string  CorrectAnswer
        {
            get
            {
                return _CorrectAnswer;
            }
            set
            {
                _CorrectAnswer = value;
            }
        }

        public int InsertedBy
        {
            get
            {
                return _InsertedBy;
            }
            set
            {
                _InsertedBy = value;
            }
        }

        public DateTime InsertedOn
        {
            get
            {
                return _InsertedOn;
            }
            set
            {
                _InsertedOn = value;
            }
        }

        public int UpdatedBy
        {
            get
            {
                return _UpdatedBy;
            }
            set
            {
                _UpdatedBy = value;
            }
        }

        public DateTime UpdatedOn
        {
            get
            {
                return _UpdatedOn;
            }
            set
            {
                _UpdatedOn = value;
            }
        }

        public bool Deactive
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


        #endregion
    }
    public class Question_MstManager
    {
        public enum Question_MstOperationResult
        {
            Question_Mst_EXISTS,
            Question_Mst_ADDED
        }
        //public const string USER_EXISTS = "Question_Mst_EXISTS";
        //public const string USER_ADDED = "Question_Mst_ADDED";
        private Question_MstDAL objQuestion_MstDAL = new Question_MstDAL();

        public static Question_MstOperationResult Add(Question_Mst objQuestion_Mst)
        {

            int returnValue = Question_MstDAL.Add(objQuestion_Mst);
            if (returnValue == 0)
                return Question_MstOperationResult.Question_Mst_EXISTS;
            else
                return Question_MstOperationResult.Question_Mst_ADDED;
        }
        public static Question_MstOperationResult Update(Question_Mst objQuestion_Mst)
        {
            int returnValue = Question_MstDAL.Update(objQuestion_Mst);
            if (returnValue == 0)
                return Question_MstOperationResult.Question_Mst_EXISTS;
            else
                return Question_MstOperationResult.Question_Mst_ADDED;
        }
        public static void Delete(int QuestionId)
        {
            Question_MstDAL.Delete(QuestionId);
        }
        public static Question_Mst Select(int QuestionId)
        {
            return Question_MstDAL.Select(QuestionId);
        }
        public static List<Question_Mst> GetAll()
        {
            return Question_MstDAL.GetAll();
        }
        public static List<Question_Mst> usp_GetQuestionBySubjectIdLessonId(int SubjectId, int LessonId)
        {
            return Question_MstDAL.usp_GetQuestionBySubjectIdLessonId(SubjectId, LessonId);
        }
         
    }

    public class Question_MstDAL
    {
        internal static int Add(Question_Mst objQuestion_Mst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_AddQuestion";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter  p = new SqlParameter("@SubjectId", objQuestion_Mst.SubjectId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Question", objQuestion_Mst.Question);
            comm.Parameters.Add(p);
            p = new SqlParameter("@LessonId", objQuestion_Mst.LessonId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option1", objQuestion_Mst.Option1);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option2", objQuestion_Mst.Option2);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option3", objQuestion_Mst.Option3);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option4", objQuestion_Mst.Option4);
            comm.Parameters.Add(p);
            p = new SqlParameter("@CorrectAnswer", objQuestion_Mst.CorrectAnswer);
            comm.Parameters.Add(p);
            p = new SqlParameter("@InsertedBy", objQuestion_Mst.InsertedBy);
            comm.Parameters.Add(p);
           

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int Update(Question_Mst objQuestion_Mst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateQuestion";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@QuestionId", objQuestion_Mst.QuestionId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@SubjectId", objQuestion_Mst.SubjectId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@LessonId", objQuestion_Mst.LessonId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Question", objQuestion_Mst.Question);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option1", objQuestion_Mst.Option1);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option2", objQuestion_Mst.Option2);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option3", objQuestion_Mst.Option3);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option4", objQuestion_Mst.Option4);
            comm.Parameters.Add(p);
            p = new SqlParameter("@CorrectAnswer", objQuestion_Mst.CorrectAnswer);
            comm.Parameters.Add(p);
           
            p = new SqlParameter("@UpdatedBy", objQuestion_Mst.UpdatedBy);
            comm.Parameters.Add(p);
          
            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int QuestionId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_DeleteQuestion";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@QuestionId", QuestionId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static Question_Mst Select(int QuestionId)
        {
            SqlCommand comm = new SqlCommand();
            Question_Mst objQuestion_Mst = null;
            comm.CommandText = "usp_SelectQuestion";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@QuestionId", QuestionId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objQuestion_Mst = new Question_Mst();
                    objQuestion_Mst.QuestionId = DataHelper.GetInt(dataReader, "QuestionId");
                    objQuestion_Mst.SubjectId = DataHelper.GetInt(dataReader, "SubjectId");
                    objQuestion_Mst.LessonId = DataHelper.GetInt(dataReader, "LessonId");
                    objQuestion_Mst.Question = DataHelper.GetString(dataReader, "Question");
                    objQuestion_Mst.Option1 = DataHelper.GetString(dataReader, "Option1");
                    objQuestion_Mst.Option2 = DataHelper.GetString(dataReader, "Option2");
                    objQuestion_Mst.Option3 = DataHelper.GetString(dataReader, "Option3");
                    objQuestion_Mst.Option4 = DataHelper.GetString(dataReader, "Option4");
                    objQuestion_Mst.CorrectAnswer = DataHelper.GetString(dataReader, "CorrectAnswer");
                    objQuestion_Mst.ImageStatus = DataHelper.GetString(dataReader, "ImageStatus");
                    objQuestion_Mst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objQuestion_Mst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objQuestion_Mst.UpdatedBy = DataHelper.GetInt(dataReader, "UpdatedBy");
                    objQuestion_Mst.UpdatedOn = DataHelper.GetDateTime(dataReader, "UpdatedOn");
                    objQuestion_Mst.Deactive = DataHelper.GetBoolean(dataReader, "Deactive");



                }
            }

            return objQuestion_Mst;

        }

        public static List<Question_Mst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            Question_Mst objQuestion_Mst = null;
            List<Question_Mst> Question_MstList = new List<Question_Mst>();
            comm.CommandText = "usp_GetAllQuestion";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objQuestion_Mst = new Question_Mst();
                    objQuestion_Mst.QuestionId = DataHelper.GetInt(dataReader, "QuestionId");
                    objQuestion_Mst.SubjectId = DataHelper.GetInt(dataReader, "SubjectId");
                    objQuestion_Mst.LessonId = DataHelper.GetInt(dataReader, "LessonId");
                    objQuestion_Mst.Question = DataHelper.GetString(dataReader, "Question");
                    objQuestion_Mst.Option1 = DataHelper.GetString(dataReader, "Option1");
                    objQuestion_Mst.Option2 = DataHelper.GetString(dataReader, "Option2");
                    objQuestion_Mst.Option3 = DataHelper.GetString(dataReader, "Option3");
                    objQuestion_Mst.Option4 = DataHelper.GetString(dataReader, "Option4");
                    objQuestion_Mst.CorrectAnswer = DataHelper.GetString(dataReader, "CorrectAnswer");
                    objQuestion_Mst.ImageStatus = DataHelper.GetString(dataReader, "ImageStatus");
                    objQuestion_Mst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objQuestion_Mst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objQuestion_Mst.UpdatedBy = DataHelper.GetInt(dataReader, "UpdatedBy");
                    objQuestion_Mst.UpdatedOn = DataHelper.GetDateTime(dataReader, "UpdatedOn");
                    objQuestion_Mst.Deactive = DataHelper.GetBoolean(dataReader, "Deactive");


                    Question_MstList.Add(objQuestion_Mst);
                }
            }

            return Question_MstList;

        }

        public static List<Question_Mst> usp_GetQuestionBySubjectIdLessonId(int SubjectId,int LessonId)
        {
            SqlCommand comm = new SqlCommand();
            Question_Mst objQuestion_Mst = null;
            List<Question_Mst> Question_MstList = new List<Question_Mst>();
            comm.CommandText = "usp_GetQuestionBySubjectIdLessonId";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@SubjectId", SubjectId);
                   comm.Parameters.Add(p);
                   p = new SqlParameter("@LessonId", LessonId);
                   comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objQuestion_Mst = new Question_Mst();
                    objQuestion_Mst.QuestionId = DataHelper.GetInt(dataReader, "QuestionId");
                    objQuestion_Mst.SubjectId = DataHelper.GetInt(dataReader, "SubjectId");
                    objQuestion_Mst.LessonId = DataHelper.GetInt(dataReader, "LessonId");
                    objQuestion_Mst.Question = DataHelper.GetString(dataReader, "Question");
                    objQuestion_Mst.Option1 = DataHelper.GetString(dataReader, "Option1");
                    objQuestion_Mst.Option2 = DataHelper.GetString(dataReader, "Option2");
                    objQuestion_Mst.Option3 = DataHelper.GetString(dataReader, "Option3");
                    objQuestion_Mst.Option4 = DataHelper.GetString(dataReader, "Option4");
                    objQuestion_Mst.CorrectAnswer = DataHelper.GetString(dataReader, "CorrectAnswer");
                    objQuestion_Mst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objQuestion_Mst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objQuestion_Mst.UpdatedBy = DataHelper.GetInt(dataReader, "UpdatedBy");
                    objQuestion_Mst.UpdatedOn = DataHelper.GetDateTime(dataReader, "UpdatedOn");
                    objQuestion_Mst.Deactive = DataHelper.GetBoolean(dataReader, "Deactive");


                    Question_MstList.Add(objQuestion_Mst);
                }
            }

            return Question_MstList;

        }
    }
    //


}





