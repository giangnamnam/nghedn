using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThiNghe.Forms
{
    public partial class frmThanhVien_ThemMoi : Form
    {
        QLTN_Entities en = new QLTN_Entities();
        DialogResult rt = DialogResult.Cancel;
        public TaiKhoan pTaiKhoan { get; set; }
        public frmThanhVien_ThemMoi()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedItem != null)
            {
                string quyen = comboBoxEdit1.SelectedItem.ToString();
                if ((from q in en.PhanQuyen where q.TenQuyen == quyen select q).Count() < 1)
                {
                    XtraMessageBox.Show("Vui lòng chọn phân quyền thích hợp cho tài khoản mới.", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (textEdit4.Text != textEdit3.Text)
            {
                XtraMessageBox.Show("Mật khẩu không khớp, xin vui lòng nhập lại mật khẩu.", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEdit4.SelectAll();
                textEdit3.SelectAll();
                textEdit3.Focus();
            }
            else if (string.IsNullOrEmpty(textEdit3.Text) || string.IsNullOrEmpty(textEdit1.Text) || string.IsNullOrEmpty(textEdit2.Text))
            {
                XtraMessageBox.Show("Tên đăng nhập, họ và tên, mật khẩu và phân quyền không được để trống. \nXin vui lòng kiểm tra lại.", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //luu
                if (textEdit2.Enabled)
                {
                    #region thêm
                    if (en.TaiKhoan.Where(t => t.TenDangNhap == textEdit2.Text).Count() > 0)
                    {
                        MessageBox.Show("Tên đăng nhập này đã tồn tại, xin vui lòng chọn tên đăng nhập khác", "Tài khoản");
                        textEdit2.SelectAll();
                    }
                    else
                    {
                        string quyen = comboBoxEdit1.SelectedItem.ToString();
                        PhanQuyen pq = (from q in en.PhanQuyen where q.TenQuyen == quyen select q).First();
                        TaiKhoan tk = new TaiKhoan();
                        tk.DienThoai = textEdit5.Text;
                        tk.HoVaTen = textEdit1.Text;
                        tk.MatKhau = XuLyChuoi.MaHoa(textEdit3.Text, XuLyChuoi.KieuMaHoa.HungVQ);
                        tk.MAC = textEdit6.Text;
                        tk.TenDangNhap = textEdit2.Text;
                        tk.NguoiTao = HeThong.TaiKhoanDangNhap().TenDangNhap;
                        tk.NgayTao = HeThong.LayGioHeThong();
                        pq.TaiKhoan.Add(tk);
                        //tk.PhanQuyen.TenQuyen = comboBoxEdit1.SelectedText;
                        en.SaveChanges();
                        XuLyForm.LuuNhatKy("Tạo mới tài khoản " + textEdit2.Text);
                        rt = DialogResult.OK;
                        this.Close();
                    }
                    #endregion
                }
                else
                {
                    string username = textEdit2.Text;
                    TaiKhoan tk = (from t in en.TaiKhoan where t.TenDangNhap == username select t).First();
                    string quyen = comboBoxEdit1.SelectedItem.ToString();
                    PhanQuyen pq = (from q in en.PhanQuyen where q.TenQuyen == quyen select q).First();

                    tk.NguoiCapNhat = HeThong.TaiKhoanDangNhap().TenDangNhap;// ((frmMain)Application.OpenForms["frmMain"]).TaiKhoanHienTai.TenDangNhap;
                    tk.NgayCapNhat = HeThong.LayGioHeThong();

                    tk.DienThoai = textEdit5.Text;
                    tk.HoVaTen = textEdit1.Text;
                    if (tk.MatKhau!=textEdit3.Text)
                    {
                        tk.MatKhau = XuLyChuoi.MaHoa(textEdit3.Text, XuLyChuoi.KieuMaHoa.HungVQ);
                    }
                    tk.MAC = textEdit6.Text;
                    pq.TaiKhoan.Add(tk);
                    en.SaveChanges();
                    XuLyForm.LuuNhatKy("Chỉnh sửa thông tin tài khoản " + textEdit2.Text);
                    rt = DialogResult.OK;
                    this.Close();
                }
                
            }
            
        }

        private void frmThanhVien_ThemMoi_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.Items.AddRange(en.PhanQuyen.Select(h => h.TenQuyen).ToList());

            if (pTaiKhoan != null)
            {
                textEdit5.Text = pTaiKhoan.DienThoai;
                textEdit1.Text = pTaiKhoan.HoVaTen;
                textEdit3.Text = pTaiKhoan.MatKhau;
                textEdit4.Text = pTaiKhoan.MatKhau;
                textEdit6.Text = pTaiKhoan.MAC;
                textEdit2.Text = pTaiKhoan.TenDangNhap;
                pTaiKhoan.PhanQuyenReference.Load();
                comboBoxEdit1.SelectedText = pTaiKhoan.PhanQuyen.TenQuyen;
                this.Text = "Cập nhật tài khoản "+pTaiKhoan.TenDangNhap;
                textEdit2.Enabled = false;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmThanhVien_ThemMoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = rt;
        }



    }
}
