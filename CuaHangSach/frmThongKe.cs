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
    public partial class frmThongKe : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        CTHoaDonBUS HDbus = new CTHoaDonBUS();
        CTPhieuNhapBUS PNbus = new CTPhieuNhapBUS();

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = HDbus.GetData();
            gridControl2.DataSource = PNbus.GetData();
            gridView1.ExpandAllGroups();
            gridView2.ExpandAllGroups();

            DataTable dt1 = new DataTable();
            dt1 = HDbus.GetData_TotalEarn();
            txtTongDT.Text = dt1.Rows[0][0].ToString();

            //DataTable dt2 = new DataTable();
            //dt2 = HDbus.GetData_MostBook();
            //txtSachBanChay.Text = dt2.Rows[0][1].ToString();

            //dt2 = PNbus.GetData_TongChi();
            //txtChi.Text = dt2.Rows[0][0].ToString();
        }
        //private void TinhDoanhThu(DateTime date1,DateTime date2)
        //{
        //    DataTable dt = new DataTable();
        //    dt = HDbus.GetData_TotalEarnMonth(date1,date2);
        //    txtDTThang.Text = dt.Rows[0][0].ToString();
        //}

        private void txtSachBanChay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dtStart_EditValueChanged(object sender, EventArgs e)
        {
            //if (dtEnd.Text != string.Empty)
            //{
            //    TinhDoanhThu(DateTime.Parse(dtStart.Text), DateTime.Parse(dtStart.Text));
            //}
        }

        private void dtEnd_EditValueChanged(object sender, EventArgs e)
        {
            //if (dtStart.Text != string.Empty)
            //{
            //    TinhDoanhThu(DateTime.Parse(dtStart.Text), DateTime.Parse(dtEnd.Text));
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           // TinhDoanhThu( dtStart.EditValue,dtEnd.EditValue);
        }
    }
}