using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThiNghe_ThuKy
{
   public class MonThi
    {
        DataTable dt;
        public DataTable Table
        {
            get
            {
                if (dt == null)
                    dt = DataProvider.LayTaiKhoan();
                return dt;
            }
        }
        public MonThi()
        {
            dt = DataProvider.LayMonThi();
        }
        public DataRow LayMotMonThi(int MaMonThi)
        {
            
            
            string expression = "(Convert(" + "MaMonThi" + ",'System.String') LIKE '" + MaMonThi.ToString() + "')";
            DataRow[] drs = dt.Select(expression);
            if (drs.Count() > 0)
            {
                return drs[0];
            }
            else
                return null;
        }
    }
}
