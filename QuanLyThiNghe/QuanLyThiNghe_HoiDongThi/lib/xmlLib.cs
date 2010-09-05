using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

using System.Net;
using System.Net.NetworkInformation;
namespace QuanLyThiNghe_ThuKy
{
    public class XuLyForm
    {
        //public static void LuuNhatKy(string NoiDung)
        //{
        //    try
        //    {
        //        NhatKy nk = new NhatKy();
        //        int[] TaiKhoan;
        //        string ComputerUser = HeThong.TenMay();
        //        string ThaoTac = NoiDung;
        //        DateTime NgayThaoTac = DateTime.Now;
        //        string IP = "MAC: " + HeThong.LayMAC() + "; IP:  " + HeThong.LayIP();
        //        foreach (int item in TaiKhoan)
        //        {
        //            nk.ThemNhatKy(item, NgayThaoTac, IP, ComputerUser, ThaoTac, true);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}
        public static void LuuNhatKy(int MaTaiKhoan, string NoiDung)
        {
            try
            {
                NhatKy nk = new NhatKy();
                string ComputerUser = HeThong.TenMay();
                string ThaoTac = NoiDung;
                DateTime NgayThaoTac = DateTime.Now;
                string IP = "MAC: " + HeThong.LayMAC() + "; IP:  " + HeThong.LayIP();
                nk.ThemNhatKy(MaTaiKhoan, NgayThaoTac, IP, ComputerUser, ThaoTac, true);
            }
            catch (Exception)
            {
            }
        }
        public static void LuuFile(string FilePath, string NoiDung, bool ThemDongMoi)
        {
            if (!File.Exists(@"C:\ThiNgheDatabaseBackupList.bin"))
            {
                FileStream fs = File.Create(@"C:\ThiNgheDatabaseBackupList.bin");
                fs.Close();
            }
            TextWriter tw = new StreamWriter(FilePath, ThemDongMoi);
            tw.WriteLine(NoiDung);
            tw.Close();
        }
    }
    public class HeThong
    {
        public static DateTime LayGioHeThong()
        {
            return DateTime.Now;
        }
        public static string LayMAC()
        {
            string macAddresses = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddresses;
        }
        public static string TenMay()
        {
            return Dns.GetHostName();
        }
        public static string LayIP()
        {
            IPHostEntry ipEntry = Dns.GetHostEntry(TenMay());
            IPAddress[] addr = ipEntry.AddressList;
            string ip = "";
            for (int i = 0; i < addr.Length; i++)
            {
                ip += " (" + i.ToString() + ": " + addr[i].ToString() + ");";
            }
            return ip;
        }
    }

    public class XuLyChuoi
    {
        public enum KieuMaHoa { MD5, SHA1, HungVQ };
        public static string MaHoa(string ChuoiCanMaHoa, KieuMaHoa MaHoa)
        {
            string kq = "";
            if (MaHoa == KieuMaHoa.MD5)
            {
                kq = Convert.ToBase64String(new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(ChuoiCanMaHoa)));
            }
            else if (MaHoa == KieuMaHoa.SHA1)
            {
                kq = Convert.ToBase64String(new System.Security.Cryptography.SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(ChuoiCanMaHoa)));
            }
            else
            {
                kq = Convert.ToBase64String(new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(ChuoiCanMaHoa)));
                kq = Convert.ToBase64String(new System.Security.Cryptography.SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(kq)));
            }
            return kq;
        }

    }

    public class XuLyDuLieu
    {
        private static string stDanhSachThiSinh = "thuky_KyThiHienTai_DanhSachThiSinh";
        private static string stHoiDongThi = "thuky_KyThiHienTai_HoiDongThi";
        private static string stKyThiHienTai = "thuky_KyThiHienTai";
        private static string stMonThi = "thuky_MonThi";
        private static string stNhatKy = "thuky_NhatKyTemplate";
        private static string stTaiKhoan = "thuky_TaiKhoanThuKyVaAdminDangSuDung";
        private static string s_DongBoDiem = "thuky_DongBoHoa_CapNhatDiem";
        private static string s_DongBoNhatKy = "thuky_DongBoHoa_ThemNhatKy";
        

        public static void CapNhatDuLieuThiNgheVeMay()
        {
            DataProvider.GhiDanhSachThiSinh(ReadFromDatabase(stDanhSachThiSinh));
            DataProvider.GhiHoiDongThi(ReadFromDatabase(stHoiDongThi));
            DataProvider.GhiKyThiHienTai(ReadFromDatabase(stKyThiHienTai));
            DataProvider.GhiMonThi(ReadFromDatabase(stMonThi));
            DataProvider.GhiNhatKy(ReadFromDatabase(stNhatKy));
            DataProvider.GhiTaiKhoan(ReadFromDatabase(stTaiKhoan));
        }
        public static bool CapNhatDanhSachThiSinh()
        {
            try
            {
                DataProvider.GhiDanhSachThiSinh(ReadFromDatabase(stDanhSachThiSinh));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool CapNhatHoiDongThi()
        {
            try
            {
                DataProvider.GhiHoiDongThi(ReadFromDatabase(stHoiDongThi));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool CapNhatKyThiHienTai()
        {
            try
            {
                DataProvider.GhiKyThiHienTai(ReadFromDatabase(stKyThiHienTai));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool CapNhatMonThi()
        {
            try
            {
                DataProvider.GhiMonThi(ReadFromDatabase(stMonThi));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool CapNhatNhatKy()
        {
            try
            {
                DataProvider.GhiNhatKy(ReadFromDatabase(stNhatKy));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool CapNhatTaiKhoan()
        {
            try
            {
                DataProvider.GhiTaiKhoan(ReadFromDatabase(stTaiKhoan));
            
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool DongBoDiem(DataRow pThiSinh)
        {
            try
            {
                
                
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool DongBoNhatKy(DataRow pNhatKy)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=designpro.vn;Initial Catalog=ThiNge;Persist Security Info=True;User ID=thinge;Password=tn123@");
                SqlCommand com = new SqlCommand(s_DongBoNhatKy, con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("MaTaiKhoan", pNhatKy["MaTaiKhoan"].ToString()));
                com.Parameters.Add(new SqlParameter("NgayThaoTac", pNhatKy["NgayThaoTac"].ToString()));
                com.Parameters.Add(new SqlParameter("IP", pNhatKy["IP"].ToString()));
                com.Parameters.Add(new SqlParameter("ComputerUser", pNhatKy["ComputerUser"].ToString()));
                com.Parameters.Add(new SqlParameter("ThaoTac", pNhatKy["ThaoTac"].ToString()));

                /*
                    @MaTaiKhoan int
                   ,@NgayThaoTac datetime
                   ,@IP varchar(550)
                   ,@ComputerUser nvarchar(550)
                   ,@ThaoTac nvarchar(550)   
                 */
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        private static DataTable ReadFromDatabase(string Command)
        {
            SqlConnection con = new SqlConnection("Data Source=designpro.vn;Initial Catalog=ThiNge;Persist Security Info=True;User ID=thinge;Password=tn123@");
            SqlCommand com = new SqlCommand(Command, con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
    }

    public class DataProvider
    {

        public bool CoTaiKhoan { get; set; }
        public bool CoNhatKy { get; set; }
        public bool CoHoiDong { get; set; }
        public bool CoMonThi { get; set; }
        public bool CoThiSinh { get; set; }
        public bool CoKyThiHienTai { get; set; }

        public DataProvider()
        {
            CoTaiKhoan = CheckExitsFile(TaiKhoan);
            CoNhatKy = CheckExitsFile(NhatKy);
            CoHoiDong = CheckExitsFile(HoiDongThi);
            CoMonThi = CheckExitsFile(MonThi);
            CoThiSinh = CheckExitsFile(DanhSachThiSinh);
            CoKyThiHienTai = CheckExitsFile(KyThiHienTai);
        }



        #region var
        //static string path = AppDomain.CurrentDomain.BaseDirectory;
        private static string path = @"C:\DuLieuThiNghe\";

        static string TaiKhoan = "1.xml"; //MaTaiKhoan ,TenDangNhap ,MatKhau ,HoVaTen ,MAC ,MaPhanQuyen
        static string NhatKy = "4.xml";//[MaNhatKy],[MaTaiKhoan],[NgayThaoTac],[IP],[ComputerUser],[ThaoTac]   luu txt
        //static string DiemThi = "3.xml"; //sbd hoten hoidongthi môn thi phongthi
        static string DanhSachThiSinh = "5.xml";
        static string KyThiHienTai = "7.xml";
        static string HoiDongThi = "8.xml";
        static string MonThi = "9.xml";

        #endregion

        #region Public Method
        #region TaiKhoan
        public static DataTable LayTaiKhoan()
        {
            return Doc(TaiKhoan);
        }
        public static bool GhiTaiKhoan(DataTable dt)
        {
            return Ghi(dt, TaiKhoan);
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
        #region DanhSachThiSinh
        public static DataTable LayDanhSachThiSinh()
        {
            return Doc(DanhSachThiSinh);
        }
        public static bool GhiDanhSachThiSinh(DataTable dt)
        {
            return Ghi(dt, DanhSachThiSinh);
        }
        #endregion
        #region KyThiHienTai
        public static DataTable LayKyThiHienTai()
        {
            return Doc(KyThiHienTai);
        }
        public static bool GhiKyThiHienTai(DataTable dt)
        {
            return Ghi(dt, KyThiHienTai);
        }
        #endregion
        #region HoiDongThi
        public static DataTable LayHoiDongThi()
        {
            return Doc(HoiDongThi);
        }
        public static bool GhiHoiDongThi(DataTable dt)
        {
            return Ghi(dt, HoiDongThi);
        }
        #endregion
        #region MonThi
        public static DataTable LayMonThi()
        {
            return Doc(MonThi);
        }
        public static bool GhiMonThi(DataTable dt)
        {
            return Ghi(dt, MonThi);
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
        private static bool CheckExitsFile(string spath)
        {
            FileInfo fi = new FileInfo(path+spath);
            return fi.Exists;
        }
        #endregion
    }
    public class XMLController
    {
        public static DataTable ReadFile(string FileName)
        {
            DataSet ds = new DataSet();
            ds.ReadXmlSchema(FileName + "s");
            ds.ReadXml(FileName);
            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }
        public static void WriteFile(DataTable dt, string FileName)
        {
            try
            {
                FileInfo fi = new FileInfo(FileName);
                if (fi.Exists)
                {
                    fi.CopyTo(FileName + ".bak."+DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss"), true);
                }
                DataSet ds = new DataSet();
                if (dt.DataSet == null)
                    ds.Tables.Add(dt);
                dt.DataSet.WriteXml(FileName);
                FileInfo sch = new FileInfo(FileName + "s");
                if (!sch.Exists)
                    dt.DataSet.WriteXmlSchema(FileName + "s");
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}