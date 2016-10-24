using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ValueObject;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CTPhieuNhapBUS
    {
        CTPhieuNhapDAO dao = new CTPhieuNhapDAO();
        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetData_TongChi()
        {
            return dao.GetData_TongChi();
        }
    }
}
