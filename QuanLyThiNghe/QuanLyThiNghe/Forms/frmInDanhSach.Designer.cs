namespace QuanLyThiNghe.Forms
{
    partial class frmInDanhSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInDanhSach));
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.dropDownButton2 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.dropDownButton3 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu3 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.dropDownButton4 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu4 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.dropDownButton5 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu5 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.dropDownButton6 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu6 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu6)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.Location = new System.Drawing.Point(9, 42);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(219, 23);
            this.dropDownButton1.TabIndex = 6;
            this.dropDownButton1.Text = "In danh sách phòng thi cho các trường";
            this.dropDownButton1.Click += new System.EventHandler(this.dropDownButton1_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thiết kế lại danh sách phòng thi";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageIndex = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageList1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7});
            this.barManager1.MaxItemId = 7;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Properties_16x16.png");
            this.imageList1.Images.SetKeyName(1, "Edit_16x16.png");
            this.imageList1.Images.SetKeyName(2, "script.ico");
            this.imageList1.Images.SetKeyName(3, "Photoshop CS2 green .ico");
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thiết kế lại danh sách phòng thi";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageIndex = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thiết kế lại báo cáo";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageIndex = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thiết kế lại danh sách mã phách";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageIndex = 2;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Đánh mã phách...";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageIndex = 0;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Thiết kế lại danh sách";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageIndex = 2;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Thiết kế lại danh sách";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageIndex = 2;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // dropDownButton2
            // 
            this.dropDownButton2.DropDownControl = this.popupMenu2;
            this.dropDownButton2.Location = new System.Drawing.Point(9, 71);
            this.dropDownButton2.Name = "dropDownButton2";
            this.dropDownButton2.Size = new System.Drawing.Size(219, 23);
            this.dropDownButton2.TabIndex = 7;
            this.dropDownButton2.Text = "In danh sách phòng thi cho hội đồng thi";
            // 
            // popupMenu2
            // 
            this.popupMenu2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.popupMenu2.Manager = this.barManager1;
            this.popupMenu2.Name = "popupMenu2";
            // 
            // dropDownButton3
            // 
            this.dropDownButton3.DropDownControl = this.popupMenu3;
            this.dropDownButton3.Location = new System.Drawing.Point(251, 71);
            this.dropDownButton3.Name = "dropDownButton3";
            this.dropDownButton3.Size = new System.Drawing.Size(219, 23);
            this.dropDownButton3.TabIndex = 8;
            this.dropDownButton3.Text = "Thống kê số lượng thí sinh dự thi";
            // 
            // popupMenu3
            // 
            this.popupMenu3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.popupMenu3.Manager = this.barManager1;
            this.popupMenu3.Name = "popupMenu3";
            // 
            // dropDownButton4
            // 
            this.dropDownButton4.DropDownControl = this.popupMenu4;
            this.dropDownButton4.Location = new System.Drawing.Point(251, 42);
            this.dropDownButton4.Name = "dropDownButton4";
            this.dropDownButton4.Size = new System.Drawing.Size(219, 23);
            this.dropDownButton4.TabIndex = 9;
            this.dropDownButton4.Text = "In danh sách mã phách";
            this.dropDownButton4.Click += new System.EventHandler(this.dropDownButton4_Click);
            // 
            // popupMenu4
            // 
            this.popupMenu4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.popupMenu4.Manager = this.barManager1;
            this.popupMenu4.Name = "popupMenu4";
            // 
            // dropDownButton5
            // 
            this.dropDownButton5.DropDownControl = this.popupMenu5;
            this.dropDownButton5.Location = new System.Drawing.Point(9, 100);
            this.dropDownButton5.Name = "dropDownButton5";
            this.dropDownButton5.Size = new System.Drawing.Size(219, 23);
            this.dropDownButton5.TabIndex = 10;
            this.dropDownButton5.Text = "In kết quả thi cho các trường";
            // 
            // popupMenu5
            // 
            this.popupMenu5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6)});
            this.popupMenu5.Manager = this.barManager1;
            this.popupMenu5.Name = "popupMenu5";
            // 
            // dropDownButton6
            // 
            this.dropDownButton6.DropDownControl = this.popupMenu6;
            this.dropDownButton6.Location = new System.Drawing.Point(9, 129);
            this.dropDownButton6.Name = "dropDownButton6";
            this.dropDownButton6.Size = new System.Drawing.Size(219, 23);
            this.dropDownButton6.TabIndex = 11;
            this.dropDownButton6.Text = "In kết quả thi cho các hội đồng thi";
            // 
            // popupMenu6
            // 
            this.popupMenu6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7)});
            this.popupMenu6.Manager = this.barManager1;
            this.popupMenu6.Name = "popupMenu6";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl8.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.pin;
            this.labelControl8.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Appearance.Options.UseImage = true;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl8.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl8.LineVisible = true;
            this.labelControl8.Location = new System.Drawing.Point(9, 7);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(218, 35);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Danh sách thí sinh";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.pin;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(251, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(218, 35);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Thống kê kỳ thi";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 481F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 470);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dropDownButton6);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dropDownButton1);
            this.panel1.Controls.Add(this.dropDownButton2);
            this.panel1.Controls.Add(this.dropDownButton5);
            this.panel1.Controls.Add(this.dropDownButton4);
            this.panel1.Controls.Add(this.dropDownButton3);
            this.panel1.Location = new System.Drawing.Point(154, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 173);
            this.panel1.TabIndex = 23;
            // 
            // frmInDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 470);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmInDanhSach";
            this.Text = "In danh sách thí sinh và mã phách";
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu6)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton2;
        private DevExpress.XtraEditors.DropDownButton dropDownButton3;
        private DevExpress.XtraEditors.DropDownButton dropDownButton4;
        private DevExpress.XtraEditors.DropDownButton dropDownButton5;
        private DevExpress.XtraEditors.DropDownButton dropDownButton6;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraBars.PopupMenu popupMenu3;
        private DevExpress.XtraBars.PopupMenu popupMenu4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.PopupMenu popupMenu5;
        private DevExpress.XtraBars.PopupMenu popupMenu6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}