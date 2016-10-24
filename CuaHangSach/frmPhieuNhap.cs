using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CuaHangSach
{
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        public void KhoaDieuKhien()
        {
            mAPNTextEdit.Enabled = false;
            mANVTextEdit.Enabled = false;
            nGAYLAPDateEdit.Enabled = false;

            btnTaoMoi.Enabled = true;
            btnThem.Enabled = false;
            btnTinhTien.Enabled = false;
            btnIn.Enabled = false;
        }
        public void MoKhoaDieuKhien()
        {
            mAPNTextEdit.Enabled = true;
            mANVTextEdit.Enabled = true;
            nGAYLAPDateEdit.Enabled = true;

            btnTaoMoi.Enabled = true;
            btnThem.Enabled = false;
            btnTinhTien.Enabled = true;
            btnIn.Enabled = true;
        }
        void XoaText()
        {
            mAPNTextEdit.Text=string.Empty;
            mANVTextEdit.Text=string.Empty;
            nGAYLAPDateEdit.Text = string.Empty;
        }
        private void pHIEUNHAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUNHAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void pHIEUNHAPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUNHAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            // TODO: This line of code loads data into the 'dS.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.dS.SACH);
            tENSACHTextEdit.Text = "";

        }

        DSTableAdapters.QueriesTableAdapter q = new DSTableAdapters.QueriesTableAdapter();
        public void summary()
        {
            decimal sum = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                sum += decimal.Parse(gridView1.GetRowCellValue(i, "THANHTIEN").ToString());
            }
            tONGTIENSpinEdit.EditValue = sum;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MoKhoaDieuKhien();
                pHIEUNHAPBindingSource.AddNew();
                DateTime now = DateTime.Now;
                mAPNTextEdit.EditValue = now.ToString("yyMMddhhmmss");
                mANVTextEdit.EditValue = frmDangNhap.manv;
                nGAYLAPDateEdit.EditValue = now;
                pHIEUNHAPBindingSource.EndEdit();
                pHIEUNHAPTableAdapter.Update(this.dS.PHIEUNHAP);
            }
            catch(Exception)
            {

            }

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MASACH")
            {
                string ms = e.Value.ToString();
                string tenS = q.getTS(ms).ToString();
                tENSACHTextEdit.Text = tenS;
                gridView1.SetRowCellValue(e.RowHandle, "TENSACH", tenS);
                gridView1.SetRowCellValue(e.RowHandle, "DONGIA", q.GetGM(ms));
            }
            else if (e.Column.FieldName == "SOLUONG")
            {
                int soLuong = int.Parse(e.Value.ToString());
                int donGia = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "DONGIA").ToString());
                gridView1.SetRowCellValue(e.RowHandle, "THANHTIEN", soLuong * donGia);
            }
        }

        private void cHITIETPHIEUNHAPGridControl_ProcessGridKey(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    gridView1.AddNewRow();
                    gridView1.FocusedColumn = colMASACH;
                    summary();
                    q.UpdateTTienPN(decimal.Parse(tONGTIENSpinEdit.EditValue.ToString()), mAPNTextEdit.Text);
                }
                else if (e.KeyCode == Keys.F2)
                {
                    gridView1.UpdateCurrentRow();
                    summary();
                    q.UpdateTTienPN(decimal.Parse(tONGTIENSpinEdit.EditValue.ToString()), mAPNTextEdit.Text);
                }
            }
            catch (Exception)
            {

            }
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            btnTinhTien.Enabled = false;
            try
            {
                cHITIETPHIEUNHAPTableAdapter.Update(this.dS.CHITIETPHIEUNHAP);
            }
            catch
            {

            }

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            btnThem.Enabled = true;
            XoaText();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }
    }
}