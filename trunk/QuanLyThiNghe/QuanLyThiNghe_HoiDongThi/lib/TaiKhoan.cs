using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThiNghe_ThuKy
{
    public class TaiKhoan
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
        public TaiKhoan()
        {
            dt = DataProvider.LayTaiKhoan();
        }
        public DataRow LayMotTaiKhoan(string TenDangNhap, string MatKhau)
        {
            //string expression = "(Convert(" + column + ",'System.String') LIKE '%"+tstxtKey.Text+"%')";
            MatKhau = XuLyChuoi.MaHoa(MatKhau, XuLyChuoi.KieuMaHoa.HungVQ);
            string expression = "(Convert(" + "TenDangNhap" + ",'System.String') LIKE '" + TenDangNhap + "')";
            expression += "AND (Convert(" + "MatKhau" + ",'System.String') LIKE '" + MatKhau + "')";
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
