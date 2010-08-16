﻿using System;
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
        QLTN_Entities _entities = new QLTN_Entities();
        public frmHoiDongThi()
        {
            InitializeComponent();
            LoadHDT();
        }

        private void frmHoiDongThi_Load(object sender, EventArgs e)
        {
            
        }

        void LoadHDT()
        {
            gcHDT.DataSource = _entities.HoiDongThi.Select(h => new { h.SoLuongPhongDuTinh, h.DMTruong.TenTruong, h.MaHoiDong, h.SoThiSinhDuTinh });
        }

        private void btnCreateRooms_Click(object sender, EventArgs e)
        {
            frmTaoPhongThi frm = new frmTaoPhongThi();
            frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gcHDT.ShowPrintPreview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCapNhatHDT frm = new frmCapNhatHDT();
            frm.btnSave.ToolTipTitle = "insert";
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvHDT.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn các môn thi cần xoá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string TenHuyens = "";

            try
            {
                for (int i = 0; i < gvHDT.SelectedRowsCount; i++)
                {
                    var MaHD = int.Parse(gvHDT.GetRowCellValue(gvHDT.GetSelectedRows()[i], "MaHoiDong").ToString());

                    var h = _entities.HoiDongThi.First(d => d.MaHoiDong == MaHD);
                    h.DMTruongReference.Load();

                    h.DaXoa = true;
                    var TenHuyen = h.DMTruong.TenTruong;

                    TenHuyens += TenHuyen + ", ";
                }
                _entities.SaveChanges();
            }
            catch (Exception exp)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Xoá không thành công: " + exp.Message);
                return;

            }
            finally
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Đã xoá thành công.");
                XuLyForm.LuuNhatKy("Xoá hội đồng thi: " + TenHuyens.Substring(0, TenHuyens.Length - 2));
                LoadHDT();
            }
        }
    }
}
