using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ValueObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class TheLoaiDAO
    {

        dbConnect db = new dbConnect();
        public DataTable GetData()
        {
            return db.GetData("THELOAI_SELECT_ALL", null);
        }
        public int Insert(TheLoai obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MATHELOAI",obj.MaTheLoai),
                new SqlParameter("TENTHELOAI",obj.TenTheLoai),
                new SqlParameter("MOTA",obj.MoTa)
            };
            return db.ExecuteSQL("THELOAI_INSERT", para);
        }
        public int Update(TheLoai obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MATHELOAI",obj.MaTheLoai),
                new SqlParameter("TENTHELOAI",obj.TenTheLoai),
                new SqlParameter("MOTA",obj.MoTa)
            };
            return db.ExecuteSQL("THELOAI_UPDATE", para);
        }
        public int Delete(string Ma)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MATHELOAI",Ma) 
            };
            return db.ExecuteSQL("THELOAI_DELETE", para);
        }
    }
}
