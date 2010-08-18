namespace QuanLyThiNghe.Forms
{
    partial class frmHoiDongThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoiDongThi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateRooms = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gcHDT = new DevExpress.XtraGrid.GridControl();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmHuyệnMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchThíSinhDựThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xoáHuyệnNàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvHDT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvColSchoolName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvColNumOfRooms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cbSchools = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gluESchoolName = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.luESchools = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHDT)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSchools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluESchoolName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luESchools)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCreateRooms);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(691, 30);
            this.panel1.TabIndex = 2;
            // 
            // btnCreateRooms
            // 
            this.btnCreateRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateRooms.Image = global::QuanLyThiNghe.Properties.Resources.iconlist;
            this.btnCreateRooms.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCreateRooms.Location = new System.Drawing.Point(449, 3);
            this.btnCreateRooms.Name = "btnCreateRooms";
            this.btnCreateRooms.Size = new System.Drawing.Size(160, 24);
            this.btnCreateRooms.TabIndex = 5;
            this.btnCreateRooms.Text = "Xem/Sắp xếp hội đồng thi";
            this.btnCreateRooms.ToolTip = "Sắp xếp hội đồng thi.";
            this.btnCreateRooms.Click += new System.EventHandler(this.btnCreateRooms_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QuanLyThiNghe.Properties.Resources.Delete_16x16;
            this.btnDelete.Location = new System.Drawing.Point(82, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.ToolTip = "Xoá hội đồng thi đang chọn.";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QuanLyThiNghe.Properties.Resources.Add_16x16;
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.ToolTip = "Lưu lại các thay đổi.";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::QuanLyThiNghe.Properties.Resources.Print_16x16;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(611, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 24);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "In";
            this.btnPrint.ToolTip = "In danh sách Hội đồng thi.";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gcHDT
            // 
            this.gcHDT.ContextMenuStrip = this.Menu;
            this.gcHDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHDT.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcHDT.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gcHDT.Location = new System.Drawing.Point(0, 30);
            this.gcHDT.MainView = this.gvHDT;
            this.gcHDT.Name = "gcHDT";
            this.gcHDT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.cbSchools,
            this.gluESchoolName,
            this.luESchools});
            this.gcHDT.ShowOnlyPredefinedDetails = true;
            this.gcHDT.Size = new System.Drawing.Size(691, 367);
            this.gcHDT.TabIndex = 4;
            this.gcHDT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHDT});
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHuyệnMớiToolStripMenuItem,
            this.btnEdit,
            this.danhSáchThíSinhDựThiToolStripMenuItem,
            this.toolStripSeparator1,
            this.xoáHuyệnNàyToolStripMenuItem});
            this.Menu.Name = "contextMenuStrip1";
            this.Menu.Size = new System.Drawing.Size(161, 120);
            // 
            // thêmHuyệnMớiToolStripMenuItem
            // 
            this.thêmHuyệnMớiToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.Add_16x16;
            this.thêmHuyệnMớiToolStripMenuItem.Name = "thêmHuyệnMớiToolStripMenuItem";
            this.thêmHuyệnMớiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.thêmHuyệnMớiToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.thêmHuyệnMớiToolStripMenuItem.Text = "Thêm mới";
            this.thêmHuyệnMớiToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::QuanLyThiNghe.Properties.Resources.Edit_16x16;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.btnEdit.Size = new System.Drawing.Size(160, 22);
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // danhSáchThíSinhDựThiToolStripMenuItem
            // 
            this.danhSáchThíSinhDựThiToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.iconlist;
            this.danhSáchThíSinhDựThiToolStripMenuItem.Name = "danhSáchThíSinhDựThiToolStripMenuItem";
            this.danhSáchThíSinhDựThiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.danhSáchThíSinhDựThiToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.danhSáchThíSinhDựThiToolStripMenuItem.Text = "Sắp xếp HĐT";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // xoáHuyệnNàyToolStripMenuItem
            // 
            this.xoáHuyệnNàyToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.Delete_16x16;
            this.xoáHuyệnNàyToolStripMenuItem.Name = "xoáHuyệnNàyToolStripMenuItem";
            this.xoáHuyệnNàyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.xoáHuyệnNàyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.xoáHuyệnNàyToolStripMenuItem.Text = "Xoá";
            // 
            // gvHDT
            // 
            this.gvHDT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gvColSchoolName,
            this.gvColNumOfRooms,
            this.gridColumn2});
            this.gvHDT.GridControl = this.gcHDT;
            this.gvHDT.GroupPanelText = "Danh sách huyện trong tỉnh";
            this.gvHDT.GroupRowHeight = 0;
            this.gvHDT.Name = "gvHDT";
            this.gvHDT.NewItemRowText = "Nhấn vào đây để nhập hội đồng thi mới";
            this.gvHDT.OptionsCustomization.AllowColumnMoving = false;
            this.gvHDT.OptionsCustomization.AllowColumnResizing = false;
            this.gvHDT.OptionsCustomization.AllowGroup = false;
            this.gvHDT.OptionsMenu.EnableColumnMenu = false;
            this.gvHDT.OptionsMenu.EnableFooterMenu = false;
            this.gvHDT.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvHDT.OptionsView.EnableAppearanceOddRow = true;
            this.gvHDT.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvHDT.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "MaHoiDong";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gvColSchoolName
            // 
            this.gvColSchoolName.Caption = "Hội đồng thi";
            this.gvColSchoolName.FieldName = "TenTruong";
            this.gvColSchoolName.Name = "gvColSchoolName";
            this.gvColSchoolName.OptionsColumn.AllowEdit = false;
            this.gvColSchoolName.OptionsColumn.ReadOnly = true;
            this.gvColSchoolName.Visible = true;
            this.gvColSchoolName.VisibleIndex = 0;
            this.gvColSchoolName.Width = 437;
            // 
            // gvColNumOfRooms
            // 
            this.gvColNumOfRooms.AppearanceCell.Options.UseTextOptions = true;
            this.gvColNumOfRooms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvColNumOfRooms.AppearanceHeader.Options.UseTextOptions = true;
            this.gvColNumOfRooms.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvColNumOfRooms.Caption = "Phòng thi(dự tính)";
            this.gvColNumOfRooms.FieldName = "SoLuongPhongDuTinh";
            this.gvColNumOfRooms.Name = "gvColNumOfRooms";
            this.gvColNumOfRooms.OptionsColumn.AllowFocus = false;
            this.gvColNumOfRooms.OptionsColumn.AllowMove = false;
            this.gvColNumOfRooms.OptionsColumn.AllowSize = false;
            this.gvColNumOfRooms.OptionsColumn.ReadOnly = true;
            this.gvColNumOfRooms.Visible = true;
            this.gvColNumOfRooms.VisibleIndex = 1;
            this.gvColNumOfRooms.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Thí sinh(dự tính)";
            this.gridColumn2.FieldName = "SoThiSinhDuTinh";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 133;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // cbSchools
            // 
            this.cbSchools.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbSchools.AutoHeight = false;
            this.cbSchools.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSchools.DropDownRows = 10;
            this.cbSchools.Name = "cbSchools";
            // 
            // gluESchoolName
            // 
            this.gluESchoolName.AutoHeight = false;
            this.gluESchoolName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.gluESchoolName.Name = "gluESchoolName";
            this.gluESchoolName.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gluESchoolName.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // luESchools
            // 
            this.luESchools.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.luESchools.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.luESchools.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTruong", "Tên trường")});
            this.luESchools.DisplayMember = "TenTruong";
            this.luESchools.DropDownRows = 10;
            this.luESchools.Name = "luESchools";
            this.luESchools.NullText = "Chưa nhập dữ liệu";
            this.luESchools.PopupSizeable = false;
            this.luESchools.PopupWidth = 20;
            this.luESchools.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.luESchools.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luESchools.ValueMember = "TenTruong";
            // 
            // frmHoiDongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 397);
            this.Controls.Add(this.gcHDT);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoiDongThi";
            this.Text = "Danh sách hội đồng thi";
            this.Load += new System.EventHandler(this.frmHoiDongThi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHDT)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSchools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluESchoolName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luESchools)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl gcHDT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHDT;
        private DevExpress.XtraGrid.Columns.GridColumn gvColSchoolName;
        private DevExpress.XtraGrid.Columns.GridColumn gvColNumOfRooms;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btnCreateRooms;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbSchools;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluESchoolName;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luESchools;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem thêmHuyệnMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem danhSáchThíSinhDựThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xoáHuyệnNàyToolStripMenuItem;

    }
}