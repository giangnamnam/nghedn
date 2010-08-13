namespace QuanLyThiNghe.Forms
{
    partial class frmMonThi
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
            this.components = new System.ComponentModel.Container();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmHuyệnMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaHuyệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchThíSinhDựThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xoáHuyệnNàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.Menu;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gridControl1.Location = new System.Drawing.Point(0, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(592, 338);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHuyệnMớiToolStripMenuItem,
            this.chỉnhSửaHuyệnToolStripMenuItem,
            this.danhSáchThíSinhDựThiToolStripMenuItem,
            this.toolStripSeparator1,
            this.xoáHuyệnNàyToolStripMenuItem});
            this.Menu.Name = "contextMenuStrip1";
            this.Menu.Size = new System.Drawing.Size(246, 98);
            // 
            // thêmHuyệnMớiToolStripMenuItem
            // 
            this.thêmHuyệnMớiToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.Add_16x16;
            this.thêmHuyệnMớiToolStripMenuItem.Name = "thêmHuyệnMớiToolStripMenuItem";
            this.thêmHuyệnMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.thêmHuyệnMớiToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.thêmHuyệnMớiToolStripMenuItem.Text = "Thêm môn thi mới";
            // 
            // chỉnhSửaHuyệnToolStripMenuItem
            // 
            this.chỉnhSửaHuyệnToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.Edit_16x16;
            this.chỉnhSửaHuyệnToolStripMenuItem.Name = "chỉnhSửaHuyệnToolStripMenuItem";
            this.chỉnhSửaHuyệnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.chỉnhSửaHuyệnToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.chỉnhSửaHuyệnToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // danhSáchThíSinhDựThiToolStripMenuItem
            // 
            this.danhSáchThíSinhDựThiToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.iconlist;
            this.danhSáchThíSinhDựThiToolStripMenuItem.Name = "danhSáchThíSinhDựThiToolStripMenuItem";
            this.danhSáchThíSinhDựThiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.danhSáchThíSinhDựThiToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.danhSáchThíSinhDựThiToolStripMenuItem.Text = "Danh sách thí sinh dự thi";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // xoáHuyệnNàyToolStripMenuItem
            // 
            this.xoáHuyệnNàyToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.Delete_16x16;
            this.xoáHuyệnNàyToolStripMenuItem.Name = "xoáHuyệnNàyToolStripMenuItem";
            this.xoáHuyệnNàyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xoáHuyệnNàyToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.xoáHuyệnNàyToolStripMenuItem.Text = "Xoá môn thi này";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Danh sách huyện trong tỉnh";
            this.gridView1.GroupRowHeight = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Nhấn vào đây để nhập hội đồng thi mới";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Môn thi";
            this.gridColumn1.FieldName = "TenMonThi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 313;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số thí sinh";
            this.gridColumn2.FieldName = "SoThiSinh";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.AllowSize = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(592, 30);
            this.panel1.TabIndex = 7;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton4.Image = global::QuanLyThiNghe.Properties.Resources.iconlist;
            this.simpleButton4.Location = new System.Drawing.Point(339, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(150, 24);
            this.simpleButton4.TabIndex = 6;
            this.simpleButton4.Text = "Danh sách thí sinh dự thi";
            this.simpleButton4.ToolTip = "Thêm huyện mới        Ctr + N";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton3.Image = global::QuanLyThiNghe.Properties.Resources.Delete_16x16;
            this.simpleButton3.Location = new System.Drawing.Point(103, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(100, 24);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Xoá môn thi";
            this.simpleButton3.ToolTip = "Thêm huyện mới        Ctr + N";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton2.Image = global::QuanLyThiNghe.Properties.Resources.Add_16x16;
            this.simpleButton2.Location = new System.Drawing.Point(3, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(100, 24);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Thêm môn thi";
            this.simpleButton2.ToolTip = "Thêm huyện mới        Ctr + N";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.Image = global::QuanLyThiNghe.Properties.Resources.Print_16x16;
            this.simpleButton1.Location = new System.Drawing.Point(489, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 24);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "In danh sách";
            // 
            // frmMonThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMonThi";
            this.Text = "Danh sách môn thi";
            this.Load += new System.EventHandler(this.frmMonThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem thêmHuyệnMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaHuyệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchThíSinhDựThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xoáHuyệnNàyToolStripMenuItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;

    }
}