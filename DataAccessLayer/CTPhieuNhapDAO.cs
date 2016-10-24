using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ValueObject;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class CTPhieuNhapDAO:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("CTPN_SELECT_ALL", null);
        }
        public DataTable GetData_TongChi()
        {
            return base.GetData("TONGCHI", null);
        }
    }
}
