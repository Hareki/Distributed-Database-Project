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
    class MySQLConncetion
    {
        private static SqlConnection PublisherConnection = new SqlConnection();
        private static SqlConnection SubcriberConnection = new SqlConnection();
        public static String PublisherName = "MSI";
        public static String DatabaseName = "TN_CSDLPT";
        public static String SysAdminName = "sa";
        public static String SysAdminPassword = "123456";

        public static String PublisherConnectionString = "Data source=" + PublisherName + "; " +
            "Initial Catalog=" + DatabaseName + ";Persist Security Info=True;" +
            "User ID=" + SysAdminName + ";Password=" + SysAdminPassword;

        public static String RemoteLogin = "HTKN";
        public static String RemotePassword = "123456";

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
                Utils.ShowErrorMessage("Kết nối đến CSDL thất bại\n" +
                    "Vui lòng xem lại tên server và tên CSDL trong chuỗi kết nối", "Lỗi kết nối");
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
                Utils.ShowErrorMessage("Kết nối đến CSDL thất bại.\n" +
                    "Tài khoản, mật khẩu hoặc cơ sở không chính xác.\nVui lòng xem " +
                    "lại thông tin đăng nhập.", "Lỗi đăng nhập");
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
                Utils.ShowErrorMessage("Lỗi không xác định", "Lỗi kết nối");
                Console.WriteLine(ex.ToString());
                return null;
            }

        }

        public static DataTable ExecuteSqlDataTable(string query)
        {
            DataTable result = new DataTable();
            if (SubcriberConnection.State == ConnectionState.Closed)
                SubcriberConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, SubcriberConnection);
            dataAdapter.Fill(result);
            SubcriberConnection.Close();
            return result;
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
                Utils.ShowErrorMessage("Lỗi không xác định", "Lỗi kết nối");
                Console.WriteLine(ex.ToString());
                SubcriberConnection.Close();
                return false;
            }
        }
    }
}
