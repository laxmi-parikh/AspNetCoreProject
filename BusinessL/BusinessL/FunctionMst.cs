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
    public class FunctionMst
    {

        
#region Private Properties
 	
	private int _Functionid;
	private string _FunctionName;
	private DateTime _InsertedOn;
	private int _InsertedBy;
	private int _Deactive;
 
 #endregion
 #region Public Properties
 	
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

	public string FunctionName
	{
		get
		{
			return _FunctionName;
		}
		set
		{
			_FunctionName = value;
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
    public class FunctionMstManager
    {
        public enum FunctionMstOperationResult
        {
            FunctionMst_EXISTS,
            FunctionMst_ADDED
        }
        //public const string USER_EXISTS = "FunctionMst_EXISTS";
        //public const string USER_ADDED = "FunctionMst_ADDED";
        private FunctionMstDAL objFunctionMstDAL = new FunctionMstDAL();

        public static FunctionMstOperationResult Add(FunctionMst objFunctionMst)
        {

            int returnValue = FunctionMstDAL.Add(objFunctionMst);
            if (returnValue == 0)
                return FunctionMstOperationResult.FunctionMst_EXISTS;
            else
                return FunctionMstOperationResult.FunctionMst_ADDED;
        }
        public static FunctionMstOperationResult Update(FunctionMst objFunctionMst)
        {
            int returnValue = FunctionMstDAL.Update(objFunctionMst);
            if (returnValue == 0)
                return FunctionMstOperationResult.FunctionMst_EXISTS;
            else
                return FunctionMstOperationResult.FunctionMst_ADDED;
        }
        public static void Delete(int FunctionMstId)
        {
            FunctionMstDAL.Delete(FunctionMstId);
        }
        public static FunctionMst Select(int FunctionMstId)
        {
            return FunctionMstDAL.Select(FunctionMstId);
        }
        public static List<FunctionMst> GetAll()
        {
            return FunctionMstDAL.GetAll();
        }
        public static DataSet Listfunction()
        {
            return DataConnector.GetDataSet("usp_GetAllFunctionMst");
        }
        
    }

    public class FunctionMstDAL
    {
        internal static int Add(FunctionMst objFunctionMst)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "usp_AddFunctionMst";
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                //     SqlParameter p = new SqlParameter("@Functionid", objFunctionMst.Functionid);
                //comm.Parameters.Add(p);
                SqlParameter p = new SqlParameter("@FunctionName", objFunctionMst.FunctionName);
                comm.Parameters.Add(p);
                p = new SqlParameter("@InsertedOn", objFunctionMst.InsertedOn);
                comm.Parameters.Add(p);
                p = new SqlParameter("@InsertedBy", objFunctionMst.InsertedBy);
                comm.Parameters.Add(p);
                //p = new SqlParameter("@Deactive", objFunctionMst.Deactive);
                //   comm.Parameters.Add(p);

                return Convert.ToInt32(DataConnector.ExecuteScalar(comm));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        internal static int Update(FunctionMst objFunctionMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateFunctionMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@Functionid", objFunctionMst.Functionid);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@FunctionName", objFunctionMst.FunctionName);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@InsertedOn", objFunctionMst.InsertedOn);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@InsertedBy", objFunctionMst.InsertedBy);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Deactive", objFunctionMst.Deactive);
	 comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int FunctionMstId)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "usp_deleteFunctionMst";
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@FunctionMstId", FunctionMstId);
                comm.Parameters.Add(p);

                DataConnector.ExecuteCommand(comm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        internal static FunctionMst Select(int FunctionMstId)
        {
            SqlCommand comm = new SqlCommand();
            FunctionMst objFunctionMst = null;           
            comm.CommandText = "usp_selectFunctionMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@FunctionMstId", FunctionMstId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objFunctionMst = new FunctionMst();
                    objFunctionMst.Functionid= DataHelper.GetInt(dataReader, "Functionid"); 
objFunctionMst.FunctionName= DataHelper.GetString(dataReader, "FunctionName"); 
objFunctionMst.InsertedOn= DataHelper.GetDateTime(dataReader, "InsertedOn"); 
objFunctionMst.InsertedBy= DataHelper.GetInt(dataReader, "InsertedBy"); 
objFunctionMst.Deactive= DataHelper.GetInt(dataReader, "Deactive"); 


                    
                }
            }

            return objFunctionMst;

        }

        public static List<FunctionMst> GetAll()
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                FunctionMst objFunctionMst = null;
                List<FunctionMst> FunctionMstList = new List<FunctionMst>();
                comm.CommandText = "usp_GetAllFunctionMst";
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
                //        comm.Parameters.Add(p);

                using (IDataReader dataReader = DataConnector.GetDataReader(comm))
                {
                    while (dataReader.Read())
                    {
                        objFunctionMst = new FunctionMst();
                        objFunctionMst.Functionid = DataHelper.GetInt(dataReader, "Functionid");
                        objFunctionMst.FunctionName = DataHelper.GetString(dataReader, "FunctionName");
                        objFunctionMst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                        objFunctionMst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                        objFunctionMst.Deactive = DataHelper.GetInt(dataReader, "Deactive");


                        FunctionMstList.Add(objFunctionMst);
                    }
                }

                return FunctionMstList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

}





