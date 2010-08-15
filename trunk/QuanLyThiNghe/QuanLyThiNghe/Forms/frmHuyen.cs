using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThiNghe;

namespace QuanLyThiNghe.Forms
{
    public partial class frmHuyen : Form
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        int MaHuyen = 0;
        public frmHuyen()
        {
            InitializeComponent();
        }

        private void frmHuyen_Load(object sender, EventArgs e)
        {
            LoadDistricts();
        }

        public void LoadDistricts()
        {
            var Huyen = _Entities.DMHuyen.Where(h => h.DaXoa == false).Select(h => new { h.TenHuyen, h.MaHuyen, h.NgayCapNhat, h.NgayTao, h.NguoiCapNhat, h.NguoiTao, SoTruong = h.DMTruong.Count }).OrderBy(h => h.TenHuyen);
            gvDistricts.DataSource = Huyen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //gridView1.AddNewRow();

            frmCapNhatHuyen frm = new frmCapNhatHuyen();
            frm.btnSave.ToolTipTitle = "insert";
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn huyện cần xoá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MaHuyen = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "MaHuyen").ToString());
            var h = _Entities.DMHuyen.First(d => d.MaHuyen == MaHuyen);
            var tenHuyen = h.TenHuyen;

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
                XuLyForm.LuuNhatKy("Xoá huyện: " + tenHuyen);
                LoadDistricts();
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn các huyện cần xoá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string TenHuyens = "";

            try
            {
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    var TenHuyen = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "TenHuyen").ToString();

                    var h = _Entities.DMHuyen.First(d => d.TenHuyen == TenHuyen);

                    h.DaXoa = true;

                    TenHuyens += TenHuyen + ", ";
                }
                _Entities.SaveChanges();
            }
            catch (Exception exp)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Xoá thành công: " + exp.Message);
                return;

            }
            finally
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Đã xoá thành công.");
                XuLyForm.LuuNhatKy("Xoá huyện: " + TenHuyens.Substring(0, TenHuyens.Length - 2));
                LoadDistricts();
            }
        }

        private void btnViewSchoolInDistricts_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn huyện cần xem.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string TenHuyen = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "TenHuyen").ToString();

            frmTruong frm = new frmTruong();

            frm.LoadSchools(TenHuyen);
            
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gvDistricts.ShowPrintPreview();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int MaHuyen = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "MaHuyen").ToString());
            var TenHuyen = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "TenHuyen").ToString();

            frmCapNhatHuyen frm = new frmCapNhatHuyen();
            frm.MaHuyen = MaHuyen;
            frm.btnSave.ToolTipTitle = "update";
            frm.txtDistrictName.Text = TenHuyen;
            frm.ShowDialog();
        }
    }
}
