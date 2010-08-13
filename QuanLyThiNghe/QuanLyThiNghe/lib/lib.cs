using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;

namespace QuanLyThiNghe
{
    public class XuLyChuoi
    {
        public enum KieuMaHoa{MD5,SHA1,HungVQ};
        public static string MaHoa(string ChuoiCanMaHoa, KieuMaHoa MaHoa)
        {
            string kq = "";
            if (MaHoa == KieuMaHoa.MD5)
            {
                kq= Convert.ToBase64String(new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(ChuoiCanMaHoa)));
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
    public class XuLyForm
    {
        public static void LuuNhatKy(string NoiDung)
        {
            try
            {
                string TenDangNhap = HeThong.TaiKhoanDangNhap().TenDangNhap;
                QLTN_Entities en = new QLTN_Entities();
                TaiKhoan vl = (from v in en.TaiKhoan where (v.TenDangNhap == TenDangNhap) select v).First();
                NhatKy k = new NhatKy();

                k.ComputerUser = HeThong.TenMay();
                k.ThaoTac = NoiDung;
                k.NgayThaoTac = (from s in en.ThongKe select s).First().GioHeThong;//DateTime.Now;
                k.IP = "MAC: " + HeThong.LayMAC() +"; IP:  "+ HeThong.LayIP();
                vl.NhatKy.Add(k);
                en.SaveChanges();
            }
            catch (Exception)
            {
            }
        }
    }
    public class HeThong
    {
        public static TaiKhoan TaiKhoanDangNhap()
        {
            return ((Forms.frmMain) System.Windows.Forms.Application.OpenForms["frmMain"]).TaiKhoanHienTai;
        }
        public static DateTime LayGioHeThong()
        {
            QLTN_Entities en = new QLTN_Entities();
            return (from s in en.ThongKe select s).First().GioHeThong;//DateTime.Now;
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
}
