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
    public partial class frmDongBoDuLieu : DevExpress.XtraEditors.XtraForm
    {
        ThiSinh TS = new ThiSinh();
        NhatKy NK = new NhatKy();
        public frmDongBoDuLieu()
        {
            InitializeComponent();
        }

        private void frmDongBoDuLieu_Load(object sender, EventArgs e)
        {
            LoadThongTin();            
        }

        private void LoadThongTin()
        {
            lblTongBaiDaChamDiem.Text = TS.LayTongSoThiSinhDaCoDiem().ToString();
            lblLT.Text = TS.LayTongSoThiSinhDaCoDiemLyThuyet().ToString();
            lblTH.Text = TS.LayTongSoThiSinhDaCoDiemThucHanh().ToString();
            lblHDT.Text = TS.DemTongSoHoiDongThiDaCoDiem().ToString();
            lblMT.Text = TS.DemTongSoMonThiDaCoDiem().ToString();
            lblPhong.Text = TS.DemTongSoPhongThiDaCoDiem().ToString();
            lblDaDongBo.Text = TS.DemTongSoThiSinhDaDongBo().ToString();
            lblChuaDongBo.Text = (int.Parse(lblTongBaiDaChamDiem.Text) - int.Parse(lblDaDongBo.Text)).ToString();
            lblThaoTac.Text = NK.Table.Rows.Count.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            //đồng bộ hóa điểm.
            int dbhd = TS.DongBoHoaDiem();
            XtraMessageBox.Show("Số bài được đồng bộ: "+dbhd.ToString()+".", "Đồng bộ dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //đồng bộ hóa nhật ký.


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
    }
}