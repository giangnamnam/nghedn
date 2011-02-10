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

    public partial class frmNhatKyDangNhap : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities en = new QLTN_Entities();
        public string pTenDangNhap { get; set; }
        public frmNhatKyDangNhap()
        {
            InitializeComponent();
        }

        private void frmNhatKyDangNhap_Load(object sender, EventArgs e)
        {
            loadNhatKy();
        }
        private void loadNhatKy()
        {
            DateTime tuNgay = DateTime.Parse("1754/01/01");
            DateTime denNgay = DateTime.MaxValue;

            en.Refresh(System.Data.Objects.RefreshMode.ClientWins, en.NhatKy);

            if (dateEdit1.Text !="" && dateEdit2.Text!="")
            {
                if (dateEdit2.DateTime<dateEdit1.DateTime)
                {
                    tuNgay = dateEdit2.DateTime;
                    dateEdit2.DateTime = dateEdit1.DateTime;
                    dateEdit1.DateTime = tuNgay;
                }
                tuNgay = DateTime.Parse(dateEdit1.DateTime.ToString("yyyy/MM/dd"));
                denNgay = DateTime.Parse(dateEdit2.DateTime.ToString("yyyy/MM/dd") + " 11:59:59 PM");
            }

            
            
            
            try
            {
                if (string.IsNullOrEmpty(pTenDangNhap))
                {
                    var NhatKys = en.NhatKy.Where
                        (x => ((x.DaXoa == null || x.DaXoa == false) && (x.NgayThaoTac >= tuNgay) && (x.NgayThaoTac <= denNgay))).Select(tk => new { tk.TaiKhoan.TenDangNhap, tk.TaiKhoan.HoVaTen, tk.TaiKhoan.PhanQuyen.TenQuyen, tk.NgayThaoTac, tk.ThaoTac, tk.ComputerUser, tk.IP, tk.MaNhatKy });
                    int st = gridView1.TopRowIndex;
                    int[] sindex = gridView1.GetSelectedRows();
                    gridControl1.DataSource = NhatKys;
                    gridView1.TopRowIndex = st;
                    foreach (int item in sindex)
                    {
                        gridView1.FocusedRowHandle = item;
                    }
                }
                else
                {

                    var NhatKys = en.NhatKy.Where(x => ((x.DaXoa == null || x.DaXoa == false) && (x.NgayThaoTac >= tuNgay) && (x.NgayThaoTac <= denNgay) && x.TaiKhoan.TenDangNhap == pTenDangNhap)).Select(tk => new { tk.TaiKhoan.TenDangNhap, tk.TaiKhoan.HoVaTen, tk.TaiKhoan.PhanQuyen.TenQuyen, tk.NgayThaoTac, tk.ThaoTac, tk.ComputerUser, tk.IP, tk.MaNhatKy });
                    int st = gridView1.TopRowIndex;
                    int[] sindex = gridView1.GetSelectedRows();
                    gridControl1.DataSource = NhatKys;
                    gridView1.TopRowIndex = st;
                    foreach (int item in sindex)
                    {
                        gridView1.FocusedRowHandle = item;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //xóa
            deleteNhatKy();
        }
        private void deleteNhatKy()
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    int index = gridView1.GetSelectedRows()[i];
                    string Ma1 = gridView1.GetRowCellValue(index, "MaNhatKy").ToString();
                    int Ma = int.Parse(Ma1);
                    NhatKy nk = (from t in en.NhatKy where t.MaNhatKy == Ma select t).First();
                    nk.NgayCapNhat = HeThong.LayGioHeThong();
                    nk.NguoiCapNhat = HeThong.TaiKhoanDangNhap().TenDangNhap;
                    nk.DaXoa = true;
                }
                en.SaveChanges();
                XuLyForm.LuuNhatKy("Xóa nhật ký");
                loadNhatKy();
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            loadNhatKy();
        }
        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            loadNhatKy();
        }
        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {
            loadNhatKy();
        }
        private void danhSáchThíSinhDựThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int index = gridView1.GetSelectedRows()[0];
                string Ma1 = gridView1.GetRowCellValue(index, "TenDangNhap").ToString();
                TaiKhoan tk = (from t in en.TaiKhoan where t.TenDangNhap == Ma1 select t).First();
                frmThanhVien_ThemMoi frm = new frmThanhVien_ThemMoi();
                frm.pTaiKhoan = tk;
                frm.ShowDialog();
            }
        }

        private void xoáHuyệnNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteNhatKy();
        }
    }
}
