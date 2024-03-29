using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;

namespace QuanLyThiNghe.Forms
{
    public partial class frmDangNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TaiKhoan TaiKhoanDangNhap { get; set; }
        public DMKyThi KyThiHienTai { get; set; }
        QLTN_Entities en = new QLTN_Entities();
        DialogResult rt = DialogResult.Cancel;
        int countDown = 0;
        public frmDangNhap()
        {
            InitializeComponent();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            int MaKyThi = (from c in en.Config select c).First().KyThiHienTai.GetValueOrDefault(0);
            KyThiHienTai = en.DMKyThi.Where(k => k.MaKyThi == MaKyThi).First();

            string strMac = GetMacAddress();
            string comName = Dns.GetHostName();
            string ip = "";

            IPHostEntry ipEntry = Dns.GetHostEntry(comName);
            IPAddress[] addr = ipEntry.AddressList;
            ip = "MAC: " + strMac + "; IP: ";
            for (int i = 0; i < addr.Length; i++)
            {
                ip += " (" + i.ToString() + ": " + addr[i].ToString() + ");";
            }



            if (countDown++ >4)
            {
                TaiKhoan vl = (from v in en.TaiKhoan where (v.TenDangNhap == "unknown") select v).First();
                NhatKy k = new NhatKy();
                k.ComputerUser = comName;
                k.ThaoTac = "Đăng nhập thất bại sau 5 lần với tài khoản \""+textEdit1.Text+"\" và mật khẩu \""+textEdit2.Text+"\" ";
                k.NgayThaoTac = HeThong.LayGioHeThong();
                k.IP = ip;
                vl.NhatKy.Add(k);
                en.SaveChanges();

                rt = DialogResult.Cancel;
                this.Close();
                return;
            }
            bool checkMac = ((from c in en.Config where (c.CheckMac == true) select c).Count()==1);
            string matkhau = XuLyChuoi.MaHoa(textEdit2.Text, XuLyChuoi.KieuMaHoa.HungVQ);
            bool passCheckMac = true;

            if ((from t in en.TaiKhoan where (t.MatKhau == matkhau && t.TenDangNhap == textEdit1.Text && (t.DaXoa == false ||t.DaXoa ==null)) select t).Count() > 0)
            {
                TaiKhoanDangNhap = (from t in en.TaiKhoan where (t.MatKhau == matkhau && t.TenDangNhap == textEdit1.Text) select t).First();
                rt = DialogResult.OK;

                //lưu log
                try
                {
                    NhatKy nk = new NhatKy();
                    nk.ComputerUser = Dns.GetHostName();
                    nk.ThaoTac = "Đăng nhập";
                    nk.NgayThaoTac = HeThong.LayGioHeThong();
                    nk.IP = ip;
                    

                    if (checkMac)
                    {

                        if ((TaiKhoanDangNhap.MAC==null)|| !((TaiKhoanDangNhap.MAC.ToLower().Contains(strMac.ToLower()) || TaiKhoanDangNhap.MAC == "unlimited")))
                        {
                            nk.ThaoTac = "Đăng nhập sai MAC (lần đăng nhập thứ" + countDown.ToString() + ")";
                            XtraMessageBox.Show("Máy bạn đang dùng không được cấp quyền đăng nhập hệ thống, \nxin vui lòng dùng đúng máy đã quy định.\nMAC hiện tại: "+strMac+"", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            rt = DialogResult.Cancel;
                            passCheckMac = false;
                        }
                    }
                    TaiKhoanDangNhap.NhatKy.Add(nk);
                    en.SaveChanges();
                }
                catch (Exception)
                {
                }
                if (passCheckMac)
                {
                    this.Close();
                }
                else
                {
                    TaiKhoanDangNhap = null;
                }
            }
            else
            {
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng, \nxin vui lòng đăng nhập lại.", "Đăng nhập", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


        private string GetMacAddress()
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
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                en.Connection.Open();
                en.Connection.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                XtraMessageBox.Show("Xin lỗi, hiện tại phần mềm không thể kết nối được tới dữ liệu.\nXin vui lòng kiểm tra lại đường truyền internet.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = rt;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //string[] files = System.IO.Directory.GetFiles(@"C:\Users\HungVQ\Desktop\");
            //for (int i = 0; i < files.Length; i++)
            //{
            //    DirectoryInfo b = new DirectoryInfo(files[i]);
            //    b.MoveTo(files[i].Replace(".xml",""));
            //    //FileInfo a = new FileInfo(files[i]);
            //    //a.CopyTo(@"C:\Users\HungVQ\Desktop\m\"+i.ToString()+".xml");
            //}
            this.Close();
            
        }
    }
}