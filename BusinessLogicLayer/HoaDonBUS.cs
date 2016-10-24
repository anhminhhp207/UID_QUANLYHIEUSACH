using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ValueObject;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class HoaDonBUS
    {
        HoaDonDAO dao = new HoaDonDAO();
        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetDataByID(string MaHD)
        {
            return dao.GetDataByID(MaHD);
        }

        public int Insert(HoaDon obj)
        {
            return dao.Insert(obj);
        }

        public int Update(HoaDon obj)
        {
            return dao.Update(obj);
        }
        public int Delete(string MaHD)
        {
            return dao.Delete(MaHD);
        }

        public DataTable GetDataSach()
        {
            return dao.GetDataSach();
        }
        public DataTable GetDataNV()
        {
            return dao.GetDataNV();
        }

    }
}
