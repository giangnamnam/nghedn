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
    public partial class frmKyThi : Form
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        public frmKyThi()
        {
            InitializeComponent();
            LoadKyThi();
        }

        public void LoadKyThi()
        {
            gridControl1.DataSource = _Entities.DMKyThi.Where(d => d.DaXoa == false || d.DaXoa == null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCapNhatKyThi frm = new frmCapNhatKyThi();
            frm.btnSave.ToolTipTitle = "insert";
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn các kỳ thi cần xoá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string TenHuyens = "";

            try
            {
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    var MaHD = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "MaKyThi").ToString());

                    var h = _Entities.DMKyThi.First(d => d.MaKyThi == MaHD);

                    h.DaXoa = true;
                    var TenHuyen = h.TenKyThi;

                    TenHuyens += TenHuyen + ", ";
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
                XuLyForm.LuuNhatKy("Xoá kỳ thi: " + TenHuyens.Substring(0, TenHuyens.Length - 2));
                LoadKyThi();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn kỳ thi cần cập nhật.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var MaHD = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "MaKyThi").ToString());

            frmCapNhatKyThi frm = new frmCapNhatKyThi();
            frm.LoadChiTietKyThi(MaHD);
            frm.ShowDialog();
        }
    }
}
