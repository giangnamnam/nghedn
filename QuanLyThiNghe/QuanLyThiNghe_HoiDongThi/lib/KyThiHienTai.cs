using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThiNghe_ThuKy
{
    public class KyThiHienTai
    {
        DataTable dt;
        public int MaKyThiHienTai { get; set; }
        public string TenKyThi { get; set; }
        public bool DaKetThuc { get; set; }
        public bool CheckMac { get; set; }
        public bool ChoThuKyNhapDiem { get; set; }
        public bool ChoThuKyQuayLaiKhiNhapDiem { get; set; }
        public DataTable Table
        {
            get
            {
                if (dt == null)
                    dt = DataProvider.LayTaiKhoan();
                return dt;
            }
        }
        public KyThiHienTai()
        {
            dt = DataProvider.LayKyThiHienTai();
            DataRow r = LayKyThiHienTai();
            MaKyThiHienTai = int.Parse(r["KyThiHienTai"].ToString());
            TenKyThi = r["TenKyThi"].ToString();
            DaKetThuc = bool.Parse(r["DaKetThuc"].ToString());
            CheckMac = bool.Parse(r["CheckMac"].ToString());
            ChoThuKyNhapDiem = bool.Parse(r["ChoThuKyNhapDiem"].ToString());
            ChoThuKyQuayLaiKhiNhapDiem = bool.Parse(r["ChoThuKyQuayLaiKhiNhapDiem"].ToString());
        }
        public DataRow LayKyThiHienTai()
        {
            DataRow[] drs = dt.Select();
            if (drs.Count() > 0)
            {
                return drs[0];
            }
            else
                return null;
        }
    }
}
