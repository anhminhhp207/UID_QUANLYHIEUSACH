using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ValueObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class SachDAO:dbConnect 
    {
        public DataTable GetData()
        {
            return base.GetData("SACH_SELECT_ALL", null);
        }
        public DataTable GetDataByID(string MASACH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MASACH", MASACH)
            };
            return base.GetData("SACH_SELECT_BYID", para);
        }

        public int Insert(Sach obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MASACH",obj.MaSach),
                new SqlParameter("TENSACH",obj.TenSach),
                new SqlParameter("TENTG",obj.TenTG),
                new SqlParameter("MATHELOAI",obj.MaTheLoai),
                new SqlParameter("GIAMUA",obj.GiaMua),
                new SqlParameter("GIABAN",obj.GiaBan),
                new SqlParameter("SOLUONGKHO",obj.SoLuongKho),
                new SqlParameter("MANXB",obj.MaNXB),
                new SqlParameter("MOTA",obj.Mota)
                
            };
            return base.ExecuteSQL("SACH_INSERT", para);
        }

        public int Update(Sach obj)
        {
            SqlParameter[] para =
           {
                new SqlParameter("MASACH",obj.MaSach),
                new SqlParameter("TENSACH",obj.TenSach),
                new SqlParameter("TENTG",obj.TenTG),
                new SqlParameter("MATHELOAI",obj.MaTheLoai),
                new SqlParameter("GIAMUA",obj.GiaMua),
                new SqlParameter("GIABAN",obj.GiaBan),
                new SqlParameter("SOLUONGKHO",obj.SoLuongKho),
                new SqlParameter("MANXB",obj.MaNXB),
                new SqlParameter("MOTA",obj.Mota)
            };
            return base.ExecuteSQL("SACH_UPDATE", para);
        }
        public int Delete(string MaSach)
        {
            SqlParameter[] para =
               {
                new SqlParameter("MASACH", MaSach)
            };
            return base.ExecuteSQL("SACH_DELETE", para);
        }

        public DataTable GetDataNXB()
        {
            return base.GetData("NXB_SELECT_ALL", null);
        }
        public DataTable GetDataTheLoai()
        {
            return base.GetData("THELOAI_SELECT_ALL", null);
        }
    }
}
