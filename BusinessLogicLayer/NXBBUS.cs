using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ValueObject;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class NXBBUS
    {
        NXBDAO DAO = new NXBDAO();
        public DataTable GetData()
        {
            return DAO.GetData();
        }
        public int Insert(NhaXuatBan obj)
        {
            return DAO.Insert(obj);
        }
        public int Update(NhaXuatBan obj)
        {
            return DAO.Update(obj);
        }
        public int Delete(string Ma)
        {
            return DAO.Delete(Ma);
        }
    }
}
