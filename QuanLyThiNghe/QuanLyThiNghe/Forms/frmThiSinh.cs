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
    public partial class frmThiSinh : Form
    {
        public frmThiSinh()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            frmThiSinh_ThemMoi frm = new frmThiSinh_ThemMoi();
            frm.ShowDialog();
        }

        private void btnInpuMark_Click(object sender, EventArgs e)
        {
            frmNhapDiem frm = new frmNhapDiem();
            frm.ShowDialog();
        }
    }
}
