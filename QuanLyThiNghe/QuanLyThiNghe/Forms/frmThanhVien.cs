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
    public partial class frmThanhVien : Form
    {
        QLTN_Entities en = new QLTN_Entities();
        public int MaPhanQuyen { get; set; }

        public frmThanhVien()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmThanhVien_ThemMoi frm = new frmThanhVien_ThemMoi();
            if (frm.ShowDialog()== DialogResult.OK)
            {
                loadThanhVien();
            }
            
        }
        private void thêmHuyệnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThanhVien_ThemMoi frm = new frmThanhVien_ThemMoi();
            frm.ShowDialog();
        }
        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            loadThanhVien();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            EditThanhVien();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DeleteThanhVien();
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
        private void chỉnhSửaHuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditThanhVien();
        }

        private void danhSáchThíSinhDựThiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void xoáHuyệnNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteThanhVien();
        }
        private void xoáCácHuyệnĐượcChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadThanhVien()
        {
            if (MaPhanQuyen != 0)
            {
                en.Refresh(System.Data.Objects.RefreshMode.ClientWins, en.TaiKhoan);
                var TaiKhoans = en.TaiKhoan.Where(x => ((x.DaXoa == null || x.DaXoa == false) && x.PhanQuyen.MaPhanQuyen == MaPhanQuyen)).Select(tk => new { tk.TenDangNhap, tk.HoVaTen, tk.DienThoai, tk.MAC, tk.PhanQuyen.TenQuyen, tk.NguoiTao, tk.NguoiCapNhat, tk.NgayTao, tk.NgayCapNhat });//Where(t => t.DMHuyen.TenHuyen == tenhuyen).Select(t1 => new { t1.TenTruong, SoThiSinh = t1.ThiSinh.Count });
                int st = gridView1.TopRowIndex;
                int[] sindex = gridView1.GetSelectedRows();
                gridControl1.DataSource = TaiKhoans;
                gridView1.TopRowIndex = st;
                foreach (int item in sindex)
                {
                    gridView1.FocusedRowHandle = item;
                }
            }
            else
            {
                en.Refresh(System.Data.Objects.RefreshMode.ClientWins, en.TaiKhoan);
                var TaiKhoans = en.TaiKhoan.Where(x => (x.DaXoa == null || x.DaXoa == false)).Select(tk => new { tk.TenDangNhap, tk.HoVaTen, tk.DienThoai, tk.MAC, tk.PhanQuyen.TenQuyen, tk.NguoiTao, tk.NguoiCapNhat, tk.NgayTao, tk.NgayCapNhat });//Where(t => t.DMHuyen.TenHuyen == tenhuyen).Select(t1 => new { t1.TenTruong, SoThiSinh = t1.ThiSinh.Count });
                int st = gridView1.TopRowIndex;
                int[] sindex = gridView1.GetSelectedRows();
                gridControl1.DataSource = TaiKhoans;
                gridView1.TopRowIndex = st;
                foreach (int item in sindex)
                {
                    gridView1.FocusedRowHandle = item;
                }
            }
        }
        private void EditThanhVien()
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                string username = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "TenDangNhap").ToString();
                frmThanhVien_ThemMoi frm = new frmThanhVien_ThemMoi();
                en.Refresh(System.Data.Objects.RefreshMode.ClientWins, en.TaiKhoan);
                TaiKhoan tk = (from t in en.TaiKhoan where t.TenDangNhap == username select t).First();
                frm.pTaiKhoan = tk;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadThanhVien();
                }
            }
        }
        private void DeleteThanhVien()
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                string username = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "TenDangNhap").ToString();
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chắc rằng muốn xóa tài khoản "+username+" ?", "Tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    en.Refresh(System.Data.Objects.RefreshMode.ClientWins, en.TaiKhoan);
                    TaiKhoan tk = (from t in en.TaiKhoan where t.TenDangNhap == username select t).First();
                    tk.DaXoa = true;

                    tk.NguoiCapNhat = ((frmMain)this.ParentForm).TaiKhoanHienTai.TenDangNhap;
                    tk.NgayCapNhat = (from s in en.HeThong select s).First().GioHeThong;
                    en.SaveChanges();
                    loadThanhVien();
                }
            }
        }

    }
}
