using System;
using System.Collections.Generic;
using System.Text;
//using Bhairav.DataLayer;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL
{
   //Date : 24/10/2011
    //Description : Business class
    public class LevelMst
    {

        
#region Private Properties
 	
	private int _Levelid;
	private int _Functionid;
	private string _Levelname;
	private DateTime _InsertedOn;
	private int _InsertedBy;
	private int _Deactive;
 
 #endregion
 #region Public Properties
 	
	public int Levelid
	{
		get
		{
			return _Levelid;
		}
		set
		{
			_Levelid = value;
		}
	}

	public int Functionid
	{
		get
		{
			return _Functionid;
		}
		set
		{
			_Functionid = value;
		}
	}

	public string Levelname
	{
		get
		{
			return _Levelname;
		}
		set
		{
			_Levelname = value;
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

 
 #endregion
    }
    public class LevelMstManager
    {
        public enum LevelMstOperationResult
        {
            LevelMst_EXISTS,
            LevelMst_ADDED
        }
        //public const string USER_EXISTS = "LevelMst_EXISTS";
        //public const string USER_ADDED = "LevelMst_ADDED";
        private LevelMstDAL objLevelMstDAL = new LevelMstDAL();

        public static LevelMstOperationResult Add(LevelMst objLevelMst)
        {

            int returnValue = LevelMstDAL.Add(objLevelMst);
            if (returnValue == 0)
                return LevelMstOperationResult.LevelMst_EXISTS;
            else
                return LevelMstOperationResult.LevelMst_ADDED;
        }
        public static LevelMstOperationResult Update(LevelMst objLevelMst)
        {
            int returnValue = LevelMstDAL.Update(objLevelMst);
            if (returnValue == 0)
                return LevelMstOperationResult.LevelMst_EXISTS;
            else
                return LevelMstOperationResult.LevelMst_ADDED;
        }
        public static void Delete(int LevelMstId)
        {
            LevelMstDAL.Delete(LevelMstId);
        }
        public static LevelMst Select(int LevelMstId)
        {
            return LevelMstDAL.Select(LevelMstId);
        }
        public static List<LevelMst> GetAll()
        {
            return LevelMstDAL.GetAll();
        }
        public static DataSet ListSubTitle()
        {
            return DataConnector.GetDataSet("usp_GetAlllevelName");
        }
        public static DataSet listlevel(int functionid)
        {
            return DataConnector.GetDataSet("usp_GetSelectedLevel " + functionid);
        }
    }

    public class LevelMstDAL
    {
        internal static int Add(LevelMst objLevelMst)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "usp_AddLevelMst";
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                // p = new SqlParameter("@Levelid", objLevelMst.Levelid);
                //comm.Parameters.Add(p);
                SqlParameter p = new SqlParameter("@Functionid", objLevelMst.Functionid);
                comm.Parameters.Add(p);
                p = new SqlParameter("@Levelname", objLevelMst.Levelname);
                comm.Parameters.Add(p);
                p = new SqlParameter("@InsertedOn", objLevelMst.InsertedOn);
                comm.Parameters.Add(p);
                p = new SqlParameter("@InsertedBy", objLevelMst.InsertedBy);
                comm.Parameters.Add(p);
                //p = new SqlParameter("@Deactive", objLevelMst.Deactive);
                //comm.Parameters.Add(p);

                return Convert.ToInt32(DataConnector.ExecuteScalar(comm));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        internal static int Update(LevelMst objLevelMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateLevelMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@Levelid", objLevelMst.Levelid);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Functionid", objLevelMst.Functionid);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Levelname", objLevelMst.Levelname);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@InsertedOn", objLevelMst.InsertedOn);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@InsertedBy", objLevelMst.InsertedBy);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Deactive", objLevelMst.Deactive);
	 comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int LevelMstId)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "usp_deleteLevelMst";
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@LevelMstId", LevelMstId);
                comm.Parameters.Add(p);

                DataConnector.ExecuteCommand(comm);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        internal static LevelMst Select(int LevelMstId)
        {
            SqlCommand comm = new SqlCommand();
            LevelMst objLevelMst = null;           
            comm.CommandText = "usp_selectLevelMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@LevelMstId", LevelMstId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objLevelMst = new LevelMst();
                    objLevelMst.Levelid= DataHelper.GetInt(dataReader, "Levelid"); 
objLevelMst.Functionid= DataHelper.GetInt(dataReader, "Functionid"); 
objLevelMst.Levelname= DataHelper.GetString(dataReader, "Levelname"); 
objLevelMst.InsertedOn= DataHelper.GetDateTime(dataReader, "InsertedOn"); 
objLevelMst.InsertedBy= DataHelper.GetInt(dataReader, "InsertedBy"); 
objLevelMst.Deactive= DataHelper.GetInt(dataReader, "Deactive"); 


                    
                }
            }

            return objLevelMst;

        }

        public static List<LevelMst> GetAll()
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                LevelMst objLevelMst = null;
                List<LevelMst> LevelMstList = new List<LevelMst>();
                comm.CommandText = "usp_GetAllLevelMst";
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
                //        comm.Parameters.Add(p);

                using (IDataReader dataReader = DataConnector.GetDataReader(comm))
                {
                    while (dataReader.Read())
                    {
                        objLevelMst = new LevelMst();
                        objLevelMst.Levelid = DataHelper.GetInt(dataReader, "Levelid");
                        objLevelMst.Functionid = DataHelper.GetInt(dataReader, "Functionid");
                        objLevelMst.Levelname = DataHelper.GetString(dataReader, "Levelname");
                        objLevelMst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                        objLevelMst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                        objLevelMst.Deactive = DataHelper.GetInt(dataReader, "Deactive");


                        LevelMstList.Add(objLevelMst);
                    }
                }

                return LevelMstList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

}





