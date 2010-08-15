namespace QuanLyThiNghe.Forms
{
    partial class frmHuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHuyen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewSchoolInDistricts = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteSelected = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gvDistricts = new DevExpress.XtraGrid.GridControl();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmHuyệnMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xoáHuyệnNàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáCácHuyệnĐượcChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDistricts)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewSchoolInDistricts);
            this.panel1.Controls.Add(this.btnDeleteSelected);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(592, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnViewSchoolInDistricts
            // 
            this.btnViewSchoolInDistricts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewSchoolInDistricts.Image = global::QuanLyThiNghe.Properties.Resources.iconlist;
            this.btnViewSchoolInDistricts.Location = new System.Drawing.Point(401, 3);
            this.btnViewSchoolInDistricts.Name = "btnViewSchoolInDistricts";
            this.btnViewSchoolInDistricts.Size = new System.Drawing.Size(125, 24);
            this.btnViewSchoolInDistricts.TabIndex = 5;
            this.btnViewSchoolInDistricts.Text = "Danh sách trường";
            this.btnViewSchoolInDistricts.ToolTip = "Thêm huyện mới        Ctr + N";
            this.btnViewSchoolInDistricts.Click += new System.EventHandler(this.btnViewSchoolInDistricts_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Image = global::QuanLyThiNghe.Properties.Resources.Delete_16x16;
            this.btnDeleteSelected.Location = new System.Drawing.Point(127, 3);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(130, 24);
            this.btnDeleteSelected.TabIndex = 4;
            this.btnDeleteSelected.Text = "Xoá huyện đã chọn";
            this.btnDeleteSelected.ToolTip = "Thêm huyện mới        Ctr + N";
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QuanLyThiNghe.Properties.Resources.Delete_16x16;
            this.btnDelete.Location = new System.Drawing.Point(65, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 24);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.ToolTip = "Thêm huyện mới        Ctr + N";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QuanLyThiNghe.Properties.Resources.Add_16x16;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.ToolTip = "Thêm huyện mới        Ctr + N";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::QuanLyThiNghe.Properties.Resources.Print_16x16;
            this.btnPrint.Location = new System.Drawing.Point(528, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(60, 24);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gvDistricts
            // 
            this.gvDistricts.ContextMenuStrip = this.Menu;
            this.gvDistricts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDistricts.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gvDistricts.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gvDistricts.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gvDistricts.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gvDistricts.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gvDistricts.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gvDistricts.Location = new System.Drawing.Point(0, 30);
            this.gvDistricts.MainView = this.gridView1;
            this.gvDistricts.Name = "gvDistricts";
            this.gvDistricts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gvDistricts.Size = new System.Drawing.Size(592, 338);
            this.gvDistricts.TabIndex = 1;
            this.gvDistricts.UseEmbeddedNavigator = true;
            this.gvDistricts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHuyệnMớiToolStripMenuItem,
            this.btnEdit,
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem,
            this.toolStripSeparator1,
            this.xoáHuyệnNàyToolStripMenuItem,
            this.xoáCácHuyệnĐượcChọnToolStripMenuItem});
            this.Menu.Name = "contextMenuStrip1";
            this.Menu.Size = new System.Drawing.Size(263, 120);
            // 
            // thêmHuyệnMớiToolStripMenuItem
            // 
            this.thêmHuyệnMớiToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.Add_16x16;
            this.thêmHuyệnMớiToolStripMenuItem.Name = "thêmHuyệnMớiToolStripMenuItem";
            this.thêmHuyệnMớiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.thêmHuyệnMớiToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.thêmHuyệnMớiToolStripMenuItem.Text = "Thêm huyện mới";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::QuanLyThiNghe.Properties.Resources.Edit_16x16;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.btnEdit.Size = new System.Drawing.Size(262, 22);
            this.btnEdit.Text = "Chỉnh sửa huyện";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // xemDanhSáchTrườngTrongHuyệnToolStripMenuItem
            // 
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.iconlist;
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem.Name = "xemDanhSáchTrườngTrongHuyệnToolStripMenuItem";
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem.Text = "Danh sách trường trong huyện";
            this.xemDanhSáchTrườngTrongHuyệnToolStripMenuItem.Click += new System.EventHandler(this.btnViewSchoolInDistricts_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // xoáHuyệnNàyToolStripMenuItem
            // 
            this.xoáHuyệnNàyToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.Delete_16x16;
            this.xoáHuyệnNàyToolStripMenuItem.Name = "xoáHuyệnNàyToolStripMenuItem";
            this.xoáHuyệnNàyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.xoáHuyệnNàyToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.xoáHuyệnNàyToolStripMenuItem.Text = "Xoá huyện này";
            this.xoáHuyệnNàyToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // xoáCácHuyệnĐượcChọnToolStripMenuItem
            // 
            this.xoáCácHuyệnĐượcChọnToolStripMenuItem.Name = "xoáCácHuyệnĐượcChọnToolStripMenuItem";
            this.xoáCácHuyệnĐượcChọnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.xoáCácHuyệnĐượcChọnToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.xoáCácHuyệnĐượcChọnToolStripMenuItem.Text = "Xoá các huyện được chọn";
            this.xoáCácHuyệnĐượcChọnToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaHuyen,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gvDistricts;
            this.gridView1.GroupPanelText = "Danh sách huyện trong tỉnh";
            this.gridView1.GroupRowHeight = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Nhấn vào đây để nhập huyện mới";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cMaHuyen
            // 
            this.cMaHuyen.Caption = "gridColumn7";
            this.cMaHuyen.FieldName = "MaHuyen";
            this.cMaHuyen.Name = "cMaHuyen";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên huyện";
            this.gridColumn1.FieldName = "TenHuyen";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 295;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Trường";
            this.gridColumn2.FieldName = "SoTruong";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.AllowSize = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 50;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Ngày tạo";
            this.gridColumn3.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "NgayTao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 59;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Người tạo";
            this.gridColumn4.FieldName = "NguoiTao";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 63;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Ngày CN";
            this.gridColumn5.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn5.FieldName = "NgayCapNhat";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 69;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Người CN";
            this.gridColumn6.FieldName = "NguoiCapNhat";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // frmHuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.Controls.Add(this.gvDistricts);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHuyen";
            this.Text = "Danh mục huyện trong tỉnh";
            this.Load += new System.EventHandler(this.frmHuyen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDistricts)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl gvDistricts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem thêmHuyệnMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchTrườngTrongHuyệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xoáHuyệnNàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáCácHuyệnĐượcChọnToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnDeleteSelected;
        private DevExpress.XtraEditors.SimpleButton btnViewSchoolInDistricts;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn cMaHuyen;
    }
}