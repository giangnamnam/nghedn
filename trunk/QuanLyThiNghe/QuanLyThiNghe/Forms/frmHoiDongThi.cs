using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThiNghe.Forms
{
    public partial class frmHoiDongThi : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities en = new QLTN_Entities();

        public DMKyThi KyThiHienTai { get; set; }
        public frmHoiDongThi()
        {
            InitializeComponent();
            KyThiHienTai = HeThong.KyThiHienTai();
        }

        private void frmHoiDongThi_Load(object sender, EventArgs e)
        {
            
            LoadHDT();
            btnPrint.Enabled = gvHDT.RowCount > 0;
            btnDelete.Enabled = gvHDT.RowCount > 0;
        }

        public void LoadHDT()
        {
            int MaKyThiHienTai = KyThiHienTai.MaKyThi;
            gcHDT.DataSource = en.HoiDongThi.Where(h => (h.DaXoa == false || h.DaXoa == null) && h.DMKyThi.MaKyThi == MaKyThiHienTai)
                .Select(h => new { h.SoLuongPhongDuTinh, TenTruong = h.DMTruong.TenTruong, h.MaHoiDong, h.SoThiSinhDuTinh, SoThiSinhHienTai = h.ThiSinh.Count });
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gcHDT.ShowPrintPreview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCapNhatHDT frm = new frmCapNhatHDT();
            frm.btnSave.ToolTipTitle = "insert";
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvHDT.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn các hội đồng thi cần xoá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string TenHuyens = "";

            try
            {
                for (int i = 0; i < gvHDT.SelectedRowsCount; i++)
                {
                    var MaHD = int.Parse(gvHDT.GetRowCellValue(gvHDT.GetSelectedRows()[i], "MaHoiDong").ToString());

                    var h = en.HoiDongThi.First(d => d.MaHoiDong == MaHD);
                    h.DMTruongReference.Load();

                    h.DaXoa = true;
                    var TenHuyen = h.DMTruong.TenTruong;

                    TenHuyens += TenHuyen + ", ";
                }
                en.SaveChanges();
            }
            catch (Exception exp)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Xoá không thành công: " + exp.Message);
                return;

            }
            finally
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Đã xoá thành công.");
                XuLyForm.LuuNhatKy("Xoá hội đồng thi: " + TenHuyens.Substring(0, TenHuyens.Length - 2));
                LoadHDT();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvHDT.SelectedRowsCount == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn hội đồng thi cần cập nhật.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var MaHD = int.Parse(gvHDT.GetRowCellValue(gvHDT.GetSelectedRows()[0], "MaHoiDong").ToString());
            frmCapNhatHDT frm = new frmCapNhatHDT();
            frm.LoadChiTietHDT(MaHD);
            frm.ShowDialog();
        }

        private void btnDanhSoBaoDanhVaChiaPhongThi_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Thao tác đánh số báo danh và chia phòng thi sẽ ghi đè lên các dữ liệu cũ nếu có bạn vẫn muốn tiếp tục thao tác?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                ChiaPhongThiVaDanhSoBaoDanh();
                DevExpress.XtraEditors.XtraMessageBox.Show("Đã đánh số báo danh và chia phòng thi xong.", "Đánh số báo danh và chia phòng thi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        void ChiaPhongThiVaDanhSoBaoDanh()
        {
            int MaKyThiHienTai = KyThiHienTai.MaKyThi;
            var HDTs = en.ThiSinh.Where(t => t.MaKyThi == MaKyThiHienTai && (t.DaXoa == false || t.DaXoa == null) && t.HoiDongThi!=null).Select(t => new { t.HoiDongThi.MaHoiDong }).Distinct().ToList();
            for (int i = 0; i < HDTs.Count; i++)
            {
                int MaHDT = HDTs[i].MaHoiDong;
                int phong = 1;
                int phongtmp = 1;
                var MTs = en.ThiSinh.Where(t => t.MaKyThi == MaKyThiHienTai && (t.DaXoa==false || t.DaXoa==null) && t.HoiDongThi.MaHoiDong == MaHDT).Select(t => new { t.DMMonThi.MaMonThi }).Distinct().ToList();
                for (int j = 0; j < MTs.Count; j++)
                {
                    int MaMonThi = MTs[j].MaMonThi;
                    List<ThiSinh> TSs = en.ThiSinh.Where(t => t.MaKyThi == MaKyThiHienTai && (t.DaXoa==false || t.DaXoa==null) && t.HoiDongThi.MaHoiDong == MaHDT && t.DMMonThi.MaMonThi == MaMonThi).OrderBy(t => t.Ten).ThenBy(t => t.NgaySinh).ToList();
                    if (phongtmp!=1)
                    {
                        phong++;
                        phongtmp = 1;
                    }
                    int sbd = 1;


                    foreach (ThiSinh ts in TSs)
                    {
                        ts.SBD = sbd;
                        ts.PhongThi = phong;
                        
                        if (phongtmp==20) //20 thi sinh mot phong
                        {
                            phong++;
                            phongtmp = 0;
                        }
                        phongtmp++;
                        sbd++;
                    }
                }
            }
            en.SaveChanges();
            XuLyForm.LuuNhatKy("Đánh số báo danh và chia phòng thi cho thí sinh dự kỳ thi: "+KyThiHienTai.TenKyThi);
        }
    }
}
