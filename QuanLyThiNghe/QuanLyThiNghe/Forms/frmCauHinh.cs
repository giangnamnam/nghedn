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

namespace QuanLyThiNghe.Forms
{
    public partial class frmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities en = new QLTN_Entities();
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void frmCauHinh_Load(object sender, EventArgs e)
        {
            LoadCauHinh();
        }
        private void LoadKyThi()
        {
            comboBoxEdit1.Properties.Items.AddRange(en.DMKyThi.Where(h => h.DaXoa != null || h.DaXoa == false).Select(h1 => h1.TenKyThi).ToList());
        }
        private void LoadCauHinh()
        {
            LoadKyThi();
            en.Refresh(System.Data.Objects.RefreshMode.ClientWins, en.Config);
            Config cf = (from c in en.Config select c).First();
            chkCheckMAC.Checked = (cf.CheckMac==true? true: false);
            chkHienThiThongBao.Checked = (cf.HienThiThongBaoTrenWeb == true ? true : false);
            chk.Checked = (cf.ChoCacTruongGuiDanhSach == true ? true : false);
            checkEdit1.Checked = (cf.ChoCacTruongNhanDanhSach == true ? true : false);
            checkEdit2.Checked = (cf.ChoHoiDongThiNhanDanhSach == true ? true : false);
            checkEdit3.Checked = (cf.ChoCacTruongNhanKetQua == true ? true : false);
            checkEdit4.Checked = (cf.ChoHoiDongNhanKetQua == true ? true : false);
            checkEdit5.Checked = (cf.ChoThuKyNhapDiem == true ? true : false);
            checkEdit6.Checked = (cf.ChoLoginWeb == true ? true : false);
            checkEdit7.Checked = (cf.ApDungSTSTPT == true ? true : false);
            spinEdit1.Value = cf.SoThiSinhTrenPhong.GetValueOrDefault(24);
            chkNLD.Checked = (cf.ChoThuKyQuayLaiKhiNhapDiem == true ? true : false);
            memoEdit1.Text = cf.NoiDungThongBaoTrenWeb;
            DMKyThi kt = (from k in en.DMKyThi where k.MaKyThi == cf.KyThiHienTai select k).First();
            comboBoxEdit1.SelectedText = kt.TenKyThi;
            chkKetThuc.Checked = kt.DaKetThuc==true ? true : false;
            btnLuu.Tag = cf.ConfigID;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = int.Parse(btnLuu.Tag.ToString());
                Config cf = (from c in en.Config where (c.ConfigID == cid) select c).First();

                cf.CheckMac = chkCheckMAC.Checked;
                cf.HienThiThongBaoTrenWeb = chkHienThiThongBao.Checked;
                cf.ChoCacTruongGuiDanhSach = chk.Checked;
                cf.ChoCacTruongNhanDanhSach = checkEdit1.Checked;
                cf.ChoHoiDongThiNhanDanhSach = checkEdit2.Checked;
                cf.ChoCacTruongNhanKetQua = checkEdit3.Checked;
                cf.ChoHoiDongNhanKetQua = checkEdit4.Checked;
                cf.ChoThuKyNhapDiem = checkEdit5.Checked;
                cf.ChoLoginWeb = checkEdit6.Checked;
                cf.NoiDungThongBaoTrenWeb = memoEdit1.Text;
                cf.ChoThuKyQuayLaiKhiNhapDiem = chkNLD.Checked;
                cf.ApDungSTSTPT = checkEdit7.Checked;
                cf.SoThiSinhTrenPhong = int.Parse(spinEdit1.Value.ToString());

                if (comboBoxEdit1.SelectedItem != null)
                {
                    string kythi = comboBoxEdit1.SelectedItem.ToString();
                    if ((from q in en.DMKyThi where q.TenKyThi == kythi select q).Count() < 1)
                    {
                        XtraMessageBox.Show("Vui lòng chọn kỳ thi chính xác.", "Cấu hình hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DMKyThi kt = (from k in en.DMKyThi where k.TenKyThi == kythi select k).First();
                    cf.KyThiHienTai = kt.MaKyThi;
                    kt.DaKetThuc = chkKetThuc.Checked;
                    HeThong.GanKyThiHienTai(kt);
                }               
                en.SaveChanges();
                XtraMessageBox.Show("Đã lưu lại cấu hình thành công.", "Cấu hình hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XuLyForm.LuuNhatKy("Chỉnh sửa cấu hình hệ thống. ");
            }
            catch (Exception ex)
            {
                XuLyForm.LuuNhatKy("Lỗi cấu hình hệ thống. "+ex.Message);
            }
            
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedItem != null)
            {
                string kythi = comboBoxEdit1.SelectedItem.ToString();
                if ((from q in en.DMKyThi where q.TenKyThi == kythi select q).Count() < 1)
                {
                    XtraMessageBox.Show("Vui lòng chọn kỳ thi chính xác.", "Cấu hình hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DMKyThi kt = (from k in en.DMKyThi where k.TenKyThi == kythi select k).First();
                chkKetThuc.Checked = kt.DaKetThuc == true ? true : false;
            }
        }

        private void checkEdit7_CheckedChanged(object sender, EventArgs e)
        {
            spinEdit1.Enabled = checkEdit7.Checked;
        }

        
    }
}
