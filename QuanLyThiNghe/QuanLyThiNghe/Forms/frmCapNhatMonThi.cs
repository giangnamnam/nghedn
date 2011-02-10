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
    public partial class frmCapNhatMonThi : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities _entities = new QLTN_Entities();
        public int MaMonThi;
        public frmCapNhatMonThi()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.ToolTipTitle == "insert")
            {
                DMMonThi h = new DMMonThi();

                h.DaXoa = false;
                h.NgayCapNhat = h.NgayTao = HeThong.LayGioHeThong();
                h.NguoiCapNhat = h.NguoiTao = HeThong.TaiKhoanDangNhap().TenDangNhap;
                h.TenMonThi = txtDistrictName.Text;

                try
                {
                    _entities.AddToDMMonThi(h);
                    _entities.SaveChanges();
                }
                catch (Exception exp)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Có lỗi xảy ra: " + exp.Message);
                    return;
                }
                finally
                {
                    frmMonThi f = (frmMonThi)Application.OpenForms["frmMonThi"];
                    f.LoadMonThi();

                    txtDistrictName.Text = "";
                }
            }
            else
            {
                var h = _entities.DMMonThi.Where(d => d.MaMonThi == MaMonThi).FirstOrDefault();

                h.DaXoa = false;
                h.NgayCapNhat = HeThong.LayGioHeThong();
                h.NguoiCapNhat = HeThong.TaiKhoanDangNhap().TenDangNhap;
                h.TenMonThi = txtDistrictName.Text;

                try
                {
                    _entities.SaveChanges();
                }
                catch (Exception exp)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Có lỗi xảy ra: " + exp.Message);
                    return;
                }
                finally
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã cập nhật thành công.");

                    frmMonThi f = (frmMonThi)Application.OpenForms["frmMonThi"];
                    f.LoadMonThi();
                }
            }
        }
    }
}
