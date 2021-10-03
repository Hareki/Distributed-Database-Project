using DevExpress.XtraEditors;
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
    public partial class FormCauHoi : DevExpress.XtraEditors.XtraForm
    {
        public FormCauHoi()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.MonHocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPTDataSet);

        }

        private void FormCauHoi_Load(object sender, EventArgs e)
        {
            this.MonHocTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BoDeTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            this.BoDeTableAdapter.Fill(this.TN_CSDLPTDataSet.BODE);
            
            

        }

        private void MonHocGridView_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            GridView view = sender as GridView;
            if (view is null) return;
            string tenMon = (string)view.GetRowCellValue(e.RowHandle, colTENMH); ;
            if (e.RelationIndex == 1)
                e.RelationName = $"Câu hỏi thuộc môn {tenMon}";
        }

        private void MonHocGridView_DetailTabStyle(object sender, DetailTabStyleEventArgs e)
        {
            e.Appearance.Header.Font = new Font("Baloo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}