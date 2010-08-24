using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThiNghe_ThuKy
{
    public partial class frmLyThuyet : DevExpress.XtraEditors.XtraForm
    {
        ThiSinh DanhSachThiSinh = new ThiSinh();
        public frmLyThuyet()
        {
            InitializeComponent();
        }

        private void frmLyThuyet_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadDanhSachThiSinh(int MaHoiDongThi, int MaMonThi, int PhongThi)
        {
            dataGridView1.DataSource = DanhSachThiSinh.LayDanhSachThiSinhTheoPhongThi(MaHoiDongThi, MaMonThi, PhongThi);
        }
        public void Luu()
        {
            if (DanhSachThiSinh.LuuThayDoi())
            {
                XtraMessageBox.Show("Đã lưu dữ liệu thành công.", "Nhập điểm lý thuyết", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lưu dữ liệu không thành công, xin vui lòng kiểm tra lỗi và thực hiện lưu lại.", "Nhập điểm lý thuyết", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}