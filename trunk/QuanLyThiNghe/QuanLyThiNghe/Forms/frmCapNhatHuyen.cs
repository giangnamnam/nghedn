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
    public partial class frmCapNhatHuyen : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        public int MaHuyen;

        public frmCapNhatHuyen()
        {
            InitializeComponent();
        }

        private void frmCapNhatHuyen_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.ToolTipTitle == "insert")
            {
                DMHuyen h = new DMHuyen();

                h.DaXoa = false;
                h.NgayCapNhat = h.NgayTao = HeThong.LayGioHeThong();
                h.NguoiCapNhat = h.NguoiTao = HeThong.TaiKhoanDangNhap().TenDangNhap;
                h.TenHuyen = txtDistrictName.Text;

                try
                {
                    _Entities.AddToDMHuyen(h);
                    _Entities.SaveChanges();
                }
                catch (Exception exp)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Có lỗi xảy ra: " + exp.Message);
                    return;
                }
                finally
                {
                    frmHuyen f = (frmHuyen)Application.OpenForms["frmHuyen"];
                    f.LoadDistricts();
                    XuLyForm.LuuNhatKy("Thêm huyện: " + h.TenHuyen);
                    txtDistrictName.Text = "";
                }
            }
            else
            {
                var h = _Entities.DMHuyen.Where(d => d.MaHuyen == MaHuyen).FirstOrDefault();

                h.DaXoa = false;
                h.NgayCapNhat = HeThong.LayGioHeThong();
                h.NguoiCapNhat = HeThong.TaiKhoanDangNhap().TenDangNhap;
                h.TenHuyen = txtDistrictName.Text;

                try
                {
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
                    XuLyForm.LuuNhatKy("Cập nhật huyện: " + h.TenHuyen);
                    frmHuyen f = (frmHuyen)Application.OpenForms["frmHuyen"];
                    f.LoadDistricts();
                }
            }
        }

        private void txtDistrictName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}
