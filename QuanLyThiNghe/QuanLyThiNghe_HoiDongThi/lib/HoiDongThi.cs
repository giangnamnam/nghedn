using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThiNghe_ThuKy
{
    public class HoiDongThi
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
        public HoiDongThi()
        {
            dt = DataProvider.LayHoiDongThi();
        }
        public DataRow LayMotHoiDongThi(int MaHoiDong)
        {
            string expression = "(Convert(" + "MaHoiDong" + ",'System.String') LIKE '%"+MaHoiDong.ToString()+"%')";
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
