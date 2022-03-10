using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace BusinessL
{
    public class DataConnector : IDisposable
    {
        // Fields
        private bool disposed;
        private SqlConnection gConn;
        private SqlTransaction gTran;

        // Methods
        public DataConnector()
        {
            if (DateTime.Now.Year > 0x7da)
            {
                throw new Exception("Year Overflow");
            }
        }

        public void BeginTransaction()
        {
            this.gConn = new SqlConnection(ConnectionString.GetConnectionString());
            this.gConn.Open();
            this.gTran = this.gConn.BeginTransaction(IsolationLevel.Serializable);
        }

        public void CommitTransaction()
        {
            this.gTran.Commit();
            if (this.gConn.State == ConnectionState.Open)
            {
                this.gConn.Close();
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.gConn.Dispose();
                }
                this.disposed = true;
            }
        }

        public static int ExecuteCommand(SqlCommand comm)
        {
            int num;
            SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString());
            try
            {
                comm.Connection = connection;
                connection.Open();
                num = comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return num;
        }

        public static int ExecuteCommand(string strCommand)
        {
            int num;
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString());
            try
            {
                command.Connection = connection;
                command.CommandText = strCommand;
                connection.Open();
                num = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return num;
        }

        public int ExecuteCommandTransaction(SqlCommand comm)
        {
            int num;
            try
            {
                comm.Connection = this.gConn;
                comm.Transaction = this.gTran;
                num = comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            return num;
        }

        public static string ExecuteScalar(SqlCommand comm)
        {
            string str;
            SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString());
            try
            {
                comm.Connection = connection;
                connection.Open();
                str = comm.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return str;
        }

        public static string ExecuteScalar(string strCommand)
        {
            string str;
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString());
            try
            {
                command.Connection = connection;
                command.CommandText = strCommand;
                connection.Open();
                str = command.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return str;
        }

        public static SqlDataReader GetDataReader(SqlCommand comm)
        {
            SqlDataReader reader;
            SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString());
            try
            {
                comm.Connection = connection;
                connection.Open();
                reader = comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                throw;
            }
            return reader;
        }

        public static SqlDataReader GetDataReader(string strCommand)
        {
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString());
            try
            {
                command.Connection = connection;
                command.CommandText = strCommand;
                connection.Open();
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                throw;
            }
            return reader;
        }

        public static DataSet GetDataSet(string strCommand)
        {
            DataSet set;
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString());
            DataSet dataSet = new DataSet();
            try
            {
                command.Connection = connection;
                command.CommandText = strCommand;
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                set = dataSet;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return set;
        }

        public void RollbackTransaction()
        {
            this.gTran.Rollback();
            if (this.gConn.State == ConnectionState.Open)
            {
                this.gConn.Close();
            }
        }
    }

}
