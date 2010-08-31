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
                    dt = DataProvider.LayDanhSachThiSinh();
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
        public DataTable LayTableDanhSachThiSinhTheoPhongThi(int MaHoiDong, int MaMonThi, int PhongThi)
        {
            DataTable tbl = dt.Clone();

            string expression = "(Convert(" + "MaHoiDong" + ",'System.Int32') = " + MaHoiDong + ")";
            expression += "AND (Convert(" + "MaMonThi" + ",'System.Int32') = " + MaMonThi + ")";
            expression += "AND (Convert(" + "PhongThi" + ",'System.Int32') = " + PhongThi + ")";
            DataRow[] drs = dt.Select(expression);
            foreach (DataRow item in drs)
            {
                tbl.ImportRow(item);
            }
            return tbl;
        }
        public void CapNhatDiemLyThuyet(int MaThiSinh, float DiemLyThuyet, int ThuKy1, int ThuKy2, int ThuKy3, bool Luu)
        {
            string expression = "(Convert(" + "MaThiSinh" + ",'System.Int32') = " + MaThiSinh + ")";
            DataRow[] drs = dt.Select(expression);
            if (drs.Count() == 1)
            {
                drs[0]["DiemLT"] = DiemLyThuyet;
                drs[0]["ThuKy1"] = ThuKy1;
                drs[0]["ThuKy2"] = ThuKy2;
                drs[0]["ThuKy3"] = ThuKy3;
            }
        }
        public void CapNhatDiemThucHanh(int MaThiSinh, float DiemThucHanh, int ThuKy1, int ThuKy2, int ThuKy3, bool Luu)
        {
            string expression = "(Convert(" + "MaThiSinh" + ",'System.Int32') = " + MaThiSinh + ")";
            DataRow[] drs = dt.Select(expression);
            if (drs.Count() == 1)
            {
                drs[0]["DiemTH"] = DiemThucHanh;
                drs[0]["ThuKy1"] = ThuKy1;
                drs[0]["ThuKy2"] = ThuKy2;
                drs[0]["ThuKy3"] = ThuKy3;
            }
        }
        public bool LuuThayDoi()
        {
           return DataProvider.GhiDanhSachThiSinh(dt);
        }
        public int LayTongSoThiSinh()
        {
            return dt.Rows.Count;
        }

        public int LayTongSoThiSinhDaCoDiem()
        {
            string expression = "(Convert(" + "DiemLT" + ",'System.String') <> " + "''" + ")";
            expression += "or (Convert(" + "DiemTH" + ",'System.String') <> " + "''" + ")";
            return dt.Select(expression).Count();
        }
        public int LayTongSoThiSinhDaCoDiemLyThuyet()
        {
            string expression = "(Convert(" + "DiemLT" + ",'System.String') <> " + "''" + ")";
            return dt.Select(expression).Count();
        }
        public int LayTongSoThiSinhDaCoDiemThucHanh()
        {
            string expression = "(Convert(" + "DiemTH" + ",'System.String') <> " + "''" + ")";
            return dt.Select(expression).Count();
        }
        public int DemTongSoHoiDongThiDaCoDiem()
        {
            string expression = "((Convert(" + "DiemLT" + ",'System.String') <> " + "''" + ")";
            expression += "or (Convert(" + "DiemTH" + ",'System.String') <> " + "''" + "))";
            return (LayDanhSachTheoDieuKien(expression).DefaultView.ToTable(true, "MaHoiDong")).Rows.Count;
        }
        public int DemTongSoMonThiDaCoDiem()
        {
            string expression = "((Convert(" + "DiemLT" + ",'System.String') <> " + "''" + ")";
            expression += "or (Convert(" + "DiemTH" + ",'System.String') <> " + "''" + "))";
            return (LayDanhSachTheoDieuKien(expression).DefaultView.ToTable(true, "MaHoiDong", "MaMonThi")).Rows.Count;
        }
        public int DemTongSoPhongThiDaCoDiem()
        {
            string expression = "((Convert(" + "DiemLT" + ",'System.String') <> " + "''" + ")";
            expression += "or (Convert(" + "DiemTH" + ",'System.String') <> " + "''" + "))";
            return (LayDanhSachTheoDieuKien(expression).DefaultView.ToTable(true, "MaHoiDong", "MaMonThi", "PhongThi")).Rows.Count;
        }
        public int DemTongSoThiSinhDaDongBo()
        {
            string expression = "(Convert(" + "DaDongBo" + ",'System.String') = " + "True" + ")";
            return dt.Select(expression).Count();
        }


        public int LayTongSoThiSinhChuaCoDiemLyThuyet()
        {
            string expression = "(Convert(" + "DiemLT" + ",'System.String') = " + "" + ")";
            return dt.Select(expression).Count();
        }
        
        public int LayTongSoThiSinhChuaCoDiemLyThuyetTheoHoiDongThi(int MaHoiDong)
        {
            string expression = "(Convert(" + "DaDongBo" + ",'System.Int32') = " + MaHoiDong + ")";
            expression += "(Convert(" + "DiemLT" + ",'System.String') = " + "" + ")";
            return dt.Select(expression).Count();
        }
        public int LayTongSo(int MaHoiDong, int MaMonThi, int Phong, bool DienLyThuyet,bool DaCoDiem, bool DaDongBo)
        {
            string expression = "(Convert(" + "MaHoiDong" + ",'System.Int32') = " + MaHoiDong + ")";
            if (MaHoiDong!=0)
                expression += "(Convert(" + "MaHoiDong" + ",'System.Int32') = " + MaHoiDong + ")";
            if (MaMonThi != 0)
                expression += "(Convert(" + "MaMonThi" + ",'System.Int32') = " + MaMonThi + ")";
            if (Phong != 0)
                expression += "(Convert(" + "Phong" + ",'System.Int32') = " + Phong + ")";
            if (DienLyThuyet && DaCoDiem)
                expression += "(Convert(" + "DiemLT" + ",'System.String') <> " + "" + ")";
            if (DienLyThuyet && !DaCoDiem)
                expression += "(Convert(" + "DiemLT" + ",'System.String')  = " + "" + ")";

            if(DaDongBo)
                expression += "(Convert(" + "DaDongBo" + ",'System.String') = " + DaDongBo.ToString() + ")";
            return dt.Select(expression).Count();
        }
        public int DongBoHoaDiem()
        {
            int SoBaiDuocDongBo = 0;

            string expression = "((Convert(" + "DiemLT" + ",'System.String') <> " + "''" + ")";
            expression += "or (Convert(" + "DiemTH" + ",'System.String') <> " + "''" + "))";

            expression += " and (Convert(" + "DaDongBo" + ",'System.String') = " + "False" + ")";
            DataRow[] drs = dt.Select(expression);

            SqlConnection con = new SqlConnection("Data Source=designpro.vn;Initial Catalog=ThiNge;Persist Security Info=True;User ID=thinge;Password=tn123@");
            SqlCommand com = new SqlCommand("thuky_DongBoHoa_CapNhatDiem", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                foreach (DataRow item in drs)
                {
                    com.Parameters.Add(new SqlParameter("MaThiSinh", item["MaThiSinh"].ToString()));
                    com.Parameters.Add(new SqlParameter("DiemLT", item["DiemLT"].ToString()));
                    com.Parameters.Add(new SqlParameter("DiemTH", item["DiemTH"].ToString()));
                    com.Parameters.Add(new SqlParameter("ThuKy1", item["ThuKy1"].ToString()));
                    com.Parameters.Add(new SqlParameter("ThuKy2", item["ThuKy2"].ToString()));
                    com.Parameters.Add(new SqlParameter("ThuKy3", item["ThuKy3"].ToString()));
                    com.ExecuteNonQuery();

                    item["DaDongBo"] = true;
                    SoBaiDuocDongBo++;
                }
            }
            catch (Exception)
            {
                LuuThayDoi();
            }
            finally { con.Close(); }
            LuuThayDoi();
            return SoBaiDuocDongBo;
        }
        public DataTable LayDanhSachTheoDieuKien(string DK)
        {
            DataTable tbl = dt.Clone();

            DataRow[] drs = dt.Select(DK);
            foreach (DataRow item in drs)
            {
                tbl.ImportRow(item);
            }
            return tbl;
        }

    }
}
