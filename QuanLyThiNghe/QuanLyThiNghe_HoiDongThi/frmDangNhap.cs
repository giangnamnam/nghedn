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

namespace QuanLyThiNghe_ThuKy
{
    public partial class frmDangNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public System.Collections.ArrayList TaiKhoanDangNhap { get; set; }
        
        DialogResult rt = DialogResult.Cancel;
        int countDown = 0;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TaiKhoanDangNhap.Clear();
            string strMac = GetMacAddress();
            if (countDown++ >4)
            {
                rt = DialogResult.Cancel;
                this.Close();
                return;
            }

            KyThiHienTai ktht = new KyThiHienTai();
            TaiKhoan tk = new TaiKhoan();
            

            if (!string.IsNullOrEmpty(txtTK1.Text))
            {
                DataRow r = tk.LayMotTaiKhoan(txtTK1.Text, txtPass1.Text);
                if (r != null && ktht.CheckMac)
                {
                    string accMAC = r["MAC"].ToString().ToUpper();
                    if ((accMAC == null) || !((accMAC.Contains(strMac) || accMAC.ToLower() == "unlimited")))
                    {
                        XtraMessageBox.Show("Máy bạn đang dùng không được cấp quyền đăng nhập hệ thống, \nxin vui lòng dùng đúng máy đã quy định.\nMAC hiện tại: " + strMac + "", "Đăng nhập "+txtTK1.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rt = DialogResult.Cancel;
                        return;
                    }
                }
                else if (r==null)
                {
                    XtraMessageBox.Show("Đăng nhập thất bại cho vị trí thư ký 1.", "Đăng nhập " + txtTK1.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rt = DialogResult.Cancel;
                    return;
                }
                TaiKhoanDangNhap.Add(r);
            }
            if (!string.IsNullOrEmpty(txtTK2.Text))
            {
                DataRow r = tk.LayMotTaiKhoan(txtTK2.Text, txtPass2.Text);
                if (r != null && ktht.CheckMac)
                {
                    string accMAC = r["MAC"].ToString().ToUpper();
                    if ((accMAC == null) || !((accMAC.Contains(strMac) || accMAC.ToLower() == "unlimited")))
                    {
                        XtraMessageBox.Show("Máy bạn đang dùng không được cấp quyền đăng nhập hệ thống, \nxin vui lòng dùng đúng máy đã quy định.\nMAC hiện tại: " + strMac + "", "Đăng nhập " + txtTK2.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rt = DialogResult.Cancel;
                        return;
                    }
                }
                else if (r == null)
                {
                    XtraMessageBox.Show("Đăng nhập thất bại cho vị trí thư ký 2.", "Đăng nhập " + txtTK1.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rt = DialogResult.Cancel;
                    return;
                }
                TaiKhoanDangNhap.Add(r);
            }
            if (!string.IsNullOrEmpty(txtTK3.Text))
            {
                DataRow r = tk.LayMotTaiKhoan(txtTK3.Text, txtPass3.Text);
                if (r != null && ktht.CheckMac)
                {
                    string accMAC = r["MAC"].ToString().ToUpper();
                    if ((accMAC == null) || !((accMAC.Contains(strMac) || accMAC.ToLower() == "unlimited")))
                    {
                        XtraMessageBox.Show("Máy bạn đang dùng không được cấp quyền đăng nhập hệ thống, \nxin vui lòng dùng đúng máy đã quy định.\nMAC hiện tại: " + strMac + "", "Đăng nhập " + txtTK3.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rt = DialogResult.Cancel;
                        return;
                    }
                }
                else if (r == null)
                {
                    XtraMessageBox.Show("Đăng nhập thất bại cho vị trí thư ký 3.", "Đăng nhập " + txtTK1.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rt = DialogResult.Cancel;
                    return;
                }
                TaiKhoanDangNhap.Add(r);
            }
            for (int i = 0; i < TaiKhoanDangNhap.Count; i++)
            {
                for (int j = i+1; j < TaiKhoanDangNhap.Count; j++)
                {
                    if (((DataRow)TaiKhoanDangNhap[i])["MaTaiKhoan"].ToString() == ((DataRow)TaiKhoanDangNhap[j])["MaTaiKhoan"].ToString())
                    {
                        TaiKhoanDangNhap.RemoveAt(j);
                        i --;
                        break;
                    }
                }
            }
            for (int i = 0; i < TaiKhoanDangNhap.Count; i++)
            {
                XuLyForm.LuuNhatKy(int.Parse(((DataRow)TaiKhoanDangNhap[i])["MaTaiKhoan"].ToString()), "Đăng nhập vào ứng dụng thư ký");
            }
            rt = DialogResult.OK;
            this.Close();
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
            TaiKhoanDangNhap = new System.Collections.ArrayList();
            TaiKhoan tk = new TaiKhoan();
            if (tk.Table==null)
            {
                XtraMessageBox.Show("Xin lỗi, hiện tại phần mềm chưa được cập nhật dữ liệu.\nXin vui lòng kết nối internet và thực hiện cập nhật dữ liệu thi nghề.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmCapNhatDuLieu frm = new frmCapNhatDuLieu();
                if (frm.ShowDialog()!= DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = rt;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCapNhatDuLieu frm = new frmCapNhatDuLieu();
            frm.ShowDialog();
        }
        
    }
}