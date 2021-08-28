using DDBProject.SQL_Connection;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDBProject.Views
{
    public partial class PanelQuanLy : UserControl
    {
        private Boolean canSearch = true;
        public PanelQuanLy()
        {
            InitializeComponent();
            //Bunifu.Utils.ScrollbarBinder.BindDatagridView(table, customScrollbar);
        }

        private void PanelQuanLy_Load(object sender, EventArgs e)
        {
            // table.DataSource = loadDataToTable().Tables[0].DefaultView;
            loadDataToTable3();
            DataGridViewColumn column = table.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column.DefaultCellStyle.Padding = new Padding(30, 0, 0, 0);
            column.HeaderCell.Style.Padding = new Padding(30, 0, 0, 0);
        }
        //Cách 1
        private DataSet loadDataToTable()
        {
            DataSet data = new DataSet();
            string query = "select * from Product";
            using (SqlConnection connection = DBConnection.getDBConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        //Cách 2
        public SqlDataReader GetData(string sql, SqlConnection connection)
        {
            try
            {
                SqlDataReader reader;
                SqlCommand cmd = new SqlCommand(sql, connection);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        private void loadDataToTable2()
        {
            string query = "select * from Product";
            SqlConnection connection = DBConnection.getDBConnection();
            connection.Open();
            SqlDataReader row;
            row = GetData(query, connection);

            var testList = new List<TestObject>();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    TestObject obj = new TestObject(Int32.Parse(row["ID"].ToString()),
                        row["Name"].ToString(), row["Type2"].ToString());
                    testList.Add(obj);
                }
                connection.Close();


                foreach (TestObject element in testList)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.Height = 40;
                    newRow.CreateCells(table);
                    newRow.Cells[0].Value = element.ID;
                    newRow.Cells[1].Value = element.Ten;
                    newRow.Cells[2].Value = element.Loai;
                    table.Rows.Add(newRow);
                }
            }

        }
        //Cách 3 - Dữ liệu không từ SQL
        private void loadDataToTable3()
        {
            for(int i = 1; i<= 100; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.Height = 40;
                newRow.CreateCells(table);
                newRow.Cells[0].Value = i;
                newRow.Cells[1].Value = "Tên sản phẩm " + i;
                newRow.Cells[2].Value = "Loại " + i;
                table.Rows.Add(newRow);
            }
            
        }

        private void SearchBox_TextChange(object sender, EventArgs e)
        {
            if (canSearch)
            {
                var SearchList = new List<TestObject>();
                string SearchText = SearchBox.Text.ToLower();
                string TestedName;
                int PreferedLength;
                int Length = SearchText.Length;
                //đang làm...
                canSearch = false;
            }
            else canSearch = true;


        }
    }
    public class TestObject
    {
        public int ID;
        public string Ten;
        public string Loai;
        public TestObject(int ID, string Ten, string loai)
        {
            this.ID = ID;
            this.Ten = Ten;
            this.Loai = loai;
        }
    }
    
}
