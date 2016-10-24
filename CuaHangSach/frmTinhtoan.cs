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
using ValueObject;


namespace CuaHangSach
{
    public partial class frmTinhtoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTinhtoan()
        {
            InitializeComponent();
        }
        CTHoaDonBUS bus = new CTHoaDonBUS();
        private void frmTinhtoan_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt = bus.GetData_TotalEarnMonth();
        }
    }
}