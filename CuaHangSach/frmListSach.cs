using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using BusinessLogicLayer;

namespace CuaHangSach
{
    public partial class frmListSach : DevExpress.XtraEditors.XtraForm
    {
        public frmListSach()
        {
            InitializeComponent();
        }
        SachBUS bus = new SachBUS();
        void HienThi()
        {
            msdsListSach.DataSource = bus.GetData();
            gridView1.ExpandAllGroups();
        }


        private void frmListSach_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        //btnxoa
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string Ma = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                    bus.Delete(Ma);
                    XtraMessageBox.Show("Đã xóa thành công");
                    HienThi();
                }
                catch
                {
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmSach frm = new frmSach();
            frm.IsInsert = true;
            frm.LamMoi += new EventHandler(btnHienThi_Click);
            frm.ShowInTaskbar = false;
            frm.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmSach frm = new frmSach();
            frm.IsInsert = false;
            frm.Ma = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            frm.LamMoi += new EventHandler(btnHienThi_Click);
            frm.ShowInTaskbar = false;
            frm.ShowDialog();
        }
    }
}