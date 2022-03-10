using System;
using System.Collections.Generic;
using System.Text;
//using Bll;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL
{
   //Date : 22/12/2010
    //Description : Business class
    public class QuestionSetMst
    {

        
#region Private Properties
 	
	private int _QuestionSetID;
	private int _SetID;
	private int _QuestionID;
	private int _InsertedBy;
	private int _UpdateBy;
    private int _QuestionId;
    private int _ExamId;
    private int _TotalQuestion;
    
 
 #endregion
 #region Public Properties
 	
	public int QuestionSetID
	{
		get
		{
			return _QuestionSetID;
		}
		set
		{
			_QuestionSetID = value;
		}
	}

	public int SetID
	{
		get
		{
			return _SetID;
		}
		set
		{
			_SetID = value;
		}
	}

	public int QuestionID
	{
		get
		{
			return _QuestionID;
		}
		set
		{
			_QuestionID = value;
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

	public int UpdateBy
	{
		get
		{
			return _UpdateBy;
		}
		set
		{
			_UpdateBy = value;
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


 
 #endregion
    }
    public class QuestionSetMstManager
    {
        public enum QuestionSetMstOperationResult
        {
            QuestionSetMst_EXISTS,
            QuestionSetMst_ADDED
        }
        //public const string USER_EXISTS = "QuestionSetMst_EXISTS";
        //public const string USER_ADDED = "QuestionSetMst_ADDED";
        private QuestionSetMstDAL objQuestionSetMstDAL = new QuestionSetMstDAL();

        public static QuestionSetMstOperationResult Add(QuestionSetMst objQuestionSetMst)
        {

            int returnValue = QuestionSetMstDAL.Add(objQuestionSetMst);
            if (returnValue == 0)
                return QuestionSetMstOperationResult.QuestionSetMst_EXISTS;
            else
                return QuestionSetMstOperationResult.QuestionSetMst_ADDED;
        }
        public static QuestionSetMstOperationResult Update(QuestionSetMst objQuestionSetMst)
        {
            int returnValue = QuestionSetMstDAL.Update(objQuestionSetMst);
            if (returnValue == 0)
                return QuestionSetMstOperationResult.QuestionSetMst_EXISTS;
            else
                return QuestionSetMstOperationResult.QuestionSetMst_ADDED;
        }
        public static void Delete(int QuestionSetMstId)
        {
            QuestionSetMstDAL.Delete(QuestionSetMstId);
        }
        public static QuestionSetMst Select(int QuestionSetMstId)
        {
            return QuestionSetMstDAL.Select(QuestionSetMstId);
        }
        public static List<QuestionSetMst> GetAll()
        {
            return QuestionSetMstDAL.GetAll();
        }
    }

    public class QuestionSetMstDAL
    {
        internal static int Add(QuestionSetMst objQuestionSetMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_addQuestionSetMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

           //SqlParameter p = new SqlParameter("@QuestionSetID", objQuestionSetMst.QuestionSetID);
           //   comm.Parameters.Add(p);
               SqlParameter p  = new SqlParameter("@SetID", objQuestionSetMst.SetID);
	             comm.Parameters.Add(p);
                 p = new SqlParameter("@QuestionID ", objQuestionSetMst.QuestionID);
	             comm.Parameters.Add(p);

              //p = new SqlParameter("@InsertedBy", objQuestionSetMst.InsertedBy);
              //   comm.Parameters.Add(p);
              //p = new SqlParameter("@UpdateBy", objQuestionSetMst.UpdateBy);
              //   comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int Update(QuestionSetMst objQuestionSetMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateQuestionSetMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		               SqlParameter p = new SqlParameter("@QuestionSetID", objQuestionSetMst.QuestionSetID);
	                     comm.Parameters.Add(p);
                      p = new SqlParameter("@SetID", objQuestionSetMst.SetID);
	                     comm.Parameters.Add(p);
                      p = new SqlParameter("@QuestionID", objQuestionSetMst.QuestionID);
	                     comm.Parameters.Add(p);
                      p = new SqlParameter("@InsertedBy", objQuestionSetMst.InsertedBy);
	                     comm.Parameters.Add(p);
                      p = new SqlParameter("@UpdateBy", objQuestionSetMst.UpdateBy);
	                     comm.Parameters.Add(p);

                      return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int QuestionSetMstId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteQuestionSetMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@QuestionSetMstId", QuestionSetMstId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static QuestionSetMst Select(int QuestionSetMstId)
        {
            SqlCommand comm = new SqlCommand();
            QuestionSetMst objQuestionSetMst = null;           
            comm.CommandText = "usp_selectQuestionSetMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@QuestionSetMstId", QuestionSetMstId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                        objQuestionSetMst = new QuestionSetMst();
                        objQuestionSetMst.QuestionSetID= DataHelper.GetInt(dataReader, "QuestionSetID"); 
                        objQuestionSetMst.SetID= DataHelper.GetInt(dataReader, "SetID"); 
                        objQuestionSetMst.QuestionID= DataHelper.GetInt(dataReader, "QuestionID"); 
                        objQuestionSetMst.InsertedBy= DataHelper.GetInt(dataReader, "InsertedBy"); 
                        objQuestionSetMst.UpdateBy= DataHelper.GetInt(dataReader, "UpdateBy"); 

                }
            }

            return objQuestionSetMst;

        }

        public static List<QuestionSetMst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            QuestionSetMst objQuestionSetMst = null;
            List<QuestionSetMst> QuestionSetMstList = new List<QuestionSetMst>();
            comm.CommandText = "usp_GetAllQuestionSetMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objQuestionSetMst = new QuestionSetMst();
                    objQuestionSetMst.QuestionSetID= DataHelper.GetInt(dataReader, "QuestionSetID"); 
                    objQuestionSetMst.SetID= DataHelper.GetInt(dataReader, "SetID"); 
                    objQuestionSetMst.QuestionID= DataHelper.GetInt(dataReader, "QuestionID"); 
                    objQuestionSetMst.InsertedBy= DataHelper.GetInt(dataReader, "InsertedBy"); 
                    objQuestionSetMst.UpdateBy= DataHelper.GetInt(dataReader, "UpdateBy"); 


                    QuestionSetMstList.Add(objQuestionSetMst);
                }
            }

            return QuestionSetMstList;

        }
    }

}





