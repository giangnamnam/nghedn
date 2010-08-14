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
        private void LoadCauHinh()
        {
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
            memoEdit1.Text = cf.NoiDungThongBaoTrenWeb;
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
                en.SaveChanges();
                XtraMessageBox.Show("Đã lưu lại cấu hình thành công.", "Cấu hình hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XuLyForm.LuuNhatKy("Chỉnh sửa cấu hình hệ thống. ");
            }
            catch (Exception ex)
            {
                XuLyForm.LuuNhatKy("Lỗi cấu hình hệ thống. "+ex.Message);
            }
            
        }

        
    }
}