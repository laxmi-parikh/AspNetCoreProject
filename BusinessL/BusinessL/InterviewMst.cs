using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL
{
   //Date : 29/3/2012
    //Description : Business class
    public class InterviewMst
    {

        
#region Private Properties
 	
	private int _InterviewId;
	private string _Name;
	private string _ApplyForPosition;
	private string _UserName;
	private string _Password;
	private int _Interview;
	private int _inductionId;
	private DateTime _InsertedOn;
	private int _InsertedBy;
	private DateTime _updatedOn;
	private int _updatedby;
	private int _Deactive;
 
 #endregion
 #region Public Properties
 	
	public int InterviewId
	{
		get
		{
			return _InterviewId;
		}
		set
		{
			_InterviewId = value;
		}
	}

	public string Name
	{
		get
		{
			return _Name;
		}
		set
		{
			_Name = value;
		}
	}

	public string ApplyForPosition
	{
		get
		{
			return _ApplyForPosition;
		}
		set
		{
			_ApplyForPosition = value;
		}
	}

	public string UserName
	{
		get
		{
			return _UserName;
		}
		set
		{
			_UserName = value;
		}
	}

	public string Password
	{
		get
		{
			return _Password;
		}
		set
		{
			_Password = value;
		}
	}

	public int Interview
	{
		get
		{
			return _Interview;
		}
		set
		{
			_Interview = value;
		}
	}

	public int inductionId
	{
		get
		{
			return _inductionId;
		}
		set
		{
			_inductionId = value;
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

	public DateTime updatedOn
	{
		get
		{
			return _updatedOn;
		}
		set
		{
			_updatedOn = value;
		}
	}

	public int updatedby
	{
		get
		{
			return _updatedby;
		}
		set
		{
			_updatedby = value;
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
    public class InterviewMstManager
    {
        public enum InterviewMstOperationResult
        {
            InterviewMst_EXISTS,
            InterviewMst_ADDED
        }
        //public const string USER_EXISTS = "InterviewMst_EXISTS";
        //public const string USER_ADDED = "InterviewMst_ADDED";
        private InterviewMstDAL objInterviewMstDAL = new InterviewMstDAL();

        public static InterviewMstOperationResult Add(InterviewMst objInterviewMst)
        {

            int returnValue = InterviewMstDAL.Add(objInterviewMst);
            if (returnValue == 0)
                return InterviewMstOperationResult.InterviewMst_EXISTS;
            else
                return InterviewMstOperationResult.InterviewMst_ADDED;
        }
        public static InterviewMstOperationResult Update(InterviewMst objInterviewMst)
        {
            int returnValue = InterviewMstDAL.Update(objInterviewMst);
            if (returnValue == 0)
                return InterviewMstOperationResult.InterviewMst_EXISTS;
            else
                return InterviewMstOperationResult.InterviewMst_ADDED;
        }
        public static void Delete(int InterviewMstId)
        {
            InterviewMstDAL.Delete(InterviewMstId);
        }
        public static InterviewMst Select(int InterviewMstId)
        {
            return InterviewMstDAL.Select(InterviewMstId);
        }

        public static InterviewMst GetInterviewlogin(string UserName, string Password)
        {
            return InterviewMstDAL.GetInterviewlogin(UserName,Password);
        }

         
        public static List<InterviewMst> GetAll()
        {
            return InterviewMstDAL.GetAll();
        }
    }

    public class InterviewMstDAL
    {
        internal static int Add(InterviewMst objInterviewMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_AddInterviewMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

          SqlParameter  p = new SqlParameter("@Name", objInterviewMst.Name);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@ApplyForPosition", objInterviewMst.ApplyForPosition);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@UserName", objInterviewMst.UserName);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Password", objInterviewMst.Password);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Interview", objInterviewMst.Interview);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@inductionId", objInterviewMst.inductionId);
	 comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int Update(InterviewMst objInterviewMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateInterviewMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@InterviewId", objInterviewMst.InterviewId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Name", objInterviewMst.Name);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@ApplyForPosition", objInterviewMst.ApplyForPosition);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@UserName", objInterviewMst.UserName);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Password", objInterviewMst.Password);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Interview", objInterviewMst.Interview);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@inductionId", objInterviewMst.inductionId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@InsertedOn", objInterviewMst.InsertedOn);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@InsertedBy", objInterviewMst.InsertedBy);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@updatedOn", objInterviewMst.updatedOn);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@updatedby", objInterviewMst.updatedby);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Deactive", objInterviewMst.Deactive);
	 comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int InterviewMstId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteInterviewMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@InterviewId", InterviewMstId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static InterviewMst Select(int InterviewMstId)
        {
            SqlCommand comm = new SqlCommand();
            InterviewMst objInterviewMst = null;           
            comm.CommandText = "usp_selectInterviewMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@InterviewId", InterviewMstId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objInterviewMst = new InterviewMst();
                    objInterviewMst.InterviewId= DataHelper.GetInt(dataReader, "InterviewId"); 
objInterviewMst.Name= DataHelper.GetString(dataReader, "Name"); 
objInterviewMst.ApplyForPosition= DataHelper.GetString(dataReader, "ApplyForPosition"); 
objInterviewMst.UserName= DataHelper.GetString(dataReader, "UserName"); 
objInterviewMst.Password= DataHelper.GetString(dataReader, "Password"); 
objInterviewMst.Interview= DataHelper.GetInt(dataReader, "Interview"); 
objInterviewMst.inductionId= DataHelper.GetInt(dataReader, "inductionId"); 
objInterviewMst.InsertedOn= DataHelper.GetDateTime(dataReader, "InsertedOn"); 
objInterviewMst.InsertedBy= DataHelper.GetInt(dataReader, "InsertedBy"); 
objInterviewMst.updatedOn= DataHelper.GetDateTime(dataReader, "updatedOn"); 
objInterviewMst.updatedby= DataHelper.GetInt(dataReader, "updatedby"); 
objInterviewMst.Deactive= DataHelper.GetInt(dataReader, "Deactive"); 


                    
                }
            }

            return objInterviewMst;

        }


       // usp_getInterviewlogin(@userName nvarchar(50),@Password nvarchar(50))


        internal static InterviewMst GetInterviewlogin(string UserName,string Password)
        {
            SqlCommand comm = new SqlCommand();
            InterviewMst objInterviewMst = null;
            comm.CommandText = "usp_getInterviewlogin";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@userName", UserName);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Password", Password);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objInterviewMst = new InterviewMst();
                    objInterviewMst.InterviewId = DataHelper.GetInt(dataReader, "InterviewId");
                    objInterviewMst.Name = DataHelper.GetString(dataReader, "Name");
                    objInterviewMst.ApplyForPosition = DataHelper.GetString(dataReader, "ApplyForPosition");
                    objInterviewMst.UserName = DataHelper.GetString(dataReader, "UserName");
                    objInterviewMst.Password = DataHelper.GetString(dataReader, "Password");
                    objInterviewMst.Interview = DataHelper.GetInt(dataReader, "Interview");
                    objInterviewMst.inductionId = DataHelper.GetInt(dataReader, "inductionId");
                    objInterviewMst.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objInterviewMst.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                    objInterviewMst.updatedOn = DataHelper.GetDateTime(dataReader, "updatedOn");
                    objInterviewMst.updatedby = DataHelper.GetInt(dataReader, "updatedby");
                    objInterviewMst.Deactive = DataHelper.GetInt(dataReader, "Deactive");



                }
            }

            return objInterviewMst;

        }
        public static List<InterviewMst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            InterviewMst objInterviewMst = null;
            List<InterviewMst> InterviewMstList = new List<InterviewMst>();
            comm.CommandText = "usp_GetAllInterviewMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objInterviewMst = new InterviewMst();
                    objInterviewMst.InterviewId= DataHelper.GetInt(dataReader, "InterviewId"); 
objInterviewMst.Name= DataHelper.GetString(dataReader, "Name"); 
objInterviewMst.ApplyForPosition= DataHelper.GetString(dataReader, "ApplyForPosition"); 
objInterviewMst.UserName= DataHelper.GetString(dataReader, "UserName"); 
objInterviewMst.Password= DataHelper.GetString(dataReader, "Password"); 
objInterviewMst.Interview= DataHelper.GetInt(dataReader, "Interview"); 
objInterviewMst.inductionId= DataHelper.GetInt(dataReader, "inductionId"); 
objInterviewMst.InsertedOn= DataHelper.GetDateTime(dataReader, "InsertedOn"); 
objInterviewMst.InsertedBy= DataHelper.GetInt(dataReader, "InsertedBy"); 
objInterviewMst.updatedOn= DataHelper.GetDateTime(dataReader, "updatedOn"); 
objInterviewMst.updatedby= DataHelper.GetInt(dataReader, "updatedby"); 
objInterviewMst.Deactive= DataHelper.GetInt(dataReader, "Deactive"); 


                    InterviewMstList.Add(objInterviewMst);
                }
            }

            return InterviewMstList;

        }
    }

}





