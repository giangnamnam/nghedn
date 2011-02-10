using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThiNghe.Forms
{
    public partial class frmCapNhatKyThi : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        public int MaKyThi = 0;
        public frmCapNhatKyThi()
        {
            InitializeComponent();
            txtNgayThi.Properties.NullDate = DateTime.Now;
        }

        public void LoadChiTietKyThi(int maKyThi)
        {
            var kyThi = _Entities.DMKyThi.First(t => t.MaKyThi == maKyThi);

            txtTenKyThi.Text = kyThi.TenKyThi;
            txtNgayThi.Text = kyThi.NgayThi.HasValue ? kyThi.NgayThi.Value.ToString("dd/MM/yyyy") : "";
            txtGhiChu.Text = kyThi.GhiChu;
            cbDaKetThuc.Checked = kyThi.DaKetThuc.HasValue ? kyThi.DaKetThuc.Value : false;

            btnSave.ToolTipTitle = "update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.ToolTipTitle == "insert")
            {
                var kythi = new DMKyThi();

                try
                {
                    kythi.DaKetThuc = cbDaKetThuc.Checked;
                    kythi.GhiChu = txtGhiChu.Text;
                    kythi.TenKyThi = txtTenKyThi.Text;
                    kythi.NgayThi = (DateTime)txtNgayThi.EditValue;

                    kythi.NgayTao = kythi.NgayCapNhat = HeThong.LayGioHeThong();
                    kythi.NguoiCapNhat = kythi.NguoiTao = HeThong.TaiKhoanDangNhap().TenDangNhap;
                    kythi.DaXoa = false;

                    _Entities.AddToDMKyThi(kythi);
                    _Entities.SaveChanges();
                }
                catch (Exception exp)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Có lỗi xảy ra: " + exp.Message);
                    return;
                }
                finally
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã thêm thành công.");
                    frmKyThi f = (frmKyThi)Application.OpenForms["frmKyThi"];
                    f.LoadKyThi();
                    XuLyForm.LuuNhatKy("Thêm kỳ thi: " + kythi.TenKyThi);
                    txtTenKyThi.Text = txtGhiChu.Text = txtNgayThi.Text = "";
                    cbDaKetThuc.Checked = false;
                }
            }
            else
            {
                var kythi = _Entities.DMKyThi.First(t => t.MaKyThi == MaKyThi);

                try
                {
                    kythi.DaKetThuc = cbDaKetThuc.Checked;
                    kythi.GhiChu = txtGhiChu.Text;
                    kythi.TenKyThi = txtTenKyThi.Text;
                    kythi.NgayThi = (DateTime)txtNgayThi.EditValue;

                    kythi.NgayCapNhat = HeThong.LayGioHeThong();
                    kythi.NguoiCapNhat = HeThong.TaiKhoanDangNhap().TenDangNhap;

                    _Entities.SaveChanges();
                }
                catch (Exception exp)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Có lỗi xảy ra: " + exp.Message);
                    return;
                }
                finally
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã cập nhật thành công.");
                    frmKyThi f = (frmKyThi)Application.OpenForms["frmKyThi"];
                    f.LoadKyThi();
                    XuLyForm.LuuNhatKy("Cập nhật kỳ thi: " + kythi.TenKyThi);
                }
            }
        }
    }
}
