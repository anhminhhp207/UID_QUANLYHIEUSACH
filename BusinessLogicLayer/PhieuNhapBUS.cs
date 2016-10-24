using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ValueObject;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class PhieuNhapBUS
    {
        PhieuNhapDAO dao = new PhieuNhapDAO();
        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetDataByID(string MAPN)
        {
            return dao.GetDataByID(MAPN);
        }

        public int Insert(PhieuNhap obj)
        {
            return dao.Insert(obj);
        }

        public int Update(PhieuNhap obj)
        {
            return dao.Update(obj);
        }
        public int Delete(string MAPN)
        {
            return dao.Delete(MAPN);
        }

        //public DataTable GetDataSach()
        //{
        //    return dao.GetDataSach();
        //}
        //public DataTable GetDataNV()
        //{
        //    return dao.GetDataNV();
        //}
    }
}
