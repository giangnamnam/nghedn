using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyThiNghe.Reports;

namespace QuanLyThiNghe.Forms
{
    public partial class frmInDanhSach : DevExpress.XtraEditors.XtraForm
    {
        public frmInDanhSach()
        {
            InitializeComponent();
        }


        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            rptDanhSachThiSinhDuThi_Truong rpt = new rptDanhSachThiSinhDuThi_Truong();
            rpt.ShowPreviewDialog();
        }

        private void dropDownButton4_Click(object sender, EventArgs e)
        {
            rptDanhSachMaPhachTheoPhong rpt = new rptDanhSachMaPhachTheoPhong();
            rpt.ShowPreviewDialog();
        }
    }
}