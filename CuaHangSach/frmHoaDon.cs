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
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        int slKho;
        public void KhoaDieuKhien()
        {
            mAHDTextEdit.Enabled = false;
            mANVTextEdit.Enabled = false;
            nGAYLAPDateEdit.Enabled = false;
            tENKHTextEdit.Enabled = false;

            btnTaoMoi.Enabled = true;
            btnThem.Enabled = false;
            btnTinhTien.Enabled = false;
            btnIn.Enabled = false;
        }
        public void MoKhoaDieuKhien()
        {
            mAHDTextEdit.Enabled = true;
            mANVTextEdit.Enabled = true;
            nGAYLAPDateEdit.Enabled = true;
            tENKHTextEdit.Enabled = true;

            btnTaoMoi.Enabled = true;
            btnThem.Enabled = false;
            btnTinhTien.Enabled = true;
            btnIn.Enabled = true;
        }
        void XoaText()
        {
            mAHDTextEdit.Text = string.Empty;
            mANVTextEdit.Text = string.Empty;
            nGAYLAPDateEdit.Text = string.Empty;
            tENKHTextEdit.Text = string.Empty;
        }
        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmHoaDon1_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            this.sACHTableAdapter.Fill(this.dS.SACH);
            tENSACHTextEdit.Text = string.Empty;
            XoaText();
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
                hOADONBindingSource.AddNew();
                DateTime now = DateTime.Now;
                mAHDTextEdit.EditValue = now.ToString("yyMMddhhmmss");
                mANVTextEdit.EditValue = frmDangNhap.manv;
                nGAYLAPDateEdit.EditValue = now;
                hOADONBindingSource.EndEdit();
                hOADONTableAdapter.Update(this.dS.HOADON);
                tENKHTextEdit.Focus();
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
                slKho = int.Parse(q.getSL(ms).ToString());
                //MessageBox.Show(slKho.ToString());
                tENSACHTextEdit.Text = tenS;
                gridView1.SetRowCellValue(e.RowHandle, "TENSACH", tenS);
                gridView1.SetRowCellValue(e.RowHandle, "GIASACH", q.getDG(ms));
            }
                
            else if (e.Column.FieldName == "SOLUONG")
            {
                int soLuong = int.Parse(e.Value.ToString());
                if (soLuong>slKho)
                {
                    XtraMessageBox.Show("Số lượng quá lớn!");
                }
                else
                {
                    int donGia = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "GIASACH").ToString());
                    gridView1.SetRowCellValue(e.RowHandle, "THANHTIEN", soLuong * donGia);
                }
            }
          //  MessageBox.Show(slKho.ToString());
        }


        private void cHITIETHOADONGridControl_ProcessGridKey(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    gridView1.AddNewRow();
                    gridView1.FocusedColumn = colMASACH;
                    summary();
                    q.Update_TONGTIEN(decimal.Parse(tONGTIENSpinEdit.EditValue.ToString()), mAHDTextEdit.Text);
                }
                else if (e.KeyCode == Keys.F2)
                {
                    gridView1.UpdateCurrentRow();
                    summary();
                    q.Update_TONGTIEN(decimal.Parse(tONGTIENSpinEdit.EditValue.ToString()), mAHDTextEdit.Text);
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
                cHITIETHOADONTableAdapter.Update(this.dS.CHITIETHOADON);
            }
            catch(Exception)
            {
             
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

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