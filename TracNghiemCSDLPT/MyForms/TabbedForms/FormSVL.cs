using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.SQL_Connection;

namespace TracNghiemCSDLPT.MyForms.TabbedForms
{
    public partial class FormSVL : DevExpress.XtraEditors.XtraForm
    {
        public FormSVL()
        {
            InitializeComponent();
        }


        private void FormSVL_Load(object sender, EventArgs e)
        {
            this.TN_CSDLPTDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.SINHVIEN' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.


            this.KhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.LopTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.SinhVienTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
            this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
            this.SinhVienTableAdapter.Fill(this.TN_CSDLPTDataSet.SINHVIEN);

            KhoaGridView.ExpandMasterRow(0);
        }

        private void LopGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int row = KhoaGridView.GetSelectedRows()[0];
            var detailView = KhoaGridView.GetDetailView(row, 0);
            Object test = (detailView as GridView).GetFocusedRowCellValue(colMALOP1);
            string MaLop;
            if (test != null)
                MaLop = test.ToString();
            else return;
            LopBindingSource.Position = LopBindingSource.Find("MALOP", MaLop);

        }

        private void KhoaGridView_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            GridView view = sender as GridView;
            if (view is null) return;
            string tenKhoa = (string)view.GetRowCellValue(e.RowHandle, colTENKH); ;
            if (e.RelationIndex == 0)
                e.RelationName = $"Lớp thuộc khoa {tenKhoa}";
        }

        private void KhoaGridView_DetailTabStyle(object sender, DetailTabStyleEventArgs e)
        {
            e.Appearance.Header.Font = new Font("Baloo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }
    }
}