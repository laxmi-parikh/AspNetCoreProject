using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL
{
   //Date : 22/3/2012
    //Description : Business class
    public class ExamTitleMst
    {

        
#region Private Properties
 	
	private int _TitleId;
	private string _Title;
 
 #endregion
 #region Public Properties
 	
	public int TitleId
	{
		get
		{
			return _TitleId;
		}
		set
		{
			_TitleId = value;
		}
	}

	public string Title
	{
		get
		{
			return _Title;
		}
		set
		{
			_Title = value;
		}
	}

 
 #endregion
    }
    public class ExamTitleMstManager
    {
        public enum ExamTitleMstOperationResult
        {
            ExamTitleMst_EXISTS,
            ExamTitleMst_ADDED
        }
        //public const string USER_EXISTS = "ExamTitleMst_EXISTS";
        //public const string USER_ADDED = "ExamTitleMst_ADDED";
        private ExamTitleMstDAL objExamTitleMstDAL = new ExamTitleMstDAL();

        public static ExamTitleMstOperationResult Add(ExamTitleMst objExamTitleMst)
        {

            int returnValue = ExamTitleMstDAL.Add(objExamTitleMst);
            if (returnValue == 0)
                return ExamTitleMstOperationResult.ExamTitleMst_EXISTS;
            else
                return ExamTitleMstOperationResult.ExamTitleMst_ADDED;
        }
        public static ExamTitleMstOperationResult Update(ExamTitleMst objExamTitleMst)
        {
            int returnValue = ExamTitleMstDAL.Update(objExamTitleMst);
            if (returnValue == 0)
                return ExamTitleMstOperationResult.ExamTitleMst_EXISTS;
            else
                return ExamTitleMstOperationResult.ExamTitleMst_ADDED;
        }
        public static void Delete(int ExamTitleMstId)
        {
            ExamTitleMstDAL.Delete(ExamTitleMstId);
        }
        public static ExamTitleMst Select(int ExamTitleMstId)
        {
            return ExamTitleMstDAL.Select(ExamTitleMstId);
        }
        public static List<ExamTitleMst> GetAll()
        {
            return ExamTitleMstDAL.GetAll();
        }
    }

    public class ExamTitleMstDAL
    {
        internal static int Add(ExamTitleMst objExamTitleMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_AddExamTitleMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

          SqlParameter p = new SqlParameter("@Title", objExamTitleMst.Title);
	 comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int Update(ExamTitleMst objExamTitleMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateExamTitleMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@TitleId", objExamTitleMst.TitleId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Title", objExamTitleMst.Title);
	 comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int ExamTitleMstId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteExamTitleMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@TitleId", ExamTitleMstId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static ExamTitleMst Select(int ExamTitleMstId)
        {
            SqlCommand comm = new SqlCommand();
            ExamTitleMst objExamTitleMst = null;           
            comm.CommandText = "usp_selectExamTitleMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@TitleId", ExamTitleMstId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objExamTitleMst = new ExamTitleMst();
                    objExamTitleMst.TitleId= DataHelper.GetInt(dataReader, "TitleId"); 
objExamTitleMst.Title= DataHelper.GetString(dataReader, "Title"); 


                    
                }
            }

            return objExamTitleMst;

        }

        public static List<ExamTitleMst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            ExamTitleMst objExamTitleMst = null;
            List<ExamTitleMst> ExamTitleMstList = new List<ExamTitleMst>();
            comm.CommandText = "usp_GetAllExamTitleMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objExamTitleMst = new ExamTitleMst();
                    objExamTitleMst.TitleId= DataHelper.GetInt(dataReader, "TitleId"); 
objExamTitleMst.Title= DataHelper.GetString(dataReader, "Title"); 


                    ExamTitleMstList.Add(objExamTitleMst);
                }
            }

            return ExamTitleMstList;

        }
    }

}





