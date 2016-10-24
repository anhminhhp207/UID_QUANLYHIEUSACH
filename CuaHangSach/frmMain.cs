using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;


namespace CuaHangSach
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public frmMain()
        {
            InitializeComponent();
        }
        Form CheckActiveForm(Type fType)
        {
            foreach (var f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }
        private void btnTheLoai_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmTheLoai));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTheLoai fr = new frmTheLoai();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        //nxb
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmNXB));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNXB fr = new frmNXB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmNhanVien));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNhanVien fr = new frmNhanVien();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmListSach));
            if (frm != null)
                frm.Activate();
            else
            {
                frmListSach fr = new frmListSach();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBanSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmHoaDon));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHoaDon fr = new frmHoaDon();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnNhapSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmPhieuNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                frmPhieuNhap fr = new frmPhieuNhap();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            if(frmDangNhap.quyen=="Nhân viên")
            {
                btnNhapSach.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
            }
        }

        private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmThongKe));
            if (frm != null)
                frm.Activate();
            else
            {
                frmThongKe fr = new frmThongKe();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmThongTinCaNhan));
            if (frm != null)
                frm.Activate();
            else
            {
                frmThongTinCaNhan fr = new frmThongTinCaNhan();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmDangNhap frm = new frmDangNhap();
                this.Hide();
                frm.Show();
            }
        }
    }
}