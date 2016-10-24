using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ValueObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class NhanVienDAO:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("NHANVIEN_SELECT_ALL", null);
        }
        public DataTable GetDataByAccount(string TK,string MK)
        {
            SqlParameter[] para =
            {
                new SqlParameter("TAIKHOAN",TK),
                new SqlParameter("MATKHAU",MK)
            };
            return base.GetData("NHANVIEN_SELECT_BYACCOUNT",para);
        }
        public int Insert(NhanVien obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANV",obj.MaNV),
                new SqlParameter("TENNV",obj.TenNV),
                new SqlParameter("GT",obj.GioiTinh),
                new SqlParameter("NGAYSINH",obj.NgaySinh),
                new SqlParameter("DIENTHOAI",obj.DienThoai),
                new SqlParameter("DIACHI",obj.DiaChi),
                new SqlParameter("TAIKHOAN",obj.TaiKhoan),
                new SqlParameter("MATKHAU",obj.MatKhau),
                new SqlParameter("QUYEN",obj.QUYEN)
            };
            return base.ExecuteSQL("NHANVIEN_INSERT", para);
        }
        public int Update(NhanVien obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANV",obj.MaNV),
                new SqlParameter("TENNV",obj.TenNV),
                new SqlParameter("GT",obj.GioiTinh),
                new SqlParameter("NGAYSINH",obj.NgaySinh),
                new SqlParameter("DIENTHOAI",obj.DienThoai),
                new SqlParameter("DIACHI",obj.DiaChi),
                new SqlParameter("TAIKHOAN",obj.TaiKhoan),
                new SqlParameter("MATKHAU",obj.MatKhau),
                new SqlParameter("QUYEN",obj.QUYEN)
            };
            return base.ExecuteSQL("NHANVIEN_UPDATE", para);
        }
        public int Update_MK(NhanVien obj)
        {
            SqlParameter[] para =
            {   new SqlParameter("MANV",obj.MaNV),
                new SqlParameter("MATKHAU",obj.MatKhau)
            };
            return base.ExecuteSQL("NHANVIEN_UPDATE_MK", para);
        }
        public int Delete(string Ma)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANV",Ma) 
            };
            return base.ExecuteSQL("NHANVIEN_DELETE", para);
        }
    }
}
