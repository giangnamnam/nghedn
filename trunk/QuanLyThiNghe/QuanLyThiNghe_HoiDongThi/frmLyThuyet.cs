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
        public string TinhTrang { get; set; }
        public string HDT { get; set; }
        public string MT { get; set; }
        public string Phong { get; set; }

        private void frmLyThuyet_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
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
        private void frmLyThuyet_Activated(object sender, EventArgs e)
        {
            ((frmThuKy)this.MdiParent).frm_active = this.Name;
            ((frmThuKy)this.MdiParent).ghiChuTinhTrang(TinhTrang);

            frmThuKy tk = ((frmThuKy)this.MdiParent);
            string _HDT = (tk.le_HoiDong.EditValue != null ? tk.le_HoiDong.Edit.GetDisplayText(tk.le_HoiDong.EditValue) : "");
            string _MT = (tk.le_MonThi.EditValue != null ? tk.le_MonThi.Edit.GetDisplayText(tk.le_MonThi.EditValue) : "");
            string _Phong = (tk.le_Phong.EditValue != null ? tk.le_Phong.Edit.GetDisplayText(tk.le_Phong.EditValue) : "");

            if (_HDT!=HDT || _MT!=MT || _Phong != Phong)
            {
                XtraMessageBox.Show("Bảng điểm hiện tại không phải là bảng điểm đang được chọn theo điều kiện ở trên.  \nXin vui lòng hoàn tất bảng điểm này và lưu lại trước khi nhập điểm phòng khác.", "Nhập điểm lý thuyết", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void frmLyThuyet_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmThuKy)this.MdiParent).ghiChuTinhTrang("Xin chọn hội đồng thi, môn thi và phòng thi để nhập điểm.");
        }

        public void LoadDanhSachThiSinh(int MaHoiDongThi, int MaMonThi, int PhongThi)
        {
            frmThuKy tk = ((frmThuKy)this.MdiParent);
            HDT = (tk.le_HoiDong.EditValue != null ? tk.le_HoiDong.Edit.GetDisplayText(tk.le_HoiDong.EditValue) : "");
            MT = (tk.le_MonThi.EditValue != null ? tk.le_MonThi.Edit.GetDisplayText(tk.le_MonThi.EditValue) : "");
            Phong = (tk.le_Phong.EditValue != null ? tk.le_Phong.Edit.GetDisplayText(tk.le_Phong.EditValue) : "");

            TinhTrang = 
                "HĐT: " + HDT
                + " | MT: " + MT
                + " | Phòng: " + Phong
                + " | Đang "+ this.Text.ToLower();

            ((frmThuKy)this.MdiParent).ghiChuTinhTrang(TinhTrang);
            DanhSachThiSinh = new ThiSinh();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            DanhSachTheoPhong = DanhSachThiSinh.LayTableDanhSachThiSinhTheoPhongThi(MaHoiDongThi, MaMonThi, PhongThi);
            dataGridView1.DataSource = DanhSachTheoPhong;
            dataGridView1.Refresh();

            bool dcQuayLai = ((frmThuKy)this.MdiParent).KT.ChoThuKyQuayLaiKhiNhapDiem;
            if (!dcQuayLai)
            {
                bool DaNhapDiemHet = true;
                foreach (DataRow item in DanhSachTheoPhong.Rows)
                {
                    if (string.IsNullOrEmpty(item["DiemLT"].ToString()))
                    {
                        DaNhapDiemHet = false;
                        break;
                    }
                }
                if (DaNhapDiemHet)
                    dataGridView1.Enabled = false;
            }

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
    }
}