using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThiNghe.Forms
{
    public partial class frmHoiDongThi : Form
    {
        QLTN_Entities en = new QLTN_Entities();
        public frmHoiDongThi()
        {
            InitializeComponent();
        }

        private void frmHoiDongThi_Load(object sender, EventArgs e)
        {
            
        }

        void LoadHDT()
        {
            gcHDT.DataSource = en.HoiDongThi.Select(h => new { h.SoLuongPhongDuTinh, h.DMTruong.TenTruong });
        }

        private void btnCreateRooms_Click(object sender, EventArgs e)
        {
            frmTaoPhongThi frm = new frmTaoPhongThi();
            frm.ShowDialog();
        }

        private void gcHDT_Load(object sender, EventArgs e)
        {
            LoadHDT();
        }
    }
}
