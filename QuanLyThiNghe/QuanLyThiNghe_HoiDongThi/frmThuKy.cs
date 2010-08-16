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
            frmLyThuyet frm = new frmLyThuyet();
            OpenForm(frm);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCapNhatDuLieu frm = new frmCapNhatDuLieu();
            OpenForm(frm);
        }

        private void btnNhapDiemThucHanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThucHanh frm = new frmThucHanh();
            frm.MdiParent = this;
            OpenForm(frm);
        }





        void OpenForm(Form frm)
        {
            if (Application.OpenForms[frm.Name] != null)
                Application.OpenForms[frm.Name].Activate();
            else
            {
                //AddOpenWindow(frm);
                frm.MdiParent = this;
                frm.Show();
            }
        }




    }
}