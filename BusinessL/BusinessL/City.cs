using System;
using System.Collections.Generic;
using System.Text;
//using Bll;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
namespace BusinessL
{
   //Date : 22/4/2010
    //Description : Business class
    public class City_Mst
    {    

#region Private Properties
 	
	private int _CityId;
	private string _City;
	private string _CityDesc;
	private int _countryId;
	private int _stateId;
	private int _insertedby;
	private DateTime _insertedon;
	private int _updatedby;
	private DateTime _updatedon;
	private int _deactive;
 
 #endregion
 #region Public Properties
       
 	
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

	public string City
	{
		get
		{
			return _City;
		}
		set
		{
			_City = value;
		}
	}

	public string CityDesc
	{
		get
		{
			return _CityDesc;
		}
		set
		{
			_CityDesc = value;
		}
	}

	public int countryId
	{
		get
		{
			return _countryId;
		}
		set
		{
			_countryId = value;
		}
	}

	public int stateId
	{
		get
		{
			return _stateId;
		}
		set
		{
			_stateId = value;
		}
	}

	public int insertedby
	{
		get
		{
			return _insertedby;
		}
		set
		{
			_insertedby = value;
		}
	}

	public DateTime insertedon
	{
		get
		{
			return _insertedon;
		}
		set
		{
			_insertedon = value;
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

	public DateTime updatedon
	{
		get
		{
			return _updatedon;
		}
		set
		{
			_updatedon = value;
		}
	}

	public int deactive
	{
		get
		{
			return _deactive;
		}
		set
		{
			_deactive = value;
		}
	}

   
   
 
 #endregion

    }
    public class City_MstManager
    {
        public enum City_MstOperationResult
        {
            City_Mst_EXISTS,
            City_Mst_ADDED
        }
        //public const string USER_EXISTS = "City_Mst_EXISTS";
        //public const string USER_ADDED = "City_Mst_ADDED";
        private City_MstDAL objCity_MstDAL = new City_MstDAL();

        public static City_MstOperationResult Add(City_Mst objCity_Mst)
        {

            int returnValue = City_MstDAL.Add(objCity_Mst);
            if (returnValue == 0)
                return City_MstOperationResult.City_Mst_EXISTS;
            else
                return City_MstOperationResult.City_Mst_ADDED;
        }
        public static City_MstOperationResult Update(City_Mst objCity_Mst)
        {
            int returnValue = City_MstDAL.Update(objCity_Mst);
            if (returnValue == 0)
                return City_MstOperationResult.City_Mst_EXISTS;
            else
                return City_MstOperationResult.City_Mst_ADDED;
        }
        public static void Delete(int CityId)
        {
            City_MstDAL.Delete(CityId);
        }
        public static City_Mst Select(int CityId)
        {
            return City_MstDAL.Select(CityId);
        }
        public static List<City_Mst> GetAll()
        {
            return City_MstDAL.GetAll();
        }
        public static City_Mst CheckCity()
        {
            return City_MstDAL.CheckCity();
        }
       // 
        public static List<City_Mst> GetCityByState(int stateId)
        {
            return City_MstDAL.GetCityByState(stateId);
        }
      
    }

    public class City_MstDAL
    {
        internal static int Add(City_Mst objCity_Mst)
        {
            int CityId;
            try
            {

                SqlCommand comm = new SqlCommand();
                comm.CommandText = "usp_AddCity";
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@City", objCity_Mst.City);
                comm.Parameters.Add(p);
                p = new SqlParameter("@CityDesc", objCity_Mst.CityDesc);
                comm.Parameters.Add(p);
                p = new SqlParameter("@countryId", objCity_Mst.countryId);
                comm.Parameters.Add(p);
                p = new SqlParameter("@stateId", objCity_Mst.stateId);
                comm.Parameters.Add(p);
                p = new SqlParameter("@insertedby", objCity_Mst.insertedby);
                comm.Parameters.Add(p);



                CityId = Convert.ToInt32(DataConnector.ExecuteScalar(comm));
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return CityId;

        }
        internal static int Update(City_Mst objCity_Mst)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_updateCity";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
		SqlParameter p = new SqlParameter("@CityId", objCity_Mst.CityId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@City", objCity_Mst.City);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@CityDesc", objCity_Mst.CityDesc);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@countryId", objCity_Mst.countryId);
	 comm.Parameters.Add(p);
  p = new SqlParameter("@stateId", objCity_Mst.stateId);
	 comm.Parameters.Add(p);
 
  p = new SqlParameter("@updatedby", objCity_Mst.updatedby);
	 comm.Parameters.Add(p);
  
  

            return Convert.ToInt32(DataConnector.ExecuteScalar(comm));

        }
        internal static void Delete(int CityId)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "usp_DeleteCity";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@CityId", CityId);
            comm.Parameters.Add(p);

            DataConnector.ExecuteCommand(comm);
        }
        internal static City_Mst Select(int CityId)
        {
            SqlCommand comm = new SqlCommand();
            City_Mst objCity_Mst = null;
            comm.CommandText = "usp_selectCity";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@CityId", CityId);
            comm.Parameters.Add(p);
         
            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objCity_Mst = new City_Mst();
                    objCity_Mst.CityId = DataHelper.GetInt(dataReader, "CityId");
                    objCity_Mst.City = DataHelper.GetString(dataReader, "City");
                    objCity_Mst.CityDesc = DataHelper.GetString(dataReader, "CityDesc");
                    objCity_Mst.countryId = DataHelper.GetInt(dataReader, "countryId");
                    objCity_Mst.stateId = DataHelper.GetInt(dataReader, "stateId");
                    objCity_Mst.insertedby = DataHelper.GetInt(dataReader, "insertedby");
                    objCity_Mst.insertedon = DataHelper.GetDateTime(dataReader, "insertedon");
                    objCity_Mst.updatedby = DataHelper.GetInt(dataReader, "updatedby");
                    objCity_Mst.updatedon = DataHelper.GetDateTime(dataReader, "updatedon");
                    objCity_Mst.deactive = DataHelper.GetInt(dataReader, "deactive");



                }
            }

            return objCity_Mst;

        }

        public static List<City_Mst> GetAll()
        {
            SqlCommand comm = new SqlCommand();
            City_Mst objCity_Mst = null;
            List<City_Mst> City_MstList = new List<City_Mst>();
            comm.CommandText = "usp_GetAllCity";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objCity_Mst = new City_Mst();
                    objCity_Mst.CityId = DataHelper.GetInt(dataReader, "CityId");
                    objCity_Mst.City = DataHelper.GetString(dataReader, "City");
                    objCity_Mst.CityDesc = DataHelper.GetString(dataReader, "CityDesc");
                    objCity_Mst.countryId = DataHelper.GetInt(dataReader, "countryId");
                    objCity_Mst.stateId = DataHelper.GetInt(dataReader, "stateId");
                    objCity_Mst.insertedby = DataHelper.GetInt(dataReader, "insertedby");
                    objCity_Mst.insertedon = DataHelper.GetDateTime(dataReader, "insertedon");
                    objCity_Mst.updatedby = DataHelper.GetInt(dataReader, "updatedby");
                    objCity_Mst.updatedon = DataHelper.GetDateTime(dataReader, "updatedon");
                    objCity_Mst.deactive = DataHelper.GetInt(dataReader, "deactive");


                    City_MstList.Add(objCity_Mst);
                }
            }

            return City_MstList;

        }

        public static City_Mst CheckCity()
        {
            SqlCommand comm = new SqlCommand();
            City_Mst objCity_Mst = null;
           // List<City_Mst> City_MstList = new List<City_Mst>();
            comm.CommandText = "usp_GetAllCity";
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objCity_Mst = new City_Mst();
                    objCity_Mst.CityId = DataHelper.GetInt(dataReader, "CityId");
                    objCity_Mst.City = DataHelper.GetString(dataReader, "City");
                    objCity_Mst.CityDesc = DataHelper.GetString(dataReader, "CityDesc");
                    objCity_Mst.countryId = DataHelper.GetInt(dataReader, "countryId");
                    objCity_Mst.stateId = DataHelper.GetInt(dataReader, "stateId");
                    objCity_Mst.insertedby = DataHelper.GetInt(dataReader, "insertedby");
                    objCity_Mst.insertedon = DataHelper.GetDateTime(dataReader, "insertedon");
                    objCity_Mst.updatedby = DataHelper.GetInt(dataReader, "updatedby");
                    objCity_Mst.updatedon = DataHelper.GetDateTime(dataReader, "updatedon");
                    objCity_Mst.deactive = DataHelper.GetInt(dataReader, "deactive");


                   // City_MstList.Add(objCity_Mst);
                }
            }

           // return City_MstList;
            return objCity_Mst;

        }

        public static List<City_Mst> GetCityByState(int stateId)
        {
            SqlCommand comm = new SqlCommand();
            City_Mst objCity_Mst = null;
            List<City_Mst> City_MstList = new List<City_Mst>();
            comm.CommandText = "usp_GetCityByStateId";
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@stateId", stateId);
            comm.Parameters.Add(p);

            //SqlParameter p = new SqlParameter("@UserId", objUserMst.UserId);
            //        comm.Parameters.Add(p);

            using (IDataReader dataReader = DataConnector.GetDataReader(comm))
            {
                while (dataReader.Read())
                {
                    objCity_Mst = new City_Mst();
                    objCity_Mst.CityId = DataHelper.GetInt(dataReader, "CityId");
                    objCity_Mst.City = DataHelper.GetString(dataReader, "City");
                    objCity_Mst.CityDesc = DataHelper.GetString(dataReader, "CityDesc");
                    objCity_Mst.countryId = DataHelper.GetInt(dataReader, "countryId");
                    objCity_Mst.stateId = DataHelper.GetInt(dataReader, "stateId");
                    objCity_Mst.insertedby = DataHelper.GetInt(dataReader, "insertedby");
                    objCity_Mst.insertedon = DataHelper.GetDateTime(dataReader, "insertedon");
                    objCity_Mst.updatedby = DataHelper.GetInt(dataReader, "updatedby");
                    objCity_Mst.updatedon = DataHelper.GetDateTime(dataReader, "updatedon");
                    objCity_Mst.deactive = DataHelper.GetInt(dataReader, "deactive");


                    City_MstList.Add(objCity_Mst);
                }
            }

            return City_MstList;

        }
    }


}





