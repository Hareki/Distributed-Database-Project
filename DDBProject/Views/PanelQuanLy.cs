using DDBProject.SQL_Connection;
using DDBProject.Views.Custom_UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DDBProject.Views
{
    public partial class PanelQuanLy : UserControl
    {
        private Boolean canSearch = true;
        List<TestObject> testList;


        public PanelQuanLy()
        {
            InitializeComponent();
            //Bunifu.Utils.ScrollbarBinder.BindDatagridView(table, customScrollbar);
            loadDataToTable3();
            DataGridViewColumn column = table.Columns[0];
            column.DefaultCellStyle.Padding = new Padding(30, 0, 0, 0);
            column.HeaderCell.Style.Padding = new Padding(25, 0, 0, 0);
            guna2ComboBox1.SelectedIndex = 0;
        }
        private void AddRowToTable(TestObject obj)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Height = 40;
            newRow.CreateCells(table);
            newRow.Cells[0].Value = obj.ID;
            newRow.Cells[1].Value = obj.Ten;
            newRow.Cells[2].Value = obj.Loai;
            table.Rows.Add(newRow);
        }

        private void ReloadSearchTable(List<TestObject> list)
        {
            table.RowCount = 0;
            foreach (TestObject element in list)
            {
                AddRowToTable(element);
            }
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

            testList = new List<TestObject>();
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
                    AddRowToTable(element);
                }
            }

        }
        //Cách 3 - Dữ liệu không từ SQL
        private void loadDataToTable3()
        {
            testList = new List<TestObject>();
            for (int i = 1; i <= 100; i++)
            {
                TestObject obj = new TestObject(i, "Tên sản phẩm " + i, "Loại " + i);
                AddRowToTable(obj);
                testList.Add(obj);
            }

        }

        private List<TestObject> GetListByName(string SearchName)
        {
            List<TestObject> SearchList = new List<TestObject>();
            string SearchText = SearchName.ToLower();
            string TestedName;
            int SearchLength = SearchText.Length;
            foreach (TestObject element in testList)
            {
                TestedName = element.Ten.ToLower();
                for (int j = 0; j < TestedName.Length; j++)
                {
                    if (j + SearchLength > TestedName.Length)
                    {
                        break;
                    }

                    if (SearchText.Equals(TestedName.Substring(j, SearchLength)) && !SearchList.Contains(element))
                    {
                        SearchList.Add(element);
                        break;
                    }
                }
            }
            return SearchList;
        }

        private void SearchBox_TextChange(object sender, EventArgs e)
        {
            if (canSearch)
            {
                if (SearchBox.Text.Length == 0)
                {
                    loadDataToTable3();
                }
                else
                {
                    ReloadSearchTable(GetListByName(SearchBox.Text));
                }
                canSearch = false;
            }
            else canSearch = true;
        }

    }
    public class TestObject
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string Loai { get; set; }
        public TestObject(int ID, string Ten, string loai)
        {
            this.ID = ID;
            this.Ten = Ten;
            this.Loai = loai;
        }

    }

}
