namespace QuanLyThiNghe.Forms
{
    partial class frmTaoPhongThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoPhongThi));
            this.cbDistricts = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.lblSchoolName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblDistrictName = new DevExpress.XtraEditors.LabelControl();
            this.lblSoPhongDuTinh = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbHDT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblSoThiSinhDuTinh = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblSoPhong = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lblSoThiSinh = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.gcHDT = new DevExpress.XtraGrid.GridControl();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.danhSáchThíSinhDựThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xoáHuyệnNàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvHDT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvColSchoolName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvColNumOfRooms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cbSchools = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gluESchoolName = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.luESchools = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.cbMonThi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cbTruong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.lblSoThiSinh1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbDistricts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHDT)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSchools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluESchoolName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luESchools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDistricts
            // 
            this.cbDistricts.Location = new System.Drawing.Point(84, 10);
            this.cbDistricts.Name = "cbDistricts";
            this.cbDistricts.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbDistricts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.cbDistricts.Properties.DropDownRows = 10;
            this.cbDistricts.Size = new System.Drawing.Size(188, 20);
            this.cbDistricts.TabIndex = 28;
            this.cbDistricts.SelectedIndexChanged += new System.EventHandler(this.cbDistricts_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl8.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseImage = true;
            this.labelControl8.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl8.Location = new System.Drawing.Point(8, 10);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 20);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Huyện:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Truong.png");
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelControl15.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.pin;
            this.labelControl15.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Appearance.Options.UseImage = true;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl15.LineColor = System.Drawing.Color.Silver;
            this.labelControl15.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl15.LineVisible = true;
            this.labelControl15.Location = new System.Drawing.Point(299, 43);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(318, 23);
            this.labelControl15.TabIndex = 24;
            this.labelControl15.Text = "Thông tin về Hội đồng thi:";
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSchoolName.Appearance.Options.UseFont = true;
            this.lblSchoolName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblSchoolName.Location = new System.Drawing.Point(401, 75);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(84, 14);
            this.lblSchoolName.TabIndex = 21;
            this.lblSchoolName.Text = "Đốc Binh Kiều";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.tag_blue;
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseImage = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(299, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 20);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Huyện:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.tag_blue;
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseImage = true;
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl4.Location = new System.Drawing.Point(299, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 20);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Phòng(DT):";
            // 
            // lblDistrictName
            // 
            this.lblDistrictName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrictName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDistrictName.Appearance.Options.UseFont = true;
            this.lblDistrictName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblDistrictName.Location = new System.Drawing.Point(401, 98);
            this.lblDistrictName.Name = "lblDistrictName";
            this.lblDistrictName.Size = new System.Drawing.Size(33, 14);
            this.lblDistrictName.TabIndex = 21;
            this.lblDistrictName.Text = "Cai lậy";
            // 
            // lblSoPhongDuTinh
            // 
            this.lblSoPhongDuTinh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhongDuTinh.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblSoPhongDuTinh.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoPhongDuTinh.Appearance.Options.UseFont = true;
            this.lblSoPhongDuTinh.Appearance.Options.UseForeColor = true;
            this.lblSoPhongDuTinh.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblSoPhongDuTinh.Location = new System.Drawing.Point(401, 121);
            this.lblSoPhongDuTinh.Name = "lblSoPhongDuTinh";
            this.lblSoPhongDuTinh.Size = new System.Drawing.Size(8, 14);
            this.lblSoPhongDuTinh.TabIndex = 21;
            this.lblSoPhongDuTinh.Text = "0";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelControl7.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.pin;
            this.labelControl7.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Appearance.Options.UseImage = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl7.LineColor = System.Drawing.Color.Silver;
            this.labelControl7.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 160);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(616, 23);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Các trường tham gia HĐT này:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.tag_blue;
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseImage = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(299, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 20);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Tên HĐT:";
            // 
            // cbHDT
            // 
            this.cbHDT.Location = new System.Drawing.Point(436, 10);
            this.cbHDT.Name = "cbHDT";
            this.cbHDT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.cbHDT.Size = new System.Drawing.Size(181, 20);
            this.cbHDT.TabIndex = 30;
            this.cbHDT.SelectedIndexChanged += new System.EventHandler(this.cbHDT_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(299, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 20);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Chọn Hội đồng thi:";
            // 
            // lblSoThiSinhDuTinh
            // 
            this.lblSoThiSinhDuTinh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoThiSinhDuTinh.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblSoThiSinhDuTinh.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoThiSinhDuTinh.Appearance.Options.UseFont = true;
            this.lblSoThiSinhDuTinh.Appearance.Options.UseForeColor = true;
            this.lblSoThiSinhDuTinh.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblSoThiSinhDuTinh.Location = new System.Drawing.Point(401, 144);
            this.lblSoThiSinhDuTinh.Name = "lblSoThiSinhDuTinh";
            this.lblSoThiSinhDuTinh.Size = new System.Drawing.Size(8, 14);
            this.lblSoThiSinhDuTinh.TabIndex = 21;
            this.lblSoThiSinhDuTinh.Text = "0";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.tag_blue;
            this.labelControl6.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseImage = true;
            this.labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl6.Location = new System.Drawing.Point(299, 141);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(93, 20);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Thí sinh(DT):";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhong.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblSoPhong.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoPhong.Appearance.Options.UseFont = true;
            this.lblSoPhong.Appearance.Options.UseForeColor = true;
            this.lblSoPhong.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblSoPhong.Location = new System.Drawing.Point(562, 121);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(8, 14);
            this.lblSoPhong.TabIndex = 21;
            this.lblSoPhong.Text = "0";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.tag_blue;
            this.labelControl10.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseImage = true;
            this.labelControl10.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl10.Location = new System.Drawing.Point(460, 118);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(86, 20);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "Phòng(TT):";
            // 
            // lblSoThiSinh
            // 
            this.lblSoThiSinh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoThiSinh.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblSoThiSinh.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoThiSinh.Appearance.Options.UseFont = true;
            this.lblSoThiSinh.Appearance.Options.UseForeColor = true;
            this.lblSoThiSinh.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblSoThiSinh.Location = new System.Drawing.Point(562, 144);
            this.lblSoThiSinh.Name = "lblSoThiSinh";
            this.lblSoThiSinh.Size = new System.Drawing.Size(8, 14);
            this.lblSoThiSinh.TabIndex = 21;
            this.lblSoThiSinh.Text = "0";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.tag_blue;
            this.labelControl12.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseImage = true;
            this.labelControl12.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl12.Location = new System.Drawing.Point(460, 141);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(93, 20);
            this.labelControl12.TabIndex = 21;
            this.labelControl12.Text = "Thí sinh(TT):";
            // 
            // gcHDT
            // 
            this.gcHDT.ContextMenuStrip = this.Menu;
            this.gcHDT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcHDT.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcHDT.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcHDT.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gcHDT.Location = new System.Drawing.Point(5, 189);
            this.gcHDT.MainView = this.gvHDT;
            this.gcHDT.Name = "gcHDT";
            this.gcHDT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.cbSchools,
            this.gluESchoolName,
            this.luESchools});
            this.gcHDT.ShowOnlyPredefinedDetails = true;
            this.gcHDT.Size = new System.Drawing.Size(616, 201);
            this.gcHDT.TabIndex = 25;
            this.gcHDT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHDT});
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchThíSinhDựThiToolStripMenuItem,
            this.toolStripSeparator1,
            this.xoáHuyệnNàyToolStripMenuItem});
            this.Menu.Name = "contextMenuStrip1";
            this.Menu.Size = new System.Drawing.Size(217, 54);
            // 
            // danhSáchThíSinhDựThiToolStripMenuItem
            // 
            this.danhSáchThíSinhDựThiToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.iconlist;
            this.danhSáchThíSinhDựThiToolStripMenuItem.Name = "danhSáchThíSinhDựThiToolStripMenuItem";
            this.danhSáchThíSinhDựThiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.danhSáchThíSinhDựThiToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.danhSáchThíSinhDựThiToolStripMenuItem.Text = "Xem danh sách thí sinh";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // xoáHuyệnNàyToolStripMenuItem
            // 
            this.xoáHuyệnNàyToolStripMenuItem.Image = global::QuanLyThiNghe.Properties.Resources.Delete_16x16;
            this.xoáHuyệnNàyToolStripMenuItem.Name = "xoáHuyệnNàyToolStripMenuItem";
            this.xoáHuyệnNàyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.xoáHuyệnNàyToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.xoáHuyệnNàyToolStripMenuItem.Text = "Xoá";
            // 
            // gvHDT
            // 
            this.gvHDT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gvColSchoolName,
            this.gridColumn3,
            this.gridColumn4,
            this.gvColNumOfRooms,
            this.gridColumn2});
            this.gvHDT.GridControl = this.gcHDT;
            this.gvHDT.GroupPanelText = "Danh sách huyện trong tỉnh";
            this.gvHDT.GroupRowHeight = 0;
            this.gvHDT.Name = "gvHDT";
            this.gvHDT.NewItemRowText = "Nhấn vào đây để nhập hội đồng thi mới";
            this.gvHDT.OptionsCustomization.AllowColumnMoving = false;
            this.gvHDT.OptionsCustomization.AllowColumnResizing = false;
            this.gvHDT.OptionsMenu.EnableColumnMenu = false;
            this.gvHDT.OptionsMenu.EnableFooterMenu = false;
            this.gvHDT.OptionsView.EnableAppearanceOddRow = true;
            this.gvHDT.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvHDT.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "MaTruong";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // gvColSchoolName
            // 
            this.gvColSchoolName.Caption = "Tên trường";
            this.gvColSchoolName.FieldName = "TenTruong";
            this.gvColSchoolName.Name = "gvColSchoolName";
            this.gvColSchoolName.OptionsColumn.AllowEdit = false;
            this.gvColSchoolName.OptionsColumn.ReadOnly = true;
            this.gvColSchoolName.Visible = true;
            this.gvColSchoolName.VisibleIndex = 0;
            this.gvColSchoolName.Width = 215;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Môn thi";
            this.gridColumn3.FieldName = "TenMonThi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 110;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Huyện";
            this.gridColumn4.FieldName = "TenHuyen";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 100;
            // 
            // gvColNumOfRooms
            // 
            this.gvColNumOfRooms.AppearanceCell.Options.UseTextOptions = true;
            this.gvColNumOfRooms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvColNumOfRooms.AppearanceHeader.Options.UseTextOptions = true;
            this.gvColNumOfRooms.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvColNumOfRooms.Caption = "Phòng thi";
            this.gvColNumOfRooms.FieldName = "SoLuongPhongDuTinh";
            this.gvColNumOfRooms.Name = "gvColNumOfRooms";
            this.gvColNumOfRooms.OptionsColumn.AllowFocus = false;
            this.gvColNumOfRooms.OptionsColumn.AllowMove = false;
            this.gvColNumOfRooms.OptionsColumn.AllowSize = false;
            this.gvColNumOfRooms.OptionsColumn.ReadOnly = true;
            this.gvColNumOfRooms.Visible = true;
            this.gvColNumOfRooms.VisibleIndex = 3;
            this.gvColNumOfRooms.Width = 82;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Thí sinh";
            this.gridColumn2.FieldName = "SoThiSinhDuTinh";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 88;
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
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.labelControl16);
            this.panelControl1.Controls.Add(this.cbMonThi);
            this.panelControl1.Controls.Add(this.labelControl14);
            this.panelControl1.Controls.Add(this.cbTruong);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Controls.Add(this.cbDistricts);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.lblSoThiSinh1);
            this.panelControl1.Location = new System.Drawing.Point(8, 8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(282, 148);
            this.panelControl1.TabIndex = 31;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QuanLyThiNghe.Properties.Resources.Add_16x16;
            this.btnSave.Location = new System.Drawing.Point(8, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(264, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Thêm môn thi này vào Hội đồng thi";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl16.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseImage = true;
            this.labelControl16.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl16.Location = new System.Drawing.Point(8, 88);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(150, 20);
            this.labelControl16.TabIndex = 29;
            this.labelControl16.Text = "Tổng số thí sinh dự thi:";
            // 
            // cbMonThi
            // 
            this.cbMonThi.Location = new System.Drawing.Point(84, 62);
            this.cbMonThi.Name = "cbMonThi";
            this.cbMonThi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbMonThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.cbMonThi.Properties.DropDownRows = 10;
            this.cbMonThi.Size = new System.Drawing.Size(188, 20);
            this.cbMonThi.TabIndex = 28;
            this.cbMonThi.SelectedIndexChanged += new System.EventHandler(this.cbMonThi_SelectedIndexChanged);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl14.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseImage = true;
            this.labelControl14.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl14.Location = new System.Drawing.Point(8, 62);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(66, 20);
            this.labelControl14.TabIndex = 27;
            this.labelControl14.Text = "Môn thi:";
            // 
            // cbTruong
            // 
            this.cbTruong.Location = new System.Drawing.Point(84, 36);
            this.cbTruong.Name = "cbTruong";
            this.cbTruong.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbTruong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.cbTruong.Properties.DropDownRows = 10;
            this.cbTruong.Size = new System.Drawing.Size(188, 20);
            this.cbTruong.TabIndex = 28;
            this.cbTruong.SelectedIndexChanged += new System.EventHandler(this.cbTruong_SelectedIndexChanged);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl13.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseImage = true;
            this.labelControl13.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl13.Location = new System.Drawing.Point(8, 36);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(66, 20);
            this.labelControl13.TabIndex = 27;
            this.labelControl13.Text = "Trường:";
            // 
            // lblSoThiSinh1
            // 
            this.lblSoThiSinh1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoThiSinh1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblSoThiSinh1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoThiSinh1.Appearance.Options.UseFont = true;
            this.lblSoThiSinh1.Appearance.Options.UseForeColor = true;
            this.lblSoThiSinh1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblSoThiSinh1.Location = new System.Drawing.Point(164, 91);
            this.lblSoThiSinh1.Name = "lblSoThiSinh1";
            this.lblSoThiSinh1.Size = new System.Drawing.Size(8, 14);
            this.lblSoThiSinh1.TabIndex = 21;
            this.lblSoThiSinh1.Text = "0";
            // 
            // frmTaoPhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 395);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.cbHDT);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcHDT);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.lblSoThiSinh);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.lblSoThiSinhDuTinh);
            this.Controls.Add(this.lblSoPhong);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblSoPhongDuTinh);
            this.Controls.Add(this.lblDistrictName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblSchoolName);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaoPhongThi";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem/Sắp xếp Hội Đồng thi";
            this.Load += new System.EventHandler(this.frmTaoPhongThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbDistricts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHDT)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSchools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluESchoolName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luESchools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl lblSchoolName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblDistrictName;
        private DevExpress.XtraEditors.LabelControl lblSoPhongDuTinh;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cbDistricts;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbHDT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblSoThiSinhDuTinh;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblSoPhong;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lblSoThiSinh;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraGrid.GridControl gcHDT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHDT;
        private DevExpress.XtraGrid.Columns.GridColumn gvColSchoolName;
        private DevExpress.XtraGrid.Columns.GridColumn gvColNumOfRooms;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbSchools;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluESchoolName;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luESchools;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbTruong;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.ComboBoxEdit cbMonThi;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl lblSoThiSinh1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem danhSáchThíSinhDựThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xoáHuyệnNàyToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}