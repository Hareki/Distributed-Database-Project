using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiemCSDLPT.MyForms.QuanLy
{
    public partial class FormChuyenNhom : DevExpress.XtraEditors.XtraForm
    {
        public FormChuyenNhom()
        {
            InitializeComponent();
            table1.DataSource = genTable1();
            table2.DataSource = genTable2();
        }



        private DataTable genTable1()
        {
            DataTable Customer = new DataTable("Customer");

            //Tạo các cột và các schema
            DataColumn CustomerId = new DataColumn("ID", typeof(string));
            Customer.Columns.Add(CustomerId);
            DataColumn CustomerName = new DataColumn("Name", typeof(string));
            Customer.Columns.Add(CustomerName);

            //Thêm các hàng dữ liệu vào bảng Customer

            for(int i =1;i< 10; i++)
            {
                string maNhom = "c0" + i.ToString();
                string tenNhom = "Nâng cấp hệ thống viễn thông " + i.ToString();
                Customer.Rows.Add(maNhom, tenNhom);
            }
            return Customer;
        }

        private DataTable genTable2()
        {
            DataTable Customer = new DataTable("Customer");

            //Tạo các cột và các schema
            DataColumn CustomerId = new DataColumn("ID", typeof(string));
            Customer.Columns.Add(CustomerId);
            DataColumn CustomerName = new DataColumn("Name", typeof(string));
            Customer.Columns.Add(CustomerName);

            //Thêm các hàng dữ liệu vào bảng Customer

            for (int i = 1; i < 10; i++)
            {
                string maNhom = "d0" + i.ToString();
                string tenNhom = "Hệ thống phát sóng băng tần " + i.ToString();
                Customer.Rows.Add(maNhom, tenNhom);
            }
            return Customer;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}