using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyThiNghe_ThuKy
{
    class NhatKy
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
        public NhatKy()
        {
            dt = DataProvider.LayNhatKy();
        }
        public bool ThemNhatKy(int MaTaiKhoan,DateTime NgayThaoTac,string IP,string ComputerUser,string ThaoTac, bool ThucHienGhiXuongFile)
        {
            try
            {
                DataRow dr = dt.NewRow();
                dr["MaTaiKhoan"] = MaTaiKhoan;
                dr["NgayThaoTac"] = NgayThaoTac;
                dr["IP"] = IP;
                dr["ComputerUser"] = ComputerUser;
                dr["ThaoTac"] = ThaoTac;
                dr["DaDongBo"] = false;

                dt.Rows.Add(dr);
                if (ThucHienGhiXuongFile)
                    return GhiNhatKy();
                return true;
            }
            catch (Exception ex)
            {
                string aa = ex.ToString();
                return false;
            }
        }
        public bool GhiNhatKy()
        {
            return DataProvider.GhiNhatKy(dt);
        }

        



    }
}
