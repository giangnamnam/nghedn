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
        DataTable DanhSachTheoPhong;
        public frmLyThuyet()
        {
            InitializeComponent();
        }

        private void frmLyThuyet_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }
        public void LoadDanhSachThiSinh(int MaHoiDongThi, int MaMonThi, int PhongThi)
        {
            DanhSachThiSinh = new ThiSinh();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            DanhSachTheoPhong = DanhSachThiSinh.LayTableDanhSachThiSinhTheoPhongThi(MaHoiDongThi, MaMonThi, PhongThi);
            dataGridView1.DataSource = DanhSachTheoPhong;
            dataGridView1.Refresh();
        }
        public void Luu()
        {
            int thuky1, thuky2, thuky3;
            thuky1 = thuky2 = thuky3 = 0;
            System.Collections.ArrayList TaiKhoan = ((frmThuKy)this.ParentForm).TaiKhoanHienTai;
            thuky1 = int.Parse(((DataRow)TaiKhoan[0])[0].ToString());
            if (TaiKhoan.Count==2)
                thuky2 = int.Parse(((DataRow)TaiKhoan[1])[0].ToString());
            else if (TaiKhoan.Count == 3)
            {
                thuky2 = int.Parse(((DataRow)TaiKhoan[1])[0].ToString());
                thuky3 = int.Parse(((DataRow)TaiKhoan[2])[0].ToString());
            }

            dataGridView1.EndEdit();
            foreach (DataRow item in DanhSachTheoPhong.Rows)
                if (item["DiemLT"].ToString() != "")
                    DanhSachThiSinh.CapNhatDiemLyThuyet(int.Parse(item["MaThiSinh"].ToString()), float.Parse(item["DiemLT"].ToString()), thuky1, thuky2, thuky3, false);
            //CapNhatDiemLyThuyet
            if (DanhSachThiSinh.LuuThayDoi())
                XtraMessageBox.Show("Đã lưu dữ liệu thành công.", "Nhập điểm lý thuyết", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Lưu dữ liệu không thành công, xin vui lòng kiểm tra lỗi và thực hiện lưu lại.", "Nhập điểm lý thuyết", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv["cSTT", e.RowIndex].Value = (e.RowIndex + 1).ToString();
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            string current = dgv.CurrentCell.Value.ToString();
            if (current != "")
            {
                float val = -1;
                bool pass = float.TryParse(current, out val);
                if (pass)
                    pass = ((val <= 10) && (val >= 0));
                if (!pass)
                {
                    XtraMessageBox.Show("Điểm không hợp lệ, xin vui lòng nhập lại.", "Nhập điểm lý thuyết", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgv.CurrentCell.Value = DBNull.Value;
                    SendKeys.Send("{UP}");
                }
            }
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            string current = dgv.CurrentCell.Value.ToString();
            XtraMessageBox.Show("Điểm " + current + " không hợp lệ, xin vui lòng nhập lại.", "Nhập điểm lý thuyết", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dgv.CurrentCell.Value = DBNull.Value;
            SendKeys.Send("+{Home}");
        }


    }
}