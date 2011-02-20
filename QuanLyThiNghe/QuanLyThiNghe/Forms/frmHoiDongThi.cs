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
    public partial class frmHoiDongThi : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities _entities = new QLTN_Entities();
        public frmHoiDongThi()
        {
            InitializeComponent();
            LoadHDT();

            btnCreateRooms.Enabled = gvHDT.RowCount > 0;
            btnPrint.Enabled = gvHDT.RowCount > 0;
            btnDelete.Enabled = gvHDT.RowCount > 0;
        }

        private void frmHoiDongThi_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadHDT()
        {
            gcHDT.DataSource = _entities.HoiDongThi.Where(h => h.DaXoa == false || h.DaXoa == null).Select(h => new { h.SoLuongPhongDuTinh, TenTruong = h.DMTruong.TenTruong, h.MaHoiDong, h.SoThiSinhDuTinh });
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
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn các hội đồng thi cần xoá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvHDT.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn hội đồng thi cần cập nhật.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var MaHD = int.Parse(gvHDT.GetRowCellValue(gvHDT.GetSelectedRows()[0], "MaHoiDong").ToString());
            frmCapNhatHDT frm = new frmCapNhatHDT();
            frm.LoadChiTietHDT(MaHD);
            frm.ShowDialog();
        }

        private void danhSáchThíSinhDựThiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xoáHuyệnNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
