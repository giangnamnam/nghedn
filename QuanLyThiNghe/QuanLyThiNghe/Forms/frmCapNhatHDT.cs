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
    public partial class frmCapNhatHDT : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        public int MaHDT = 0;
        public int MaHuyen { get; set; }
        public int MaTruong { get; set; }
        public int MaKyThi { get; set; }
        


        public frmCapNhatHDT()
        {
            InitializeComponent();
            
            
        }
        void LoadTruong(int MaHuyen)
        {
            var source = _Entities.DMTruong.Where(t => (t.DaXoa == false || t.DaXoa == null) && t.DMHuyen.MaHuyen== MaHuyen).OrderBy(t => t.TenTruong);
            lookUpTruong.Properties.DataSource = source;
        }
        void LoadHuyen()
        {
            var source = _Entities.DMHuyen.Where(t => t.DaXoa == false || t.DaXoa == null).OrderBy(t => t.TenHuyen);
            lookUpHuyen.Properties.DataSource = source;
            //lookUpHuyen
        }

        public void LoadChiTietHDT(int MaHD)
        {
            var HDT = _Entities.HoiDongThi.Where(h => h.MaHoiDong == MaHD).FirstOrDefault();
            
            if (HDT == null) this.Close();
            
            MaHDT = MaHD;

            HDT.DMTruongReference.Load();
            HDT.DMTruong.DMHuyenReference.Load();

            lookUpHuyen.EditValue = HDT.DMTruong.DMHuyen.MaHuyen;
            lookUpTruong.EditValue = HDT.DMTruong.MaTruong;
            spinEdit1.Value = HDT.SoLuongThiSinhTrenMotPhongThi.GetValueOrDefault(0);

            txtSoPhong.Value = (decimal)HDT.SoLuongPhongDuTinh.GetValueOrDefault(0);
            txtSoThiSinh.Value = (decimal)HDT.SoThiSinhDuTinh.GetValueOrDefault(0);

            btnSave.ToolTipTitle = "update";
            lookUpHuyen.Enabled = lookUpTruong.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MaHDT==0)
            {
                MaTruong = int.Parse(lookUpTruong.EditValue.ToString());
                int KyThiHienTai = MaKyThi;
                if (MaKyThi==0)
                    KyThiHienTai = HeThong.KyThiHienTai().MaKyThi;

                var hdt = _Entities.HoiDongThi.Where(t => t.DMTruong.MaTruong == MaTruong && t.DMKyThi.MaKyThi==KyThiHienTai).FirstOrDefault();
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
                    hdt.SoLuongThiSinhTrenMotPhongThi = (int)spinEdit1.Value;
                    hdt.DaXoa = false;

                    _Entities.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    frmHoiDongThi frm = new frmHoiDongThi();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã thêm thành công.");
                    frm.LoadHDT();
                    return;
                }
                
                try
                {
                    var HDT = new HoiDongThi();
                    HDT.DaXoa = false;

                    
                    HDT.DMKyThi = _Entities.DMKyThi.Where(d => d.MaKyThi == KyThiHienTai).FirstOrDefault();

                    HDT.DMTruong = _Entities.DMTruong.Where(t => t.MaTruong == MaTruong).FirstOrDefault();

                    HDT.NgayTao = HeThong.LayGioHeThong();
                    HDT.NguoiTao = HeThong.TaiKhoanDangNhap().TenDangNhap;

                    HDT.SoLuongPhongDuTinh = (int)txtSoPhong.Value;
                    HDT.SoThiSinhDuTinh = (int)txtSoThiSinh.Value;
                    HDT.SoLuongThiSinhTrenMotPhongThi = (int)spinEdit1.Value;

                    _Entities.AddToHoiDongThi(HDT);
                    _Entities.SaveChanges();
                    XuLyForm.LuuNhatKy("Thêm hội đồng thi "+HDT.DMTruong.TenTruong);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception exp)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Có lỗi xảy ra: " + exp.Message);
                    this.DialogResult = DialogResult.Retry;
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
                    XuLyForm.LuuNhatKy("Cập nhật thông tin hội đồng thi " + HDT.DMTruong.TenTruong);
                    this.DialogResult = DialogResult.OK;

                }
                catch (Exception exp)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Có lỗi xảy ra: " + exp.Message);
                    this.DialogResult = DialogResult.Retry;
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
            //LoadTruong(cbHuyen.EditValue.ToString());
        }
        private void frmCapNhatHDT_Load(object sender, EventArgs e)
        {
            LoadHuyen();
            int HuyenDangChon = 0;
            if (MaHuyen != 0)
            {
                lookUpHuyen.EditValue = MaHuyen;
            }

            if (int.TryParse(lookUpHuyen.EditValue.ToString(), out HuyenDangChon))
            {
                MaHuyen = HuyenDangChon;
                LoadTruong(MaHuyen);
                if (MaTruong != 0)
                {
                    lookUpTruong.EditValue = MaTruong;
                }
            }
        }
        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (spinEdit1.Value>100||spinEdit1.Value<1)
                spinEdit1.Value = 1;
            
            txtSoPhong.Value = (int)((int)txtSoThiSinh.Value / (int)spinEdit1.Value);
        }
        private void txtSoThiSinh_EditValueChanged(object sender, EventArgs e)
        {
            txtSoPhong.Value = (int)((int)txtSoThiSinh.Value / (int)spinEdit1.Value);
        }
        private void lookUpHuyen_EditValueChanged(object sender, EventArgs e)
        {
            int HuyenDangChon = 0;
            if (int.TryParse(lookUpHuyen.EditValue.ToString(), out HuyenDangChon))
            {
                MaHuyen = HuyenDangChon;
                LoadTruong(MaHuyen);
            }
        }
    }
}
