using System;
using System.Collections.Generic;
using System.Text;
//using Bhairav.DataLayer;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL
{
   //Date : 21/11/2011
    //Description : Business class
    public class EmailaddressbookMst
    {

        
#region Private Properties
 	
	private int _emailid;
	private string _personname;
	private string _Designation;
	private string _Emailaddress;
	private DateTime _InsertedOn;
	private int _InsertedBy;
	private DateTime _UpdatedOn;
	private int _UpdatedBy;
	private bool _Deactive;
 
 #endregion
 #region Public Properties
 	
	public int emailid
	{
		get
		{
			return _emailid;
		}
		set
		{
			_emailid = value;
		}
	}

	public string personname
	{
		get
		{
			return _personname;
		}
		set
		{
			_personname = value;
		}
	}

	public string Designation
	{
		get
		{
			return _Designation;
		}
		set
		{
			_Designation = value;
		}
	}

	public string Emailaddress
	{
		get
		{
			return _Emailaddress;
		}
		set
		{
			_Emailaddress = value;
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

 
 #endregion
    }
    public class EmailaddressbookMstManager
    {
        public enum EmailaddressbookMstOperationResult
        {
            EmailaddressbookMst_EXISTS,
            EmailaddressbookMst_ADDED
        }
        //public const string USER_EXISTS = "EmailaddressbookMst_EXISTS";
        //public const string USER_ADDED = "EmailaddressbookMst_ADDED";
        private EmailaddressbookMstDAL objEmailaddressbookMstDAL = new EmailaddressbookMstDAL();

        public static EmailaddressbookMstOperationResult Add(EmailaddressbookMst objEmailaddressbookMst)
        {

            int returnValue = EmailaddressbookMstDAL.Add(objEmailaddressbookMst);
            if (returnValue == 0)
                return EmailaddressbookMstOperationResult.EmailaddressbookMst_EXISTS;
            else
                return EmailaddressbookMstOperationResult.EmailaddressbookMst_ADDED;
        }
        public static EmailaddressbookMstOperationResult Update(EmailaddressbookMst objEmailaddressbookMst)
        {
            int returnValue = EmailaddressbookMstDAL.Update(objEmailaddressbookMst);
            if (returnValue == 0)
                return EmailaddressbookMstOperationResult.EmailaddressbookMst_EXISTS;
            else
                return EmailaddressbookMstOperationResult.EmailaddressbookMst_ADDED;
        }
        public static void Delete(int EmailaddressbookMstId)
        {
            EmailaddressbookMstDAL.Delete(EmailaddressbookMstId);
        }
        public static EmailaddressbookMst Select(int EmailaddressbookMstId)
        {
            return EmailaddressbookMstDAL.Select(EmailaddressbookMstId);
        }
        public static List<EmailaddressbookMst> GetAll()
        {
            return EmailaddressbookMstDAL.GetAll();
        }
    }

    public class EmailaddressbookMstDAL
    {
        internal static int Add(EmailaddressbookMst objEmailaddressbookMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_AddEmailaddressbookMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

     //     SqlParameter p = new SqlParameter("@emailid", objEmailaddressbookMst.emailid);
     //comm.Parameters.Add(p);
     SqlParameter p = new SqlParameter("@personname", objEmailaddressbookMst.personname);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Designation", objEmailaddressbookMst.Designation);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Emailaddress", objEmailaddressbookMst.Emailaddress);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@InsertedOn", objEmailaddressbookMst.InsertedOn);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@InsertedBy", objEmailaddressbookMst.InsertedBy);
	 comm.Parameters.Add(p);
  //p = new SqlParameter("@UpdatedOn", objEmailaddressbookMst.UpdatedOn);
  //   comm.Parameters.Add(p);
  //p = new SqlParameter("@UpdatedBy", objEmailaddressbookMst.UpdatedBy);
  //   comm.Parameters.Add(p);
  //p = new SqlParameter("@Deactive", objEmailaddressbookMst.Deactive);
  //   comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int Update(EmailaddressbookMst objEmailaddressbookMst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateEmailaddressbookMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@emailid", objEmailaddressbookMst.emailid);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@personname", objEmailaddressbookMst.personname);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Designation", objEmailaddressbookMst.Designation);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@Emailaddress", objEmailaddressbookMst.Emailaddress);
	 comm.Parameters.Add(p);
  //p = new SqlParameter("@InsertedOn", objEmailaddressbookMst.InsertedOn);
  //   comm.Parameters.Add(p);
  //p = new SqlParameter("@InsertedBy", objEmailaddressbookMst.InsertedBy);
  //   comm.Parameters.Add(p);
  p = new SqlParameter("@UpdatedOn", objEmailaddressbookMst.UpdatedOn);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@UpdatedBy", objEmailaddressbookMst.UpdatedBy);
	 comm.Parameters.Add(p);
  //p = new SqlParameter("@Deactive", objEmailaddressbookMst.Deactive);
  //   comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int EmailaddressbookMstId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteEmailaddressbookMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@emailid", EmailaddressbookMstId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static EmailaddressbookMst Select(int EmailaddressbookMstId)
        {
            SqlCommand comm = new SqlCommand();
            EmailaddressbookMst objEmailaddressbookMst = null;           
            comm.CommandText = "usp_selectEmailaddressbookMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@emailid", EmailaddressbookMstId);
            comm.Parameters.Add(p);
            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objEmailaddressbookMst = new EmailaddressbookMst();
                    objEmailaddressbookMst.emailid= DataHelper.GetInt(dataReader, "emailid"); 
objEmailaddressbookMst.personname= DataHelper.GetString(dataReader, "personname"); 
objEmailaddressbookMst.Designation= DataHelper.GetString(dataReader, "Designation"); 
objEmailaddressbookMst.Emailaddress= DataHelper.GetString(dataReader, "Emailaddress"); 
objEmailaddressbookMst.InsertedOn= DataHelper.GetDateTime(dataReader, "InsertedOn"); 
objEmailaddressbookMst.InsertedBy= DataHelper.GetInt(dataReader, "InsertedBy"); 
objEmailaddressbookMst.UpdatedOn= DataHelper.GetDateTime(dataReader, "UpdatedOn"); 
objEmailaddressbookMst.UpdatedBy= DataHelper.GetInt(dataReader, "UpdatedBy"); 
objEmailaddressbookMst.Deactive= DataHelper.GetBoolean(dataReader, "Deactive"); 


                    
                }
            }

            return objEmailaddressbookMst;

        }

        public static List<EmailaddressbookMst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            EmailaddressbookMst objEmailaddressbookMst = null;
            List<EmailaddressbookMst> EmailaddressbookMstList = new List<EmailaddressbookMst>();
            comm.CommandText = "usp_GetAllEmailaddressbookMst";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objEmailaddressbookMst = new EmailaddressbookMst();
                    objEmailaddressbookMst.emailid= DataHelper.GetInt(dataReader, "emailid"); 
objEmailaddressbookMst.personname= DataHelper.GetString(dataReader, "personname"); 
objEmailaddressbookMst.Designation= DataHelper.GetString(dataReader, "Designation"); 
objEmailaddressbookMst.Emailaddress= DataHelper.GetString(dataReader, "Emailaddress"); 
objEmailaddressbookMst.InsertedOn= DataHelper.GetDateTime(dataReader, "InsertedOn"); 
objEmailaddressbookMst.InsertedBy= DataHelper.GetInt(dataReader, "InsertedBy"); 
objEmailaddressbookMst.UpdatedOn= DataHelper.GetDateTime(dataReader, "UpdatedOn"); 
objEmailaddressbookMst.UpdatedBy= DataHelper.GetInt(dataReader, "UpdatedBy"); 
objEmailaddressbookMst.Deactive= DataHelper.GetBoolean(dataReader, "Deactive"); 


                    EmailaddressbookMstList.Add(objEmailaddressbookMst);
                }
            }

            return EmailaddressbookMstList;

        }
    }

}





