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
        public System.Collections.ArrayList TaiKhoanHienTai { get; set; }
        public frmThuKy()
        {
            InitializeComponent();
            frmDangNhap frm = new frmDangNhap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TaiKhoanHienTai = frm.TaiKhoanDangNhap;
                this.Tag = TaiKhoanHienTai;
                DataRow dr = (DataRow)TaiKhoanHienTai[0];
                tbnThuKy1.Caption = "Thư ký 1: " + dr["TenDangNhap"].ToString() + " (" + dr["HoVaTen"].ToString() + ")";
                if (TaiKhoanHienTai.Count > 1)
                {
                    dr = (DataRow)TaiKhoanHienTai[1];
                    btnThuKy2.Caption = "Thư ký 2: " + dr["TenDangNhap"].ToString() + " (" + dr["HoVaTen"].ToString() + ")";
                }
                else
                {
                    btnThuKy2.Visibility = btnThuKy3.Visibility = BarItemVisibility.Never;
                }
                if (TaiKhoanHienTai.Count > 2)
                {
                    dr = (DataRow)TaiKhoanHienTai[2];
                    btnThuKy3.Caption = "Thư ký 3: " + dr["TenDangNhap"].ToString() + " (" + dr["HoVaTen"].ToString() + ")";
                }
                else
                {
                    btnThuKy3.Visibility = BarItemVisibility.Never;
                }
                

            }
            else
            {
                this.Close();
            }
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

        private void frmThuKy_Load(object sender, EventArgs e)
        {
            
        }




    }
}