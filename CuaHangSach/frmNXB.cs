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
    public partial class frmNXB : DevExpress.XtraEditors.XtraForm
    {
        public frmNXB()
        {
            InitializeComponent();
        }
        NhaXuatBan obj = new NhaXuatBan();
        NXBBUS bus = new NXBBUS();
        bool IsInsert = false;
        void KhoaDieuKhien()
        {

            txtMaNXB.Enabled = false;
            txtTenNXB.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        void MoKhoaDieuKhien()
        {
            txtMaNXB.Enabled = true;
            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        void XoaText()
        {
            txtMaNXB.Text = string.Empty;
            txtTenNXB.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
        }
        void HienThi()
        {
            msdsNXB.DataSource = bus.GetData();
        }

        private void frmNXB_Load(object sender, EventArgs e)
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
            txtMaNXB.Enabled = false;
            IsInsert = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bus.Delete(txtMaNXB.Text);
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
            obj.MaNXB = txtMaNXB.Text;
            obj.TenNXB = txtTenNXB.Text;
            obj.DiaChi = txtDiaChi.Text;
            obj.SoDienThoai = txtDienThoai.Text;
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

        private void msdsNXB_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                txtMaNXB.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                txtTenNXB.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
                txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
                txtDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            }
            catch
            {

            }
        }


    }
}