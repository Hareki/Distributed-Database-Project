
namespace TracNghiemCSDLPT.MyForms
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.buttonMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.buttonDeThi = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSVL = new DevExpress.XtraBars.BarButtonItem();
            this.buttonGV = new DevExpress.XtraBars.BarButtonItem();
            this.buttonKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.buttonDKTN = new DevExpress.XtraBars.BarButtonItem();
            this.buttonTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.buttonDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.statusMa = new DevExpress.XtraBars.BarStaticItem();
            this.statusTen = new DevExpress.XtraBars.BarStaticItem();
            this.statusQuyen = new DevExpress.XtraBars.BarStaticItem();
            this.buttonBangDiem = new DevExpress.XtraBars.BarButtonItem();
            this.buttonKQThi = new DevExpress.XtraBars.BarButtonItem();
            this.buttonToChucThi = new DevExpress.XtraBars.BarButtonItem();
            this.buttonThamGiaThi = new DevExpress.XtraBars.BarButtonItem();
            this.pageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageThi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.Controller = this.barAndDockingController1;
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(34, 30, 34, 30);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.buttonMonHoc,
            this.buttonDeThi,
            this.buttonSVL,
            this.buttonGV,
            this.buttonKhoa,
            this.buttonDKTN,
            this.buttonTaoTK,
            this.buttonDangXuat,
            this.statusMa,
            this.statusTen,
            this.statusQuyen,
            this.buttonBangDiem,
            this.buttonKQThi,
            this.buttonToChucThi,
            this.buttonThamGiaThi});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 377;
            this.ribbon.OptionsTouch.ShowTouchUISelectorInSearchMenu = false;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageQuanLy,
            this.pageBaoCao,
            this.pageThi,
            this.pageTaiKhoan});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1093, 237);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.AppearancesRibbon.Item.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAndDockingController1.AppearancesRibbon.Item.Options.UseFont = true;
            this.barAndDockingController1.AppearancesRibbon.ItemDisabled.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.barAndDockingController1.AppearancesRibbon.ItemDisabled.Options.UseFont = true;
            this.barAndDockingController1.AppearancesRibbon.ItemHovered.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.barAndDockingController1.AppearancesRibbon.ItemHovered.Options.UseFont = true;
            this.barAndDockingController1.AppearancesRibbon.ItemPressed.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.barAndDockingController1.AppearancesRibbon.ItemPressed.Options.UseFont = true;
            this.barAndDockingController1.AppearancesRibbon.PageGroupCaption.Font = new System.Drawing.Font("Baloo 2", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAndDockingController1.AppearancesRibbon.PageGroupCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.barAndDockingController1.AppearancesRibbon.PageGroupCaption.Options.UseFont = true;
            this.barAndDockingController1.AppearancesRibbon.PageGroupCaption.Options.UseForeColor = true;
            // 
            // buttonMonHoc
            // 
            this.buttonMonHoc.Caption = "Môn học";
            this.buttonMonHoc.Id = 6;
            this.buttonMonHoc.ImageOptions.Image = global::TracNghiemCSDLPT.Properties.Resources.choice_480px;
            this.buttonMonHoc.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.book_480px;
            this.buttonMonHoc.LargeWidth = 80;
            this.buttonMonHoc.Name = "buttonMonHoc";
            this.buttonMonHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.buttonMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMonHoc_ItemClick);
            // 
            // buttonDeThi
            // 
            this.buttonDeThi.Caption = "Đề thi";
            this.buttonDeThi.Id = 7;
            this.buttonDeThi.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.choice_480px;
            this.buttonDeThi.LargeWidth = 80;
            this.buttonDeThi.Name = "buttonDeThi";
            this.buttonDeThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDeThi_ItemClick);
            // 
            // buttonSVL
            // 
            this.buttonSVL.Caption = "Sinh viên và lớp";
            this.buttonSVL.Id = 8;
            this.buttonSVL.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.classroom_480px;
            this.buttonSVL.LargeWidth = 80;
            this.buttonSVL.Name = "buttonSVL";
            this.buttonSVL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSinhVien_ItemClick);
            // 
            // buttonGV
            // 
            this.buttonGV.Caption = "Giáo viên";
            this.buttonGV.Id = 9;
            this.buttonGV.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.teacher_500px;
            this.buttonGV.LargeWidth = 80;
            this.buttonGV.Name = "buttonGV";
            this.buttonGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.butonGiaoVien_ItemClick);
            // 
            // buttonKhoa
            // 
            this.buttonKhoa.Caption = "Khoa";
            this.buttonKhoa.Id = 10;
            this.buttonKhoa.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.school_480px;
            this.buttonKhoa.LargeWidth = 80;
            this.buttonKhoa.Name = "buttonKhoa";
            this.buttonKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonKhoaLop_ItemClick);
            // 
            // buttonDKTN
            // 
            this.buttonDKTN.Caption = "Đăng ký thi TN";
            this.buttonDKTN.Id = 11;
            this.buttonDKTN.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.scorecard_480px;
            this.buttonDKTN.LargeWidth = 80;
            this.buttonDKTN.Name = "buttonDKTN";
            this.buttonDKTN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDKTN_ItemClick);
            // 
            // buttonTaoTK
            // 
            this.buttonTaoTK.Caption = "Tạo tài khoản";
            this.buttonTaoTK.Id = 12;
            this.buttonTaoTK.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.add_user_male_480px;
            this.buttonTaoTK.LargeWidth = 80;
            this.buttonTaoTK.Name = "buttonTaoTK";
            this.buttonTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonTaoTK_ItemClick);
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.Caption = "Đăng xuất";
            this.buttonDangXuat.Id = 13;
            this.buttonDangXuat.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.export_480px;
            this.buttonDangXuat.LargeWidth = 80;
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDangXuat_ItemClick);
            // 
            // statusMa
            // 
            this.statusMa.Caption = "Mã NV: ABC123";
            this.statusMa.Id = 15;
            this.statusMa.ItemAppearance.Hovered.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMa.ItemAppearance.Hovered.Options.UseFont = true;
            this.statusMa.ItemAppearance.Normal.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.statusMa.ItemAppearance.Normal.Options.UseFont = true;
            this.statusMa.ItemAppearance.Pressed.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.statusMa.ItemAppearance.Pressed.Options.UseFont = true;
            this.statusMa.Name = "statusMa";
            // 
            // statusTen
            // 
            this.statusTen.Caption = "Họ và tên: Nguyễn Ngọc Minh Tú";
            this.statusTen.Id = 16;
            this.statusTen.ItemAppearance.Hovered.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.statusTen.ItemAppearance.Hovered.Options.UseFont = true;
            this.statusTen.ItemAppearance.Normal.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.statusTen.ItemAppearance.Normal.Options.UseFont = true;
            this.statusTen.ItemAppearance.Pressed.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.statusTen.ItemAppearance.Pressed.Options.UseFont = true;
            this.statusTen.Name = "statusTen";
            // 
            // statusQuyen
            // 
            this.statusQuyen.Caption = "Nhóm: Admin";
            this.statusQuyen.Id = 17;
            this.statusQuyen.ItemAppearance.Hovered.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.statusQuyen.ItemAppearance.Hovered.Options.UseFont = true;
            this.statusQuyen.ItemAppearance.Normal.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.statusQuyen.ItemAppearance.Normal.Options.UseFont = true;
            this.statusQuyen.ItemAppearance.Pressed.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.statusQuyen.ItemAppearance.Pressed.Options.UseFont = true;
            this.statusQuyen.Name = "statusQuyen";
            // 
            // buttonBangDiem
            // 
            this.buttonBangDiem.Caption = "Bảng điểm";
            this.buttonBangDiem.Id = 18;
            this.buttonBangDiem.ImageOptions.Image = global::TracNghiemCSDLPT.Properties.Resources.logbook_500px;
            this.buttonBangDiem.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.logbook_500px;
            this.buttonBangDiem.LargeWidth = 80;
            this.buttonBangDiem.Name = "buttonBangDiem";
            this.buttonBangDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonBangDiem_ItemClick);
            // 
            // buttonKQThi
            // 
            this.buttonKQThi.Caption = "Kết quả thi";
            this.buttonKQThi.Id = 19;
            this.buttonKQThi.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.leaderboard_500px;
            this.buttonKQThi.LargeWidth = 80;
            this.buttonKQThi.Name = "buttonKQThi";
            this.buttonKQThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonKQThi_ItemClick);
            // 
            // buttonToChucThi
            // 
            this.buttonToChucThi.Caption = "Đăng ký thi";
            this.buttonToChucThi.Id = 20;
            this.buttonToChucThi.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.box_settings_500px;
            this.buttonToChucThi.LargeWidth = 80;
            this.buttonToChucThi.Name = "buttonToChucThi";
            this.buttonToChucThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonToChucThi_ItemClick);
            // 
            // buttonThamGiaThi
            // 
            this.buttonThamGiaThi.Caption = "Tham gia thi";
            this.buttonThamGiaThi.Id = 21;
            this.buttonThamGiaThi.ImageOptions.LargeImage = global::TracNghiemCSDLPT.Properties.Resources.time_500px;
            this.buttonThamGiaThi.LargeWidth = 80;
            this.buttonThamGiaThi.Name = "buttonThamGiaThi";
            this.buttonThamGiaThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonThamGiaThi_ItemClick);
            // 
            // pageQuanLy
            // 
            this.pageQuanLy.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageQuanLy.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.pageQuanLy.Appearance.Options.UseFont = true;
            this.pageQuanLy.Appearance.Options.UseForeColor = true;
            this.pageQuanLy.Appearance.Options.UseTextOptions = true;
            this.pageQuanLy.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.pageQuanLy.ImageOptions.Image = global::TracNghiemCSDLPT.Properties.Resources.database_administrator_25px;
            this.pageQuanLy.Name = "pageQuanLy";
            this.pageQuanLy.Text = "  Quản lý  ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonMonHoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonDeThi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup1.Text = "Môn học";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.buttonSVL);
            this.ribbonPageGroup2.ItemLinks.Add(this.buttonKhoa);
            this.ribbonPageGroup2.ItemLinks.Add(this.buttonGV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Phòng ban và nhân sự";
            // 
            // pageBaoCao
            // 
            this.pageBaoCao.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.pageBaoCao.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.pageBaoCao.Appearance.Options.UseFont = true;
            this.pageBaoCao.Appearance.Options.UseForeColor = true;
            this.pageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.pageBaoCao.ImageOptions.Image = global::TracNghiemCSDLPT.Properties.Resources.edit_graph_report_25px;
            this.pageBaoCao.Name = "pageBaoCao";
            this.pageBaoCao.Text = "  Báo cáo  ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.buttonDKTN);
            this.ribbonPageGroup4.ItemLinks.Add(this.buttonBangDiem);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Danh sách";
            // 
            // pageThi
            // 
            this.pageThi.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.pageThi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.pageThi.Appearance.Options.UseFont = true;
            this.pageThi.Appearance.Options.UseForeColor = true;
            this.pageThi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.pageThi.ImageOptions.Image = global::TracNghiemCSDLPT.Properties.Resources.test_passed_25px;
            this.pageThi.Name = "pageThi";
            this.pageThi.Text = "  Thi  ";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.buttonToChucThi);
            this.ribbonPageGroup6.ItemLinks.Add(this.buttonThamGiaThi);
            this.ribbonPageGroup6.ItemLinks.Add(this.buttonKQThi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Thi cử";
            // 
            // pageTaiKhoan
            // 
            this.pageTaiKhoan.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.pageTaiKhoan.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.pageTaiKhoan.Appearance.Options.UseFont = true;
            this.pageTaiKhoan.Appearance.Options.UseForeColor = true;
            this.pageTaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.pageTaiKhoan.ImageOptions.Image = global::TracNghiemCSDLPT.Properties.Resources.account2_25px;
            this.pageTaiKhoan.Name = "pageTaiKhoan";
            this.pageTaiKhoan.Text = "  Tài khoản  ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.buttonTaoTK);
            this.ribbonPageGroup5.ItemLinks.Add(this.buttonDangXuat);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tài khoản";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.BackColor = System.Drawing.Color.Red;
            this.ribbonStatusBar.ItemLinks.Add(this.statusMa, true);
            this.ribbonStatusBar.ItemLinks.Add(this.statusTen, true);
            this.ribbonStatusBar.ItemLinks.Add(this.statusQuyen, true);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 678);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1093, 36);
            // 
            // documentManager1
            // 
            this.documentManager1.BarAndDockingController = this.barAndDockingController1;
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.Appearance.Font = new System.Drawing.Font("Baloo 2 SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbedView1.Appearance.Options.UseFont = true;
            this.tabbedView1.AppearancePage.Header.Font = new System.Drawing.Font("Baloo 2 SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.tabbedView1.AppearancePage.Header.Options.UseFont = true;
            this.tabbedView1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Baloo 2 SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.tabbedView1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.tabbedView1.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Baloo 2 SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.tabbedView1.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.tabbedView1.AppearancePage.HeaderSelected.Font = new System.Drawing.Font("Baloo 2 SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.tabbedView1.AppearancePage.HeaderSelected.Options.UseFont = true;
            // 
            // MainView
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 714);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainView.IconOptions.Icon")));
            this.IconOptions.Image = global::TracNghiemCSDLPT.Properties.Resources.CSDLPT_Logo1;
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý thi trắc nghiệm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainView_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem buttonMonHoc;
        private DevExpress.XtraBars.BarButtonItem buttonDeThi;
        private DevExpress.XtraBars.BarButtonItem buttonSVL;
        private DevExpress.XtraBars.BarButtonItem buttonGV;
        private DevExpress.XtraBars.BarButtonItem buttonKhoa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem buttonDKTN;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem buttonTaoTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem buttonDangXuat;
        private DevExpress.XtraBars.BarButtonItem buttonBangDiem;
        private DevExpress.XtraBars.BarButtonItem buttonKQThi;
        private DevExpress.XtraBars.BarButtonItem buttonToChucThi;
        private DevExpress.XtraBars.BarButtonItem buttonThamGiaThi;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        public DevExpress.XtraBars.BarStaticItem statusMa;
        public DevExpress.XtraBars.BarStaticItem statusTen;
        public DevExpress.XtraBars.BarStaticItem statusQuyen;
    }
}