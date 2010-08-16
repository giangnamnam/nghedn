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
    public partial class frmCapNhatTruong : Form
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        public int MaTruong;

        public frmCapNhatTruong()
        {
            InitializeComponent();
            LoadDistricts();
        }

        void LoadDistricts()
        {
            cbHuyen.Properties.Items.AddRange(_Entities.DMHuyen.Where(h => h.DaXoa == false || h.DaXoa == null).Select(h => h.TenHuyen).ToList());
        }

        private void frmCapNhatHuyen_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.ToolTipTitle == "insert")
            {
                DMTruong h = new DMTruong();

                h.DaXoa = false;
                h.NgayCapNhat = h.NgayTao = HeThong.LayGioHeThong();
                h.NguoiCapNhat = h.NguoiTao = HeThong.TaiKhoanDangNhap().TenDangNhap;

                h.DMHuyen = _Entities.DMHuyen.First(f => f.TenHuyen == cbHuyen.SelectedText);
                h.TenTruong = txtSchoolName.Text;

                try
                {
                    _Entities.AddToDMTruong(h);
                    _Entities.SaveChanges();
                }
                catch (Exception exp)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Có lối xảy ra: " + exp.Message);
                    return;
                }
                finally
                {
                    frmTruong f = (frmTruong)Application.OpenForms["frmTruong"];
                    f.LoadSchools(f.cbHuyen.SelectedText);
                    XuLyForm.LuuNhatKy("Thêm trường: " + h.TenTruong);
                    txtSchoolName.Text = "";
                }
            }
            else
            {
                var h = _Entities.DMTruong.Where(d => d.MaTruong == MaTruong).FirstOrDefault();

                h.DaXoa = false;
                h.NgayCapNhat = HeThong.LayGioHeThong();
                h.NguoiCapNhat = HeThong.TaiKhoanDangNhap().TenDangNhap;

                h.DMHuyen = _Entities.DMHuyen.First(f => f.TenHuyen == cbHuyen.SelectedText);
                h.TenTruong = txtSchoolName.Text;

                try
                {
                    _Entities.SaveChanges();
                }
                catch (Exception exp)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Có lối xảy ra: " + exp.Message);
                    return;
                }
                finally
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã cập nhật thành công.");
                    XuLyForm.LuuNhatKy("Cập nhật trường: " + h.TenTruong);
                    frmTruong f = (frmTruong)Application.OpenForms["frmTruong"];
                    f.LoadSchools(f.cbHuyen.SelectedText);
                }
            }
        }
    }
}
