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

        void LoadDanhSach()
        {
            this.Enabled = false;
            BindTreeTruong();
            BindTreeHoiDongThi();
            this.Enabled = true; ;
        }
        void LoadKyThi()
        {

        }
        void BindTreeTruong()
        {
            //treeListTruong.Nodes.Clear();
            treeViewTruong.Nodes.Clear();
            List<DMHuyen> dmHuyen = en.DMHuyen.ToList();
            int Khoi = radioButton1.Checked ? 2 : 1;
            foreach (DMHuyen item in dmHuyen)
            {
                int Huyen = item.MaHuyen;

                List<DMTruong> dmTruong = en.DMTruong.Include("DMKhoi").Include("ThiSinh").Include("HoiDongThi").Where(t =>
                    t.DMKhoi.MaKhoi == Khoi && t.DMHuyen.MaHuyen == Huyen).ToList();
                //DevExpress.XtraTreeList.Nodes.TreeListNode H = treeListTruong.AppendNode(new object[] { item.TenHuyen }, null);
                TreeNode nH = new TreeNode(item.TenHuyen);
                nH.ImageIndex = 7;
                treeViewTruong.Nodes.Add(nH);
                foreach (DMTruong t in dmTruong)
                {
                    int Truong = t.MaTruong;
                    int SoLuongTheoTruong = en.ThiSinh.Include("DMMonThi").Where(s => s.DMTruong.MaTruong == Truong && s.MaKyThi == MaKyThiHienTai).Count();
                    if (SoLuongTheoTruong > 0)
                    {
                        //DevExpress.XtraTreeList.Nodes.TreeListNode T = treeListTruong.AppendNode(new object[] { t.TenTruong + " (" + SoLuongTheoTruong.ToString() + ")" }, H);
                        TreeNode nT = new TreeNode(t.TenTruong + " (" + SoLuongTheoTruong.ToString() + ")");
                        nT.Tag = t.MaTruong + "|0";
                        nT.ImageIndex = 1;
                        nH.Nodes.Add(nT);
                        var thisinh = en.ThiSinh.Include("DMMonThi").Where(s => s.DMTruong.MaTruong == Truong && s.MaKyThi == MaKyThiHienTai).Select(ts => new { ts.DMMonThi.TenMonThi, ts.DMMonThi.MaMonThi }).Distinct().ToList();
                        for (int i = 0; i < thisinh.Count; i++)
                        {
                            int MonThi = thisinh[i].MaMonThi;
                            int SoLuong = en.ThiSinh.Include("DMMonThi").Where(s => s.DMTruong.MaTruong == Truong && s.DMMonThi.MaMonThi == MonThi && s.MaKyThi == MaKyThiHienTai).Count();
                            ThiSinh tsm = en.ThiSinh.Include("DMMonThi").Where(s => s.DMTruong.MaTruong == Truong && s.DMMonThi.MaMonThi == MonThi && s.MaKyThi == MaKyThiHienTai).First();
                            //treeListTruong.AppendNode(new object[] { thisinh[i].TenMonThi + " (" + SoLuong.ToString() + ")" }, T);
                            TreeNode nM = new TreeNode(thisinh[i].TenMonThi + " (" + SoLuong.ToString() + ")");
                            nM.Tag = t.MaTruong + "|" + thisinh[i].MaMonThi;
                            if (tsm.HoiDongThi.MaHoiDong != null)
                                nM.ImageIndex = 3;
                            else
                                nM.ImageIndex = 2;
                            nT.Nodes.Add(nM);
                        }
                    }
                } nH.ExpandAll();
            }
        }
        void BindTreeHoiDongThi()
        {

            //treeListHDT.Nodes.Clear();
            treeViewHDT.Nodes.Clear();
            List<DMHuyen> dmHuyen = en.DMHuyen.ToList();
            //int Khoi = radioButton1.Checked ? 2 : 1;
            List<HoiDongThi> dmHDTs = en.HoiDongThi.Include("DMTruong").Include("DMKyThi").Where(h => h.DMKyThi.MaKyThi == MaKyThiHienTai).ToList();
            foreach (HoiDongThi item in dmHDTs)
            {
                item.DMTruong.DMHuyenReference.Load();
                item.DMTruong.DMKhoiReference.Load();
            }

            int soLuongHoanThanh = 0;
            int Tong = dmHuyen.Count;
            progressBarControl1.Visible = true;
            foreach (DMHuyen item in dmHuyen)
            {
                soLuongHoanThanh++;
                progressBarControl1.Text = ((soLuongHoanThanh * 100) / Tong).ToString();
                progressBarControl1.Update();

                int Huyen = item.MaHuyen;
                List<HoiDongThi> dmHDT = dmHDTs.Where(h => h.DMTruong.DMHuyen.MaHuyen == Huyen).ToList();
                //DevExpress.XtraTreeList.Nodes.TreeListNode H = treeListHDT.AppendNode(new object[] { item.TenHuyen }, null);
                TreeNode H = new TreeNode(item.TenHuyen); H.ImageIndex = 7;
                treeViewHDT.Nodes.Add(H);
                foreach (HoiDongThi t in dmHDT)
                {
                    int MaHoiDong = t.MaHoiDong;
                    int SoLuongTheoHoiDong = en.ThiSinh.Include("DMMonThi").Where(s => s.HoiDongThi.MaHoiDong == MaHoiDong).Count();
                    //if (SoLuongTheoHoiDong > 0)
                    //{
                    //DevExpress.XtraTreeList.Nodes.TreeListNode T = treeListHDT.AppendNode(new object[] { t.DMTruong.DMKhoi.TenKhoi + " - " + t.DMTruong.TenTruong + " (" + SoLuongTheoHoiDong.ToString() + ")" }, H);
                    TreeNode T = new TreeNode(t.DMTruong.DMKhoi.TenKhoi + " - " + t.DMTruong.TenTruong + " (" + SoLuongTheoHoiDong.ToString() + ")");
                    T.Tag = MaHoiDong + "|0|0"; 
                    T.ImageIndex = 6;
                    H.Nodes.Add(T);
                    var thisinh = en.ThiSinh.Include("DMMonThi").Where(s => s.HoiDongThi.MaHoiDong == MaHoiDong).Select(ts => new { ts.DMMonThi.TenMonThi, ts.DMMonThi.MaMonThi }).Distinct().ToList();


                    for (int i = 0; i < thisinh.Count; i++)
                    {
                        int MonThi = thisinh[i].MaMonThi;
                        int SoLuong = en.ThiSinh.Include("DMMonThi").Where(s => s.HoiDongThi.MaHoiDong == MaHoiDong && s.DMMonThi.MaMonThi == MonThi).Count();
                        //DevExpress.XtraTreeList.Nodes.TreeListNode M = treeListHDT.AppendNode(new object[] { thisinh[i].TenMonThi + " (" + SoLuong.ToString() + ")" }, T);
                        TreeNode M = new TreeNode(thisinh[i].TenMonThi + " (" + SoLuong.ToString() + ")");

                        M.Tag = MaHoiDong + "|" + MonThi + "|0"; 
                        M.ImageIndex = 2;
                        T.Nodes.Add(M);
                        var truongduthi = en.ThiSinh.Include("DMMonThi").Where(s => s.HoiDongThi.MaHoiDong == MaHoiDong && s.DMMonThi.MaMonThi == MonThi).Select(tt => new { TenTruong = tt.DMTruong.DMKhoi.TenKhoi + " - " + tt.DMTruong.TenTruong, tt.DMTruong.MaTruong }).Distinct().ToList();
                        for (int j = 0; j < truongduthi.Count; j++)
                        {
                            int MaTruongDT = truongduthi[j].MaTruong;
                            int SoLuongTheoTruong = en.ThiSinh.Include("DMMonThi").Where(s => s.HoiDongThi.MaHoiDong == MaHoiDong && s.DMMonThi.MaMonThi == MonThi && s.DMTruong.MaTruong == MaTruongDT).Count();
                            //treeListHDT.AppendNode(new object[] { truongduthi[j].TenTruong + " (" + SoLuongTheoTruong.ToString() + ")" }, M);
                            TreeNode nT = new TreeNode(truongduthi[j].TenTruong + " (" + SoLuongTheoTruong.ToString() + ")");
                            nT.Tag = MaHoiDong + "|" + MonThi + "|" + MaTruongDT; 
                            nT.ImageIndex = 1;
                            M.Nodes.Add(nT);
                        }
                    }
                    T.Expand();
                    //}
                } H.Expand();
            }
            progressBarControl1.Visible = false;
        }
        public void ChiaHoiDongThi(int MaTruong, int MaMonThi, int MaHoiDongThi)
        {
            bool tatCaMonThi = (MaMonThi == 0);

            List<ThiSinh> lThiSinh = en.ThiSinh.Include("HoiDongThi").Include("DMTruong").Include("DMMonThi").Where(t => t.DMTruong.MaTruong == MaTruong && (tatCaMonThi || t.DMMonThi.MaMonThi == MaMonThi)).ToList();
            int soLuongHoanThanh = 0;
            int Tong = lThiSinh.Count;
            if (Tong > 0)
            {
                progressBarControl1.Visible = true;
                this.Enabled = false;
                HoiDongThi HDT = en.HoiDongThi.Where(h => h.MaHoiDong == MaHoiDongThi).First();
                foreach (ThiSinh item in lThiSinh)
                {
                    HDT.ThiSinh.Add(item);
                    soLuongHoanThanh++;
                    progressBarControl1.Text = ((soLuongHoanThanh * 100) / Tong).ToString();
                    progressBarControl1.Update();
                }
                //en.SaveChanges();
                progressBarControl1.Visible = false;
                this.Enabled = true;
            }
        }
        void ThemMoi()
        {
            frmCapNhatHDT frm = new frmCapNhatHDT();
            frm.btnSave.ToolTipTitle = "Tạo mới";
            frm.ShowDialog();
        }
        void Sua(int MaHD)
        {
            frmCapNhatHDT frm = new frmCapNhatHDT();
            frm.LoadChiTietHDT(MaHD);
            frm.ShowDialog();
        }


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
                comboBoxKyThi.SelectedIndex = 1;
            }
        }
        private void comboBoxKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaKyThiHienTai = int.Parse(comboBoxKyThi.SelectedValue.ToString());
            LoadDanhSach();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //LoadDanhSach();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
        private void treeViewTruong_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void treeViewHDT_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void treeViewTruong_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (((TreeNode)e.Item).Level>0)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
            
        }
        private void treeViewHDT_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);
                NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                if (DestinationNode.Level > 0)
                {
                    string[] param = NewNode.Tag.ToString().Split('|');
                    int MaTruong = int.Parse(param[0]);
                    int MaMonThi= int.Parse(param[1]);
                    int MaHoiDongThi = int.Parse(DestinationNode.Tag.ToString().Split('|')[0]);//hội đồng - môn thi - trường dự thi
                    ChiaHoiDongThi(MaTruong, MaMonThi, MaHoiDongThi);
                    LoadDanhSach();
                    string NodeChuyen = "";
                    string NodeDen = "";

                    if (NewNode.Level == 1)
                        NodeChuyen = "Thí sinh trường " + NewNode.Text;
                    else
                        NodeChuyen = "Thí sinh trường " + NewNode.Parent.Text +" thi môn "+ NewNode.Text;

                    NodeDen = DestinationNode.FirstNode.Text;
                    
                    XtraMessageBox.Show("Đã chuyển " + NodeChuyen + " vào hội đồng thi " + NodeDen
                    , "Chia hội đồng thi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        bool treeViewTruongExpanded = false;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (treeViewTruongExpanded)
            {
                treeViewTruong.CollapseAll();
                treeViewTruongExpanded = false;
                simpleButton1.Text = "Mở rộng";
            }
            else
            {
                treeViewTruong.ExpandAll(); 
                treeViewTruongExpanded = true;
                simpleButton1.Text = "Rút gọn";
            }
            
        }
        bool treeViewHDTExpanded = false;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (treeViewHDTExpanded)
            {
                treeViewHDT.CollapseAll();
                treeViewHDTExpanded = false;
                simpleButton2.Text = "Mở rộng";
            }
            else
            {
                treeViewHDT.ExpandAll();
                treeViewHDTExpanded = true;
                simpleButton2.Text = "Rút gọn";
            }
        }
        private void treeViewHDT_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeViewHDT.SelectedNode = e.Node;
            if (e.Node.Level == 1)
            {
                treeViewHDT.ContextMenuStrip = contextMenuHDT;
            }
            else
                treeViewHDT.ContextMenuStrip = null;
        }
        private void treeViewTruong_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeViewTruong.SelectedNode = e.Node;
            if (e.Node.Level == 1)
            {
                treeViewTruong.ContextMenuStrip = contextMenuTruong;
            }
            else
                treeViewTruong.ContextMenuStrip = null;
        }
        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            ThemMoi();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int MaHoiDongThi = int.Parse(treeViewHDT.SelectedNode.Tag.ToString().Split('|')[0]);
            Sua(MaHoiDongThi);
        }

        private void toolStripMenuThemHoiDongThi_Click(object sender, EventArgs e)
        {
            ThemMoi();
        }

        private void toolStripMenuXoaHoiDongThi_Click(object sender, EventArgs e)
        {
            int MaHoiDongThi = int.Parse(treeViewHDT.SelectedNode.Tag.ToString().Split('|')[0]);
        }
    }
}