using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QuanLyThiNghe_ThuKy
{
    public partial class frmThuKy : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmThuKy()
        {
            InitializeComponent();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapDiemLyThuyet_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCapNhatDuLieu frm = new frmCapNhatDuLieu();
            frm.ShowDialog();
        }
        


    }
}