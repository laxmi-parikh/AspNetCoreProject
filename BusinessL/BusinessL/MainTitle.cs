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
    public class MainTitle
    {


        #region Private Properties

        private int _MainID;
        private int _SrNo;
        private string _Title;
        private int _Insertedby;
        private DateTime _InsertedOn;
        private int _UpdateBy;
        private DateTime _UpdateOn;
        private int _Deactive;
        private int functionid;
        private int levelid;
        private string _Technical;

        

        #endregion
        #region Public Properties

        public int Levelid
        {
            get { return levelid; }
            set { levelid = value; }
        }
        public int Functionid
        {
            get { return functionid; }
            set { functionid = value; }
        }
        public string Technical
        {
            get { return _Technical; }
            set { _Technical = value; }
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
        public int SrNo
        {
            get
            {
                return _SrNo;
            }
            set
            {
                _SrNo = value;
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


        #endregion
    }

    public class MainTitleManager
    {
        public enum MainTitleOperationResult
        {
            MainTitle_EXISTS,
            MainTitle_ADDED
        }
        //public const string USER_EXISTS = "MainTitle_EXISTS";
        //public const string USER_ADDED = "MainTitle_ADDED";
        private MainTitleDAL objMainTitleDAL = new MainTitleDAL();

        public static int Add(MainTitle objMainTitle)
        {

            int returnValue = MainTitleDAL.Add(objMainTitle);
            if (returnValue == 0)
                return returnValue;
            else
                return returnValue;
        }
        public static MainTitleOperationResult Update(MainTitle objMainTitle)
        {
            int returnValue = MainTitleDAL.Update(objMainTitle);
            if (returnValue == 0)
                return MainTitleOperationResult.MainTitle_EXISTS;
            else
                return MainTitleOperationResult.MainTitle_ADDED;
        }
        public static void Delete(int MainID)
        {
            MainTitleDAL.Delete(MainID);
        }
        public static MainTitle Select(int MainId)
        {
            return MainTitleDAL.Select(MainId);
        }
        public static List<MainTitle> GetAll()
        {
            return MainTitleDAL.GetAll();
        }
        public static List<MainTitle> GetAllByTechical(string Techical)
        {
            return MainTitleDAL.GetAllBySales(Techical);
        }
        public static DataSet ListMaintitle(string technical, int levelid)
        {
            return DataConnector.GetDataSet("usp_getmaintitleforselectedlevel " + technical + "," + levelid);
        }

    }


    public class MainTitleDAL
    {
        internal static int Add(MainTitle objMainTitle)
        {
            int MainId;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "Usp_AddMainTitle";
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlParameter p = new SqlParameter("@MainID", objMainTitle.MainID);
                //comm.Parameters.Add(p);
                SqlParameter p = new SqlParameter("@Title", objMainTitle.Title);
                comm.Parameters.Add(p);
                p = new SqlParameter("@Insertedby", objMainTitle.Insertedby);
                comm.Parameters.Add(p);
                p = new SqlParameter("@Technical", objMainTitle.Technical);
                comm.Parameters.Add(p);
                p = new SqlParameter("@functionid", objMainTitle.Functionid);
                comm.Parameters.Add(p);
                p = new SqlParameter("@levelid", objMainTitle.Levelid);
                comm.Parameters.Add(p);
                //p = new SqlParameter("@UpdateBy", objMainTitle.UpdateBy);
                //comm.Parameters.Add(p);
                //p = new SqlParameter("@UpdateOn", objMainTitle.UpdateOn);
                //comm.Parameters.Add(p);
                //p = new SqlParameter("@Deactive", objMainTitle.Deactive);
                //comm.Parameters.Add(p);

                MainId=  Convert.ToInt32(DataConnector.ExecuteScalar(comm));
                return MainId;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        internal static int Update(MainTitle objMainTitle)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_UpdateMainTitle";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MainID", objMainTitle.MainID);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Title", objMainTitle.Title);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Insertedby", objMainTitle.Insertedby);
            comm.Parameters.Add(p);
            p = new SqlParameter("@InsertedOn", objMainTitle.InsertedOn);
            comm.Parameters.Add(p);
            p = new SqlParameter("@UpdateBy", objMainTitle.UpdateBy);
            comm.Parameters.Add(p);
            p = new SqlParameter("@UpdateOn", objMainTitle.UpdateOn);
            comm.Parameters.Add(p);
            p = new SqlParameter("@Deactive", objMainTitle.Deactive);
            comm.Parameters.Add(p);

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int MainID)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_deleteMainTitle";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MainID", MainID);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static MainTitle Select(int MainId)
        {
            SqlCommand comm = new SqlCommand();
            MainTitle objMainTitle = null;
            comm.CommandText = "usp_selectMainTitle";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MainID", MainId);
            comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objMainTitle = new MainTitle();
                    objMainTitle.MainID = DataHelper.GetInt(dataReader, "MainID");
                    objMainTitle.Title = DataHelper.GetString(dataReader, "Title");
                    objMainTitle.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    objMainTitle.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objMainTitle.UpdateBy = DataHelper.GetInt(dataReader, "UpdateBy");
                    objMainTitle.UpdateOn = DataHelper.GetDateTime(dataReader, "UpdateOn");
                    objMainTitle.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    objMainTitle.Technical = DataHelper.GetString(dataReader, "Technical");
                   


                }
            }

            return objMainTitle;

        }
        public static List<MainTitle> GetAllBySales(string Techical)
        {
            SqlCommand comm = new SqlCommand();
            MainTitle objMainTitle = null;
            List<MainTitle> MainTitleList = new List<MainTitle>();
            comm.CommandText = "usp_GetAllMainTitle1";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Techical",Techical);
                   comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objMainTitle = new MainTitle();
                    objMainTitle.MainID = DataHelper.GetInt(dataReader, "MainID");
                    objMainTitle.Title = DataHelper.GetString(dataReader, "Title");
                    objMainTitle.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    objMainTitle.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objMainTitle.UpdateBy = DataHelper.GetInt(dataReader, "UpdateBy");
                    objMainTitle.UpdateOn = DataHelper.GetDateTime(dataReader, "UpdateOn");
                    objMainTitle.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    objMainTitle.Technical = DataHelper.GetString(dataReader, "Technical");

                    MainTitleList.Add(objMainTitle);

                }
            }

            return MainTitleList;

        }
        public static List<MainTitle> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            MainTitle objMainTitle = null;
            List<MainTitle> MainTitleList = new List<MainTitle>();
            comm.CommandText = "usp_GetAllMainTitle";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objMainTitle = new MainTitle();
                    objMainTitle.MainID = DataHelper.GetInt(dataReader, "MainID");
                    objMainTitle.Title = DataHelper.GetString(dataReader, "Title");
                    objMainTitle.Insertedby = DataHelper.GetInt(dataReader, "Insertedby");
                    objMainTitle.InsertedOn = DataHelper.GetDateTime(dataReader, "InsertedOn");
                    objMainTitle.UpdateBy = DataHelper.GetInt(dataReader, "UpdateBy");
                    objMainTitle.UpdateOn = DataHelper.GetDateTime(dataReader, "UpdateOn");
                    objMainTitle.Deactive = DataHelper.GetInt(dataReader, "Deactive");
                    objMainTitle.Technical = DataHelper.GetString(dataReader, "Technical");

                    MainTitleList.Add(objMainTitle);

                }
            }

            return MainTitleList;

        }
    }
}
