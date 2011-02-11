using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;

namespace QuanLyThiNghe.Forms
{
    public partial class frmChiaHoiDongThi : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities en = new QLTN_Entities();
        public int MaKyThiHienTai { get; set; }

        public frmChiaHoiDongThi()
        {
            InitializeComponent();
        }
        private void frmChiaHoiDongThi_Load(object sender, EventArgs e)
        {
            List<DMKyThi> ListKyThi = en.DMKyThi.OrderByDescending(k => k.NgayTao).ToList();

            if (ListKyThi.Count > 0)
            {
                comboBoxKyThi.DataSource = ListKyThi;
                comboBoxKyThi.SelectedIndex = 0;
            }
        }
        private void treeListHDT_DragEnter(object sender, DragEventArgs e)
        {
            if (GetDragNode(e.Data) != null)
                e.Effect = DragDropEffects.Move;
        }
        private void treeListHDT_DragDrop(object sender, DragEventArgs e)
        {
            DevExpress.XtraTreeList.TreeList tl = sender as DevExpress.XtraTreeList.TreeList;
            DevExpress.XtraTreeList.Nodes.TreeListNode node = GetDragNode(e.Data);
            if (node != null)
            {
                //string dragString = GetStringByNode(node);
                //int ind = lb.IndexFromPoint(lb.PointToClient(new Point(e.X, e.Y)));
                tl.Nodes.Add(node);
            }
        }
        private DevExpress.XtraTreeList.Nodes.TreeListNode GetDragNode(IDataObject data)
        {
            return data.GetData(typeof(DevExpress.XtraTreeList.Nodes.TreeListNode)) as DevExpress.XtraTreeList.Nodes.TreeListNode;
        }
        private string GetStringByNode(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            string ret = "";
            for (int i = 0; i < treeListTruong.Columns.Count; i++)
                ret += node.GetDisplayText(i) + (i < treeListTruong.Columns.Count - 1 ? "; " : ".");
            return ret;
        }
        private void comboBoxKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaKyThiHienTai = int.Parse(comboBoxKyThi.SelectedValue.ToString());
            LoadDanhSach();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        void LoadDanhSach()
        {
            BindTreeTruong();
        }
        void LoadKyThi()
        {

        }
        void BindTreeTruong()
        {
            treeListTruong.Nodes.Clear();
            List<DMHuyen> dmHuyen = en.DMHuyen.ToList();
            int Khoi = radioButton1.Checked ? 2 : 1;
            foreach (DMHuyen item in dmHuyen)
            {
                try
                {
                    int Huyen = item.MaHuyen;
                    
                    List<DMTruong> dmTruong = en.DMTruong.Include("DMKhoi").Include("ThiSinh").Include("HoiDongThi").Where(t =>
                        t.DMKhoi.MaKhoi == Khoi && t.DMHuyen.MaHuyen == Huyen).ToList();
                    DevExpress.XtraTreeList.Nodes.TreeListNode H = treeListTruong.AppendNode(new object[] { item.TenHuyen }, null);

                    foreach (DMTruong t in dmTruong)
                    {
                        int Truong = t.MaTruong;
                        int SoLuongTheoTruong = en.ThiSinh.Include("DMMonThi").Where(s => s.DMTruong.MaTruong == Truong && s.MaKyThi == MaKyThiHienTai).Count();
                        if (SoLuongTheoTruong > 0)
                        {
                            DevExpress.XtraTreeList.Nodes.TreeListNode T = treeListTruong.AppendNode(new object[] { t.TenTruong + " (" + SoLuongTheoTruong.ToString() + ")" }, H);
                            var thisinh = en.ThiSinh.Include("DMMonThi").Where(s => s.DMTruong.MaTruong == Truong && s.MaKyThi == MaKyThiHienTai).Select(ts => new { ts.DMMonThi.TenMonThi, ts.DMMonThi.MaMonThi }).Distinct().ToList();


                            for (int i = 0; i < thisinh.Count; i++)
                            {
                                int MonThi = thisinh[i].MaMonThi;
                                int SoLuong = en.ThiSinh.Include("DMMonThi").Where(s => s.DMTruong.MaTruong == Truong && s.DMMonThi.MaMonThi == MonThi && s.MaKyThi == MaKyThiHienTai).Count();
                                treeListTruong.AppendNode(new object[] { thisinh[i].TenMonThi + " (" + SoLuong.ToString() + ")" }, T);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        void BindTreeHoiDongThi()
        {

        }
    }
}