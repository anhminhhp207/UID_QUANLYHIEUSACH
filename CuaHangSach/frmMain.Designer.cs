namespace CuaHangSach
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhapSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTheLoai = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnThongKe = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnNhapSach,
            this.btnBanSach,
            this.btnSach,
            this.btnTheLoai,
            this.barButtonItem3,
            this.btnNhanVien,
            this.skinRibbonGalleryBarItem1,
            this.btnThongKe,
            this.btnThongTin,
            this.btnDangXuat});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(926, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.Caption = "Nhập sách";
            this.btnNhapSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhapSach.Glyph")));
            this.btnNhapSach.Id = 1;
            this.btnNhapSach.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhapSach.LargeGlyph")));
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapSach_ItemClick);
            // 
            // btnBanSach
            // 
            this.btnBanSach.Caption = "Bán sách";
            this.btnBanSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBanSach.Glyph")));
            this.btnBanSach.Id = 2;
            this.btnBanSach.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBanSach.LargeGlyph")));
            this.btnBanSach.Name = "btnBanSach";
            this.btnBanSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanSach_ItemClick);
            // 
            // btnSach
            // 
            this.btnSach.Caption = "Sách";
            this.btnSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSach.Glyph")));
            this.btnSach.Id = 3;
            this.btnSach.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSach.LargeGlyph")));
            this.btnSach.Name = "btnSach";
            this.btnSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSach_ItemClick);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Caption = "Thể loại";
            this.btnTheLoai.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTheLoai.Glyph")));
            this.btnTheLoai.Id = 4;
            this.btnTheLoai.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTheLoai.LargeGlyph")));
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTheLoai_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Nhà xuất bản";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Glyph")));
            this.btnNhanVien.Id = 6;
            this.btnNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.LargeGlyph")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 7;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Caption = "Thống kê";
            this.btnThongKe.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Glyph")));
            this.btnThongKe.Id = 8;
            this.btnThongKe.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThongKe.LargeGlyph")));
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKe_ItemClick);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Caption = "Thông tin cá nhân";
            this.btnThongTin.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThongTin.Glyph")));
            this.btnThongTin.Id = 9;
            this.btnThongTin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThongTin.LargeGlyph")));
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongTin_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Glyph")));
            this.btnDangXuat.Id = 10;
            this.btnDangXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.LargeGlyph")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapSach);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBanSach);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Nhập - Bán sách";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSach);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTheLoai);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thông tin sách";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hồ sơ nhân viên";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Báo cáo & Thống kê";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnThongKe);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hệ thống";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Giao diện";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnThongTin);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 626);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(926, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 657);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý bán sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btnNhapSach;
        private DevExpress.XtraBars.BarButtonItem btnBanSach;
        private DevExpress.XtraBars.BarButtonItem btnSach;
        private DevExpress.XtraBars.BarButtonItem btnTheLoai;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnThongTin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
    }
}