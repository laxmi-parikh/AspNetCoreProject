using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
//using Bll;



namespace BusinessL
{
   public class CCopounMst
    {
        #region Private Properties

        private int _id;
        private string _UniqueID;
        private int _Status;
        private DateTime _UsedDate;

        #endregion
        #region Public Properties

        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string UniqueID
        {
            get
            {
                return _UniqueID;
            }
            set
            {
                _UniqueID = value;
            }
        }

        public int Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }

        public DateTime UsedDate
        {
            get
            {
                return _UsedDate;
            }
            set
            {
                _UsedDate = value;
            }
        }


        #endregion



        public DataSet ValidateUserID( string UserID)
        {
            DataSet Ds;
            try
            {
                Ds = DataConnector.GetDataSet("Usp_GetNewUserID '" + UserID + "'");
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
            return Ds;
            
        }

        public DataSet ValidateCopoun(string CopounID)
        {
            DataSet Ds;
            try
            {
                Ds = DataConnector.GetDataSet("Usp_GetNewPasswordMst '" + CopounID + "'");
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return Ds;
        
        
        }

       


    }
}
