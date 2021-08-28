using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDBProject.SQL_Connection
{
    class DBConnection
    {
        public static SqlConnection
                getDBConnection()
        {
            string datasource = "MSI";
            string database = "TestingDB";
            string username = "sa";
            string password = "123456";
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                     + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
