using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Bll;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL
{
    //Date : 19/4/2011
    //Description : Business class
    public class SubTitle
    {


        #region Private Properties

        private int _SubID;
        private int _MainID;
        private string _SubTitle;
        private int _Insertedby;
        private DateTime _InsertedOn;
        private int _UpdateBy;
        private DateTime _UpdateOn;
        private int _Deactive;
        private int _SubjectId;

        #endregion
        #region Public Properties

     

        public int SubID
        {
            get
            {
                return _SubID;
            }
            set
            {
                _SubID = value;
            }
        }

        public int MainID
        {
            get
            {
                return _MainID;
            }
            set
            {
                _MainID = value;
            }
        }
        

        public string SubTitle1
        {
            get
            {
                return _SubTitle;
            }
            set
            {
                _SubTitle = value;
            }
        }

        public int Insertedby
        {
            get
            {
                return _Insertedby;
            }
            set
            {
                _Insertedby = value;
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

        public int SubjectId
        {
            get
            {
                return _SubjectId;
            }
            set
            {
                _SubjectId = value;
            }
        }


        #endregion
    }

    public class SubTitleManager
    {
        public enum SubTitleOperationResult
        {
            SubTitle_EXISTS,
            SubTitle_ADDED
        }
        //public const string USER_EXISTS = "SubTitle_EXISTS";
        //public const string USER_ADDED = "SubTitle_ADDED";
        private SubTitleDAL objSubTitleDAL = new SubTitleDAL();

        public static int Add(SubTitle objSubTitle)
        {

            int returnValue = SubTitleDAL.Add(objSubTitle);
            if (returnValue == 0)
                return returnValue;
            else
                return returnValue;
        }
        public static SubTitleOperationResult Update(SubTitle objSubTitle)
        {
            int returnValue = SubTitleDAL.Update(objSubTitle);
            if (returnValue == 0)
                return SubTitleOperationResult.SubTitle_EXISTS;
            else
                return SubTitleOperationResult.SubTitle_ADDED;
        }
        public static void Delete(int SubID)
        {
            SubTitleDAL.Delete(SubID);
        }
        public static SubTitle Select(int SubId)
        {
            return SubTitleDAL.Select(SubId);
        }
        public static List<SubTitle> GetAll()
        {
            return SubTitleDAL.GetAll();
        }

        public static DataSet ListSubTitle()
        {
            return SubTitleDAL.ListSubTitle();
        }
        public static DataSet ListAllSubTitleByMainID(int MainID)
        {

            return SubTitleDAL.ListAllSubTitleByMainID(MainID);
        }


        public static DataSet ListAllSubTitleByMainID1(int MainID,int UserId)
        {

            return SubTitleDAL.ListAllSubTitleByMainID1(MainID,UserId);
        }

    }
    public class SubTitleDAL
    {
        internal static int Add(SubTitle objSubTitle)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_addSubTitle";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@SubID", objSubTitle.SubID);
            //comm.Parameters.Add(p);
            SqlParameter p = new SqlParameter("@MainID", objSubTitle.MainID);
            comm.Parameters.Add(p);
            p = new SqlParameter("@SubTitle", objSubTitle.SubTitle1);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Insertedby", objSubTitle.Insertedby);
            comm.Parameters.Add(p);
            //p = new SqlParameter("@InsertedOn", objSubTitle.InsertedOn);
            //comm.Parameters.Add(p);
            //p = new SqlParameter("@UpdateBy", objSubTitle.UpdateBy);
            //comm.Parameters.Add(p);
            //p = new SqlParameter("@UpdateOn", objSubTitle.UpdateOn);
            //comm.Parameters.Add(p);
            //p = new SqlParameter("@Deactive", objSubTitle.Deactive);
            //comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static int Update(SubTitle objSubTitle)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateSubTitle";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@SubID", objSubTitle.SubID);
            comm.Parameters.Add(p);
            p = new SqlParameter("@MainID", objSubTitle.MainID);
            comm.Parameters.Add(p);
            p = new SqlParameter("@SubTitle", objSubTitle.SubTitle1);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Insertedby", objSubTitle.Insertedby);
            comm.Parameters.Add(p);
            p = new SqlParameter("@InsertedOn", objSubTitle.InsertedOn);
            comm.Parameters.Add(p);
            p = new SqlParameter("@UpdateBy", objSubTitle.UpdateBy);
            comm.Parameters.Add(p);
            p = new SqlParameter("@UpdateOn", objSubTitle.UpdateOn);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Deactive", objSubTitle.Deactive);
            comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int SubID)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteSubTitle";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@SubID", SubID);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static SubTitle Select(int SubId)
        {
            SqlCommand comm = new SqlCommand();
            SubTitle objSubTitle = null;
            comm.CommandText = "usp_selectSubTitle";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@SubID", SubId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSubTitle = new SubTitle();
                    objSubTitle.SubID = DataHelper.GetInt(dataReader, "SubID");
                    objSubTitle.MainID = DataHelper.GetInt(dataReader, "MainID");
                    objSubTitle.SubTitle1 = DataHelper.GetString(dataReader, "SubTitle");
                    objSubTitle.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    objSubTitle.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objSubTitle.UpdateBy = DataHelper.GetInt(dataReader, "UpdateBy");
                    objSubTitle.UpdateOn = DataHelper.GetDateTime(dataReader, "UpdateOn");
                    objSubTitle.Deactive = DataHelper.GetInt(dataReader, "Deactive");



                }
            }

            return objSubTitle;

        }

        public static List<SubTitle> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            SubTitle objSubTitle = null;
            List<SubTitle> SubTitleList = new List<SubTitle>();
            comm.CommandText = "usp_GetAllSubTitle";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objSubTitle = new SubTitle();
                    objSubTitle.SubID = DataHelper.GetInt(dataReader, "SubID");
                    objSubTitle.MainID = DataHelper.GetInt(dataReader, "MainID");
                    objSubTitle.SubTitle1 = DataHelper.GetString(dataReader, "SubTitle");
                    objSubTitle.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    objSubTitle.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objSubTitle.UpdateBy = DataHelper.GetInt(dataReader, "UpdateBy");
                    objSubTitle.UpdateOn = DataHelper.GetDateTime(dataReader, "UpdateOn");
                    objSubTitle.Deactive = DataHelper.GetInt(dataReader, "Deactive");


                    SubTitleList.Add(objSubTitle);
                }
            }

            return SubTitleList;

        }

        public static DataSet ListSubTitle()
        {
            return DataConnector.GetDataSet("usp_GetAllSubTitle");
        }
        public static DataSet ListAllSubTitleByMainID(int MainID)
        {
            return DataConnector.GetDataSet("usp_GetAllSubTitleByMainID '" + MainID + "'");
        }


        public static DataSet ListAllSubTitleByMainID1(int MainID,int UserId)
        {
            return DataConnector.GetDataSet("usp_GetAllSubTitleByMainID1 '" + MainID + "','"+UserId +"'");
        }

    }
}
