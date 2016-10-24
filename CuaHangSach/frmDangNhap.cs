using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using ValueObject;
using BusinessLogicLayer;


namespace CuaHangSach
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        
        public frmDangNhap()
        {
            InitializeComponent();
            txtTaiKhoan.Focus();
        }
        
        NhanVien obj = new NhanVien();
        NhanVienBUS bus = new NhanVienBUS();
        public static string user = null;
        public static string manv = null;
        public static string quyen = null;
        public static string pass=null;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            user = txtTaiKhoan.Text;
            pass = txtMatKhau.Text;
            DataTable dt = bus.GetDataByAccount(user,pass);
            if(dt.Rows.Count>0)
            {
                quyen = dt.Rows[0]["QUYEN"].ToString();
                manv = dt.Rows[0]["MANV"].ToString();
                frmMain frm = new frmMain();
                frm.Show();
                Hide();
            }
            else
            {
                XtraMessageBox.Show("Đăng nhập thất bại", "Thông báo!");
                txtMatKhau.Text = string.Empty;
                txtTaiKhoan.Text = string.Empty;
                txtTaiKhoan.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}