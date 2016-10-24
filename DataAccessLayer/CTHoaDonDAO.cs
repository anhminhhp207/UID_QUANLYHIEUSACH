using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ValueObject;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class CTHoaDonDAO
    {
        dbConnect db = new dbConnect();
        public DataTable GetData()
        {
            return db.GetData("CTHOADON_SELECT_ALL", null);
        }
        public DataTable GetData_MostBook()
        {
            return db.GetData("SACHBANCHAY", null);
        }
        public DataTable GetData_TongLai()
        {
            return db.GetData("TONGLAI", null);
        }
        public DataTable GetData_TotalEarnMonth(DateTime date1,DateTime date2)
        {
            SqlParameter[] para =
            {
                new SqlParameter("NGAYLAP1", date1),
                new SqlParameter("NGAYLAP1", date2)
            };
            return db.GetData("TONGTHUNHAP_THANG", null);
        }
        public DataTable GetDataSach()
        {
            return db.GetData("SACH_SELECT_CTHD", null);
        }
        public DataTable GetData_TotalEarn()
        {
            return db.GetData("TONGTHUNHAP", null);
        }
        public DataTable Get_GiaBan(string Ma)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MS", Ma)
            };
            return db.GetData("SACH_GET_GIABAN", null);
        }
        //public DataTable Get_GiaMua(string Ma)
        //{
        //    SqlParameter[] para =
        //    {
        //        new SqlParameter("MS", Ma),
        //    };
        //    return db.GetData("SACH_GET_GIAMUA", null);
        //}
    }
}
