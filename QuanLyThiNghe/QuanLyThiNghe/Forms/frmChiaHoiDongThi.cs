using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;
using System.Threading;

namespace QuanLyThiNghe.Forms
{
    public partial class frmChiaHoiDongThi : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities en = new QLTN_Entities();
        public int MaKyThiHienTai { get; set; }

        void LoadDanhSach()
        {
            try
            {
                BindTreeTruong();
                BindTreeHoiDongThi();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        
        void BindTreeTruong()
        {
            //if (InvokeRequired)
            //{
            //    // after we've done all the processing, 
            //    this.Invoke(new MethodInvoker(delegate
            //    {
            //        // load the control with the appropriate data


                    //treeListTruong.Nodes.Clear();
                    

                    treeViewTruong.Nodes.Clear();
                    List<DMHuyen> dmHuyen = en.DMHuyen.ToList();
                    int soLuongHoanThanh = 0;
                    int Tong = dmHuyen.Count;
                    progressBarControl2.Visible = true;
                    int Khoi = radioButton1.Checked ? 2 : 1;
                    foreach (DMHuyen item in dmHuyen)
                    {
                        soLuongHoanThanh++;
                        progressBarControl2.Text = ((soLuongHoanThanh * 100) / Tong).ToString();
                        progressBarControl2.Update();

                        int Huyen = item.MaHuyen;

                        List<DMTruong> dmTruong = en.DMTruong.Include("DMKhoi").Include("ThiSinh").Include("HoiDongThi").Where(t =>
                            t.DMKhoi.MaKhoi == Khoi && t.DMHuyen.MaHuyen == Huyen).ToList();
                        //DevExpress.XtraTreeList.Nodes.TreeListNode H = treeListTruong.AppendNode(new object[] { item.TenHuyen }, null);
                        TreeNode nH = new TreeNode(item.TenHuyen);
                        nH.Tag = Huyen + "|0|0";
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
                                nT.Tag = Huyen + "|" + Truong + "|0";
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
                                    nM.Tag = Huyen + "|" + Truong + "|" + MonThi;
                                    if (tsm.HoiDongThi != null)
                                        nM.ImageIndex = 3;
                                    else
                                        nM.ImageIndex = 2;
                                    nT.Nodes.Add(nM);
                                }
                            }
                        } nH.Expand();
                    }
                    progressBarControl2.Visible = false;

            //    }));
            //    return;
            //}
            
        }
        void BindTreeHoiDongThi()
        {
            //if (InvokeRequired)
            //{
            //    // after we've done all the processing, 
            //    this.Invoke(new MethodInvoker(delegate
            //    {
            //        // load the control with the appropriate data

                    #region Bind tree
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
                    #endregion

            //    }));
            //    return;
            //}

            
        }
        public void ChiaHoiDongThi(int MaTruong, int MaMonThi, int MaHoiDongThi)
        {
            bool tatCaMonThi = (MaMonThi == 0);
            List<ThiSinh> lThiSinh = en.ThiSinh.Include("HoiDongThi").Include("DMTruong").Include("DMMonThi").Where(t => 
                t.MaKyThi==MaKyThiHienTai &&
                t.DMTruong.MaTruong == MaTruong && 
                (tatCaMonThi || t.DMMonThi.MaMonThi == MaMonThi)).ToList();
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
                en.SaveChanges();

                progressBarControl1.Visible = false;
                this.Enabled = true;
            }
        }
        void ThemMoi(int MaHuyen, int MaTruong)
        {
            frmCapNhatHDT frm = new frmCapNhatHDT();
            frm.MaHuyen = MaHuyen;
            frm.MaTruong = MaTruong;
            frm.MaKyThi = MaKyThiHienTai==0?HeThong.KyThiHienTai().MaKyThi:MaKyThiHienTai;
            frm.btnSave.ToolTipTitle = "Tạo mới";
            if (frm.ShowDialog()==DialogResult.OK)
            {
                BindTreeHoiDongThi();
            }
        }
        void Sua(int MaHD)
        {
            frmCapNhatHDT frm = new frmCapNhatHDT();
            frm.LoadChiTietHDT(MaHD);
            frm.ShowDialog();
        }
        void FreezeControl(bool DaKetThuc)
        {
            DaKetThuc = !DaKetThuc;
            contextMenuHDT.Enabled = contextMenuTruong.Enabled = simpleButtonLuu.Enabled = contextMenuBoTruongKhoiHDT.Enabled = DaKetThuc;
        }

        public frmChiaHoiDongThi()
        {
            InitializeComponent();
        }
        private void frmChiaHoiDongThi_Load(object sender, EventArgs e)
        {
            //System.Threading.Thread
            //    newDoStuff = new System.Threading.Thread(
            //    new System.Threading.ParameterizedThreadStart(HeThong.Loading));
            //newDoStuff.Start(true);
            HeThong.Loading(true);
            List<DMKyThi> ListKyThi = en.DMKyThi.OrderByDescending(k => k.NgayTao).ToList();
            MaKyThiHienTai = HeThong.KyThiHienTai().MaKyThi;
            DMKyThi ktht = ListKyThi.Where(s => s.MaKyThi == MaKyThiHienTai).First();
            ListKyThi.Remove(ktht);
            ListKyThi.Insert(0, ktht);
            if (ListKyThi.Count > 0)
            {
                comboBoxKyThi.DataSource = ListKyThi;
            }
            HeThong.Loading(false);
        }
        private void comboBoxKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaKyThiHienTai = int.Parse(comboBoxKyThi.SelectedValue.ToString());
            FreezeControl(en.DMKyThi.Where(k => k.MaKyThi == MaKyThiHienTai).First().DaKetThuc.GetValueOrDefault(false));
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
            if (((TreeNode)e.Item).Level>0 && simpleButtonLuu.Enabled)
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
                    int MaTruong = int.Parse(param[1]);
                    int MaMonThi= int.Parse(param[2]);
                    int MaHoiDongThi = int.Parse(DestinationNode.Tag.ToString().Split('|')[0]);//hội đồng - môn thi - trường dự thi
                    ChiaHoiDongThi(MaTruong, MaMonThi, MaHoiDongThi);
                    //LoadDanhSach();
                    if (NewNode.Level==1)
                        for (int i = 0; i < NewNode.Nodes.Count; i++)
                            NewNode.Nodes[i].ImageIndex = 3;
                    else
                        NewNode.ImageIndex = 3;
                    BindTreeHoiDongThi();
                    string NodeChuyen = "";
                    string NodeDen = "";

                    if (NewNode.Level == 1)
                        NodeChuyen = "Thí sinh trường " + NewNode.Text;
                    else
                        NodeChuyen = "Thí sinh trường " + NewNode.Parent.Text +" thi môn "+ NewNode.Text;

                    if (DestinationNode.Level == 1)
                        NodeDen = DestinationNode.Text;
                    else if (DestinationNode.Level == 2)
                        NodeDen = DestinationNode.Parent.Text;
                    else
                        NodeDen = DestinationNode.Parent.Parent.Text;

                    XuLyForm.LuuNhatKy("Chia hội đồng thi - Đã chuyển " + NodeChuyen + " vào hội đồng thi " + NodeDen);
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
            else if (e.Node.Level == 3)
            {
                treeViewHDT.ContextMenuStrip = contextMenuBoTruongKhoiHDT;
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
            ThemMoi(0,0);
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int MaHoiDongThi = int.Parse(treeViewHDT.SelectedNode.Tag.ToString().Split('|')[0]);
            Sua(MaHoiDongThi);
        }
        private void toolStripMenuThemHoiDongThi_Click(object sender, EventArgs e)
        {
            ThemMoi(0,0);
        }
        private void toolStripMenuXoaHoiDongThi_Click(object sender, EventArgs e)
        {
            try
            {
                string log = "";
                int MaHoiDongThi = int.Parse(treeViewHDT.SelectedNode.Tag.ToString().Split('|')[0]);
                HoiDongThi hd = en.HoiDongThi.Where(h => h.MaHoiDong == MaHoiDongThi).First();
                hd.ThiSinh.Clear();
                log = "Xóa hội đồng thi " + hd.DMTruong.TenTruong;
                en.DeleteObject(hd);
                en.SaveChanges();
                XuLyForm.LuuNhatKy(log);
                LoadDanhSach();
            }
            catch (Exception ex)
            {
            }
            
        }
        private void toolStripMenuBoTruongRaKhoiHDT_Click(object sender, EventArgs e)
        {
            string log = "";
            int MaHoiDongThi = int.Parse(treeViewHDT.SelectedNode.Tag.ToString().Split('|')[0]);
            int MaMonThi = int.Parse(treeViewHDT.SelectedNode.Tag.ToString().Split('|')[1]);
            int MaTruongDuThi = int.Parse(treeViewHDT.SelectedNode.Tag.ToString().Split('|')[2]);
            int MaHuyen = 0;
            List<ThiSinh> thisinh = en.ThiSinh.Where(t => t.HoiDongThi.MaHoiDong == MaHoiDongThi && t.DMMonThi.MaMonThi == MaMonThi && t.DMTruong.MaTruong == MaTruongDuThi).ToList();

            foreach (ThiSinh item in thisinh)
            {
                if (log == "")
                {
                    log = "Bỏ thí sinh dự thi môn " + item.DMMonThi.TenMonThi + " của trường " + item.DMTruong.TenTruong + " ra khỏi hội đồng thi " + item.HoiDongThi.DMTruong.TenTruong;
                    MaHuyen = item.DMTruong.DMHuyen.MaHuyen;
                
                }
                item.HoiDongThi = null;
            }
            en.SaveChanges();
            XuLyForm.LuuNhatKy(log);

            if (treeViewHDT.SelectedNode.Parent.Nodes.Count > 1)
                treeViewHDT.SelectedNode.Remove();
            else
                treeViewHDT.SelectedNode.Parent.Remove();
            
            for (int i = 0; i < treeViewTruong.Nodes.Count; i++)
            {
                if (treeViewTruong.Nodes[i].Tag.ToString().Contains(MaHuyen+"|"))
                {
                    for (int j = 0; j < treeViewTruong.Nodes[i].Nodes.Count; j++)
                    {
                        if (treeViewTruong.Nodes[i].Nodes[j].Tag.ToString().Contains(MaHuyen + "|"+MaTruongDuThi+"|"))
                        {
                            for (int k = 0; k < treeViewTruong.Nodes[i].Nodes[j].Nodes.Count; k++)
                            {
                                if (treeViewTruong.Nodes[i].Nodes[j].Nodes[k].Tag.ToString().Contains(MaHuyen + "|" + MaTruongDuThi+"|"+MaMonThi))
                                {
                                    treeViewTruong.Nodes[i].Nodes[j].Nodes[k].ImageIndex = 2;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    break;
                } 
            }


        }
        private void danhSáchThíSinhDựThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //đặt làm hội đồng thi
            string[] param = treeViewTruong.SelectedNode.Tag.ToString().Split('|');
            int MaHuyen = int.Parse(param[0]);
            int MaTruong = int.Parse(param[1]);
            //int MaMonThi = int.Parse(param[2]);
            ThemMoi(MaHuyen,MaTruong);
        }

        
    }
}