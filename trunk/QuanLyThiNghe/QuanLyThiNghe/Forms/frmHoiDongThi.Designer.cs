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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateRooms = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteChecked = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gcHDT = new DevExpress.XtraGrid.GridControl();
            this.gvHDT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvColSchoolName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvColNumOfRooms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvColCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cbSchools = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gluESchoolName = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.luESchools = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHDT)).BeginInit();
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
            this.panel1.Controls.Add(this.btnDeleteChecked);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(691, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnCreateRooms
            // 
            this.btnCreateRooms.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreateRooms.Image = global::QuanLyThiNghe.Properties.Resources.Print_16x16;
            this.btnCreateRooms.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCreateRooms.Location = new System.Drawing.Point(473, 5);
            this.btnCreateRooms.Name = "btnCreateRooms";
            this.btnCreateRooms.Size = new System.Drawing.Size(120, 40);
            this.btnCreateRooms.TabIndex = 5;
            this.btnCreateRooms.Text = "Sắp xếp HĐT";
            this.btnCreateRooms.ToolTip = "Sắp xếp hội đồng thi.";
            this.btnCreateRooms.Click += new System.EventHandler(this.btnCreateRooms_Click);
            // 
            // btnDeleteChecked
            // 
            this.btnDeleteChecked.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteChecked.Image = global::QuanLyThiNghe.Properties.Resources.Delete_16x16;
            this.btnDeleteChecked.Location = new System.Drawing.Point(191, 5);
            this.btnDeleteChecked.Name = "btnDeleteChecked";
            this.btnDeleteChecked.Size = new System.Drawing.Size(93, 40);
            this.btnDeleteChecked.TabIndex = 4;
            this.btnDeleteChecked.Text = "Ctrl+ Del";
            this.btnDeleteChecked.ToolTip = "Xoá các hội đồng thi được chọn.";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Image = global::QuanLyThiNghe.Properties.Resources.Delete_16x16;
            this.btnDelete.Location = new System.Drawing.Point(98, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTip = "Xoá hội đồng thi đang chọn.";
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Image = global::QuanLyThiNghe.Properties.Resources.save_16;
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ctrl+ S";
            this.btnAdd.ToolTip = "Lưu lại các thay đổi.";
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Image = global::QuanLyThiNghe.Properties.Resources.Print_16x16;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(593, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 40);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Ctrl+ P";
            this.btnPrint.ToolTip = "In danh sách Hội đồng thi.";
            // 
            // gcHDT
            // 
            this.gcHDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHDT.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcHDT.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gcHDT.Location = new System.Drawing.Point(0, 50);
            this.gcHDT.MainView = this.gvHDT;
            this.gcHDT.Name = "gcHDT";
            this.gcHDT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.cbSchools,
            this.gluESchoolName,
            this.luESchools});
            this.gcHDT.ShowOnlyPredefinedDetails = true;
            this.gcHDT.Size = new System.Drawing.Size(691, 347);
            this.gcHDT.TabIndex = 4;
            this.gcHDT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHDT});
            this.gcHDT.Load += new System.EventHandler(this.gcHDT_Load);
            // 
            // gvHDT
            // 
            this.gvHDT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gvColSchoolName,
            this.gvColNumOfRooms,
            this.gvColCheck});
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
            // gvColSchoolName
            // 
            this.gvColSchoolName.Caption = "Hội đồng thi";
            this.gvColSchoolName.FieldName = "TenTruong";
            this.gvColSchoolName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.gvColSchoolName.Name = "gvColSchoolName";
            this.gvColSchoolName.OptionsColumn.AllowEdit = false;
            this.gvColSchoolName.OptionsColumn.ReadOnly = true;
            this.gvColSchoolName.Visible = true;
            this.gvColSchoolName.VisibleIndex = 0;
            this.gvColSchoolName.Width = 406;
            // 
            // gvColNumOfRooms
            // 
            this.gvColNumOfRooms.AppearanceCell.Options.UseTextOptions = true;
            this.gvColNumOfRooms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvColNumOfRooms.AppearanceHeader.Options.UseTextOptions = true;
            this.gvColNumOfRooms.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvColNumOfRooms.Caption = "Số phòng thi";
            this.gvColNumOfRooms.FieldName = "SoLuongPhong";
            this.gvColNumOfRooms.Name = "gvColNumOfRooms";
            this.gvColNumOfRooms.OptionsColumn.AllowFocus = false;
            this.gvColNumOfRooms.OptionsColumn.AllowMove = false;
            this.gvColNumOfRooms.OptionsColumn.AllowSize = false;
            this.gvColNumOfRooms.OptionsColumn.ReadOnly = true;
            this.gvColNumOfRooms.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gvColNumOfRooms.Visible = true;
            this.gvColNumOfRooms.VisibleIndex = 1;
            this.gvColNumOfRooms.Width = 125;
            // 
            // gvColCheck
            // 
            this.gvColCheck.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gvColCheck.Name = "gvColCheck";
            this.gvColCheck.OptionsColumn.AllowMove = false;
            this.gvColCheck.OptionsColumn.AllowSize = false;
            this.gvColCheck.OptionsColumn.FixedWidth = true;
            this.gvColCheck.OptionsColumn.ShowCaption = false;
            this.gvColCheck.Visible = true;
            this.gvColCheck.VisibleIndex = 2;
            this.gvColCheck.Width = 40;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTruong", "Tên trường", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
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
            this.Name = "frmHoiDongThi";
            this.Text = "Danh sách hội đồng thi";
            this.Load += new System.EventHandler(this.frmHoiDongThi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHDT)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnDeleteChecked;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl gcHDT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHDT;
        private DevExpress.XtraGrid.Columns.GridColumn gvColSchoolName;
        private DevExpress.XtraGrid.Columns.GridColumn gvColNumOfRooms;
        private DevExpress.XtraGrid.Columns.GridColumn gvColCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btnCreateRooms;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbSchools;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluESchoolName;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luESchools;

    }
}