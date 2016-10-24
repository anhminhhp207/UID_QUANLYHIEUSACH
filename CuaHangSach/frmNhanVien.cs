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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVien obj = new NhanVien();
        NhanVienBUS bus = new NhanVienBUS();
        bool IsInsert = false;
        void KhoaDieuKhien()
        {

            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            radGT.Enabled = false;
            txtGioiTinh.Enabled = false;
            dtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
            radChucVu.Enabled = false;
            txtChucVu.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        void MoKhoaDieuKhien()
        {
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            radGT.Enabled = true;
            txtGioiTinh.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
            radChucVu.Enabled = true;
            txtChucVu.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        void XoaText()
        {
            txtMaNV.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtChucVu.Text = string.Empty;
            dtNgaySinh.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtGioiTinh.Text = string.Empty;
        }
        void HienThi()
        {
            msdsNhanvien.DataSource = bus.GetData();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaText();
            MoKhoaDieuKhien();
            IsInsert = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoKhoaDieuKhien();
            txtMaNV.Enabled = false;
            IsInsert = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bus.Delete(txtMaNV.Text);
                    XtraMessageBox.Show("Đã xóa thành công");
                    XoaText();
                    KhoaDieuKhien();
                    HienThi();
                }
                catch
                {
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj.MaNV = txtMaNV.Text;
            obj.TenNV = txtTenNV.Text;
            obj.GioiTinh = txtGioiTinh.Text;
            obj.NgaySinh = DateTime.Parse(dtNgaySinh.Text);
            obj.DienThoai = txtSDT.Text;
            obj.DiaChi = txtDiaChi.Text;
            obj.TaiKhoan = txtTaiKhoan.Text;
            obj.MatKhau = txtMatKhau.Text;
            obj.QUYEN = txtChucVu.Text;
            
            if (IsInsert == true)
            {
                //insert
                bus.Insert(obj);
                XtraMessageBox.Show("Thêm thành công!");
                HienThi();
                XoaText();
                KhoaDieuKhien();
            }
            else
            {
                //update
                bus.Update(obj);
                XtraMessageBox.Show("Sửa thành công!");
                HienThi();
                XoaText();
                KhoaDieuKhien();
            }
        }

        private void frmNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void msdsNhanvien_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                txtMaNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                txtTenNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
                txtGioiTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
                dtNgaySinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
                txtSDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
                txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
                txtTaiKhoan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString();
                txtMatKhau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[7]).ToString();
                txtChucVu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[8]).ToString();
            }
            catch
            {

            }
        }

        private void radChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtChucVu.Text = radChucVu.EditValue.ToString();
        }

        private void radGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGioiTinh.Text = radGT.EditValue.ToString();
        }
    }
}