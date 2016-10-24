using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ValueObject;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class NhanVienBUS
    {
        NhanVienDAO DAO = new NhanVienDAO();
        public DataTable GetData()
        {
            return DAO.GetData();
        }
        public DataTable GetDataByAccount(string TK,string MK)
        {
            return DAO.GetDataByAccount(TK,MK);
        }
        public int Insert(NhanVien obj)
        {
            return DAO.Insert(obj);
        }
        public int Update(NhanVien obj)
        {
            return DAO.Update(obj);
        }
        public int Update_MK(NhanVien obj)
        {
            return DAO.Update_MK(obj);
        }
        public int Delete(string Ma)
        {
            return DAO.Delete(Ma);
        }
    }
}
