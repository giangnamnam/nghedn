using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Diagnostics;

namespace QuanLyThiNghe_ThuKy
{
    public class DataProvider
    {
        //static string path = AppDomain.CurrentDomain.BaseDirectory;
        private static string path = @"C:\DuLieuThiNghe\";

        static string TaiKhoan = "1.xml"; //MaTaiKhoan ,TenDangNhap ,MatKhau ,HoVaTen ,MAC ,MaPhanQuyen
        static string NhatKy = "4.xml";//[MaNhatKy],[MaTaiKhoan],[NgayThaoTac],[IP],[ComputerUser],[ThaoTac]   luu txt

        static string DiemLyThuyet = "2.xml"; //MaPhach diem
        static string DiemThucHanh = "3.xml"; //sbd hoten hoidongthi phongthi

        
        static string DanhSachThiLyThuyet = "5.xml";
        static string DanhSachThiThucHanh = "6.xml";



        #region Public Method
        #region TaiKhoan
        public static DataTable LayTaiKhoan()
        {
            return Doc(TaiKhoan);
        }
        #endregion
        #region NhatKy
        public static DataTable LayNhatKy()
        {
            return Doc(NhatKy);
        }
        public static bool GhiNhatKy(DataTable dt)
        {
            return Ghi(dt, NhatKy);
        }
        #endregion
        #region DiemLyThuyet
        public static DataTable LayDiemLyThuyet()
        {
            return Doc(DiemLyThuyet);
        }
        public static bool GhiDiemLyThuyet(DataTable dt)
        {
            return Ghi(dt, DiemLyThuyet);
        }
        #endregion
        #region DiemThucHanh
        public static DataTable LayDiemThucHanh()
        {
            return Doc(DiemThucHanh);
        }
        public static bool GhiDiemThucHanh(DataTable dt)
        {
            return Ghi(dt, DiemThucHanh);
        }
        #endregion
        #endregion

        #region Private Method
        private static DataTable Doc(string name)
        {
            try
            {
                return XMLController.ReadFile(path + name);
            }
            catch (Exception ex)
            {
                string aaa = ex.ToString();
                return null;
            }
        }
        private static bool Ghi(DataTable dt, string name)
        {
            try
            {
                TaoThuMuc(path);
                XMLController.WriteFile(dt, path + name);
            }
            catch (Exception ex)
            {
                string aa = ex.ToString();
                return false;
            }
            return true;
        }
        private static void TaoThuMuc(string path)
        {
            DirectoryInfo folder = new DirectoryInfo(path);
            if (!folder.Exists)
            {
                folder.Create();
            }
        }
        #endregion
    }

    public class XMLController
    {
        public static DataTable ReadFile(string FileName)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(FileName);
            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }
        public static void WriteFile(DataTable dt, string FileName)
        {
            DataSet ds = new DataSet();
            if (dt.DataSet == null)
                ds.Tables.Add(dt);
            dt.DataSet.WriteXml(FileName);
        }
    }
}