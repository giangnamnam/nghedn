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
    public partial class frmThiSinh_ThemMoi : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities _entities = new QLTN_Entities();
        public frmThiSinh_ThemMoi()
        {
            InitializeComponent();
        }

        void LoadHDT()
        {
            cbHDT.Properties.Items.AddRange(_entities.HoiDongThi.Where(h => h.DaXoa == false || h.DaXoa == null).Select(h => new { h.DMTruong.TenTruong }).OrderBy(t => t.TenTruong).ToList());
        }

        void LoadMonThi()
        {
            cbMonThi.Properties.Items.AddRange(_entities.DMMonThi.Where(m => m.DaXoa == false || m.DaXoa == null).Select(m => new { m.TenMonThi }).OrderBy(m => m.TenMonThi).ToList());
        }

        void LoadHuyen()
        {
            cbNoiSinh.Properties.Items.AddRange(_entities.DMHuyen.Where(h => h.DaXoa == false || h.DaXoa == null).Select(h => new { h.TenHuyen }).OrderBy(h => h.TenHuyen).ToList());
        }

        void LoadTruong()
        {
            cbTruong.Properties.Items.AddRange(_entities.DMTruong.Include("DMHuyen").Where(t => t.DaXoa == false || t.DaXoa == null).Select(t => new { t.TenTruong }).OrderBy(t => t.TenTruong).ToList());
        }

        void LoadChiTietThiSinh(int MaThiSinh)
        {
            var thiSinh = _entities.ThiSinh.First(t => t.MaThiSinh == MaThiSinh);
            thiSinh.DMMonThiReference.Load();
            thiSinh.DMTruongReference.Load();

            txtHo.Text = thiSinh.Ho;
            txtTen.Text = thiSinh.Ten;
            txtLop.Text = thiSinh.Lop;
            txtLT.Text = thiSinh.DiemLT.HasValue ? "" : thiSinh.DiemLT.Value.ToString();
            txtTH.Text = thiSinh.DiemTH.HasValue ? "" : thiSinh.DiemTH.Value.ToString();
            txtNgaySinh.Text = thiSinh.NgaySinh;

            cbNoiSinh.SelectedText= thiSinh.NoiSinh;

            if (thiSinh.DMMonThiReference.IsLoaded) cbMonThi.SelectedText = thiSinh.DMMonThi.TenMonThi;
            else cbMonThi.Text = "";

            if (thiSinh.DMTruongReference.IsLoaded) cbTruong.SelectedText = thiSinh.DMTruong.TenTruong;
            else cbTruong.Text = "";

            if (thiSinh.HoiDongThiReference.IsLoaded)
            {
                thiSinh.HoiDongThi.DMTruongReference.Load();
                cbHDT.SelectedText = thiSinh.HoiDongThi.DMTruong.TenTruong;
            }
            else
                cbHDT.Text = "";
        }

        private void frmThiSinh_ThemMoi_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
