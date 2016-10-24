using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ValueObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class NXBDAO : dbConnect
    {
        
        public DataTable GetData()
        {
            return base.GetData("NXB_SELECT_ALL", null);
        }
        public int Insert(NhaXuatBan obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANXB",obj.MaNXB),
                new SqlParameter("TENNXB",obj.TenNXB),
                new SqlParameter("DIACHI",obj.DiaChi),
                new SqlParameter("DIENTHOAI",obj.SoDienThoai)
            };
            return base.ExecuteSQL("NXB_INSERT", para);
        }
        public int Update(NhaXuatBan obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANXB",obj.MaNXB),
                new SqlParameter("TENNXB",obj.TenNXB),
                new SqlParameter("DIACHI",obj.DiaChi),
                new SqlParameter("DIENTHOAI",obj.SoDienThoai)
            };
            return base.ExecuteSQL("NXB_UPDATE", para);
        }
        public int Delete(string Ma)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANXB",Ma) 
            };
            return base.ExecuteSQL("NXB_DELETE", para);
        }
    }
}
