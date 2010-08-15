namespace QuanLyThiNghe.Forms
{
    partial class frmSaoLuuPhucHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaoLuuPhucHoi));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmHuyệnMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xóaSaoLưuNàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::QuanLyThiNghe.Properties.Resources.Add_16x16;
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Backup dữ liệu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::QuanLyThiNghe.Properties.Resources.pin;
            this.simpleButton2.Location = new System.Drawing.Point(118, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(117, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Phục hồi dữ liệu";
            this.simpleButton2.ToolTip = "Phục hồi lại dữ liệu đang được chọn bên dưới";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.ContextMenuStrip = this.Menu;
            this.gridControl1.Location = new System.Drawing.Point(13, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(492, 318);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.gridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Lần backup";
            this.gridColumn1.FieldName = "Ten";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Đường dẫn file Backup";
            this.gridColumn2.FieldName = "GiaTri";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày tạo";
            this.gridColumn3.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "NgayTao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHuyệnMớiToolStripMenuItem,
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem,
            this.toolStripSeparator1,
            this.xóaSaoLưuNàyToolStripMenuItem});
            this.Menu.Name = "contextMenuStrip1";
            this.Menu.Size = new System.Drawing.Size(176, 76);
            // 
            // thêmHuyệnMớiToolStripMenuItem
            // 
            this.thêmHuyệnMớiToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.Add_16x16;
            this.thêmHuyệnMớiToolStripMenuItem.Name = "thêmHuyệnMớiToolStripMenuItem";
            this.thêmHuyệnMớiToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.thêmHuyệnMớiToolStripMenuItem.Text = "Backup dữ liệu";
            this.thêmHuyệnMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmHuyệnMớiToolStripMenuItem_Click);
            // 
            // xemDanhSáchTrườngTrongHuyệnToolStripMenuItem
            // 
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.iconlist;
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem.Name = "xemDanhSáchTrườngTrongHuyệnToolStripMenuItem";
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem.Text = "Phục hồi lại dữ liệu";
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // xóaSaoLưuNàyToolStripMenuItem
            // 
            this.xóaSaoLưuNàyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xóaSaoLưuNàyToolStripMenuItem.Image")));
            this.xóaSaoLưuNàyToolStripMenuItem.Name = "xóaSaoLưuNàyToolStripMenuItem";
            this.xóaSaoLưuNàyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.xóaSaoLưuNàyToolStripMenuItem.Text = "Xóa sao lưu này";
            this.xóaSaoLưuNàyToolStripMenuItem.Click += new System.EventHandler(this.xóaSaoLưuNàyToolStripMenuItem_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::QuanLyThiNghe.Properties.Resources.Delete_16x16;
            this.simpleButton3.Location = new System.Drawing.Point(241, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(117, 23);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Xóa sao lưu";
            this.simpleButton3.ToolTip = "Xóa sao lưu dữ liệu đang được chọn";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // frmSaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 372);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmSaoLuuPhucHoi";
            this.Text = "Sao lưu - phục hồi cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.frmSaoLuuPhucHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem thêmHuyệnMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchTrườngTrongHuyệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ToolStripMenuItem xóaSaoLưuNàyToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}