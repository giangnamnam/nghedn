using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThiNghe_ThuKy
{
    public partial class frmCapNhatDuLieu : DevExpress.XtraEditors.XtraForm
    {
        DialogResult rs = DialogResult.Cancel;

        public frmCapNhatDuLieu()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapNhatDuLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = rs;
        }

        private void btmUpdate_Click(object sender, EventArgs e)
        {

            if (chkTaiKhoan.Checked)
            {
                if (!XuLyDuLieu.CapNhatTaiKhoan())
                    labelControl1.Appearance.ImageIndex = 1;
                else
                    labelControl1.Appearance.ImageIndex = 0;
            }


            if (chkKyThiHienTai.Checked)
            {
                if (!XuLyDuLieu.CapNhatKyThiHienTai())
                    labelControl2.Appearance.ImageIndex = 1;
                else
                    labelControl2.Appearance.ImageIndex = 0;
            }

            if (chkNhatKy.Checked)
            {
                if (!XuLyDuLieu.CapNhatNhatKy())
                    labelControl3.Appearance.ImageIndex = 1;
                else
                    labelControl3.Appearance.ImageIndex = 0;
            }

            if (chkHoiDong.Checked)
            {
                if (!XuLyDuLieu.CapNhatHoiDongThi())
                    labelControl4.Appearance.ImageIndex = 1;
                else
                    labelControl4.Appearance.ImageIndex = 0;
            }

            if (chkMonThi.Checked)
            {
                if (!XuLyDuLieu.CapNhatMonThi())
                    labelControl5.Appearance.ImageIndex = 1;
                else
                    labelControl5.Appearance.ImageIndex = 0;
            }

            if (chkThiSinh.Checked)
            {
                if (!XuLyDuLieu.CapNhatDanhSachThiSinh())
                    labelControl6.Appearance.ImageIndex = 1;
                else
                    labelControl6.Appearance.ImageIndex = 0;
            }
            XtraMessageBox.Show("Đã cập nhật thành công.", "Cập nhật dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            rs = DialogResult.OK;
            XuLyForm.LuuNhatKy(2, "Cập nhật dữ liệu thi nghề");

        }

        private void frmCapNhatDuLieu_Load(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            chkTaiKhoan.Checked = !dp.CoTaiKhoan;
            if (chkTaiKhoan.Checked)
                labelControl1.Appearance.ImageIndex = 1;
            else
                labelControl1.Appearance.ImageIndex = 0;

            chkKyThiHienTai.Checked = !dp.CoKyThiHienTai;
            if (chkKyThiHienTai.Checked)
                labelControl2.Appearance.ImageIndex = 1;
            else
                labelControl2.Appearance.ImageIndex = 0;

            chkNhatKy.Checked = !dp.CoNhatKy;
            if (chkNhatKy.Checked)
                labelControl3.Appearance.ImageIndex = 1;
            else
                labelControl3.Appearance.ImageIndex = 0;

            chkHoiDong.Checked = !dp.CoHoiDong;
            if (chkHoiDong.Checked)
                labelControl4.Appearance.ImageIndex = 1;
            else
                labelControl4.Appearance.ImageIndex = 0;

            chkMonThi.Checked = !dp.CoMonThi;
            if (chkMonThi.Checked)
                labelControl5.Appearance.ImageIndex = 1;
            else
                labelControl5.Appearance.ImageIndex = 0;

            chkThiSinh.Checked = !dp.CoThiSinh;
            if (chkThiSinh.Checked)
                labelControl6.Appearance.ImageIndex = 1;
            else
                labelControl6.Appearance.ImageIndex = 0;

        }
    }
}