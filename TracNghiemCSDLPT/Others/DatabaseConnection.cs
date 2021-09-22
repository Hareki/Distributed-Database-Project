using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiemCSDLPT.SQL_Connection
{
    class DatabaseConnection
    {
        private static SqlConnection PublisherConnection = new SqlConnection();
        private static SqlConnection SubcriberConnection = new SqlConnection();
        private static string PublisherName = "MSI";
        private static string DatabaseName = "TN_CSDLPT";
        private static string SysAdminName = "sa";
        private static string SysAdminPassword = "123456";

        private static string PublisherConnectionString = "Data source=" + PublisherName + "; " +
            "Initial Catalog=" + DatabaseName + ";Persist Security Info=True;" +
            "User ID=" + SysAdminName + ";Password=" + SysAdminPassword;

        private static string RemoteLogin = "HTKN";
        private static string RemotePassword = "123456";

        public static string LoginSV = "LOGIN_SINHVIEN";
        public static string PasswordSV = "123456";


        public static SqlConnection GetPublisherConnection()
        {
            if (PublisherConnection != null && PublisherConnection.State == System.Data.ConnectionState.Open)
            {
                PublisherConnection.Close();
            }
            try
            {
                PublisherConnection.ConnectionString = PublisherConnectionString;
                PublisherConnection.Open();
                return PublisherConnection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static SqlConnection GetSubcriberConnection(string loginName, string password, string subcriberName)
        {
            if (SubcriberConnection != null && SubcriberConnection.State == System.Data.ConnectionState.Open)
            {
                SubcriberConnection.Close();
            }
            try
            {
                string SubcriberConnectionString = "Data source=" + subcriberName + "; " +
            "Initial Catalog=" + DatabaseName + ";Persist Security Info=True;" +
            "User ID=" + loginName + ";Password=" + password;
                SubcriberConnection.ConnectionString = SubcriberConnectionString;
                SubcriberConnection.Open();
                return SubcriberConnection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static SqlConnection GetSubcriberConnection(string subcriberName)
        {
            if (SubcriberConnection != null && SubcriberConnection.State == System.Data.ConnectionState.Open)
            {
                SubcriberConnection.Close();
            }
            try
            {
                string SubcriberConnectionString = "Data source=" + subcriberName + "; " +
            "Initial Catalog=" + DatabaseName + ";Persist Security Info=True;" +
            "User ID=" + LoginSV + ";Password=" + PasswordSV;
                SubcriberConnection.ConnectionString = SubcriberConnectionString;
                SubcriberConnection.Open();
                return SubcriberConnection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static SqlDataReader ExecuteSqlDataReader(string query)
        {
            SqlDataReader result;
            SqlCommand sqlCmd = new SqlCommand(query, SubcriberConnection);
            sqlCmd.CommandType = CommandType.Text;
            if (SubcriberConnection.State == ConnectionState.Closed)
                SubcriberConnection.Open();
            try
            {
                result = sqlCmd.ExecuteReader();
                return result;
            }
            catch (SqlException ex)
            {
                SubcriberConnection.Close();
                Utils.ShowErrorMessage("Lỗi không xác định (ExecuteSqlDataReader)", "Lỗi kết nối");
                Console.WriteLine(ex.ToString());
                return null;
            }

        }

        public static DataTable ExecuteSqlDataTable(string query)
        {
            try
            {
                DataTable result = new DataTable();
                if (SubcriberConnection.State == ConnectionState.Closed)
                    SubcriberConnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, SubcriberConnection);
                dataAdapter.Fill(result);
                SubcriberConnection.Close();
                return result;
            }
            catch (SqlException ex)
            {
                SubcriberConnection.Close();
                Utils.ShowErrorMessage("Lỗi không xác định (ExecuteSqlDataTable)", "Lỗi kết nối");
                Console.WriteLine(ex.ToString());
                return null;
            }


        }

        public static bool ExecuteSqlNonQuery(string command)
        {
            SqlCommand sqlCmd = new SqlCommand(command, SubcriberConnection);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;
            if (SubcriberConnection.State == ConnectionState.Closed)
                SubcriberConnection.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Utils.ShowErrorMessage("Lỗi không xác định (ExecuteSqlNonQuery)", "Lỗi kết nối");
                Console.WriteLine(ex.ToString());
                SubcriberConnection.Close();
                return false;
            }
        }
    }
}
