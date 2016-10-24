using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using ValueObject;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class SachBUS
    {
        SachDAO dao = new SachDAO();
        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetDataByID(string MaSach)
        {
            return dao.GetDataByID(MaSach);
        }

        public int Insert(Sach obj)
        {
            return dao.Insert(obj);
        }

        public int Update(Sach obj)
        {
            return dao.Update(obj);
        }
        public int Delete(string MaSach)
        {
            return dao.Delete(MaSach);
        }

        public DataTable GetDataNXB()
        {
            return dao.GetDataNXB();
        }
        public DataTable GetDataTheLoai()
        {
            return dao.GetDataTheLoai();
        }
    }
}
