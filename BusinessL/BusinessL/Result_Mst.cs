using System;
using System.Collections.Generic;
using System.Text;
//using Bll;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL
{
   //Date : 17/12/2010
    //Description : Business class
    public class Result_Mst
    {
        #region Private Properties

        private int _ResultId;
        private int _StudentId;
        private int _SubjectId;
        private int _SetID;


        private int _TotalQuestion;
        private int _CorrectAnswer;
        private int _WrongAnswer;
        private int _InsertedBy;
        private DateTime _InsertedOn;
        private int _MarksObtained;
        private string _Detail;
        private string _status;

        
        #endregion
        #region Public Properties

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public int ResultId
        {
            get
            {
                return _ResultId;
            }
            set
            {
                _ResultId = value;
            }
        }

        public int SetID
        {
            get { return _SetID; }
            set { _SetID = value; }
        }

        public int StudentId
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

        public int TotalQuestion
        {
            get
            {
                return _TotalQuestion;
            }
            set
            {
                _TotalQuestion = value;
            }
        }

        public int CorrectAnswer
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

        public int WrongAnswer
        {
            get
            {
                return _WrongAnswer;
            }
            set
            {
                _WrongAnswer = value;
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
        public int MarksObtained
        {
            get
            {
                return _MarksObtained;
            }
            set
            {
                _MarksObtained = value;
            }
        }


        public string Detail
        {
            get { return _Detail; }
            set { _Detail = value; }
        }



        #endregion
    }
    public class Result_MstManager
    {
        public enum Result_MstOperationResult
        {
            Result_Mst_EXISTS,
            Result_Mst_ADDED
        }
        //public const string USER_EXISTS = "Result_Mst_EXISTS";
        //public const string USER_ADDED = "Result_Mst_ADDED";
        private Result_MstDAL objResult_MstDAL = new Result_MstDAL();

        public static Result_MstOperationResult Add(Result_Mst objResult_Mst)
        {

            int returnValue = Result_MstDAL.Add(objResult_Mst);
            if (returnValue == 0)
                return Result_MstOperationResult.Result_Mst_EXISTS;
            else
                return Result_MstOperationResult.Result_Mst_ADDED;
        }
        public static Result_MstOperationResult Update(Result_Mst objResult_Mst)
        {
            int returnValue = Result_MstDAL.Update(objResult_Mst);
            if (returnValue == 0)
                return Result_MstOperationResult.Result_Mst_EXISTS;
            else
                return Result_MstOperationResult.Result_Mst_ADDED;
        }
        public static void Delete(int Result_MstId)
        {
            Result_MstDAL.Delete(Result_MstId);
        }
        public static Result_Mst Select(int Result_MstId)
        {
            return Result_MstDAL.Select(Result_MstId);
        }
        public static Result_Mst SelectResult(int UserId, int SetId, int SubjectId)
        {
            return Result_MstDAL. SelectResult(UserId,SetId,SubjectId);
        }

       
        public static List<Result_Mst> GetAll()
        {
            return Result_MstDAL.GetAll();
        }
        public static List<Result_Mst> GetResultReport(int SettingId)
        {
            return Result_MstDAL.GetResultReport(SettingId);
        }

          public static List<Result_Mst> GetHistory(int StudentId)
        {
            return Result_MstDAL.GetHistory(StudentId);
        }

       // usp_Setupdate(@UserId int,@SubId int)

       
    }

    public class Result_MstDAL
    {
        internal static int Add(Result_Mst objResult_Mst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_AddResult";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@StudentId", objResult_Mst.StudentId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@SubjectId", objResult_Mst.SubjectId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@SetId", objResult_Mst.SetID);
            comm.Parameters.Add(p);

            p = new SqlParameter("@TotalQuestion", objResult_Mst.TotalQuestion);
            comm.Parameters.Add(p);
            p = new SqlParameter("@CorrectAnswer", objResult_Mst.CorrectAnswer);
            comm.Parameters.Add(p);
            p = new SqlParameter("@WrongAnswer", objResult_Mst.WrongAnswer);
            comm.Parameters.Add(p);
            p = new SqlParameter("@status", objResult_Mst.Status);
            comm.Parameters.Add(p);
          


            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int Update(Result_Mst objResult_Mst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateResult_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@ResultId", objResult_Mst.ResultId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@StudentId", objResult_Mst.StudentId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@SubjectId", objResult_Mst.SubjectId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@TotalQuestion", objResult_Mst.TotalQuestion);
            comm.Parameters.Add(p);
            p = new SqlParameter("@CorrectAnswer", objResult_Mst.CorrectAnswer);
            comm.Parameters.Add(p);
            p = new SqlParameter("@WrongAnswer", objResult_Mst.WrongAnswer);
            comm.Parameters.Add(p);
            p = new SqlParameter("@InsertedBy", objResult_Mst.InsertedBy);
            comm.Parameters.Add(p);
            p = new SqlParameter("@InsertedOn", objResult_Mst.InsertedOn);
            comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int Result_MstId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteResult_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Result_MstId", Result_MstId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static Result_Mst Select(int Result_MstId)
        {
            SqlCommand comm = new SqlCommand();
            Result_Mst objResult_Mst = null;
            comm.CommandText = "usp_selectResult_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Result_MstId", Result_MstId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objResult_Mst = new Result_Mst();
                    objResult_Mst.ResultId = DataHelper.GetInt(dataReader, "ResultId");
                    objResult_Mst.StudentId = DataHelper.GetInt(dataReader, "StudentId");
                    objResult_Mst.SubjectId = DataHelper.GetInt(dataReader, "SubjectId");
                    objResult_Mst.TotalQuestion = DataHelper.GetInt(dataReader, "TotalQuestion");
                    objResult_Mst.CorrectAnswer = DataHelper.GetInt(dataReader, "CorrectAnswer");
                    objResult_Mst.WrongAnswer = DataHelper.GetInt(dataReader, "WrongAnswer");
                    objResult_Mst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objResult_Mst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");



                }
            }

            return objResult_Mst;

        }


         internal static Result_Mst SelectResult(int UserId,int SetId,int SubjectId)
        {
            SqlCommand comm = new SqlCommand();
            Result_Mst objResult_Mst = null;
            comm.CommandText = "usp_selectResult";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@UserId",UserId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@setId", SetId);
            comm.Parameters.Add(p);

            p = new SqlParameter("@subjectId", SubjectId);
            comm.Parameters.Add(p);


            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objResult_Mst = new Result_Mst();
                    objResult_Mst.ResultId = DataHelper.GetInt(dataReader, "ResultId");
                    objResult_Mst.StudentId = DataHelper.GetInt(dataReader, "StudentId");
                    objResult_Mst.SubjectId = DataHelper.GetInt(dataReader, "SubjectId");
                    objResult_Mst.TotalQuestion = DataHelper.GetInt(dataReader, "TotalQuestion");
                    objResult_Mst.CorrectAnswer = DataHelper.GetInt(dataReader, "CorrectAnswer");
                    objResult_Mst.WrongAnswer = DataHelper.GetInt(dataReader, "WrongAnswer");
                    objResult_Mst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objResult_Mst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");



                }
            }

            return objResult_Mst;

        }

        //usp_selectResult(@UserId int ,@setId int ,@subjectId int)
        public static List<Result_Mst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            Result_Mst objResult_Mst = null;
            List<Result_Mst> Result_MstList = new List<Result_Mst>();
            comm.CommandText = "usp_GetAllResult_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objResult_Mst = new Result_Mst();
                    objResult_Mst.ResultId = DataHelper.GetInt(dataReader, "ResultId");
                    objResult_Mst.StudentId = DataHelper.GetInt(dataReader, "StudentId");
                    objResult_Mst.SubjectId = DataHelper.GetInt(dataReader, "SubjectId");
                    objResult_Mst.TotalQuestion = DataHelper.GetInt(dataReader, "TotalQuestion");
                    objResult_Mst.CorrectAnswer = DataHelper.GetInt(dataReader, "CorrectAnswer");
                    objResult_Mst.WrongAnswer = DataHelper.GetInt(dataReader, "WrongAnswer");
                    objResult_Mst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objResult_Mst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");


                    Result_MstList.Add(objResult_Mst);
                }
            }

            return Result_MstList;

        }


       // usp_GetResultReport(@SettingId int
              public static List<Result_Mst> GetResultReport(int SettingId)
        {
            SqlCommand comm = new SqlCommand();
            Result_Mst objResult_Mst = null;
            List<Result_Mst> Result_MstList = new List<Result_Mst>();
            comm.CommandText = "usp_GetResultReport";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@SettingId", SettingId);
                   comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objResult_Mst = new Result_Mst();
                    objResult_Mst.ResultId = DataHelper.GetInt(dataReader, "ResultId");
                    objResult_Mst.StudentId = DataHelper.GetInt(dataReader, "StudentId");
                    objResult_Mst.SubjectId = DataHelper.GetInt(dataReader, "SubjectId");
                    objResult_Mst.SetID = DataHelper.GetInt(dataReader, "SetId");
                    objResult_Mst.TotalQuestion = DataHelper.GetInt(dataReader, "TotalQuestion");
                    objResult_Mst.CorrectAnswer = DataHelper.GetInt(dataReader, "CorrectAnswer");
                    objResult_Mst.WrongAnswer = DataHelper.GetInt(dataReader, "WrongAnswer");
                    objResult_Mst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objResult_Mst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");


                    Result_MstList.Add(objResult_Mst);
                }
            }

            return Result_MstList;

        }

        // usp_GetHistory(@StudentId int)

              public static List<Result_Mst> GetHistory(int StudentId)
              {
                  SqlCommand comm = new SqlCommand();
                  Result_Mst objResult_Mst = null;
                  List<Result_Mst> Result_MstList = new List<Result_Mst>();
                  comm.CommandText = "usp_GetHistory";
                  comm.CommandType = System.Data.CommandType.StoredProcedure;

                  SqlParameter p = new SqlParameter("@StudentId", StudentId);
                  comm.Parameters.Add(p);

                  using (IDataReader dataReader = DataConnector.GetDataReader(comm))
                  {
                      while (dataReader.Read())
                      {
                          objResult_Mst = new Result_Mst();
                          objResult_Mst.ResultId = DataHelper.GetInt(dataReader, "ResultId");
                          objResult_Mst.StudentId = DataHelper.GetInt(dataReader, "StudentId");
                          objResult_Mst.SubjectId = DataHelper.GetInt(dataReader, "SubjectId");
                          objResult_Mst.SetID = DataHelper.GetInt(dataReader, "SetId");
                          objResult_Mst.TotalQuestion = DataHelper.GetInt(dataReader, "TotalQuestion");
                          objResult_Mst.CorrectAnswer = DataHelper.GetInt(dataReader, "CorrectAnswer");
                          objResult_Mst.WrongAnswer = DataHelper.GetInt(dataReader, "WrongAnswer");
                          objResult_Mst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                          objResult_Mst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");


                          Result_MstList.Add(objResult_Mst);
                      }
                  }

                  return Result_MstList;

              }

        
    }

}






