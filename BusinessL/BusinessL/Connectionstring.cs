using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

using System.Web.Configuration;
using System.Configuration;

namespace BusinessL
{
    //class Conn
    //{

        internal static class ConnectionString
        {
            // Fields
            private static string configFileName = (AppDomain.CurrentDomain.BaseDirectory + @"\config.xml");
            private static string strConnectionString = "";
            private static DateTime Validity;

            // Methods
            private static void BuildConnectionString()
            {
                using (XmlTextReader reader = new XmlTextReader(configFileName))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "ConnectionString")
                            {
                                reader.MoveToAttribute("Value");
                                strConnectionString = Decrypt(reader.Value);
                            }
                            if (reader.Name == "Validity")
                            {
                                reader.MoveToAttribute("Value");
                                Validity = Convert.ToDateTime(Decrypt(reader.Value));
                            }
                        }
                    }
                }
            }

            private static string Decrypt(string InputText)
            {
                byte[] bytes = Convert.FromBase64String(InputText);
                bytes = Convert.FromBase64String(Encoding.ASCII.GetString(bytes));
                return Encoding.ASCII.GetString(bytes);
            }

            public static string GetConnectionString()
            {
                //if (string.IsNullOrEmpty(strConnectionString))
                //{
                //    BuildConnectionString();
                //    if (Validity.Year < DateTime.Now.Year)
                //    {
                //        throw new Exception("Year Overflow");
                //    }
                //}
                //return strConnectionString;

               // ConnectionString cs = WebConfigurationManager.ConnectionStrings[1];
                // return cs.ConnectionString;


                string connStr = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

               return connStr;

                


            
      }


   }
}
