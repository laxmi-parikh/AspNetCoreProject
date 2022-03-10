using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace BusinessL
{
    //class Conn
    //{

    public class DataHelper
    {
        // Methods
        public static bool GetBoolean(IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
            {
                return false;
            }
            return Convert.ToBoolean(rdr[ordinal]);
        }

        public static byte[] GetBytes(IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
            {
                return null;
            }
            return (byte[])rdr[ordinal];
        }

        public static DateTime GetDateTime(IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
            {
                return DateTime.MinValue;
            }
            return (DateTime)rdr[ordinal];
        }

        public static decimal GetDecimal(IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
            {
                return 0M;
            }
            return Convert.ToDecimal(rdr[ordinal]);
        }

        public static double GetDouble(IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
            {
                return 0.0;
            }
            return (double)rdr[ordinal];
        }

        public static Guid GetGuid(IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
            {
                return Guid.Empty;
            }
            return (Guid)rdr[ordinal];
        }

        public static int GetInt(IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
            {
                return 0;
            }
            return (int)rdr[ordinal];
        }

        public static DateTime? GetNullableDateTime(IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
            {
                return null;
            }
            return new DateTime?((DateTime)rdr[ordinal]);
        }

        public static int? GetNullableInt(IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
            {
                return null;
            }
            return new int?((int)rdr[ordinal]);
        }

        public static string GetString(IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
            {
                return string.Empty;
            }
            return (string)rdr[ordinal];
        }
    }



   // }
}
