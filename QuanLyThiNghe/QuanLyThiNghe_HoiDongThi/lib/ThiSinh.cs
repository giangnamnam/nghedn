using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThiNghe_ThuKy
{
    public class ThiSinh
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
        public ThiSinh()
        {
            dt = DataProvider.LayDanhSachThiSinh();
        }
        public DataRow[] LayDanhSachThiSinhTheoPhongThi(int MaHoiDong, int MaMonThi, int PhongThi)
        {

            string expression = "(Convert(" + "MaHoiDong" + ",'System.Int32') = " + MaHoiDong + ")";
            expression += "AND (Convert(" + "MaMonThi" + ",'System.Int32') = " + MaMonThi + ")";
            expression += "AND (Convert(" + "PhongThi" + ",'System.Int32') = " + PhongThi + ")";
            DataRow[] drs = dt.Select(expression);
            if (drs.Count() > 0)
            {
                return drs;
            }
            else
                return null;
        }
    }
}
