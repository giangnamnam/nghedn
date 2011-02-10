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
    public partial class frmMonThi : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities _entities = new QLTN_Entities();
        int MaMonThi = 0;
        public frmMonThi()
        {
            InitializeComponent();
            LoadMonThi();
        }

        public void LoadMonThi()
        {
            gridControl1.DataSource = _entities.DMMonThi.Where(m => m.DaXoa == false || m.DaXoa == null).Select(m => new { m.DaXoa, m.TenMonThi, m.MaMonThi, SoThiSinh = _entities.ThiSinh.Where(t => t.DMMonThi.MaMonThi == m.MaMonThi).Count() }).OrderBy(m => m.TenMonThi);
        }

        private void frmMonThi_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCapNhatMonThi frm = new frmCapNhatMonThi();
            frm.btnSave.ToolTipTitle = "insert";
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn các môn thi cần xoá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string TenHuyens = "";

            try
            {
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    var TenHuyen = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "TenMonThi").ToString();

                    var h = _entities.DMMonThi.First(d => d.TenMonThi== TenHuyen);

                    h.DaXoa = true;

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
                XuLyForm.LuuNhatKy("Xoá môn thi: " + TenHuyens.Substring(0, TenHuyens.Length - 2));
                LoadMonThi();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmThiSinh frm = new frmThiSinh();
            frm.cbType.SelectedIndex = 2;
            frm.cbItems.Text = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "TenMonThi").ToString();
            frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmCapNhatMonThi frm = new frmCapNhatMonThi();
            frm.btnSave.ToolTipTitle = "update";
            frm.MaMonThi = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "MaMonThi").ToString());
            frm.txtDistrictName.Text = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "TenMonThi").ToString();
            frm.ShowDialog();
        }
    }
}
