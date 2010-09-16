using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace QuanLyThiNghe.lib
{
    class DanhMaPhach
    {

        //private string StrConnection = "Data Source=designpro.vn;Initial Catalog=ThiNge;Persist Security Info=True;User ID=thinge;Password=tn123@";
        public string StrConnection = @"Data Source=.\sqlexpress;Initial Catalog=ThiNge;Integrated Security=True";
        
        public int KyThiHienTai { get; set; }
        public DataTable DS_MonThi_HoiDongThi_PhongThi { get; set; }
        public DataTable DSMonThi { get; set; }
        public DataTable DSHoiDongThi { get; set; }
        public DataTable DSThiSinh { get; set; }

        public DanhMaPhach()
        {
        }
        public void LayDanhSach_MonThi_HoiDong_PhongThi_TheoKhoi(int maKhoi)
        {
            //QLTN_Entities en = new QLTN_Entities();
            //Config c = en.Config.First();
            // KyThiHienTai = c.KyThiHienTai!=null? KyThiHienTai:0;
            DS_MonThi_HoiDongThi_PhongThi = new DataTable();
            DS_MonThi_HoiDongThi_PhongThi.Load(SqlHelper.ExecuteReader(StrConnection, "chuTich_LayDanhSach_MonThi_HoiDong_PhongThi",maKhoi));
        }
        public bool CapNhatMaPhach(int MaThiSinh, string MaPhach )
        {
            try
            {
                SqlHelper.ExecuteReader(StrConnection, "chuTich_CapNhatMaPhach", MaThiSinh, MaPhach);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable LayTheoDieuKien(string DK)
        {
            DataTable tbl = DS_MonThi_HoiDongThi_PhongThi.Clone();

            DataRow[] drs = DS_MonThi_HoiDongThi_PhongThi.Select(DK);
            foreach (DataRow item in drs)
            {
                tbl.ImportRow(item);
            }
            return tbl;
        }
        public DataTable LayDanhSachKhoiThi()
        {
            DataTable ret = new DataTable();
            ret.Load(SqlHelper.ExecuteReader(StrConnection, "chuTich_DanhMaPhach_LayKhoiThi"));
            return ret;
        }
        public DataTable LayDanhSachThiSinhTheoPhong(int MaKhoi, int MaMonThi, int MaHoiDong, int PhongThi)
        {
            DataTable ret = new DataTable();
            ret.Load(SqlHelper.ExecuteReader(StrConnection, "chuTich_DanhMaPhach_LayDanhSachThiSinhTheoPhong", MaKhoi,MaMonThi, MaHoiDong, PhongThi));
            return ret;
        }
        public int LayTongSoThiSinhCanDanhMaPhach()
        {
            int tong = 0;
            tong = int.Parse(
            SqlHelper.ExecuteScalar(StrConnection, CommandType.StoredProcedure, "DemSoThiSinhCuaKyThiHienTai").ToString());
            return tong;
        }
        public int DemSoPhongThiTheoMonThi(int MaMonThi)
        {
            int tong = 0;
            tong = int.Parse(
            SqlHelper.ExecuteScalar(StrConnection,
            "DemSoPhongThiCuaKyThiHienTai_TheoMonThi",MaMonThi).ToString());
            return tong;
            
        }
        public int DemSoThiSinhDaCoMaPhach(int MaKhoi)
        {
            int tong = 0;
            tong = int.Parse(
            SqlHelper.ExecuteScalar(StrConnection,
            "chuTich_DanhMaPhach_DemSoPhachDaCo",MaKhoi).ToString());
            return tong;

        }

    }
}
