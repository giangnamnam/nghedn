using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Diagnostics;

using System.Net;
using System.Net.NetworkInformation;

using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

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
                en.Refresh(System.Data.Objects.RefreshMode.ClientWins, en.TaiKhoan);
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
        public static TaiKhoan TaiKhoanDangNhap()
        {
            return ((Forms.frmMain) System.Windows.Forms.Application.OpenForms["frmMain"]).TaiKhoanHienTai;
        }
        public static DMKyThi KyThiHienTai()
        {
            return ((Forms.frmMain)System.Windows.Forms.Application.OpenForms["frmMain"]).KyThiHienTai;
        }
        public static void GanKyThiHienTai(DMKyThi KyThiHienTai)
        {
            ((Forms.frmMain)System.Windows.Forms.Application.OpenForms["frmMain"]).KyThiHienTai = KyThiHienTai;
            ((Forms.frmMain)System.Windows.Forms.Application.OpenForms["frmMain"]).btnKyThiHienTai.Caption = "kỳ thi hiện tại: " + KyThiHienTai.TenKyThi + " (" + (KyThiHienTai.DaKetThuc.GetValueOrDefault(false) == true ? "Đã kết thúc" : "Chưa kết thúc") + ")";

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
        public static void Loading(object show)
        {
            //((Forms.frmMain)System.Windows.Forms.Application.OpenForms["frmMain"]).pictureBoxLoading.Visible = show;

            //if ((bool)show)
            //    ((Forms.frmMain)System.Windows.Forms.Application.OpenForms["frmMain"]).pictureBoxLoading.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //else
            //    ((Forms.frmMain)System.Windows.Forms.Application.OpenForms["frmMain"]).pictureBoxLoading.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;


            if ((bool)show)
                ((Forms.frmMain)System.Windows.Forms.Application.OpenForms["frmMain"]).ShowLoading();
            else
                ((Forms.frmMain)System.Windows.Forms.Application.OpenForms["frmMain"]).EndLoading();
            
            
        }
    }
    public class DataCopyHelper
    {
        Server sqlServer;
        public DataCopyHelper(String serverName, String userName, String password)
        {
            sqlServer = new Server(new ServerConnection(serverName, userName, password));
        }
        public void CopyData(String sourceDatabase, String destinationDataBase)
        {
            Database dbSource = sqlServer.Databases[sourceDatabase];
            Database dbDestination = sqlServer.Databases[destinationDataBase];

            if (dbDestination == null || dbSource == null)
                throw new Exception("Specified Database not found the server " + sqlServer.Name);
            StringBuilder sqlScript = new StringBuilder("");
            sqlScript.AppendLine("USE " + destinationDataBase + ";");
            sqlScript.AppendLine("");

            foreach (Table dataTable in dbSource.Tables)
            {
                if (!dbDestination.Tables.Contains(dataTable.Name, dataTable.Schema))
                    continue;
                sqlScript.AppendFormat("INSERT INTO {0} \n SELECT * FROM {0}", dataTable.Name);
                sqlScript.AppendLine();
            }

            dbDestination.ExecuteNonQuery(sqlScript.ToString());
        }
        public void TrancateData(String[] tableNames, String databaseName)
        {
            StringBuilder sqlScript = new StringBuilder("");
            sqlScript.AppendFormat("USE {0};", databaseName);
            sqlScript.AppendLine();
            foreach (String tableName in tableNames)
            {
                sqlScript.AppendFormat("TRUNCATE TABLE {0}", tableName);
                sqlScript.AppendLine();
            }

            Database db = sqlServer.Databases[databaseName];
            db.ExecuteNonQuery(sqlScript.ToString());
        }
        public void TruncateDatabase(String databaseName)
        {
            Database db = sqlServer.Databases[databaseName];
            if (db == null)
                throw new Exception("Specified Database not found the server " + sqlServer.Name);
            List<String> tables = new List<string>();
            foreach (Table dataTable in db.Tables)
            {
                tables.Add(dataTable.Name);
            }
            this.TrancateData(tables.ToArray(), databaseName);
        }
    }
}
