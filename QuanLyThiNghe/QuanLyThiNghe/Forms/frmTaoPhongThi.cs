using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraEditors;

namespace QuanLyThiNghe.Forms
{
    public partial class frmTaoPhongThi : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities en = new QLTN_Entities();
        bool SoLuongThiSinhVuotGioiHan = false;
        public frmTaoPhongThi()
        {
            InitializeComponent();
        }

        private void frmTaoPhongThi_Load(object sender, EventArgs e)
        {
            LoadDistricts();
            LoadHDT();
        }

        #region Functions

        void LoadDistricts()
        {
            cbDistricts.Properties.Items.Clear();
            cbDistricts.Text = "";

            cbDistricts.Properties.Items.AddRange(en.ThiSinh.Where(t => (t.DaXoa == false || t.DaXoa == null)).Select(h => new { h.DMTruong.DMHuyen.TenHuyen, h.DMTruong.DMHuyen.MaHuyen }).Distinct().ToList().Select(h => h.TenHuyen).ToList());
            cbDistricts.SelectedIndex = 0;

            //LoadSchools(cbDistricts.EditValue.ToString());
        }

        void LoadHDT()
        {
            cbHDT.Properties.Items.Clear();
            cbHDT.Text = "";

            var source = en.HoiDongThi.Where(h=>h.DaXoa==false || h.DaXoa==null).Select(t=>t.DMTruong.TenTruong).ToList();
            cbHDT.Properties.Items.AddRange(source);

            cbHDT.SelectedIndex = 0;

            LoadHDTDetails(cbHDT.EditValue.ToString());
        }

        void LoadHDTDetails(string HDTName)
        {
            var HDT = en.HoiDongThi.Where(h => h.DMTruong.TenTruong == HDTName && h.DaXoa == false || h.DaXoa == null).Select(h => new { h.MaHoiDong, TenTruong = h.DMTruong.TenTruong, h.SoLuongPhongDuTinh, h.SoThiSinhDuTinh, TenHuyen = h.DMTruong.DMHuyen.TenHuyen }).FirstOrDefault();

            if (HDT != null)
            {
                lblDistrictName.Text = HDT.TenHuyen;

                //lblRooms.Text = HDT.HoiDongThi.FirstOrDefault().SoLuongPhongDuTinh.HasValue ? HDT.HoiDongThi.FirstOrDefault().SoLuongPhongDuTinh.ToString() : "0";
                lblSchoolName.Text = HDTName;

                lblSoPhongDuTinh.Text = HDT.SoLuongPhongDuTinh.Value.ToString();
                lblSoThiSinhDuTinh.Text = HDT.SoThiSinhDuTinh.Value.ToString();

                LoadThongTinHDT();

                int TongThiSinh = 0;

                for (int i = 0; i < gvHDT.RowCount; i++)
                {
                    var soTS = int.Parse(gvHDT.GetRowCellValue(i, "SoThiSinh").ToString());
                    TongThiSinh += soTS;
                }

                lblSoThiSinh.Text = TongThiSinh.ToString();
            }
        }

        void LoadSchools(string DistrictName)
        {
            cbTruong.Properties.Items.Clear();
            cbTruong.Text = "";

            var source = en.ThiSinh.Where(t => (t.DaXoa == false || t.DaXoa == null) && t.DMTruong.DMHuyen.TenHuyen == DistrictName).Select(t => t.DMTruong.TenTruong).Distinct();
            cbTruong.Properties.Items.AddRange(source.ToList());
        }

        void LoadMonThi(string TenTruong)
        {
            cbMonThi.Properties.Items.Clear();
            cbMonThi.Text = "";
            var source = en.ThiSinh.Where(t => t.DMTruong.TenTruong == TenTruong && t.DaXoa == false || t.DaXoa == null).Select(t => t.DMMonThi.TenMonThi).Distinct();

            cbMonThi.Properties.Items.AddRange(source.ToList());
        }

        void KiemTraSoLuong(string TenMonThi)
        {
            //var monThi = en.DMMonThi.First(m => m.TenMonThi == TenMonThi);
            var tenTruong = cbTruong.EditValue.ToString();
            var soTS = en.ThiSinh.Where(t => (t.DaXoa == false || t.DaXoa == null) && t.DMMonThi.TenMonThi == TenMonThi && t.DMTruong.TenTruong == tenTruong).Count();
            lblSoThiSinh1.Text = soTS.ToString();

            int tsDuTinh = int.Parse(lblSoThiSinhDuTinh.Text);
            int tsHienTai = int.Parse(lblSoThiSinh.Text);
            int SoThiSinhChoPhep = tsDuTinh - tsHienTai;

            SoLuongThiSinhVuotGioiHan = SoThiSinhChoPhep < soTS;
        }

        void LoadThongTinHDT()
        {
            var source = en.ThiSinh.Where(t => t.HoiDongThi.DMTruong.TenTruong == lblSchoolName.Text).Select(t => new { TenTruong = t.DMTruong.TenTruong, TenMonThi = t.DMMonThi.TenMonThi, TenHuyen = t.DMTruong.DMHuyen.TenHuyen, SoThiSinh = (en.ThiSinh.Where(t1 => t1.HoiDongThi.DMTruong.TenTruong == lblSchoolName.Text).Count()) }).Distinct().OrderBy(t => t.TenTruong).OrderBy(t => t.TenMonThi);
            gcHDT.DataSource = source;
        }

        #endregion

        private void cbHDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHDTDetails(cbHDT.EditValue.ToString());
        }

        private void cbDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSchools(cbDistricts.EditValue.ToString());
        }

        private void cbTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonThi(cbTruong.EditValue.ToString());
        }

        private void cbMonThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            KiemTraSoLuong(cbMonThi.EditValue.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SoLuongThiSinhVuotGioiHan)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Số lượng thí sinh của môn thi này vượt giới hạn của hội đồng thi.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var tenTruong = cbTruong.EditValue.ToString();
            var tenMonThi = cbMonThi.EditValue.ToString();
            var TS = en.ThiSinh.Where(t => (t.DaXoa == false || t.DaXoa == null) && t.DMMonThi.TenMonThi == tenMonThi && t.DMTruong.TenTruong == tenTruong);

            foreach (var item in TS)
            {
                item.HoiDongThi = en.HoiDongThi.First(h => h.DMTruong.TenTruong == lblSchoolName.Text);
            }

            try
            {
                en.SaveChanges();
            }
            catch (Exception exp)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Có lỗi xảy ra: " + exp.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Đã thêm danh sách thí sinh của môn thi này vào hội đồng thi.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadHDTDetails(cbHDT.EditValue.ToString());
            }
        }

        //bool lv1_md;
        //private void lvSchool_DragDrop(object sender, DragEventArgs e)
        //{
        //    string textBox1 = e.Data.GetData(DataFormats.Text).ToString();
        //    string[] items = textBox1.Split(',');

        //    if (!lvSchools2.Items.ContainsKey(textBox1))
        //    {
        //        lvSchools2.Items.Add(textBox1, textBox1, 0);
        //        lvSchools.Items.RemoveByKey(textBox1);
        //    }

        //    lv1_md = false;
        //}

        //private void lvSchools2_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.Text))
        //        e.Effect = DragDropEffects.Move;
        //    else
        //        e.Effect = DragDropEffects.None;
        //}

        //private void lvSchool_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (!lv1_md) return;
        //    if (e.Button != MouseButtons.Left) return;

        //    string str = GetItemText(lvSchools);
        //    if (str == "") return;

        //    lvSchools.DoDragDrop(str, DragDropEffects.Copy | DragDropEffects.Move);

        //}

        //public string GetItemText(ListView LVIEW)
        //{
        //    int nTotalSelected = LVIEW.SelectedIndices.Count;
        //    if (nTotalSelected <= 0) return "";
        //    IEnumerator selCol = LVIEW.SelectedItems.GetEnumerator();
        //    selCol.MoveNext();
        //    ListViewItem lvi = (ListViewItem)selCol.Current;
        //    string mDir = "";
        //    for (int i = 0; i < lvi.SubItems.Count; i++)
        //        mDir += lvi.SubItems[i].Text + ",";

        //    mDir = mDir.Substring(0, mDir.Length - 1);
        //    return mDir;
        //}

        //private void lvSchool_MouseDown(object sender, MouseEventArgs e)
        //{
        //    lv1_md = true;

        //    if (e.Button == MouseButtons.Left && e.Clicks == 2)
        //    {
        //        ListViewItem lvi = lvSchools.GetItemAt(e.X, e.Y);

        //        lvSchools.Items.Remove(lvi);
        //        lvSchools2.Items.Add(lvi);
        //    }
        //}

        //private void lvSchool_MouseUp(object sender, MouseEventArgs e)
        //{
        //    lv1_md = false;
        //}

        //private void lvSchools2_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.Delete)
        //    {
        //        if (lvSchools2.SelectedItems.Count <= 0)
        //            return;

        //        int nextindex = lvSchools2.SelectedItems[0].Index - 1;

        //        int selecteditems = lvSchools2.SelectedItems.Count;

        //        for (int i = 0; i < selecteditems; i++)
        //        {
        //            lvSchools.Items.Add(lvSchools2.SelectedItems[0].Text, lvSchools2.SelectedItems[0].Text, 0);
        //            lvSchools.Items[lvSchools2.SelectedItems[0].Text].Group = lvSchools.Groups[0];

        //            lvSchools2.SelectedItems[0].Remove();
        //        }

        //        if (lvSchools2.Items.Count <= 0)
        //            return;

        //        lvSchools2.Items[nextindex < 0 ? 0 : nextindex].Selected = true;
        //    }
        //}

        //private void lvSchools_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
            
        //}
    }


}
