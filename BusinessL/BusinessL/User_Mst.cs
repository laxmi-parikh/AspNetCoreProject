using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
//using Bll;

namespace BusinessL
{
   //Date : 6/12/2010
    //Description : Business class
    public class User_Mst
    {
     
     #region Private Properties
 	
	private int _UserId;
	private int _UserRoleId;
	private string _EmailId;
	private string _UserName;
	private string _Password;
	private string _FirstName;
	private string _MiddleName;
	private string _LastName;
	private string _Gender;
	private string _DateOfBirh;
	private string _PostalAddress;
	private int _CountryId;
	private int _StateId;
	private int _CityId;
	private string _PinCode;
	private string _MoblieNumber;
	private string _FaxNumber;
	private string _Qualification;
	private string _CurrentEmployer;
    private string _ParentName;    
    private string _ParentMobile;   
    private string _CollegeName;   
    private string _Place;   
    private string _Taluka;   
    private string _District;
    private int _Deactive;
    private string _Rid;
    private string _Class;
    private string _JoiningKitOn;
    private string _EmployeeCode;
    private string _Technical;

        

  


 
 #endregion
     #region Public Properties

    public string Technical
    {
        get { return _Technical; }
        set { _Technical = value; }
    }
    public string EmployeeCode
    {
        get { return _EmployeeCode; }
        set { _EmployeeCode = value; }
    }
    public string Class
    {
        get
        {
            return _Class;
        }
        set
        {
            _Class = value;
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
    public string Rid
    {
        get { return _Rid; }
        set { _Rid = value; }
    }
    public string CollegeName
    {
        get { return _CollegeName; }
        set { _CollegeName = value; }
    }
    public string District
    {
        get { return _District; }
        set { _District = value; }
    }
    public string Place
    {
        get { return _Place; }
        set { _Place = value; }
    }
    public string Taluka
    {
        get { return _Taluka; }
        set { _Taluka = value; }
    }
	public int UserId
	{
		get
		{
			return _UserId;
		}
		set
		{
			_UserId = value;
		}
	}

	public int UserRoleId
	{
		get
		{
			return _UserRoleId;
		}
		set
		{
			_UserRoleId = value;
		}
	}

	public string EmailId
	{
		get
		{
			return _EmailId;
		}
		set
		{
			_EmailId = value;
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

	public string FirstName
	{
		get
		{
			return _FirstName;
		}
		set
		{
			_FirstName = value;
		}
	}

	public string MiddleName
	{
		get
		{
			return _MiddleName;
		}
		set
		{
			_MiddleName = value;
		}
	}

	public string LastName
	{
		get
		{
			return _LastName;
		}
		set
		{
			_LastName = value;
		}
	}

	public string Gender
	{
		get
		{
			return _Gender;
		}
		set
		{
			_Gender = value;
		}
	}

	public string DateOfBirh
	{
		get
		{
			return _DateOfBirh;
		}
		set
		{
			_DateOfBirh = value;
		}
	}

	public string PostalAddress
	{
		get
		{
			return _PostalAddress;
		}
		set
		{
			_PostalAddress = value;
		}
	}

	public int CountryId
	{
		get
		{
			return _CountryId;
		}
		set
		{
			_CountryId = value;
		}
	}

	public int StateId
	{
		get
		{
			return _StateId;
		}
		set
		{
			_StateId = value;
		}
	}

	public int CityId
	{
		get
		{
			return _CityId;
		}
		set
		{
			_CityId = value;
		}
	}

	public string PinCode
	{
		get
		{
			return _PinCode;
		}
		set
		{
			_PinCode = value;
		}
	}

	public string MoblieNumber
	{
		get
		{
			return _MoblieNumber;
		}
		set
		{
			_MoblieNumber = value;
		}
	}

	public string FaxNumber
	{
		get
		{
			return _FaxNumber;
		}
		set
		{
			_FaxNumber = value;
		}
	}

	public string Qualification
	{
		get
		{
			return _Qualification;
		}
		set
		{
			_Qualification = value;
		}
	}

	public string CurrentEmployer
	{
		get
		{
			return _CurrentEmployer;
		}
		set
		{
			_CurrentEmployer = value;
		}
	}
    public string ParentMobile
    {
        get { return _ParentMobile; }
        set { _ParentMobile = value; }
    }
    public string ParentName
    {
        get { return _ParentName; }
        set { _ParentName = value; }
    }
    public string JoiningKitOn
    {
        get { return _JoiningKitOn; }
        set { _JoiningKitOn = value; }
    }

 #endregion
    }
    public class User_MstManager
    {
        public enum User_MstOperationResult
        {
            User_Mst_EXISTS,
            User_Mst_ADDED
        }
        //public const string USER_EXISTS = "User_Mst_EXISTS";
        //public const string USER_ADDED = "User_Mst_ADDED";
        private User_MstDAL objUser_MstDAL = new User_MstDAL();

        public static int Add(User_Mst objUser_Mst)
        {

            int returnValue = User_MstDAL.Add(objUser_Mst);
            if (returnValue == 0)
                return returnValue;
            else
                return returnValue;
        }
        public static User_MstOperationResult Update(User_Mst objUser_Mst)
        {
            int returnValue = User_MstDAL.Update(objUser_Mst);
            if (returnValue == 0)
                return User_MstOperationResult.User_Mst_EXISTS;
            else
                return User_MstOperationResult.User_Mst_ADDED;
        }
        public static User_MstOperationResult Update(int userid)
        {
            int returnValue = User_MstDAL.Update(userid);
            if (returnValue == 0)
                return User_MstOperationResult.User_Mst_EXISTS;
            else
                return User_MstOperationResult.User_Mst_ADDED;
        }
        public static User_MstOperationResult UpdatePassword(User_Mst objUser_Mst)
        {
            int returnValue = User_MstDAL.UpdatePassword(objUser_Mst);
            if (returnValue == 0)
                return User_MstOperationResult.User_Mst_EXISTS;
            else
                return User_MstOperationResult.User_Mst_ADDED;
        }



        public static void Delete(int UserId)
        {
            User_MstDAL.Delete(UserId);
        }
        public static User_Mst Select(int UserId)
        {
            return User_MstDAL.Select(UserId);
        }

         public static User_Mst GetPswdByUserName(string EmailId)
        {
            return  User_MstDAL.GetPswdByUserName(EmailId);
        }

         public static User_Mst GetAdmin(string email, string password)
         {
             return User_MstDAL.Selectadmin(email, password);

         }
    
        public static List<User_Mst> GetAll()
        {
            return User_MstDAL.GetAll();
        }
        public static List<User_Mst> GetAll(bool flag)
        {
            return User_MstDAL.GetAll(flag);
        }

        public static List<User_Mst> GetDetailsByID(int UserID)
        {
            return User_MstDAL.GetDetailsBYID(UserID);

        }
        public static DataSet getuserreport(int userid)
        {
            return DataConnector.GetDataSet("usp_getuserreport " + userid);
        }
        public static DataSet getusername()
        {
            return DataConnector.GetDataSet("usp_getonlyusername");
        }
        public static DataSet GetPhysicTest()
        {
            DataSet ds;

            ds = DataConnector.GetDataSet("usp_GetPhysicTest ");


            return ds;

        }
        public static DataSet GETQUESTIONSET(int SubjectID, int UserID)
        {
            DataSet ds;

            ds = DataConnector.GetDataSet("Usp_GETQUESTIONSET " + SubjectID + "," + UserID);


            return ds;

        }
        public static DataSet GETQUESTIONBYSUBJECT(int SubjectID, int LessonId, string Source)
        {
            DataSet ds;

            ds = DataConnector.GetDataSet("Usp_GETQUESTIONBYSUBJECT '" + SubjectID + "','" + LessonId + "','" + Source + "'");


            return ds;

        }


        public static DataSet GetResult(int StudentId, int SubjectId)
        {
            DataSet ds;

            ds = DataConnector.GetDataSet("usp_GetResult " + StudentId + "," + SubjectId);


            return ds;

        }
        public static DataSet GetMarks(int UserId, int SubjectId, int SetId)
        {
            DataSet ds;

            ds = DataConnector.GetDataSet("usp_getMarks " + UserId + "," + SubjectId + "," + SetId);


            return ds;

        }
         public static DataSet GetUserByFunctionId(int FunctionId)
        {
            DataSet ds;

            ds = DataConnector.GetDataSet("usp_GetUserByFunctionId " +FunctionId );


            return ds;

        }

         public static DataSet GetallDetail(int userid,int FunctionId)
         {
             DataSet ds;

             ds = DataConnector.GetDataSet("usp_GetallDetail "+ userid+"," + FunctionId);


             return ds;

         }

         //public static DataSet GetallDetail(int userid,int FunctionId)
         //{
         //    DataSet ds;

         //    ds = DataConnector.GetDataSet("usp_GetallDetail "+ userid+"," + FunctionId);


         //    return ds;

         //}

          public static DataSet GetallDetail1(int FunctionId)
         {
             DataSet ds;

             ds = DataConnector.GetDataSet("usp_GetallDetail1 "+ FunctionId);


             return ds;

         }

        //usp_GetallDetail1(@FunctionId int
              

        //usp_GetallDatail(@userId int,@FunctionId int)

        public static bool CheckAuthentication(string StrUserName, string StrPassword, out User_Mst obj)
        {
            // string strhashPwd = "";
            User_Mst objUsermst = User_MstDAL.CheckAuthentication(StrUserName, StrPassword);
            obj = null;
            if (objUsermst.UserName != null)
            {
                obj = objUsermst;
                // FormsAuthentication.HashPasswordForStoringInConfigFile(StrPassword, "Hi");
                return true;
            }
            return false;
            throw new System.NotImplementedException();
        }





        public IDataReader forgetpassword(string stremail, string strmobile)
        {
            try
            {

                SqlDataReader dr = DataConnector.GetDataReader("usp_SelectPassword '" + stremail + "','" + strmobile + "'");
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string strpassword = dr["password"].ToString();
                        string strUserName = dr["EmailId"].ToString();
                        string strFirsrName = dr["FirstName"].ToString();

                    }

                }
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

    public class User_MstDAL
    {
        public static User_Mst GetPswdByUserName(String EmailId)
        {
            SqlCommand comm = new SqlCommand();
            User_Mst objUser_Mst = null;

            comm.CommandText = "usp_GetPswdfromEmailId";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@EmailId", EmailId);
            comm.Parameters.Add(p);

            //p = new SqlParameter("@MobileNumber", MobileNumber);
            //comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objUser_Mst = new User_Mst();
                    //objUser_Mst.UserId = DataHelper.GetInt(dataReader, "UserId");
                    //objUser_Mst.UserRoleId = DataHelper.GetInt(dataReader, "UserRoleId");
                    objUser_Mst.EmailId = DataHelper.GetString(dataReader, "EmailId");
                    //objUser_Mst.UserName = DataHelper.GetString(dataReader, "UserName");
                    objUser_Mst.Password = DataHelper.GetString(dataReader, "Password");
                    objUser_Mst.FirstName = DataHelper.GetString(dataReader, "FirstName");
                    //objUser_Mst.MiddleName = DataHelper.GetString(dataReader, "MiddleName");
                    //objUser_Mst.LastName = DataHelper.GetString(dataReader, "LastName");
                    //objUser_Mst.Gender = DataHelper.GetString(dataReader, "Gender");
                    //objUser_Mst.DateOfBirh = DataHelper.GetString(dataReader, "DateOfBirh");
                    //objUser_Mst.PostalAddress = DataHelper.GetString(dataReader, "PostalAddress");
                    //objUser_Mst.CountryId = DataHelper.GetInt(dataReader, "CountryId");
                    //objUser_Mst.StateId = DataHelper.GetInt(dataReader, "StateId");
                    //objUser_Mst.CityId = DataHelper.GetInt(dataReader, "CityId");
                    //objUser_Mst.PinCode = DataHelper.GetString(dataReader, "PinCode");
                    objUser_Mst.MoblieNumber = DataHelper.GetString(dataReader, "MoblieNumber");
                    //   objUser_Mst.FaxNumber= DataHelper.GetString(dataReader, "FaxNumber"); 
                    //objUser_Mst.Qualification = DataHelper.GetString(dataReader, "Qualification");
                    ////  objUser_Mst.CurrentEmployer= DataHelper.GetString(dataReader, "CurrentEmployer");
                    //objUser_Mst.ParentName = DataHelper.GetString(dataReader, "ParentName");
                    //objUser_Mst.ParentMobile = DataHelper.GetString(dataReader, "ParentMobile");
                    //objUser_Mst.CollegeName = DataHelper.GetString(dataReader, "CollegeName");
                    //objUser_Mst.Place = DataHelper.GetString(dataReader, "Place");
                    //objUser_Mst.Taluka = DataHelper.GetString(dataReader, "Taluka");
                    //objUser_Mst.District = DataHelper.GetString(dataReader, "District");
                    //objUser_Mst.JoiningKitOn = DataHelper.GetInt(dataReader, "JoiningKitOn").ToString();
                    //objUser_Mst.Technical = DataHelper.GetString(dataReader, "Technical");
                }
            }
            return objUser_Mst;
        }

        internal static User_Mst CheckAuthentication(string StrUserName, string StrPassword)
        {
            User_Mst obj = new User_Mst();
            IDataReader dr = null;
            dr = DataConnector.GetDataReader("usp_checkuserpassword '" + StrUserName + "','" + StrPassword + "'");
            while (dr.Read())
            {
                obj.UserName = Convert.ToString(dr["EmailId"]);
                obj.FirstName = Convert.ToString(dr["FirstName"]);
                obj.UserId = Convert.ToInt32(dr["UserId"]);
                obj.LastName = Convert.ToString(dr["LastName"]);
                
               
            }
            return obj;
            throw new System.NotImplementedException();
        }
        internal static int Add(User_Mst objUserMst)
        {
            int UserId;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "Usp_AddUserMst";
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
                //comm.Parameters.Add(p);
                SqlParameter p = new SqlParameter("@EmployeeCode", objUserMst.EmployeeCode);
                comm.Parameters.Add(p);
                p = new SqlParameter("@EmailId", objUserMst.EmailId);
                comm.Parameters.Add(p);
                p = new SqlParameter("@Password", objUserMst.Password);
                comm.Parameters.Add(p);
                p = new SqlParameter("@FirstName", objUserMst.FirstName);
                comm.Parameters.Add(p);
                p = new SqlParameter("@MiddleName", objUserMst.MiddleName);
                comm.Parameters.Add(p);
                p = new SqlParameter("@LastName", objUserMst.LastName);
                comm.Parameters.Add(p);
                p = new SqlParameter("@Gender", objUserMst.Gender);
                comm.Parameters.Add(p);
                p = new SqlParameter("@DateOfBirh", DateTime .Now);
                comm.Parameters.Add(p);
                p = new SqlParameter("@PostalAddress", objUserMst.PostalAddress);
                comm.Parameters.Add(p);
                p = new SqlParameter("@CountryId", objUserMst.CountryId);
                comm.Parameters.Add(p);
                p = new SqlParameter("@StateId", objUserMst.StateId);
                comm.Parameters.Add(p);
                p = new SqlParameter("@CityId", objUserMst.CityId);
                comm.Parameters.Add(p);
                p = new SqlParameter("@PinCode", objUserMst.PinCode);
                comm.Parameters.Add(p);
                p = new SqlParameter("@MoblieNumber", objUserMst.MoblieNumber);
                comm.Parameters.Add(p);
                p = new SqlParameter("@Qualification", objUserMst.Qualification);
                comm.Parameters.Add(p);
                p = new SqlParameter("@ParentName","");
                comm.Parameters.Add(p);
                p = new SqlParameter("@ParentMobile", "");
                comm.Parameters.Add(p);
                p = new SqlParameter("@CollegeName", "");
                comm.Parameters.Add(p);
                p = new SqlParameter("@Class", "");
                comm.Parameters.Add(p);
                p = new SqlParameter("@Place", "");
                comm.Parameters.Add(p);
                p = new SqlParameter("@Taluka", "");
                comm.Parameters.Add(p);
                p = new SqlParameter("@District", "");
                comm.Parameters.Add(p);
                p = new SqlParameter("@Deactive", "0");
                comm.Parameters.Add(p);
                p = new SqlParameter("@RID","");
                comm.Parameters.Add(p);
                p = new SqlParameter("@Technical", objUserMst.Technical);
                comm.Parameters.Add(p);
                 

                UserId = Convert.ToInt32(DataConnector.ExecuteScalar(comm));
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return UserId;

        }
        internal static int Update(User_Mst objUser_Mst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateUser_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		            SqlParameter p = new SqlParameter("@UserId", objUser_Mst.UserId);
	              comm.Parameters.Add(p);
                
                  p = new SqlParameter("@EmailId", objUser_Mst.EmailId);
	                 comm.Parameters.Add(p);
               
                 
                  p = new SqlParameter("@FirstName", objUser_Mst.FirstName);
	                 comm.Parameters.Add(p);
                  p = new SqlParameter("@MiddleName", objUser_Mst.MiddleName);
	                 comm.Parameters.Add(p);
                  p = new SqlParameter("@LastName", objUser_Mst.LastName);
	                 comm.Parameters.Add(p);
                  p = new SqlParameter("@Gender", objUser_Mst.Gender);
	                 comm.Parameters.Add(p);
                
                  p = new SqlParameter("@MoblieNumber", objUser_Mst.MoblieNumber);
	                 comm.Parameters.Add(p);
                     p = new SqlParameter("@EmployeeCode", objUser_Mst.EmployeeCode);
                     comm.Parameters.Add(p);

                     p = new SqlParameter("@Technical", objUser_Mst.Technical);
                     comm.Parameters.Add(p);
                 

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int Update(int userid)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_updateuserlevel";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@userid", userid);
            comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int UpdatePassword(User_Mst objUser_Mst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdatePasswordUser_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		            SqlParameter  p = new SqlParameter("@EmailId", objUser_Mst.EmailId);
	                 comm.Parameters.Add(p);
               
                 
                  p = new SqlParameter("@Password", objUser_Mst.Password);
	                 comm.Parameters.Add(p);
               
               

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int UserId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteUser_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@UserId", UserId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static User_Mst Select(int UserId)
        {
            SqlCommand comm = new SqlCommand();
            User_Mst objUser_Mst = null;           
            comm.CommandText = "usp_selectUser_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@UserId", UserId);
            comm.Parameters.Add(p);
            
            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                
                while (dataReader.Read())
                {
                    objUser_Mst = new User_Mst();
                    objUser_Mst.UserId = DataHelper.GetInt(dataReader, "UserId");
                   // objUser_Mst.UserRoleId = DataHelper.GetInt(dataReader, "UserRoleId");
                    objUser_Mst.EmailId = DataHelper.GetString(dataReader, "EmailId");
                    //objUser_Mst.UserName = DataHelper.GetString(dataReader, "UserName");
                    objUser_Mst.FirstName = DataHelper.GetString(dataReader, "FirstName");
                    objUser_Mst.MiddleName = DataHelper.GetString(dataReader, "MiddleName");
                    objUser_Mst.LastName = DataHelper.GetString(dataReader, "LastName");
                    objUser_Mst.Gender = DataHelper.GetString(dataReader, "Gender");
                    objUser_Mst.DateOfBirh = DataHelper.GetString(dataReader, "DateOfBirh");
                    objUser_Mst.PostalAddress = DataHelper.GetString(dataReader, "PostalAddress");
                   // objUser_Mst.CountryId = DataHelper.GetInt(dataReader, "CountryId");
                   // objUser_Mst.StateId = DataHelper.GetInt(dataReader, "StateId");
                   // objUser_Mst.CityId = DataHelper.GetInt(dataReader, "CityId");
                    objUser_Mst.PinCode = DataHelper.GetString(dataReader, "PinCode");
                    objUser_Mst.MoblieNumber = DataHelper.GetString(dataReader, "MoblieNumber");
                    objUser_Mst.Qualification = DataHelper.GetString(dataReader, "Qualification");
                    objUser_Mst.ParentName = DataHelper.GetString(dataReader, "ParentName");
                    objUser_Mst.ParentMobile = DataHelper.GetString(dataReader, "ParentMobile");
                    objUser_Mst.CollegeName = DataHelper.GetString(dataReader, "CollegeName");
                    objUser_Mst.Class = DataHelper.GetString(dataReader, "Class");
                    objUser_Mst.Place = DataHelper.GetString(dataReader, "Place");
                    objUser_Mst.Taluka = DataHelper.GetString(dataReader, "Taluka");
                    objUser_Mst.District = DataHelper.GetString(dataReader, "District");
                    objUser_Mst.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    objUser_Mst.Rid = DataHelper.GetString(dataReader, "RID");
                    objUser_Mst.Technical = DataHelper.GetString(dataReader, "Technical");

                    objUser_Mst.EmployeeCode = DataHelper.GetString(dataReader, "EmployeeCode");

                    
                }
            }

            return objUser_Mst;

        }
       // 
        internal static User_Mst Selectadmin(string Email, string Password)
        {
            SqlCommand comm = new SqlCommand();
            User_Mst objUser_Mst = null;
            comm.CommandText = "usp_GetAdminLogin";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@UserName", Email);
            comm.Parameters.Add(p);

            p = new SqlParameter("@Password", Password);
            comm.Parameters.Add(p);


            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {

                while (dataReader.Read())
                {
                    objUser_Mst = new User_Mst();
                    objUser_Mst.UserId = DataHelper.GetInt(dataReader, "LoginID");
                    // objUser_Mst.UserRoleId = DataHelper.GetInt(dataReader, "UserRoleId");
                    objUser_Mst.Password = DataHelper.GetString(dataReader, "Pwd");
                    //objUser_Mst.UserName = DataHelper.GetString(dataReader, "UserName");
                    //objUser_Mst.FirstName = DataHelper.GetString(dataReader, "FirstName");
                    //objUser_Mst.MiddleName = DataHelper.GetString(dataReader, "MiddleName");
                    //objUser_Mst.LastName = DataHelper.GetString(dataReader, "LastName");
                    //objUser_Mst.Gender = DataHelper.GetString(dataReader, "Gender");
                    //objUser_Mst.DateOfBirh = DataHelper.GetString(dataReader, "DateOfBirh");
                    //objUser_Mst.PostalAddress = DataHelper.GetString(dataReader, "PostalAddress");
                    //objUser_Mst.CountryId = DataHelper.GetInt(dataReader, "CountryId");
                    //objUser_Mst.StateId = DataHelper.GetInt(dataReader, "StateId");
                    //objUser_Mst.CityId = DataHelper.GetInt(dataReader, "CityId");
                    //objUser_Mst.PinCode = DataHelper.GetString(dataReader, "PinCode");
                    //objUser_Mst.MoblieNumber = DataHelper.GetString(dataReader, "MoblieNumber");
                    //objUser_Mst.Qualification = DataHelper.GetString(dataReader, "Qualification");
                    //objUser_Mst.ParentName = DataHelper.GetString(dataReader, "ParentName");
                    //objUser_Mst.ParentMobile = DataHelper.GetString(dataReader, "ParentMobile");
                    //objUser_Mst.CollegeName = DataHelper.GetString(dataReader, "CollegeName");
                    //objUser_Mst.Class = DataHelper.GetString(dataReader, "Class");
                    //objUser_Mst.Place = DataHelper.GetString(dataReader, "Place");
                    //objUser_Mst.Taluka = DataHelper.GetString(dataReader, "Taluka");
                    //objUser_Mst.District = DataHelper.GetString(dataReader, "District");
                    //objUser_Mst.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    //objUser_Mst.Rid = DataHelper.GetString(dataReader, "RID");
                    //objUser_Mst.Technical = DataHelper.GetString(dataReader, "Technical");

                    //objUser_Mst.EmployeeCode = DataHelper.GetString(dataReader, "EmployeeCode");


                }
            }

            return objUser_Mst;

        }
        public static List<User_Mst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            User_Mst objUser_Mst = null;
            List<User_Mst> User_MstList = new List<User_Mst>();
            comm.CommandText = "usp_GetAllUser_Mst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objUser_Mst = new User_Mst();
                    objUser_Mst.UserId = DataHelper.GetInt(dataReader, "UserId");
                    // objUser_Mst.UserRoleId = DataHelper.GetInt(dataReader, "UserRoleId");
                    objUser_Mst.EmailId = DataHelper.GetString(dataReader, "EmailId");
                    //objUser_Mst.UserName = DataHelper.GetString(dataReader, "UserName");
                    objUser_Mst.FirstName = DataHelper.GetString(dataReader, "FirstName");
                    objUser_Mst.MiddleName = DataHelper.GetString(dataReader, "MiddleName");
                    objUser_Mst.LastName = DataHelper.GetString(dataReader, "LastName");
                    objUser_Mst.Gender = DataHelper.GetString(dataReader, "Gender");
                    objUser_Mst.DateOfBirh = DataHelper.GetString(dataReader, "DateOfBirh");
                    //objUser_Mst.PostalAddress = DataHelper.GetString(dataReader, "PostalAddress");
                    //objUser_Mst.CountryId = DataHelper.GetInt(dataReader, "CountryId");
                   // objUser_Mst.StateId = DataHelper.GetInt(dataReader, "StateId");
                   // objUser_Mst.CityId = DataHelper.GetInt(dataReader, "CityId");
                   // objUser_Mst.PinCode = DataHelper.GetString(dataReader, "PinCode");
                    objUser_Mst.MoblieNumber = DataHelper.GetString(dataReader, "MoblieNumber");
                    objUser_Mst.Qualification = DataHelper.GetString(dataReader, "Qualification");
                    objUser_Mst.ParentName = DataHelper.GetString(dataReader, "ParentName");
                    objUser_Mst.ParentMobile = DataHelper.GetString(dataReader, "ParentMobile");
                    objUser_Mst.CollegeName = DataHelper.GetString(dataReader, "CollegeName");
                    objUser_Mst.Class = DataHelper.GetString(dataReader, "Class");
                    objUser_Mst.Place = DataHelper.GetString(dataReader, "Place");
                    objUser_Mst.Taluka = DataHelper.GetString(dataReader, "Taluka");
                    objUser_Mst.District = DataHelper.GetString(dataReader, "District");
                    objUser_Mst.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    objUser_Mst.Rid = DataHelper.GetString(dataReader, "RID");
                    objUser_Mst.Technical = DataHelper.GetString(dataReader, "Technical");
                    objUser_Mst.EmployeeCode = DataHelper.GetString(dataReader, "EmployeeCode");

                    User_MstList.Add(objUser_Mst);
                }
            }

            return User_MstList;

        }
        public static List<User_Mst> GetAll(bool flag)
        {
            SqlCommand comm = new SqlCommand();
            User_Mst objUser_Mst = null;
            List<User_Mst> User_MstList = new List<User_Mst>();
            comm.CommandText = "usp_GetAllUser_Mst1";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objUser_Mst = new User_Mst();
                    objUser_Mst.UserId = DataHelper.GetInt(dataReader, "UserId");
                    // objUser_Mst.UserRoleId = DataHelper.GetInt(dataReader, "UserRoleId");
                    objUser_Mst.EmailId = DataHelper.GetString(dataReader, "EmailId");
                    //objUser_Mst.UserName = DataHelper.GetString(dataReader, "UserName");
                    objUser_Mst.FirstName = DataHelper.GetString(dataReader, "FirstName");
                    //objUser_Mst.MiddleName = DataHelper.GetString(dataReader, "MiddleName");
                    objUser_Mst.LastName = DataHelper.GetString(dataReader, "LastName");
                    //objUser_Mst.Gender = DataHelper.GetString(dataReader, "Gender");
                    //objUser_Mst.DateOfBirh = DataHelper.GetString(dataReader, "DateOfBirh");
                    //objUser_Mst.PostalAddress = DataHelper.GetString(dataReader, "PostalAddress");
                    //objUser_Mst.CountryId = DataHelper.GetInt(dataReader, "CountryId");
                    //objUser_Mst.StateId = DataHelper.GetInt(dataReader, "StateId");
                    //objUser_Mst.CityId = DataHelper.GetInt(dataReader, "CityId");
                    //objUser_Mst.PinCode = DataHelper.GetString(dataReader, "PinCode");
                    objUser_Mst.MoblieNumber = DataHelper.GetString(dataReader, "MoblieNumber");
                    //objUser_Mst.Qualification = DataHelper.GetString(dataReader, "Qualification");
                    //objUser_Mst.ParentName = DataHelper.GetString(dataReader, "ParentName");
                    //objUser_Mst.ParentMobile = DataHelper.GetString(dataReader, "ParentMobile");
                    //objUser_Mst.CollegeName = DataHelper.GetString(dataReader, "CollegeName");
                    //objUser_Mst.Class = DataHelper.GetString(dataReader, "Class");
                    //objUser_Mst.Place = DataHelper.GetString(dataReader, "Place");
                    //objUser_Mst.Taluka = DataHelper.GetString(dataReader, "Taluka");
                    //objUser_Mst.District = DataHelper.GetString(dataReader, "District");
                    //objUser_Mst.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    //objUser_Mst.Rid = DataHelper.GetString(dataReader, "RID");
                    objUser_Mst.Technical = DataHelper.GetString(dataReader, "Technical");
                    objUser_Mst.EmployeeCode = DataHelper.GetString(dataReader, "EmployeeCode");

                    User_MstList.Add(objUser_Mst);
                }
            }

            return User_MstList;

        }
        public static List<User_Mst> GetDetailsBYID(int ID)
        {
            SqlCommand comm = new SqlCommand();
            User_Mst objUser_Mst = null;
            List<User_Mst> User_MstList = new List<User_Mst>();
            comm.CommandText = "Usp_GETUserDetailBYID";
            comm.CommandType = System.Data.CommandType.StoredProcedure;


            SqlParameter p = new SqlParameter("@UserId", ID);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objUser_Mst = new User_Mst();
                    objUser_Mst.UserId = DataHelper.GetInt(dataReader, "UserId");
                    //objUser_Mst.UserRoleId = DataHelper.GetInt(dataReader, "UserRoleId");
                    objUser_Mst.EmailId = DataHelper.GetString(dataReader, "EmailId");
                   // objUser_Mst.UserName = DataHelper.GetString(dataReader, "UserName");
                    //  objUser_Mst.Password= DataHelper.GetString(dataReader, "Password"); 
                    objUser_Mst.FirstName = DataHelper.GetString(dataReader, "FirstName");
                    objUser_Mst.MiddleName = DataHelper.GetString(dataReader, "MiddleName");
                    objUser_Mst.LastName = DataHelper.GetString(dataReader, "LastName");
                    objUser_Mst.Gender = DataHelper.GetString(dataReader, "Gender");
                    objUser_Mst.DateOfBirh = DataHelper.GetString(dataReader, "DateOfBirh");
                    objUser_Mst.PostalAddress = DataHelper.GetString(dataReader, "PostalAddress");
                    objUser_Mst.CountryId = DataHelper.GetInt(dataReader, "CountryId");
                    objUser_Mst.StateId = DataHelper.GetInt(dataReader, "StateId");
                    objUser_Mst.CityId = DataHelper.GetInt(dataReader, "CityId");
                    objUser_Mst.PinCode = DataHelper.GetString(dataReader, "PinCode");
                    objUser_Mst.MoblieNumber = DataHelper.GetString(dataReader, "MoblieNumber");
                    //   objUser_Mst.FaxNumber= DataHelper.GetString(dataReader, "FaxNumber"); 
                    objUser_Mst.Qualification = DataHelper.GetString(dataReader, "Qualification");
                    //  objUser_Mst.CurrentEmployer= DataHelper.GetString(dataReader, "CurrentEmployer");
                    objUser_Mst.ParentName = DataHelper.GetString(dataReader, "ParentName");
                    objUser_Mst.ParentMobile = DataHelper.GetString(dataReader, "ParentMobile");
                    objUser_Mst.CollegeName = DataHelper.GetString(dataReader, "CollegeName");
                    objUser_Mst.Place = DataHelper.GetString(dataReader, "Place");
                    objUser_Mst.Taluka = DataHelper.GetString(dataReader, "Taluka");
                    objUser_Mst.District = DataHelper.GetString(dataReader, "District");
                    objUser_Mst.Technical = DataHelper.GetString(dataReader, "Technical");
                      objUser_Mst.EmployeeCode = DataHelper.GetString(dataReader, "EmployeeCode");


                    User_MstList.Add(objUser_Mst);
                }
            }

            return User_MstList;
        
        }
    }

   public class Timer_Mst
   {
  #region Private Properties
 	
	private int _TimerId;
	private DateTime _StartTime;
	private DateTime _EndTime;
	private int _StudentId;
 
 #endregion
 #region Public Properties
 	
	public int TimerId
	{
		get
		{
			return _TimerId;
		}
		set
		{
			_TimerId = value;
		}
	}

	public DateTime StartTime
	{
		get
		{
			return _StartTime;
		}
		set
		{
			_StartTime = value;
		}
	}

	public DateTime EndTime
	{
		get
		{
			return _EndTime;
		}
		set
		{
			_EndTime = value;
		}
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

 
 #endregion
    }
    public class TimerManager
    {
        public enum TimerOperationResult
        {
            Timer_EXISTS,
            Timer_ADDED
        }
        //public const string USER_EXISTS = "Timer_EXISTS";
        //public const string USER_ADDED = "Timer_ADDED";
        private TimerDAL objTimerDAL = new TimerDAL();

        public static TimerOperationResult Add(Timer_Mst objTimer)
        {

            int returnValue = TimerDAL.Add(objTimer);
            if (returnValue == 0)
                return TimerOperationResult.Timer_EXISTS;
            else
                return TimerOperationResult.Timer_ADDED;
        }
        public static TimerOperationResult Update(Timer_Mst objTimer)
        {
            int returnValue = TimerDAL.Update(objTimer);
            if (returnValue == 0)
                return TimerOperationResult.Timer_EXISTS;
            else
                return TimerOperationResult.Timer_ADDED;
        }
        public static void Delete(int TimerId)
        {
            TimerDAL.Delete(TimerId);
        }
        public static Timer_Mst Select(int TimerId)
        {
            return TimerDAL.Select(TimerId);
        }
        public static List<Timer_Mst> GetAll()
        {
            return TimerDAL.GetAll();
        }
    }

    public class TimerDAL
    {
        internal static int Add(Timer_Mst objTimer)
        {
            int TimerId;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "usp_AddTimer";
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@StartTime", objTimer.StartTime);
                comm.Parameters.Add(p);
                p = new SqlParameter("@EndTime", objTimer.EndTime);
                comm.Parameters.Add(p);
                p = new SqlParameter("@StudentId", objTimer.StudentId);
                comm.Parameters.Add(p);

                TimerId = Convert.ToInt32(DataConnector.ExecuteScalar(comm));
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return TimerId;
        }
        internal static int Update(Timer_Mst objTimer)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateTimer";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@TimerId", objTimer.TimerId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@StartTime", objTimer.StartTime);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@EndTime", objTimer.EndTime);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@StudentId", objTimer.StudentId);
	 comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int TimerId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteTimer";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@TimerId", TimerId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static Timer_Mst Select(int TimerId)
        {
            SqlCommand comm = new SqlCommand();
            Timer_Mst objTimer = null;
            comm.CommandText = "usp_GetTimer";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@TimerId", TimerId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objTimer = new Timer_Mst();
                    objTimer.TimerId= DataHelper.GetInt(dataReader, "TimerId"); 
objTimer.StartTime= DataHelper.GetDateTime(dataReader, "StartTime"); 
objTimer.EndTime= DataHelper.GetDateTime(dataReader, "EndTime"); 
objTimer.StudentId= DataHelper.GetInt(dataReader, "StudentId"); 


                    
                }
            }

            return objTimer;

        }

        public static List<Timer_Mst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            Timer_Mst objTimer = null;
            List<Timer_Mst> TimerList = new List<Timer_Mst>();
            comm.CommandText = "usp_GetAllTimer";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objTimer = new Timer_Mst();
                    objTimer.TimerId= DataHelper.GetInt(dataReader, "TimerId"); 
objTimer.StartTime= DataHelper.GetDateTime(dataReader, "StartTime"); 
objTimer.EndTime= DataHelper.GetDateTime(dataReader, "EndTime"); 
objTimer.StudentId= DataHelper.GetInt(dataReader, "StudentId"); 


                    TimerList.Add(objTimer);
                }
            }

            return TimerList;

        }
    }

}





