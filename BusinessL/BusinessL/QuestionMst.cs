using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
//using Bll;
using System.Security.Cryptography;
using System.Data;





namespace BusinessL
{
    //Date : 20/4/2011
    //Description : Business class
    public class QuestionMst
    {


        #region Private Properties

        private int _QuestionId;
        public int TopicId {get;set;}
     
        private string _Question;
        private string _Option1;
        private string _Option2;
        private string _Option3;
        private string _Option4;
        public string Option5 { get; set; }
        public string Option6 { get; set; }
        private string _Hint;
        private string _CorrectAnswer;
        private int _InsertedBy;
        private DateTime _InsertedOn;
        private int _UpdatedBy;
        private DateTime _UpdatedOn;
        private bool _Deactive;



        private string _ImageStatus;
        private int _ExamId;
        private int _MainId;
       
        private int _SubjectId;
        private int _LessonId;
       

        #endregion
        #region Public Properties

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

        public int MainId
        {
            get { return _MainId; }
            set { _MainId = value; }
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

        public string Hint
        {
            get
            {
                return _Hint;
            }
            set
            {
                _Hint = value;
            }
        }

        public string CorrectAnswer
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
        public string lblImageStatus
        {
            get
            {
                return _ImageStatus;
            }
            set
            {
                _ImageStatus = value;
            }
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
       


        #endregion
    }



    public class QuestionMstManager
    {
        public enum QuestionMstOperationResult
        {
            QuestionMst_EXISTS,
            QuestionMst_ADDED
        }
        //public const string USER_EXISTS = "QuestionMst_EXISTS";
        //public const string USER_ADDED = "QuestionMst_ADDED";
        private QuestionMstDAL objQuestionMstDAL = new QuestionMstDAL();

        public static int Add(QuestionMst objQuestionMst)
        {

            int returnValue = QuestionMstDAL.Add(objQuestionMst);
            if (returnValue == 0)
                return returnValue;
            else
                return returnValue;
        }
        public static QuestionMstOperationResult Update(QuestionMst objQuestionMst)
        {
            int returnValue = QuestionMstDAL.Update(objQuestionMst);
            if (returnValue == 0)
                return QuestionMstOperationResult.QuestionMst_EXISTS;
            else
                return QuestionMstOperationResult.QuestionMst_ADDED;
        }
        public static void Delete(int QuestionMstId)
        {
            QuestionMstDAL.Delete(QuestionMstId);
        }
        public static QuestionMst Select(int QuestionMstId)
        {
            return QuestionMstDAL.Select(QuestionMstId);
        }
        public static List<QuestionMst> GetAll()
        {
            return QuestionMstDAL.GetAll();
        }

        public static DataSet ListExamQuestion(int MainID, int SubID)
        {
            return QuestionMstDAL.ListExamQuestion(MainID, SubID);
        }

        public static DataSet ListExamQuestionbysettingId(int SettingId, int SubId)
        {
            return QuestionMstDAL.ListExamQuestionbysettingId(SettingId, SubId);
        }
          public static DataSet ListExamQuestionbysettingIdInterview(int SettingId)
        {
            return QuestionMstDAL.ListExamQuestionbysettingIdInterview(SettingId);
        }

        
            public static DataSet ListExamQuestion1(int SubID)
        {
            return QuestionMstDAL.ListExamQuestion1(SubID);
        }

            public static DataSet ListExamQuestion3(int LessonID)
        {
            return QuestionMstDAL.ListExamQuestion3(LessonID);
        }

        
        
    }


    public class QuestionMstDAL
    {
        internal static int Add(QuestionMst objQuestionMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_AddQuestionMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

          
            SqlParameter p = new SqlParameter("@TopicId", objQuestionMst.TopicId);
            comm.Parameters.Add(p);
          
           
            p = new SqlParameter("@Question", objQuestionMst.Question);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option1", objQuestionMst.Option1);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option2", objQuestionMst.Option2);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option3", objQuestionMst.Option3);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option4", objQuestionMst.Option4);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option5", objQuestionMst.Option5);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option6", objQuestionMst.Option6);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Hint", objQuestionMst.Hint);
            comm.Parameters.Add(p);
            p = new SqlParameter("@CorrectAnswer", objQuestionMst.CorrectAnswer);
            comm.Parameters.Add(p);
            p = new SqlParameter("@InsertedBy", objQuestionMst.InsertedBy);
            comm.Parameters.Add(p);
         
          
            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int Update(QuestionMst objQuestionMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateQuestionMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@QuestionId", objQuestionMst.QuestionId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@TopicId", objQuestionMst.TopicId);
            comm.Parameters.Add(p);
           
            p = new SqlParameter("@Question", objQuestionMst.Question);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option1", objQuestionMst.Option1);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option2", objQuestionMst.Option2);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option3", objQuestionMst.Option3);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option4", objQuestionMst.Option4);
            comm.Parameters.Add(p);

            p = new SqlParameter("@Option5", objQuestionMst.Option5);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Option6", objQuestionMst.Option6);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Hint", objQuestionMst.Hint);
            comm.Parameters.Add(p);
            p = new SqlParameter("@CorrectAnswer", objQuestionMst.CorrectAnswer);
            comm.Parameters.Add(p);
          
            p = new SqlParameter("@UpdatedBy", objQuestionMst.UpdatedBy);
            comm.Parameters.Add(p);
            p = new SqlParameter("@UpdatedOn", objQuestionMst.UpdatedOn);
            comm.Parameters.Add(p);
           
            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int QuestionMstId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_DeleteQuestion";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@QuestionId", QuestionMstId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static QuestionMst Select(int QuestionMstId)
        {
            SqlCommand comm = new SqlCommand();
            QuestionMst objQuestionMst = null;
            comm.CommandText = "usp_selectQuestionMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@QuestionId", QuestionMstId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objQuestionMst = new QuestionMst();
                    objQuestionMst.QuestionId = DataHelper.GetInt(dataReader, "QuestionId");

                    //in database SubjectId is Store (LevelId)
                    // in MainId it stores FunctionId 
                    objQuestionMst.TopicId = DataHelper.GetInt(dataReader, "TopicId");
                   // objQuestionMst.LessonId = DataHelper.GetInt(dataReader, "LessonId");
                    //objQuestionMst.MainId = DataHelper.GetInt(dataReader, "MainId");

                    objQuestionMst.Question = DataHelper.GetString(dataReader, "Question");
                    objQuestionMst.Option1 = DataHelper.GetString(dataReader, "Option1");
                    objQuestionMst.Option2 = DataHelper.GetString(dataReader, "Option2");
                    objQuestionMst.Option3 = DataHelper.GetString(dataReader, "Option3");
                    objQuestionMst.Option4 = DataHelper.GetString(dataReader, "Option4");
                    objQuestionMst.Option5 = DataHelper.GetString(dataReader, "Option5");
                    objQuestionMst.Option6 = DataHelper.GetString(dataReader, "Option6");
                    objQuestionMst.Hint = DataHelper.GetString(dataReader, "Hint");
                    objQuestionMst.CorrectAnswer = DataHelper.GetString(dataReader, "CorrectAnswer");
                    objQuestionMst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objQuestionMst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objQuestionMst.UpdatedBy = DataHelper.GetInt(dataReader, "UpdatedBy");
                    objQuestionMst.UpdatedOn = DataHelper.GetDateTime(dataReader, "UpdatedOn");
                    objQuestionMst.Deactive = DataHelper.GetBoolean(dataReader, "Deactive");



                }
            }

            return objQuestionMst;

        }

        public static List<QuestionMst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            QuestionMst objQuestionMst = null;
            List<QuestionMst> QuestionMstList = new List<QuestionMst>();
            comm.CommandText = "Usp_ListQuestion1";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objQuestionMst = new QuestionMst();
                    objQuestionMst.QuestionId = DataHelper.GetInt(dataReader, "QuestionId");
                    objQuestionMst.SubjectId = DataHelper.GetInt(dataReader, "TopicId");
                   // objQuestionMst.LessonId = DataHelper.GetInt(dataReader, "LessonId");
                   // objQuestionMst.MainId = DataHelper.GetInt(dataReader, "MainId");

                    objQuestionMst.Question = DataHelper.GetString(dataReader, "Question");
                    objQuestionMst.Option1 = DataHelper.GetString(dataReader, "Option1");
                    objQuestionMst.Option2 = DataHelper.GetString(dataReader, "Option2");
                    objQuestionMst.Option3 = DataHelper.GetString(dataReader, "Option3");
                    objQuestionMst.Option4 = DataHelper.GetString(dataReader, "Option4");
                    objQuestionMst.Option5 = DataHelper.GetString(dataReader, "Option5");
                    objQuestionMst.Option6 = DataHelper.GetString(dataReader, "Option6");
                    objQuestionMst.Hint = DataHelper.GetString(dataReader, "Hint");
                    objQuestionMst.CorrectAnswer = DataHelper.GetString(dataReader, "CorrectAnswer");
                    objQuestionMst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objQuestionMst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objQuestionMst.UpdatedBy = DataHelper.GetInt(dataReader, "UpdatedBy");
                    objQuestionMst.UpdatedOn = DataHelper.GetDateTime(dataReader, "UpdatedOn");
                    objQuestionMst.Deactive = DataHelper.GetBoolean(dataReader, "Deactive");


                    QuestionMstList.Add(objQuestionMst);
                }
            }

            return QuestionMstList;

        }
        public static DataSet ListExamQuestionbysettingId(int SettingId,int SubId)
        {
            return DataConnector.GetDataSet("usp_GetQuestionsetBySettingid '" + SettingId + "','" + SubId + "'");

        }
          public static DataSet ListExamQuestionbysettingIdInterview(int SettingId)
        {
            return DataConnector.GetDataSet("usp_GetQuestionsetBySettingid1 '" + SettingId + "'");

        }

        
        public static DataSet ListExamQuestion(int MainID, int SubID)
        {
            return DataConnector.GetDataSet("Usp_ListQuestion '" + MainID + "','" + SubID + "'");

        }
        public static DataSet ListExamQuestion1(int SubID)
        {
            return DataConnector.GetDataSet("Usp_ListQuestion2 "  + SubID);

        }

         public static DataSet ListExamQuestion3(int LessonID)
        {
            return DataConnector.GetDataSet("Usp_ListQuestion3 " + LessonID);

        }

            

    }
}
