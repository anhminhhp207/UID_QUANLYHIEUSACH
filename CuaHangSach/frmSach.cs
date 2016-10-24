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
    public partial class frmSach : DevExpress.XtraEditors.XtraForm
    {
        public frmSach()
        {
            InitializeComponent();
        }
        public bool IsInsert = false;
        public EventHandler LamMoi;
        public string Ma = "";

        Sach obj = new Sach();
        SachBUS bus = new SachBUS();
       
        private void frmSach_Load(object sender, EventArgs e)
        {
            cbNXB.Properties.DataSource = bus.GetDataNXB();
            cbNXB.Properties.ValueMember = "MANXB";
            cbNXB.Properties.DisplayMember = "TENNXB";

            cbTheLoai.Properties.DataSource = bus.GetDataTheLoai();
            cbTheLoai.Properties.ValueMember = "MATHELOAI";
            cbTheLoai.Properties.DisplayMember = "TENTHELOAI";

            
            if(IsInsert==false)
            {
                txtMaSach.Enabled = false;
                DataTable dt = new DataTable();
                dt = bus.GetDataByID(Ma);
                txtMaSach.Text = Ma;
                txtTenSach.Text = dt.Rows[0]["TENSACH"].ToString();
                txtTenTG.Text = dt.Rows[0]["TENTG"].ToString();
                //txtDonGia.Text = dt.Rows[0]["DONGIASACH"].ToString();
                txtGiaMua.Text = dt.Rows[0]["GIAMUA"].ToString();
                txtDonGia.Text = dt.Rows[0]["GIABAN"].ToString();
                txtSoLuong.Text = dt.Rows[0]["SOLUONGKHO"].ToString();
                txtMota.Text = dt.Rows[0]["MOTA"].ToString();
                cbNXB.EditValue = dt.Rows[0]["MANXB"].ToString();
                cbTheLoai.EditValue = dt.Rows[0]["MATHELOAI"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj.MaSach = txtMaSach.Text;
            obj.TenSach = txtTenSach.Text;
            obj.TenTG = txtTenTG.Text;
            obj.GiaMua = txtGiaMua.Text;
            obj.GiaBan = txtDonGia.Text;
            obj.SoLuongKho = int.Parse(txtSoLuong.Text);
            obj.Mota = txtMota.Text;
            obj.MaNXB = cbNXB.EditValue.ToString();
            obj.MaTheLoai = cbTheLoai.EditValue.ToString();

            if(IsInsert==true)
            {
                bus.Insert(obj);
                XtraMessageBox.Show("Thêm thành công");
                if (LamMoi != null)
                    LamMoi(sender, e);
                this.Close();
            }
            else
            {
                bus.Update(obj);
                XtraMessageBox.Show("Sửa thành công");
                if (LamMoi != null)
                    LamMoi(sender, e);
                this.Close();
            }
        }
    }
}