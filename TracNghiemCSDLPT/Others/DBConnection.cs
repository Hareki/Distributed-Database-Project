using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TracNghiemCSDLPT.Others
{
    public struct Para
    {
        public string ValueName;
        public object RealValue;
        public Para(string valueName, object realValue)
        {
            ValueName = valueName;
            RealValue = realValue;
        }
    }
    class DBConnection
    {
        private static string _databaseName = "TN_CSDLPT";
        //Unique Publisher Connection
        public static SqlConnection PublisherConnection = new SqlConnection();
        private static string _publisherName = ConfigurationManager.AppSettings["PublisherName"];
        private static string _sysAdminName = "sa";
        private static string _sysAdminPassword = "123456";
        private static string _publisherConnectionString = "Data source=" + _publisherName + "; " +
            "Initial Catalog=" + _databaseName + ";Persist Security Info=True;" +
            "User ID=" + _sysAdminName + ";Password=" + _sysAdminPassword;

        //Current Subcriber Connection
        public static SqlConnection SubcriberConnection = new SqlConnection();

        public static string LoginSv = "LOGIN_SINHVIEN";
        public static string PasswordSv = "123456";
        public static string UserNameSV = "USER_SINHVIEN";

        public static string SubcriberName;
        public static string LoginName;
        public static string Password;
        public static string SubcriberConnectionString;


        public static BindingSource BsSubcribers = new BindingSource();
        public static string UserName; // aka MaGV
        public static string HoTen; // Ten GV
        public static string NhomQuyen;
        public static int IndexCS = -1;

        //HTKN Connection
        public static string RemoteLogin = "HTKN";
        public static string RemotePassword = "123456";

        public static String GetVnTextNhomQuyen(string nhomQuyen)
        {
            switch (nhomQuyen)
            {
                case "TRUONG":
                    return "Trường";
                case "COSO":
                    return "Cơ sở";
                case "GIAOVIEN":
                    return "Giảng viên";
                case "SINHVIEN":
                    return "Sinh viên";
            }
            return string.Empty;
        }
        public static bool ConnectToPublisher()
        {
            if (PublisherConnection != null && PublisherConnection.State == ConnectionState.Open)
            {
                PublisherConnection.Close();
            }
            try
            {
                PublisherConnection.ConnectionString = _publisherConnectionString;
                PublisherConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        private static void GenerateSubConString(string subcriberName, string loginName, string password)
        {
            SubcriberConnectionString = "Data source=" + subcriberName + "; " +
            "Initial Catalog=" + _databaseName + ";Persist Security Info=True;" +
            "User ID=" + loginName + ";Password=" + password;
        }

        public static bool ConnectToSubcriber(string loginName, string password, string subcriberName)
        {
            if (SubcriberConnection != null && SubcriberConnection.State == ConnectionState.Open)
            {
                SubcriberConnection.Close();
            }
            try
            {
                LoginName = loginName;
                Password = password;
                SubcriberName = subcriberName;
                GenerateSubConString(subcriberName, loginName, password);
                SubcriberConnection.ConnectionString = SubcriberConnectionString;
                SubcriberConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage("Xảy ra lỗi \n" + ex.ToString(), "Lỗi kết nối");
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        public static bool ConnectToSubcriber(string subcriberName)
        {
            if (SubcriberConnection != null && SubcriberConnection.State == ConnectionState.Open)
            {
                SubcriberConnection.Close();
            }
            try
            {
                LoginName = LoginSv;
                Password = PasswordSv;
                SubcriberName = subcriberName;
                GenerateSubConString(subcriberName, LoginSv, PasswordSv);
                SubcriberConnection.ConnectionString = SubcriberConnectionString;
                SubcriberConnection.Open();

                Console.WriteLine("Connection String: " + SubcriberConnectionString);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
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
                Utils.ShowErrorMessage("Xảy ra lỗi \n" + ex.ToString(), "Lỗi kết nối");
                Console.WriteLine(ex.StackTrace);
                SubcriberConnection.Close();
                return null;
            }
        }


        public static SqlDataReader ExecuteSqlDataReaderSP(string spName, List<Para> paraList)
        {
            SqlDataReader result;
            SqlCommand sqlCmd = new SqlCommand(spName, SubcriberConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            foreach (Para element in paraList)
            {
                sqlCmd.Parameters.Add(new SqlParameter(element.ValueName, element.RealValue));
            }

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
                Utils.ShowErrorMessage("Xảy ra lỗi \n" + ex.ToString(), "Lỗi kết nối");
                SubcriberConnection.Close();
                Console.WriteLine(ex.StackTrace);
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
                Utils.ShowErrorMessage("Xảy ra lỗi \n" + ex.ToString(), "Lỗi kết nối");
                Console.WriteLine(ex.StackTrace);
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
                Utils.ShowErrorMessage("Xảy ra lỗi \n" + ex.ToString(), "Lỗi kết nối");
                Console.WriteLine(ex.StackTrace);
                SubcriberConnection.Close();
                return false;
            }
        }
    }
}
