﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace QuanLyThiNghe_ThuKy
{
    public partial class frmThuKy : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MonThi MT { get; set; }
        public HoiDongThi HDT { get; set; }
        public ThiSinh TS { get; set; }
        public KyThiHienTai KT { get; set; }

        public int MaHoiDong { get; set; }
        public int MaMonThi { get; set; }
        public int PhongThi { get; set; }

        public string frm_active { get; set; }

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
        

        
        private void frmThuKy_Load(object sender, EventArgs e)
        {
            MT = new MonThi();
            HDT = new HoiDongThi();
            TS = new ThiSinh();
            KT = new KyThiHienTai();
            if (KT.ChoThuKyNhapDiem)
            {
                LoadHoiDongThi();
            }
            else
            {
                XtraMessageBox.Show("Hiện tại chủ tịch chưa gán quyền cho thư ký nhập điểm. \nXin vui lòng liên hệ chủ tịch để có quyền nhập điểm. \nNếu chủ tịch đã gán quyền nhập điểm rồi thì xin vui lòng cập nhật lại dữ liệu thi nghề.", "Thư ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void barEditItem3_EditValueChanged(object sender, EventArgs e)
        {

        }
        
        
        private void le_HoiDong_EditValueChanged(object sender, EventArgs e)
        {
            HDTC();
        }
        private void le_HoiDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            HDTC();
        }
        private void le_MonThi_EditValueChanged(object sender, EventArgs e)
        {
            MTC();
        }
        private void le_MonThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            MTC();
        }
        private void le_Phong_EditValueChanged(object sender, EventArgs e)
        {

            PTC();
        }
        private void le_Phong_ItemClick(object sender, ItemClickEventArgs e)
        {
            PTC();
        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDongBoDuLieu frm = new frmDongBoDuLieu();
            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void btnNhapDiemLyThuyet_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLyThuyet frm = new frmLyThuyet();
            OpenForm(frm);
        }
        private void btnNhapDiemThucHanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThucHanh frm = new frmThucHanh();
            OpenForm(frm);
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCapNhatDuLieu frm = new frmCapNhatDuLieu();
            frm.ShowDialog();
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Lưu
            Luu();
            
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Lưu và qua phòng thi tiếp theo.
            Luu();
            int index = repositoryItemLookUpEdit3.GetDataSourceRowIndex(repositoryItemLookUpEdit3.Columns["PhongThi"], le_Phong.EditValue); //  .Items.IndexOf(barEditItem1.EditValue
            DataTable tbl = (DataTable)repositoryItemLookUpEdit3.DataSource;
            if (tbl != null)
            {
                if (index == (tbl.Rows.Count - 1))
                {
                    XtraMessageBox.Show("Đã chấm điểm đến phòng cuối cùng.", "Thư ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (index < tbl.Rows.Count)
                {
                    le_Phong.EditValue = tbl.Rows[index + 1][0];
                }
            }
            
                

        }
        
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLyThuyet frm = new frmLyThuyet();
            OpenForm(frm);
        }
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThucHanh frm = new frmThucHanh();
            OpenForm(frm);
        }
        
        void OpenForm(Form frm)
        {
            frm.MdiParent = this;

            if (frm.Name == "frmLyThuyet")
            {
                ((frmLyThuyet)frm).LoadDanhSachThiSinh(MaHoiDong, MaMonThi, PhongThi);
            }
            else if (frm.Name == "frmThucHanh")
            {
                ((frmThucHanh)frm).LoadDanhSachThiSinh(MaHoiDong, MaMonThi, PhongThi);
            }
            if (Application.OpenForms[frm.Name] != null)
            {
                if (frm.Name == "frmLyThuyet")
                {
                    ((frmLyThuyet)Application.OpenForms[frm.Name]).LoadDanhSachThiSinh(MaHoiDong, MaMonThi, PhongThi);
                }
                else if (frm.Name == "frmThucHanh")
                {
                    ((frmThucHanh)Application.OpenForms[frm.Name]).LoadDanhSachThiSinh(MaHoiDong, MaMonThi, PhongThi);
                }
                Application.OpenForms[frm.Name].Activate();
            }
            else
            {
                //AddOpenWindow(frm);
                
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
        public void ghiChuTinhTrang(string NoiDung)
        {
            lblStatus.Caption = NoiDung;
        }
        private void LoadMonThiTheoHoiDong(int MaHoiDong)
        {
            try
            {
                DataTable DSTStheoHD = TS.Table.Clone();
                string expression = "(Convert(" + "MaHoiDong" + ",'System.Int32') = " + MaHoiDong + ")";
                DataRow[] drs = TS.Table.Select(expression);
                foreach (DataRow item in drs)
                {
                    DSTStheoHD.ImportRow(item);
                }

                DataTable DSMTtheoHD = DSTStheoHD.DefaultView.ToTable(true, "MaMonThi");
                DSMTtheoHD.Columns.Add("TenMonThi");

                foreach (DataRow r in MT.Table.Rows)
                {
                    foreach (DataRow rw in DSMTtheoHD.Rows)
                    {
                        if (r["MaMonThi"].ToString() == rw["MaMonThi"].ToString())
                        {
                            rw["TenMonThi"] = r["TenMonThi"].ToString();
                            break;
                        }
                    }
                }
                if (repositoryItemLookUpEdit2.Columns.Count < 1)
                {
                    repositoryItemLookUpEdit2.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenMonThi"));
                    repositoryItemLookUpEdit2.DisplayMember = "TenMonThi";
                    repositoryItemLookUpEdit2.ValueMember = "MaMonThi";
                }
                repositoryItemLookUpEdit2.DataSource = DSMTtheoHD;
            }
            catch (Exception ex)
            {
            }

        }
        private void LoadPhongThiTheoHoiDongVaMonThi(int MaHoiDong, int MaMonThi)
        {
            try
            {
                DataTable DSTStheoHDvaMonThi = TS.Table.Clone();
                string expression = "(Convert(" + "MaHoiDong" + ",'System.Int32') = " + MaHoiDong + ")";
                expression += "and (Convert(" + "MaMonThi" + ",'System.Int32') = " + MaMonThi + ")";
                DataRow[] drs = TS.Table.Select(expression);
                foreach (DataRow item in drs)
                {
                    DSTStheoHDvaMonThi.ImportRow(item);
                }

                DataTable tblPhong = DSTStheoHDvaMonThi.DefaultView.ToTable(true, "PhongThi");


                if (repositoryItemLookUpEdit3.Columns.Count < 1)
                {
                    repositoryItemLookUpEdit3.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PhongThi"));
                    repositoryItemLookUpEdit3.DisplayMember = "PhongThi";
                    repositoryItemLookUpEdit3.ValueMember = "PhongThi";
                }
                repositoryItemLookUpEdit3.DataSource = tblPhong;
            }
            catch (Exception ex)
            {
            }
        }
        private void HDTC()
        {
            MaHoiDong = int.Parse(le_HoiDong.EditValue != null ? le_HoiDong.EditValue.ToString() : "0");
            LoadMonThiTheoHoiDong(MaHoiDong);
            le_MonThi.Enabled = true;
            le_Phong.Enabled = false;
            MaMonThi = int.Parse(le_MonThi.EditValue != null ? le_MonThi.EditValue.ToString() : "0");
            PhongThi = 0;
        }
        private void MTC()
        {
            MaMonThi = int.Parse(le_MonThi.EditValue != null ? le_MonThi.EditValue.ToString() : "0");
            LoadPhongThiTheoHoiDongVaMonThi(MaHoiDong, MaMonThi);
            le_Phong.Enabled = true;
            PhongThi = int.Parse(le_Phong.EditValue != null ? le_Phong.EditValue.ToString() : "0");
        }
        private void PTC()
        {
            try
            {
                int a;
                bool coPhongThi = int.TryParse(le_Phong.EditValue != null ? le_Phong.EditValue.ToString() : "0", out a);
                PhongThi = a;
                if (this.MdiChildren.Length > 0 && coPhongThi)
                {
                    if (frm_active == "frmThucHanh")
                    {
                        OpenForm(new frmThucHanh());
                    }
                    else if (frm_active == "frmLyThuyet")
                    {
                        OpenForm(new frmLyThuyet());
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        private void LoadHoiDongThi()
        {
            repositoryItemLookUpEdit1.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTruong"));
            repositoryItemLookUpEdit1.DisplayMember = "TenTruong";
            repositoryItemLookUpEdit1.ValueMember = "MaHoiDong";
            repositoryItemLookUpEdit1.DataSource = HDT.Table;
            le_MonThi.Enabled = false;
            le_Phong.Enabled = false;

        }
        private void Luu()
        {
            if (this.MdiChildren.Length > 0)
            {
                if (frm_active == "frmThucHanh")
                {
                    ((frmThucHanh)Application.OpenForms["frmThucHanh"]).Luu();
                }
                else if (frm_active == "frmLyThuyet")
                {
                    ((frmLyThuyet)Application.OpenForms["frmLyThuyet"]).Luu();
                }
            }
        }
    }
}