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
    public partial class frmTheLoai : DevExpress.XtraEditors.XtraForm
    {
        public frmTheLoai()
        {
            InitializeComponent();
        }
        TheLoai obj = new TheLoai();
        TheLoaiBUS bus = new TheLoaiBUS();
        bool IsInsert = false;
        void KhoaDieuKhien()
        {

            txtMaTL.Enabled = false;
            txtTen.Enabled = false;
            txtMota.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        void MoKhoaDieuKhien()
        {
            txtMaTL.Enabled = true;
            txtTen.Enabled = true;
            txtMota.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        void XoaText()
        {
            txtMaTL.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtMota.Text = string.Empty;
        }
        void HienThi()
        {
            msds.DataSource = bus.GetData();
        }


        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmTheLoai_Load(object sender, EventArgs e)
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
            txtMaTL.Enabled = false;
            IsInsert = false;

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn xóa không?","Thông Báo!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                try
                {
                    bus.Delete(txtMaTL.Text);
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
        //nut luu
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            obj.MaTheLoai = txtMaTL.Text;
            obj.TenTheLoai = txtTen.Text;
            obj.MoTa = txtMota.Text;
            if(IsInsert == true)
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

        private void msds_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                txtMaTL.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
                txtMota.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            }
            catch
            {

            }
        }
    }
}