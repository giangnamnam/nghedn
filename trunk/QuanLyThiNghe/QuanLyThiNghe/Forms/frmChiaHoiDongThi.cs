<<<<<<< .mine
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

        private void treeListTruong_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        void LoadKyThi()
        {

        }
        void BindTreeTruong()
        {

        }
        void BindTreeHoiDongThi()
        {

        }
    }
}=======
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThiNghe.Forms
{
    public partial class frmChiaHoiDongThi : DevExpress.XtraEditors.XtraForm
    {
        public frmChiaHoiDongThi()
        {
            InitializeComponent();
        }

        private void frmChiaHoiDongThi_Load(object sender, EventArgs e)
        {
            TreeNode ParentNode1;
            TreeNode ParentNode2;

            ParentNode1 = treeView1.Nodes.Add("tv1");
            ParentNode1.Nodes.Add("tv1FirstChild");
            ParentNode1.Nodes.Add("tv1SecondChild");
            ParentNode1.Nodes.Add("tv1ThirdChild");
            ParentNode1.Nodes.Add("tv1FourthChild");
            ParentNode1.Expand();

            ParentNode2 = treeView2.Nodes.Add("tv2");
            ParentNode2.Nodes.Add("tv2FirstChild");
            ParentNode2.Nodes.Add("tv2SecondChild");
            ParentNode2.Expand();
            treeView2.AllowDrop = true;
            
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView2_DragEnter(object sender, DragEventArgs e)
        {
            // set the mouse cursor to "Move"
            e.Effect = DragDropEffects.Move;
        }

        private void treeView2_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                // get the destination node from the mouse cursor's position
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);

                // check if we're the node's treeviews are different
                NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
                if (DestinationNode.TreeView != NewNode.TreeView)
                {
                    // yes they are so lets add them to the destination node
                    DestinationNode.Nodes.Add((TreeNode)NewNode.Clone());
                    DestinationNode.Expand();
                    // and remove the original node
                    NewNode.Remove();
                }
            }
        }
        
    }
}>>>>>>> .r89
