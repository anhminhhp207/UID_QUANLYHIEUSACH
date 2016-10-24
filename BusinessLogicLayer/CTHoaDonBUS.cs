using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ValueObject;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CTHoaDonBUS
    {
        CTHoaDonDAO dao = new CTHoaDonDAO();
        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetData_MostBook()
        {
            return dao.GetData_MostBook();
        }
        public DataTable GetData_TotalEarnMonth(DateTime date1,DateTime date2)
        {
            return dao.GetData_TotalEarnMonth(date1, date2);
        }
        public DataTable GetData_TotalEarn()
        {
            return dao.GetData_TotalEarn();
        }
        public DataTable GetData_TongLai()
        {
            return dao.GetData_TongLai();
        }
        public DataTable GetDataSach()
        {
            return dao.GetDataSach();
        }
        public DataTable Get_GiaBan(string ma)
        {
            return dao.Get_GiaBan(ma);
        }

    }
}
