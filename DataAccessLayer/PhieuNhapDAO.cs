using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ValueObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PhieuNhapDAO : dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("PHIEUNHAP_SELECT_ALL", null);
        }
        public DataTable GetDataByID(string MAPN)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN", MAPN)
            };
            return base.GetData("PHIEUNHAP_SELECT_BYID", para);
        }

        public int Insert(PhieuNhap obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN",obj.MaPN),
                new SqlParameter("MANV",obj.MaNV),
                new SqlParameter("NGAYLAP",obj.NgayLap),
                new SqlParameter("TONGTIEN",obj.TongTien)
                
            };
            return base.ExecuteSQL("PHIEUNHAP_INSERT", para);
        }

        public int Update(PhieuNhap obj)
        {
            SqlParameter[] para =
           {
                new SqlParameter("MAPN",obj.MaPN),
                new SqlParameter("NGAYLAP",obj.NgayLap)
           };
            return base.ExecuteSQL("PHIEUNHAP_UPDATE", para);
        }
        public int Delete(string MAPN)
        {
            SqlParameter[] para =
               {
                new SqlParameter("MAPN", MAPN)
            };
            return base.ExecuteSQL("PHIEUNHAP_DELETE", para);
        }
        //public DataTable GetDataSach()
        //{
        //    return base.GetData("SACH_SELECT_ALL", null);
        //}
        //public DataTable GetDataNV()
        //{
        //    return base.GetData("NHANVIEN_SELECT_ALL", null);
        //}
    }
}
