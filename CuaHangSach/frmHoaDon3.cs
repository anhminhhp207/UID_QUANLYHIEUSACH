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
    public partial class frmHoaDon3 : DevExpress.XtraEditors.XtraForm
    {
        public frmHoaDon3()
        {
            InitializeComponent();
        }
        HoaDon objHD = new HoaDon();
        HoaDonBUS busHD = new HoaDonBUS();
        CTHoaDon objCT = new CTHoaDon();
        CTHoaDonBUS busCT = new CTHoaDonBUS();

        private void frmHoaDon3_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEdit1.DataSource = busCT.GetDataSach();
            repositoryItemLookUpEdit1.ValueMember = "MASACH";
            repositoryItemLookUpEdit1.DisplayMember = "MASACH";
        }
        void KhoaDieuKhien()
        {

        }
        void MoKhoaDieuKhien()
        {

        }
        void XoaText()
        {

        }
        public void summary()
        {
            decimal sum = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                sum += decimal.Parse(gridView1.GetRowCellValue(i, "THANHTIEN").ToString());
            }

            spintongTien.EditValue = sum;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoKhoaDieuKhien();
            DateTime now = DateTime.Now;
            txtMaHD.EditValue = now.ToString("yyMMddhhmmss");
            txtMaNV.EditValue = frmDangNhap.manv;
            dtNgayLap.EditValue = now;
            txtTenKH.Focus();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            btnThem.Enabled = true;
            XoaText();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            repositoryItemLookUpEdit1.DataSource = busCT.GetDataSach();
            repositoryItemLookUpEdit1.ValueMember = "MASACH";
            repositoryItemLookUpEdit1.DisplayMember = "MASACH";

            if (e.Column.FieldName == "MASACH")
            {

                MessageBox.Show(e.Value.ToString());
                string ms = e.Value.ToString();
                DataTable dt = new DataTable();
                dt = busCT.Get_GiaBan(ms);
                string tenS = dt.Rows[0]["TENSACH"].ToString();
                txtTenSach.Text = tenS;
                gridView1.SetRowCellValue(e.RowHandle, "TENSACH", tenS);
                gridView1.SetRowCellValue(e.RowHandle, "GIASACH", dt.Rows[0]["GIAMUA"].ToString());
            }
            else if (e.Column.FieldName == "SOLUONG")
            {
                int soLuong = int.Parse(e.Value.ToString());
                int donGia = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "GIASACH").ToString());
                gridView1.SetRowCellValue(e.RowHandle, "THANHTIEN", soLuong * donGia);
            }
        }
    }
}