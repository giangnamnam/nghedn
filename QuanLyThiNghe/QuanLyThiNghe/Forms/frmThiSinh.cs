using System;
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
    public partial class frmThiSinh : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        int MaThiSinh = 0;
        public DMKyThi KTHT { get; set; }
        void LoadThiSinh()
        {
            
        }
        
        public frmThiSinh()
        {
            InitializeComponent();
            KTHT = HeThong.KyThiHienTai();
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
            gridControl1.DataSource = _Entities.ThiSinh.Where(d => (d.DaXoa == false || d.DaXoa == null) && d.MaKyThi == KTHT.MaKyThi).ToList();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmTruyVanThiSinh frm = new frmTruyVanThiSinh();
            frm.ShowDialog();
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
