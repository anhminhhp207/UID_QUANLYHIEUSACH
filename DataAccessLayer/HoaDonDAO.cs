using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ValueObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class HoaDonDAO:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("HOADON_SELECT_ALL", null);
        }
        public DataTable GetDataByID(string MAHD)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAHD", MAHD)
            };
            return base.GetData("HOADON_SELECT_BYID", para);
        }

        public int Insert(HoaDon obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAHD",obj.MaHD),
                new SqlParameter("MANV",obj.MaNV),
                new SqlParameter("NGAYLAP",obj.NgayLap),
                new SqlParameter("TENKH",obj.TenKH),
                new SqlParameter("TONGTIEN",obj.TongTien)
                
            };
            return base.ExecuteSQL("HOADON_INSERT", para);
        }

        public int Update(HoaDon obj)
        {
            SqlParameter[] para =
           {
                new SqlParameter("MAHD",obj.MaHD),
                //new SqlParameter("MANV",obj.MaNV),
                new SqlParameter("NGAYLAP",obj.NgayLap),
                new SqlParameter("TENKH",obj.TenKH),
               // new SqlParameter("TONGTIEN",obj.TongTien)
            };
            return base.ExecuteSQL("HOADON_UPDATE", para);
        }
        public int Delete(string MaHD)
        {
            SqlParameter[] para =
               {
                new SqlParameter("MAHD", MaHD)
            };
            return base.ExecuteSQL("HOADON_DELETE", para);
        }
        public DataTable GetDataSach()
        {
            return base.GetData("SACH_SELECT_ALL", null);
        }
        public DataTable GetDataNV()
        {
            return base.GetData("NHANVIEN_SELECT_ALL", null);
        }

    }
}
