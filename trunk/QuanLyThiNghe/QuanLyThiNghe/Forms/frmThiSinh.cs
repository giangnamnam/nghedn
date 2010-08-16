﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThiNghe;
using DevExpress.XtraEditors.Controls;

namespace QuanLyThiNghe.Forms
{
    public partial class frmThiSinh : Form
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        int MaThiSinh = 0;

        void LoadThiSinh()
        {
            cbItems.Properties.Items.Clear();
            cbItems.Text = "";
            switch (cbType.SelectedIndex)
            {
                case 0:
                    LoadTruong();
                    break;
                case 1:
                    LoadHuyen();
                    break;
                case 2:
                    LoadMonThi();
                    break;
                case 3:
                    LoadHDT();
                    break;
                default:
                    LoadTruong();
                    break;
            }
            
        }

        void LoadTruong()
        {
            var source = _Entities.DMTruong.Where(t => t.DaXoa == false || t.DaXoa == null).OrderBy(t => t.TenTruong);

            foreach (var item in source)
            {
                ImageComboBoxItem i = new ImageComboBoxItem();
                i.Value = item.TenTruong;
                i.Description = item.MaTruong.ToString();

                cbItems.Properties.Items.Add(i);
            }
            
        }

        void LoadHuyen()
        {
            var source = _Entities.DMHuyen.Where(t => t.DaXoa == false || t.DaXoa == null).OrderBy(t => t.TenHuyen);

            foreach (var item in source)
            {
                ImageComboBoxItem i = new ImageComboBoxItem();
                i.Value = item.TenHuyen;
                i.Description = item.MaHuyen.ToString();

                cbItems.Properties.Items.Add(i);
            }
        }

        void LoadMonThi()
        {
            var source = _Entities.DMMonThi.Where(t => t.DaXoa == false || t.DaXoa == null).OrderBy(t => t.TenMonThi);

            foreach (var item in source)
            {
                ImageComboBoxItem i = new ImageComboBoxItem();
                i.Value = item.TenMonThi;
                i.Description = item.MaMonThi.ToString();

                cbItems.Properties.Items.Add(i);
            }
        }

        void LoadHDT()
        {
            var source = _Entities.HoiDongThi.Where(t => t.DaXoa == false || t.DaXoa == null).Select(t => new { t.MaHoiDong, t.DMTruong.TenTruong }).OrderBy(t => t.TenTruong);

            foreach (var item in source)
            {
                ImageComboBoxItem i = new ImageComboBoxItem();
                i.Value = item.TenTruong;
                i.Description = item.MaHoiDong.ToString();

                cbItems.Properties.Items.Add(i);
            }
        }

        void LoadThiSinhTheoTruong(int MaTruong)
        {
            var source = _Entities.ThiSinh.Where(t => t.DMTruong.MaTruong == MaTruong && t.DaXoa == false || t.DaXoa == null).OrderBy(t => t.Ten);

            gridControl1.DataSource = source;
        }

        void LoadThiSinhTheoHuyen(int MaHuyen)
        {
            var source = _Entities.ThiSinh.Where(t => t.DMTruong.DMHuyen.MaHuyen == MaHuyen && t.DaXoa == false || t.DaXoa == null).OrderBy(t => t.Ten);

            gridControl1.DataSource = source;
        }

        void LoadThiSinhTheoMonThi(int MaMonThi)
        {
            var source = _Entities.ThiSinh.Where(t => t.DMMonThi.MaMonThi == MaMonThi && t.DaXoa == false || t.DaXoa == null).OrderBy(t => t.Ten);

            gridControl1.DataSource = source;
        }

        void LoadThiSinhTheoHDT(int MaHDT)
        {
            var source = _Entities.ThiSinh.Where(t => t.HoiDongThi.MaHoiDong == MaHDT && t.DaXoa == false || t.DaXoa == null).OrderBy(t => t.Ten);

            gridControl1.DataSource = source;
        }

        public frmThiSinh()
        {
            InitializeComponent();
            LoadTruong();
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

        private void frmThiSinh_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSelecteds_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn các thí sinh cần xoá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string TenThiSinhs = "";

            try
            {
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    MaThiSinh = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "MaThiSinh").ToString());

                    var h = _Entities.ThiSinh.First(d => d.MaThiSinh == MaThiSinh);

                    h.DaXoa = true;

                    TenThiSinhs += h.Ho + " " + h.Ten + ", ";
                }
                _Entities.SaveChanges();
            }
            catch (Exception exp)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Xoá không thành công: " + exp.Message);
                return;

            }
            finally
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Đã xoá thành công.");
                XuLyForm.LuuNhatKy("Các thí sinh đã xoá: " + TenThiSinhs.Substring(0, TenThiSinhs.Length - 2));
                LoadThiSinh();
            }
        }

        private void cbType_TextChanged(object sender, EventArgs e)
        {
            LoadThiSinh();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void cbItems_TextChanged(object sender, EventArgs e)
        {
            if (cbItems.Text == "") return;
            switch (cbType.SelectedIndex)
            {
                case 0:
                    LoadThiSinhTheoTruong(_Entities.DMTruong.Where(t => t.TenTruong == cbItems.Text).FirstOrDefault().MaTruong);
                    break;
                case 1:
                    LoadThiSinhTheoHuyen(_Entities.DMHuyen.Where(t => t.TenHuyen == cbItems.Text).FirstOrDefault().MaHuyen);
                    break;
                case 2:
                    LoadThiSinhTheoMonThi(_Entities.DMMonThi.Where(t => t.TenMonThi == cbItems.Text).FirstOrDefault().MaMonThi);
                    break;
                case 3:
                    LoadThiSinhTheoHDT(_Entities.HoiDongThi.Where(t => t.DMTruong.TenTruong == cbItems.Text).FirstOrDefault().MaHoiDong);
                    break;
                default:
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn thí sinh cần xoá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MaThiSinh = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "MaThiSinh").ToString());
            var h = _Entities.ThiSinh.First(d => d.MaThiSinh == MaThiSinh);
            var tenTS = h.Ho + " " + h.Ten;

            h.DaXoa = true;
            try
            {
                _Entities.SaveChanges();
            }
            catch (Exception exp)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Có lỗi xảy ra: " + exp.Message);
                return;
            }
            finally
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Đã xoá thành công.");
                XuLyForm.LuuNhatKy("Xoá thí sinh: " + tenTS);
            }
        }
    }
}
