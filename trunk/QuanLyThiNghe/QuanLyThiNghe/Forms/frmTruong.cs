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
    public partial class frmTruong : Form
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        int MaTruong = 0;
        public frmTruong()
        {
            InitializeComponent();

            cbHuyen.Properties.Items.Add("[...]");
            cbHuyen.Properties.Items.AddRange(_Entities.DMHuyen.Where(t => t.DaXoa == false || t.DaXoa == null).Select(h => h.TenHuyen).ToList());

            LoadSchools("");
        }

        public void LoadSchools(string TenHuyen)
        {
            var schools = _Entities.DMTruong.Include("DMHuyen").Where(t => t.DaXoa == false || t.DaXoa == null).ToList();
            TenHuyen = TenHuyen == "[...]" ? "" : TenHuyen;

            if (TenHuyen != "")
            {
                schools = schools.Where(t => t.DMHuyen.TenHuyen == TenHuyen).ToList();
            }

            gridControl1.DataSource = schools.Select(t1 => new { t1.MaTruong, t1.TenTruong, SoThiSinh = t1.ThiSinh.Count, t1.DMHuyen.TenHuyen, HDT = (_Entities.HoiDongThi.Where(h=>h.DMTruong.MaTruong == t1.MaTruong).Count()) == 1 }).ToList();
        }

        private void cbTruong_TextChanged(object sender, EventArgs e)
        {
            LoadSchools(cbHuyen.SelectedText);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCapNhatTruong frm = new frmCapNhatTruong();
            frm.btnSave.ToolTipTitle = "insert";
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn trường cần xoá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var TenTruong = "";
            try
            {
                MaTruong = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "MaTruong").ToString());
                var h = _Entities.DMTruong.First(d => d.MaTruong == MaTruong);
                TenTruong = h.TenTruong;

                h.DaXoa = true;

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
                XuLyForm.LuuNhatKy("Xoá trường: " + TenTruong);
                LoadSchools(cbHuyen.SelectedText);
            }
        }

        private void btnThiSinh_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MaTruong = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "MaTruong").ToString());
            var TenTruong = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "TenTruong").ToString();
            var TenHuyen = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "TenHuyen").ToString();

            frmCapNhatTruong frm = new frmCapNhatTruong();
            frm.MaTruong = MaTruong;
            frm.btnSave.ToolTipTitle = "update";
            frm.txtSchoolName.Text = TenTruong;
            frm.cbHuyen.Text = TenHuyen;

            frm.ShowDialog();
            
        }

        private void btnDeleteSelecteds_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn các trường cần xoá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string TenTruongs = "";

            try
            {
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    var TenTruong = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "TenTruong").ToString();

                    var h = _Entities.DMTruong.First(d => d.TenTruong == TenTruong);

                    h.DaXoa = true;

                    TenTruongs += TenTruong + ", ";
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
                XuLyForm.LuuNhatKy("Xoá trường: " + TenTruongs.Substring(0, TenTruongs.Length - 2));
                LoadSchools(cbHuyen.SelectedText);
            }
        }

        private void frmTruong_Load(object sender, EventArgs e)
        {

        }


    }
}
