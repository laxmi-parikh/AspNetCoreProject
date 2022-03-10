using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Bll;
using System.Data.SqlClient ;
using System.Data;



namespace BusinessL
{
   public class CSETMASTER
  {
      #region Private Properties

      private int _SetID;
      private string _SetType;
      private int _SubjectID;
      private int _TotalMarks;
      private int _InsertedBy;
      private DateTime _InsertedOn;
      private int _UpdateBy;
      private DateTime _UpdateOn;
      private int _Deactive;

      #endregion
      #region Public Properties

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

      public string SetType
      {
          get
          {
              return _SetType;
          }
          set
          {
              _SetType = value;
          }
      }

      public int SubjectID
      {
          get
          {
              return _SubjectID;
          }
          set
          {
              _SubjectID = value;
          }
      }

      public int TotalMarks
      {
          get
          {
              return _TotalMarks;
          }
          set
          {
              _TotalMarks = value;
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

      public DateTime UpdateOn
      {
          get
          {
              return _UpdateOn;
          }
          set
          {
              _UpdateOn = value;
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
   // Insert Question

      //public DataSet ListSetBySubject(int SubjectID)
      //{
      //    DataSet DS;
      //      try 
      //      {	        
        		

      //      }
      //      catch (Exception)
      //      {
        		
      //          throw;
      //      }
      //      return DS;
      
      //}

    }

   public class SETMASTERManager
   {
       public enum SETMASTEROperationResult
       {
           SETMASTER_EXISTS,
           SETMASTER_ADDED
       }
       public const string USER_EXISTS = "SETMASTER_EXISTS";
       public const string USER_ADDED = "SETMASTER_ADDED";
       private SETMASTERDAL objSETMASTERDAL = new SETMASTERDAL();

       public static SETMASTEROperationResult Add(CSETMASTER objSETMASTER)
       {

           int returnValue = SETMASTERDAL.Add(objSETMASTER);
           if (returnValue == 0)
               return SETMASTEROperationResult.SETMASTER_EXISTS;
           else
               return SETMASTEROperationResult.SETMASTER_ADDED;
       }
       public static SETMASTEROperationResult Update(CSETMASTER objSETMASTER)
       {
           int returnValue = SETMASTERDAL.Update(objSETMASTER);
           if (returnValue == 0)
               return SETMASTEROperationResult.SETMASTER_EXISTS;
           else
               return SETMASTEROperationResult.SETMASTER_ADDED;
       }
       public static void Delete(int SETMASTERId)
       {
           SETMASTERDAL.Delete(SETMASTERId);
       }
       public static CSETMASTER Select(int SETMASTERId)
       {
           return SETMASTERDAL.Select(SETMASTERId);
       }
       public static List<CSETMASTER> GetAll()
       {
           return SETMASTERDAL.GetAll();
       }

       public static List<CSETMASTER> GetAllBySubjectID(int SubjectID)
       {
           return SETMASTERDAL.GetAllBySubjectID(SubjectID);
       }

   }

   public class SETMASTERDAL
   {
       internal static int Add(CSETMASTER objSETMASTER)
       {
           SqlCommand comm = new SqlCommand();
           comm.CommandText = "Usp_AddSETMASTER";
           comm.CommandType = System.Data.CommandType.StoredProcedure;

           SqlParameter p = new SqlParameter("@SetType", objSETMASTER.SetType);
           comm.Parameters.Add(p);
           p = new SqlParameter("@SubjectID", objSETMASTER.SubjectID);
           comm.Parameters.Add(p);
           p = new SqlParameter("@TotalMarks", objSETMASTER.TotalMarks);
           comm.Parameters.Add(p);
           p = new SqlParameter("@InsertedBy", "1");
           comm.Parameters.Add(p);
           //p = new SqlParameter("@InsertedOn", objSETMASTER.InsertedOn);
           //comm.Parameters.Add(p);
           //p = new SqlParameter("@UpdateBy", objSETMASTER.UpdateBy);
           //comm.Parameters.Add(p);
           //p = new SqlParameter("@UpdateOn", objSETMASTER.UpdateOn);
           //comm.Parameters.Add(p);
           //p = new SqlParameter("@Deactive", objSETMASTER.Deactive);
           //comm.Parameters.Add(p);

           return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

       }
       internal static int Update(CSETMASTER objSETMASTER)
       {
           SqlCommand comm = new SqlCommand();
           comm.CommandText = "usp_UpdateSETMASTER";
           comm.CommandType = System.Data.CommandType.StoredProcedure;

           SqlParameter p = new SqlParameter("@SetID", objSETMASTER.SetID);
           comm.Parameters.Add(p);
           p = new SqlParameter("@SetType", objSETMASTER.SetType);
           comm.Parameters.Add(p);
           p = new SqlParameter("@SubjectID", objSETMASTER.SubjectID);
           comm.Parameters.Add(p);
           p = new SqlParameter("@TotalMarks", objSETMASTER.TotalMarks);
           comm.Parameters.Add(p);
           p = new SqlParameter("@InsertedBy", objSETMASTER.InsertedBy);
           comm.Parameters.Add(p);
           p = new SqlParameter("@InsertedOn", objSETMASTER.InsertedOn);
           comm.Parameters.Add(p);
           p = new SqlParameter("@UpdateBy", objSETMASTER.UpdateBy);
           comm.Parameters.Add(p);
           p = new SqlParameter("@UpdateOn", objSETMASTER.UpdateOn);
           comm.Parameters.Add(p);
           p = new SqlParameter("@Deactive", objSETMASTER.Deactive);
           comm.Parameters.Add(p);

           return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

       }
       internal static void Delete(int SETMASTERId)
       {
           SqlCommand comm = new SqlCommand();
           comm.CommandText = "usp_deleteSETMASTER";
           comm.CommandType = System.Data.CommandType.StoredProcedure;

           SqlParameter p = new SqlParameter("@SETMASTERId", SETMASTERId);
           comm.Parameters.Add(p);

           DataConnector.ExecuteCommand(comm);
       }
       internal static CSETMASTER Select(int SETMASTERId)
       {
           SqlCommand comm = new SqlCommand();
           CSETMASTER objSETMASTER = null;
           comm.CommandText = "usp_selectSETMASTER";
           comm.CommandType = System.Data.CommandType.StoredProcedure;

           SqlParameter p = new SqlParameter("@SETMASTERId", SETMASTERId);
           comm.Parameters.Add(p);

           using (IDataReader dataReader = DataConnector.GetDataReader(comm))
           {
               while (dataReader.Read())
               {
                   objSETMASTER = new CSETMASTER();
                   objSETMASTER.SetID = DataHelper.GetInt(dataReader, "SetID");
                   objSETMASTER.SetType = DataHelper.GetString(dataReader, "SetType");
                   objSETMASTER.SubjectID = DataHelper.GetInt(dataReader, "SubjectID");
                   objSETMASTER.TotalMarks = DataHelper.GetInt(dataReader, "TotalMarks");
                   objSETMASTER.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                   objSETMASTER.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                   objSETMASTER.UpdateBy = DataHelper.GetInt(dataReader, "UpdateBy");
                   objSETMASTER.UpdateOn = DataHelper.GetDateTime(dataReader, "UpdateOn");
                   objSETMASTER.Deactive = DataHelper.GetInt(dataReader, "Deactive");



               }
           }

           return objSETMASTER;

       }

       public static List<CSETMASTER> GetAll()
       {
           SqlCommand comm = new SqlCommand();
           CSETMASTER objSETMASTER = null;
           List<CSETMASTER> SETMASTERList = new List<CSETMASTER>();
           comm.CommandText = "usp_GetAllSETMASTER";
           comm.CommandType = System.Data.CommandType.StoredProcedure;

           //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
           //        comm.Parameters.Add(p);

           using (IDataReader dataReader = DataConnector.GetDataReader(comm))
           {
               while (dataReader.Read())
               {
                   objSETMASTER = new CSETMASTER();
                   objSETMASTER.SetID = DataHelper.GetInt(dataReader, "SetID");
                   objSETMASTER.SetType = DataHelper.GetString(dataReader, "SetType");
                   objSETMASTER.SubjectID = DataHelper.GetInt(dataReader, "SubjectID");
                   objSETMASTER.TotalMarks = DataHelper.GetInt(dataReader, "TotalMarks");
                   objSETMASTER.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                   objSETMASTER.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                   objSETMASTER.UpdateBy = DataHelper.GetInt(dataReader, "UpdateBy");
                   objSETMASTER.UpdateOn = DataHelper.GetDateTime(dataReader, "UpdateOn");
                   objSETMASTER.Deactive = DataHelper.GetInt(dataReader, "Deactive");


                   SETMASTERList.Add(objSETMASTER);
               }
           }

           return SETMASTERList;

       }

       public static List<CSETMASTER> GetAllBySubjectID(int SubjectId)
       {
           SqlCommand comm = new SqlCommand();
           SqlParameter p = new SqlParameter("@SubjectId", SubjectId);
           comm.Parameters.Add(p);

           CSETMASTER objSETMASTER = null;
           List<CSETMASTER> SETMASTERList = new List<CSETMASTER>();
           comm.CommandText = "usp_GetAllSETMASTERBySubjectID";
           comm.CommandType = System.Data.CommandType.StoredProcedure;

           //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
           //        comm.Parameters.Add(p);

           using (IDataReader dataReader = DataConnector.GetDataReader(comm))
           {
               while (dataReader.Read())
               {
                   objSETMASTER = new CSETMASTER();
                   objSETMASTER.SetID = DataHelper.GetInt(dataReader, "SetID");
                   objSETMASTER.SetType = DataHelper.GetString(dataReader, "SetType");
                   objSETMASTER.SubjectID = DataHelper.GetInt(dataReader, "SubjectID");
                   objSETMASTER.TotalMarks = DataHelper.GetInt(dataReader, "TotalMarks");
                   objSETMASTER.InsertedBy = DataHelper.GetInt(dataReader, "InsertedBy");
                   objSETMASTER.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                   objSETMASTER.UpdateBy = DataHelper.GetInt(dataReader, "UpdateBy");
                   objSETMASTER.UpdateOn = DataHelper.GetDateTime(dataReader, "UpdateOn");
                   objSETMASTER.Deactive = DataHelper.GetInt(dataReader, "Deactive");


                   SETMASTERList.Add(objSETMASTER);
               }
           }

           return SETMASTERList;

       }


   }


  


}
