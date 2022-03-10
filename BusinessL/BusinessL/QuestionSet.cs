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
    public class QuestionSet
    {

        
#region Private Properties
 	
	private int _QuestionSetId;
	private int _TitleId;
	private int _QuestionId;
	private int _SettingId;
 
 #endregion
 #region Public Properties
 	
	public int QuestionSetId
	{
		get
		{
			return _QuestionSetId;
		}
		set
		{
			_QuestionSetId = value;
		}
	}

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

 
 #endregion
    }
    public class QuestionSetManager
    {
        public enum QuestionSetOperationResult
        {
            QuestionSet_EXISTS,
            QuestionSet_ADDED
        }
        //public const string USER_EXISTS = "QuestionSet_EXISTS";
        //public const string USER_ADDED = "QuestionSet_ADDED";
        private QuestionSetDAL objQuestionSetDAL = new QuestionSetDAL();

        public static QuestionSetOperationResult Add(QuestionSet objQuestionSet)
        {

            int returnValue = QuestionSetDAL.Add(objQuestionSet);
            if (returnValue == 0)
                return QuestionSetOperationResult.QuestionSet_EXISTS;
            else
                return QuestionSetOperationResult.QuestionSet_ADDED;
        }
        public static QuestionSetOperationResult Update(QuestionSet objQuestionSet)
        {
            int returnValue = QuestionSetDAL.Update(objQuestionSet);
            if (returnValue == 0)
                return QuestionSetOperationResult.QuestionSet_EXISTS;
            else
                return QuestionSetOperationResult.QuestionSet_ADDED;
        }
        public static void Delete(int QuestionSetId)
        {
            QuestionSetDAL.Delete(QuestionSetId);
        }
        public static QuestionSet Select(int QuestionSetId)
        {
            return QuestionSetDAL.Select(QuestionSetId);
        }
        public static QuestionSet selectQuestionsetnew1(int TitleId, int SettingId, int QuestionId)
        {
            return QuestionSetDAL.selectQuestionsetnew1(TitleId,SettingId,QuestionId);
        }
        
        public static List<QuestionSet> GetAll()
        {
            return QuestionSetDAL.GetAll();
        }
        public static void deleteQuestionsetnew(int TitleId, int SettingId, int QuestionId)
        {
            QuestionSetDAL.deleteQuestionsetnew(TitleId,SettingId,QuestionId);
        }


        public static List<QuestionSet> GetselectedQuestionsetnew(int TitleId, int SettingId)
        {
            return QuestionSetDAL.GetselectedQuestionsetnew(TitleId,SettingId);
        }
 
    }

    public class QuestionSetDAL
    {
        internal static int Add(QuestionSet objQuestionSet)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_AddQuestionSet";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

          SqlParameter p = new SqlParameter("@TitleId", objQuestionSet.TitleId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@QuestionId", objQuestionSet.QuestionId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@SettingId", objQuestionSet.SettingId);
	 comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int Update(QuestionSet objQuestionSet)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateQuestionSet";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@QuestionSetId", objQuestionSet.QuestionSetId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@TitleId", objQuestionSet.TitleId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@QuestionId", objQuestionSet.QuestionId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@SettingId", objQuestionSet.SettingId);
	 comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int QuestionSetId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteQuestionSet";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@QuestionSetId", QuestionSetId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }


        //Usp_deleteQuestionsetnew(@TitleId int,@SettingId int, @QuestionId int)

        internal static void deleteQuestionsetnew(int TitleId, int SettingId, int QuestionId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "Usp_deleteQuestionsetnew";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@TitleId", TitleId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@SettingId", SettingId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@QuestionId", QuestionId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static QuestionSet Select(int QuestionSetId)
        {
            SqlCommand comm = new SqlCommand();
            QuestionSet objQuestionSet = null;           
            comm.CommandText = "usp_selectQuestionSet";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@QuestionSetId", QuestionSetId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objQuestionSet = new QuestionSet();
                    objQuestionSet.QuestionSetId= DataHelper.GetInt(dataReader, "QuestionSetId"); 
objQuestionSet.TitleId= DataHelper.GetInt(dataReader, "TitleId"); 
objQuestionSet.QuestionId= DataHelper.GetInt(dataReader, "QuestionId"); 
objQuestionSet.SettingId= DataHelper.GetInt(dataReader, "SettingId"); 


                    
                }
            }

            return objQuestionSet;

        }




        internal static QuestionSet selectQuestionsetnew1(int TitleId, int SettingId, int QuestionId)
        {
            SqlCommand comm = new SqlCommand();
            QuestionSet objQuestionSet = null;
            comm.CommandText = "Usp_selectQuestionsetnew1";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@TitleId", TitleId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@SettingId", SettingId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@QuestionId", QuestionId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objQuestionSet = new QuestionSet();
                    objQuestionSet.QuestionSetId= DataHelper.GetInt(dataReader, "QuestionSetId"); 
objQuestionSet.TitleId= DataHelper.GetInt(dataReader, "TitleId"); 
objQuestionSet.QuestionId= DataHelper.GetInt(dataReader, "QuestionId"); 
objQuestionSet.SettingId= DataHelper.GetInt(dataReader, "SettingId"); 


                    
                }
            }

            return objQuestionSet;

        }
        public static List<QuestionSet> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            QuestionSet objQuestionSet = null;
            List<QuestionSet> QuestionSetList = new List<QuestionSet>();
            comm.CommandText = "usp_GetAllQuestionSet";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objQuestionSet = new QuestionSet();
                    objQuestionSet.QuestionSetId= DataHelper.GetInt(dataReader, "QuestionSetId"); 
objQuestionSet.TitleId= DataHelper.GetInt(dataReader, "TitleId"); 
objQuestionSet.QuestionId= DataHelper.GetInt(dataReader, "QuestionId"); 
objQuestionSet.SettingId= DataHelper.GetInt(dataReader, "SettingId"); 


                    QuestionSetList.Add(objQuestionSet);
                }
            }

            return QuestionSetList;

        }

        public static List<QuestionSet> GetselectedQuestionsetnew(int TitleId, int SettingId)
        {
            SqlCommand comm = new SqlCommand();
            QuestionSet objQuestionSet = null;
            List<QuestionSet> QuestionSetList = new List<QuestionSet>();
            comm.CommandText = "Usp_selectQuestionsetnew";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@TitleId", TitleId);
            comm.Parameters.Add(p);
            p = new SqlParameter("@SettingId", SettingId);
            comm.Parameters.Add(p);
            //p = new SqlParameter("@QuestionId", QuestionId);
            //comm.Parameters.Add(p);
            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objQuestionSet = new QuestionSet();
                    objQuestionSet.QuestionSetId= DataHelper.GetInt(dataReader, "QuestionSetId"); 
objQuestionSet.TitleId= DataHelper.GetInt(dataReader, "TitleId"); 
objQuestionSet.QuestionId= DataHelper.GetInt(dataReader, "QuestionId"); 
objQuestionSet.SettingId= DataHelper.GetInt(dataReader, "SettingId"); 


                    QuestionSetList.Add(objQuestionSet);
                }
            }

            return QuestionSetList;

        }
        
    }

}





