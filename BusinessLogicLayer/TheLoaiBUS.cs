using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer;
using ValueObject;
using System.Data;

namespace BusinessLogicLayer
{
    public class TheLoaiBUS
    {
        TheLoaiDAO DAO = new TheLoaiDAO();
        public DataTable GetData()
        {
            return DAO.GetData();
        }
        public int Insert(TheLoai obj)
        {
            return DAO.Insert(obj);
        }
        public int Update(TheLoai obj)
        {
            return DAO.Update(obj);
        }
        public int Delete(string Ma)
        {
            return DAO.Delete(Ma);
        }
    }
}
