namespace QuanLyThiNghe.Forms
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("lNode0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("lNode1", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("lNode2", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node16");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node17");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Node18");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Node19");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node10", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Node15");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Node3";
            treeNode2.Name = "Node0";
            treeNode2.Tag = "l0";
            treeNode2.Text = "lNode0";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Node4";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Node5";
            treeNode5.Name = "Node1";
            treeNode5.Tag = "l1";
            treeNode5.Text = "lNode1";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Node8";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Node9";
            treeNode10.Name = "Node2";
            treeNode10.Tag = "l2";
            treeNode10.Text = "lNode2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(368, 472);
            this.treeView1.TabIndex = 0;
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.Location = new System.Drawing.Point(387, 12);
            this.treeView2.Name = "treeView2";
            treeNode11.Name = "Node16";
            treeNode11.Text = "Node16";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Node0";
            treeNode13.Name = "Node5";
            treeNode13.Text = "Node5";
            treeNode14.Name = "Node6";
            treeNode14.Text = "Node6";
            treeNode15.Name = "Node1";
            treeNode15.Text = "Node1";
            treeNode16.Name = "Node7";
            treeNode16.Text = "Node7";
            treeNode17.Name = "Node8";
            treeNode17.Text = "Node8";
            treeNode18.Name = "Node2";
            treeNode18.Text = "Node2";
            treeNode19.Name = "Node9";
            treeNode19.Text = "Node9";
            treeNode20.Name = "Node17";
            treeNode20.Text = "Node17";
            treeNode21.Name = "Node18";
            treeNode21.Text = "Node18";
            treeNode22.Name = "Node19";
            treeNode22.Text = "Node19";
            treeNode23.Name = "Node10";
            treeNode23.Text = "Node10";
            treeNode24.Name = "Node11";
            treeNode24.Text = "Node11";
            treeNode25.Name = "Node12";
            treeNode25.Text = "Node12";
            treeNode26.Name = "Node3";
            treeNode26.Text = "Node3";
            treeNode27.Name = "Node13";
            treeNode27.Text = "Node13";
            treeNode28.Name = "Node14";
            treeNode28.Text = "Node14";
            treeNode29.Name = "Node15";
            treeNode29.Text = "Node15";
            treeNode30.Name = "Node4";
            treeNode30.Text = "Node4";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode15,
            treeNode18,
            treeNode26,
            treeNode30});
            this.treeView2.Size = new System.Drawing.Size(368, 472);
            this.treeView2.TabIndex = 1;
            this.treeView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView2_DragDrop);
            this.treeView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView2_DragEnter);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 497);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
    }
}