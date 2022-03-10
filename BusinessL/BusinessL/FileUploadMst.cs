using System;
using System.Collections.Generic;
using System.Text;
//using Bhairav.DataLayer;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL
{
   //Date : 3/11/2011
    //Description : Business class
    public class FileUploadMst
    {
#region Private Properties
 	
	private int _Uploadid;
	private int _Functionid;
    private int _Levelid;
	private string _FileTile;
	private string _FileName;
    private string _Functionname;
	private DateTime _InsertedOn;
	private int _InsertedBy;
	private int _Deactive;
 
 #endregion
 #region Public Properties

    public int Levelid
    {
        get { return _Levelid; }
        set { _Levelid = value; }
    }
    public string Functionname
    {
        get { return _Functionname; }
        set { _Functionname = value; }
    }
	public int Uploadid
	{
		get
		{
			return _Uploadid;
		}
		set
		{
			_Uploadid = value;
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

	public string FileTile
	{
		get
		{
			return _FileTile;
		}
		set
		{
			_FileTile = value;
		}
	}

	public string FileName
	{
		get
		{
			return _FileName;
		}
		set
		{
			_FileName = value;
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
    public class FileUploadMstManager
    {
        public enum FileUploadMstOperationResult
        {
            FileUploadMst_EXISTS,
            FileUploadMst_ADDED
        }
        //public const string USER_EXISTS = "FileUploadMst_EXISTS";
        //public const string USER_ADDED = "FileUploadMst_ADDED";
        private FileUploadMstDAL objFileUploadMstDAL = new FileUploadMstDAL();
        public static FileUploadMstOperationResult Add(FileUploadMst objFileUploadMst)
        {

            int returnValue = FileUploadMstDAL.Add(objFileUploadMst);
            if (returnValue == 0)
                return FileUploadMstOperationResult.FileUploadMst_EXISTS;
            else
                return FileUploadMstOperationResult.FileUploadMst_ADDED;
        }
        public static FileUploadMstOperationResult Update(FileUploadMst objFileUploadMst)
        {
            int returnValue = FileUploadMstDAL.Update(objFileUploadMst);
            if (returnValue == 0)
                return FileUploadMstOperationResult.FileUploadMst_EXISTS;
            else
                return FileUploadMstOperationResult.FileUploadMst_ADDED;
        }
        public static void Delete(int FileUploadMstId)
        {
            FileUploadMstDAL.Delete(FileUploadMstId);
        }
        public static FileUploadMst Select(int FileUploadMstId)
        {
            return FileUploadMstDAL.Select(FileUploadMstId);
        }
        public static List<FileUploadMst> GetAll()
        {
            return FileUploadMstDAL.GetAll();
        }
        public static List<FileUploadMst> GetAll(bool type)
        {
            return FileUploadMstDAL.GetAll(type);
        }
        public static List<FileUploadMst> GetAll_1(int functionid, int levelId)
        {
            return FileUploadMstDAL.GetAll_1(functionid,levelId);
        }
    }

    public class FileUploadMstDAL
    {
        internal static int Add(FileUploadMst objFileUploadMst)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "usp_AddFileUploadMst";
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandTimeout = 10000;
              SqlParameter p = new SqlParameter("@LevelId", objFileUploadMst.Levelid);
             comm.Parameters.Add(p);
                p = new SqlParameter("@Functionid", objFileUploadMst.Functionid);
                comm.Parameters.Add(p);
                p = new SqlParameter("@FileTile", objFileUploadMst.FileTile);
                comm.Parameters.Add(p);
                p = new SqlParameter("@FileName", objFileUploadMst.FileName);
                comm.Parameters.Add(p);
                p = new SqlParameter("@InsertedOn", objFileUploadMst.InsertedOn);
                comm.Parameters.Add(p);
                p = new SqlParameter("@InsertedBy", objFileUploadMst.InsertedBy);
                comm.Parameters.Add(p);
                //p = new SqlParameter("@Deactive", objFileUploadMst.Deactive);
                //   comm.Parameters.Add(p);

                return Convert.ToInt32(DataConnector.ExecuteScalar(comm));
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        internal static int Update(FileUploadMst objFileUploadMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateFileUploadMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@Uploadid", objFileUploadMst.Uploadid);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Functionid", objFileUploadMst.Functionid);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@FileTile", objFileUploadMst.FileTile);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@FileName", objFileUploadMst.FileName);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@InsertedOn", objFileUploadMst.InsertedOn);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@InsertedBy", objFileUploadMst.InsertedBy);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Deactive", objFileUploadMst.Deactive);
	 comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int FileUploadMstId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteFileUploadMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@FileUploadMstId", FileUploadMstId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static FileUploadMst Select(int FileUploadMstId)
        {
            SqlCommand comm = new SqlCommand();
            FileUploadMst objFileUploadMst = null;           
            comm.CommandText = "usp_selectFileUploadMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@FileUploadMstId", FileUploadMstId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objFileUploadMst = new FileUploadMst();
                    objFileUploadMst.Uploadid= DataHelper.GetInt(dataReader, "Uploadid"); 
objFileUploadMst.Functionid= DataHelper.GetInt(dataReader, "Functionid"); 
objFileUploadMst.FileTile= DataHelper.GetString(dataReader, "FileTile"); 
objFileUploadMst.FileName= DataHelper.GetString(dataReader, "FileName"); 
objFileUploadMst.InsertedOn= DataHelper.GetDateTime(dataReader, "InsertedOn"); 
objFileUploadMst.InsertedBy= DataHelper.GetInt(dataReader, "InsertedBy"); 
objFileUploadMst.Deactive= DataHelper.GetInt(dataReader, "Deactive"); 


                    
                }
            }

            return objFileUploadMst;

        }
        public static List<FileUploadMst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            FileUploadMst objFileUploadMst = null;
            List<FileUploadMst> FileUploadMstList = new List<FileUploadMst>();
            comm.CommandText = "usp_GetAllFileUploadMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objFileUploadMst = new FileUploadMst();
                    objFileUploadMst.Uploadid= DataHelper.GetInt(dataReader, "Uploadid"); 
objFileUploadMst.Functionid= DataHelper.GetInt(dataReader, "Functionid"); 
objFileUploadMst.FileTile= DataHelper.GetString(dataReader, "FileTile"); 
objFileUploadMst.FileName= DataHelper.GetString(dataReader, "FileName"); 
objFileUploadMst.InsertedOn= DataHelper.GetDateTime(dataReader, "InsertedOn"); 
objFileUploadMst.InsertedBy= DataHelper.GetInt(dataReader, "InsertedBy"); 
objFileUploadMst.Deactive= DataHelper.GetInt(dataReader, "Deactive"); 


                    FileUploadMstList.Add(objFileUploadMst);
                }
            }

            return FileUploadMstList;

        }
        public static List<FileUploadMst> GetAll(bool type)
        {
            SqlCommand comm = new SqlCommand();
            FileUploadMst objFileUploadMst = null;
            List<FileUploadMst> FileUploadMstList = new List<FileUploadMst>();
            comm.CommandText = "usp_getallebooktodownload";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objFileUploadMst = new FileUploadMst();
                    objFileUploadMst.Uploadid = DataHelper.GetInt(dataReader, "Uploadid");
                    //objFileUploadMst.Functionid = DataHelper.GetInt(dataReader, "Functionid");
                    objFileUploadMst.FileTile = DataHelper.GetString(dataReader, "FileTile");
                    objFileUploadMst.FileName = DataHelper.GetString(dataReader, "FileName");
                    objFileUploadMst.Functionname = DataHelper.GetString(dataReader, "Functionname");
                    //objFileUploadMst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    //objFileUploadMst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    //objFileUploadMst.Deactive = DataHelper.GetInt(dataReader, "Deactive");


                    FileUploadMstList.Add(objFileUploadMst);
                }
            }

            return FileUploadMstList;

        }
        public static List<FileUploadMst> GetAll_1(int functionid,int levelId)
        {
            SqlCommand comm = new SqlCommand();
            FileUploadMst objFileUploadMst = null;
            List<FileUploadMst> FileUploadMstList = new List<FileUploadMst>();
            comm.CommandText = "usp_GetSelectedFileUploadMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@functionid", functionid);
            comm.Parameters.Add(p);
            p = new SqlParameter("@levelId", levelId);
            comm.Parameters.Add(p);


            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objFileUploadMst = new FileUploadMst();
                    objFileUploadMst.Uploadid = DataHelper.GetInt(dataReader, "Uploadid");
                    objFileUploadMst.Functionid = DataHelper.GetInt(dataReader, "Functionid");
                    objFileUploadMst.FileTile = DataHelper.GetString(dataReader, "FileTile");
                    objFileUploadMst.FileName = DataHelper.GetString(dataReader, "FileName");
                    objFileUploadMst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objFileUploadMst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objFileUploadMst.Deactive = DataHelper.GetInt(dataReader, "Deactive");


                    FileUploadMstList.Add(objFileUploadMst);
                }
            }

            return FileUploadMstList;

        }
        
    }

}





