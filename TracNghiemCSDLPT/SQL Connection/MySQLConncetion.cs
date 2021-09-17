using System;
using System.Collections.Generic;
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
                return null;
            }
        }
    }
}
