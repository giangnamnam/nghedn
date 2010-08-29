using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace QuanLyThiNghe.Forms
{
    public partial class frmCapNhatHDT : Form
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        public int MaHDT = 0;
        public frmCapNhatHDT()
        {
            InitializeComponent();
            LoadHuyen();
            cbHuyen.SelectedIndex = 0;
            LoadTruong(cbHuyen.EditValue.ToString());
        }

        void LoadTruong(string TenHuyen)
        {
            cbTruong.Properties.Items.Clear();
            cbTruong.Text = "";
            var source = _Entities.DMTruong.Where(t => t.DaXoa == false || t.DaXoa == null && t.DMHuyen.TenHuyen== TenHuyen).OrderBy(t => t.TenTruong);

            foreach (var item in source)
            {
                ImageComboBoxItem i = new ImageComboBoxItem();
                i.Value = item.TenTruong;
                i.Description = item.MaTruong.ToString();

                cbTruong.Properties.Items.Add(i);
            }

        }

        void LoadHuyen()
        {
            var source = _Entities.DMHuyen.Where(t => t.DaXoa == false || t.DaXoa == null).OrderBy(t => t.TenHuyen);

            foreach (var item in source)
            {
                ImageComboBoxItem i = new ImageComboBoxItem();
                i.Value = item.TenHuyen;
                i.Description = item.MaHuyen.ToString();

                cbHuyen.Properties.Items.Add(i);
            }
        }

        public void LoadChiTietHDT(int MaHD)
        {
            var HDT = _Entities.HoiDongThi.Where(h => h.MaHoiDong == MaHD).FirstOrDefault();
            
            if (HDT == null) this.Close();
            
            MaHDT = MaHD;

            HDT.DMTruongReference.Load();
            HDT.DMTruong.DMHuyenReference.Load();

            cbHuyen.Text = HDT.DMTruong.DMHuyen.TenHuyen;
            cbTruong.Text = HDT.DMTruong.TenTruong;

            txtSoPhong.Value = (decimal)HDT.SoLuongPhongDuTinh.Value;
            txtSoThiSinh.Value = (decimal)HDT.SoThiSinhDuTinh.Value;

            btnSave.ToolTipTitle = "update";
            cbHuyen.Enabled = cbTruong.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.ToolTipTitle== "insert")
            {
                var TenTruong = cbTruong.EditValue.ToString();
                var hdt = _Entities.HoiDongThi.Where(t => t.DMTruong.TenTruong == TenTruong).FirstOrDefault();
                if (hdt != null && (hdt.DaXoa == false || hdt.DaXoa == null))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Trường này đã có trong danh sách hội đồng thi, xin chọn trường khác.");
                    return;
                }
                else if (hdt != null && (hdt.DaXoa == true))
                {
                    hdt.NgayCapNhat = HeThong.LayGioHeThong();
                    hdt.NguoiCapNhat = HeThong.TaiKhoanDangNhap().TenDangNhap;

                    hdt.SoLuongPhongDuTinh = (int)txtSoPhong.Value;
                    hdt.SoThiSinhDuTinh = (int)txtSoThiSinh.Value;
                    hdt.DaXoa = false;

                    _Entities.SaveChanges();

                    frmHoiDongThi frm = new frmHoiDongThi();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã thêm thành công.");
                    frm.LoadHDT();
                    return;
                }
                
                try
                {
                    var HDT = new HoiDongThi();
                    HDT.DaXoa = false;

                    var MaKT = _Entities.Config.FirstOrDefault().KyThiHienTai;
                    HDT.DMKyThi = _Entities.DMKyThi.Where(d => d.MaKyThi == MaKT).FirstOrDefault();

                    HDT.DMTruong = _Entities.DMTruong.Where(t => t.TenTruong == TenTruong).FirstOrDefault();

                    HDT.NgayCapNhat = HDT.NgayTao = HeThong.LayGioHeThong();
                    HDT.NguoiCapNhat = HDT.NguoiTao = HeThong.TaiKhoanDangNhap().TenDangNhap;

                    HDT.SoLuongPhongDuTinh = (int)txtSoPhong.Value;
                    HDT.SoThiSinhDuTinh = (int)txtSoThiSinh.Value;

                    _Entities.AddToHoiDongThi(HDT);
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
                    frmHoiDongThi frm = new frmHoiDongThi();
                    frm.LoadHDT();
                }
            }
            else
            {
                try
                {
                    var HDT = _Entities.HoiDongThi.First(h => h.MaHoiDong == MaHDT);

                    HDT.NgayCapNhat = HeThong.LayGioHeThong();
                    HDT.NguoiCapNhat = HeThong.TaiKhoanDangNhap().TenDangNhap;

                    HDT.SoLuongPhongDuTinh = (int)txtSoPhong.Value;
                    HDT.SoThiSinhDuTinh = (int)txtSoThiSinh.Value;

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
                    frmHoiDongThi frm = new frmHoiDongThi();
                    frm.LoadHDT();
                }
            }

        }

        private void cbHuyen_TextChanged(object sender, EventArgs e)
        {
            LoadTruong(cbHuyen.EditValue.ToString());
        }
    }
}
