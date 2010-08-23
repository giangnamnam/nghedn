namespace QuanLyThiNghe_ThuKy
{
    partial class frmThuKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuKy));
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallimgs = new System.Windows.Forms.ImageList(this.components);
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.btnNhapDiemLyThuyet = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapDiemThucHanh = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.tbnThuKy1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThuKy2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThuKy3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barMdiChildrenListItem2 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.BigImgs = new System.Windows.Forms.ImageList(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.BottomPaneControlContainer = null;
            this.applicationMenu1.ItemLinks.Add(this.barButtonItem1);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            this.applicationMenu1.RightPaneControlContainer = null;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Cập nhật dữ liệu";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ApplicationIcon = global::QuanLyThiNghe_ThuKy.Properties.Resources.Copy_v2_24x24;
            this.ribbon.Images = this.smallimgs;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barStaticItem2,
            this.btnNhapDiemLyThuyet,
            this.btnNhapDiemThucHanh,
            this.barButtonItem1,
            this.barEditItem1,
            this.barEditItem2,
            this.barEditItem3,
            this.tbnThuKy1,
            this.btnThuKy2,
            this.btnThuKy3,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barMdiChildrenListItem1,
            this.barMdiChildrenListItem2});
            this.ribbon.LargeImages = this.BigImgs;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barMdiChildrenListItem2);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3});
            this.ribbon.SelectedPage = this.ribbonPage1;
            this.ribbon.Size = new System.Drawing.Size(790, 148);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // smallimgs
            // 
            this.smallimgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallimgs.ImageStream")));
            this.smallimgs.TransparentColor = System.Drawing.Color.Transparent;
            this.smallimgs.Images.SetKeyName(0, "12.png");
            this.smallimgs.Images.SetKeyName(1, "20.png");
            this.smallimgs.Images.SetKeyName(2, "58_16x16.png");
            this.smallimgs.Images.SetKeyName(3, "Add_16x16.png");
            this.smallimgs.Images.SetKeyName(4, "clock.png");
            this.smallimgs.Images.SetKeyName(5, "Delete_16x16.png");
            this.smallimgs.Images.SetKeyName(6, "drive_cd.png");
            this.smallimgs.Images.SetKeyName(7, "Edit_16x16.png");
            this.smallimgs.Images.SetKeyName(8, "pin.png");
            this.smallimgs.Images.SetKeyName(9, "Print_16x16.png");
            this.smallimgs.Images.SetKeyName(10, "Remove_16x16.png");
            this.smallimgs.Images.SetKeyName(11, "save_16.png");
            this.smallimgs.Images.SetKeyName(12, "tag_blue.png");
            this.smallimgs.Images.SetKeyName(13, "Text Document_16x16.png");
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "barStaticItem2";
            this.barStaticItem2.Id = 4;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnNhapDiemLyThuyet
            // 
            this.btnNhapDiemLyThuyet.Caption = "Nhập điểm lý thuyết";
            this.btnNhapDiemLyThuyet.Id = 8;
            this.btnNhapDiemLyThuyet.LargeImageIndex = 0;
            this.btnNhapDiemLyThuyet.LargeWidth = 70;
            this.btnNhapDiemLyThuyet.Name = "btnNhapDiemLyThuyet";
            this.btnNhapDiemLyThuyet.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhapDiemLyThuyet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapDiemLyThuyet_ItemClick);
            // 
            // btnNhapDiemThucHanh
            // 
            this.btnNhapDiemThucHanh.Caption = "Nhập điểm thực hành";
            this.btnNhapDiemThucHanh.Id = 9;
            this.btnNhapDiemThucHanh.LargeImageIndex = 1;
            this.btnNhapDiemThucHanh.LargeWidth = 70;
            this.btnNhapDiemThucHanh.Name = "btnNhapDiemThucHanh";
            this.btnNhapDiemThucHanh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhapDiemThucHanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapDiemThucHanh_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Phòng";
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.Id = 13;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 227;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Môn thi";
            this.barEditItem2.Edit = this.repositoryItemComboBox2;
            this.barEditItem2.Id = 14;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Width = 222;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "Hội đồng thi";
            this.barEditItem3.Edit = this.repositoryItemComboBox3;
            this.barEditItem3.Id = 15;
            this.barEditItem3.Name = "barEditItem3";
            this.barEditItem3.Width = 200;
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // tbnThuKy1
            // 
            this.tbnThuKy1.Caption = "Thư ký 1: HungVQ (Vũ Quốc Hùng)";
            this.tbnThuKy1.Id = 16;
            this.tbnThuKy1.ImageIndex = 1;
            this.tbnThuKy1.Name = "tbnThuKy1";
            // 
            // btnThuKy2
            // 
            this.btnThuKy2.Caption = "Thư ký 2: leoC (Châu Duy An)";
            this.btnThuKy2.Id = 17;
            this.btnThuKy2.ImageIndex = 1;
            this.btnThuKy2.Name = "btnThuKy2";
            // 
            // btnThuKy3
            // 
            this.btnThuKy3.Caption = "Thư ký 3: unknown (.)(.)";
            this.btnThuKy3.CausesValidation = true;
            this.btnThuKy3.Id = 18;
            this.btnThuKy3.ImageIndex = 1;
            this.btnThuKy3.Name = "btnThuKy3";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Lưu";
            this.barButtonItem2.Id = 19;
            this.barButtonItem2.LargeImageIndex = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Lưu và qua phòng thi kế tiếp";
            this.barButtonItem3.Id = 20;
            this.barButtonItem3.LargeImageIndex = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 21;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "Đang mở";
            this.barMdiChildrenListItem1.Id = 22;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barMdiChildrenListItem2
            // 
            this.barMdiChildrenListItem2.Caption = "barMdiChildrenListItem2";
            this.barMdiChildrenListItem2.Id = 24;
            this.barMdiChildrenListItem2.Name = "barMdiChildrenListItem2";
            // 
            // BigImgs
            // 
            this.BigImgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BigImgs.ImageStream")));
            this.BigImgs.TransparentColor = System.Drawing.Color.Transparent;
            this.BigImgs.Images.SetKeyName(0, "Text Document_32x32.png");
            this.BigImgs.Images.SetKeyName(1, "Paste_32x32.png");
            this.BigImgs.Images.SetKeyName(2, "Save_32x32.png");
            this.BigImgs.Images.SetKeyName(3, "Next_32x32.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Xử lý nghiệp vụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapDiemLyThuyet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapDiemThucHanh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Nhập điểm";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barEditItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barEditItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.tbnThuKy1);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThuKy2);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThuKy3);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Thông tin đăng nhập";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem4);
            this.ribbonStatusBar.ItemLinks.Add(this.barMdiChildrenListItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 433);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 23);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // frmThuKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 456);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmThuKy";
            this.ribbon.SetPopupContextMenu(this, this.applicationMenu1);
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Thư Ký - Chương trình quản lý thi nghề";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThuKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem btnNhapDiemLyThuyet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnNhapDiemThucHanh;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem tbnThuKy1;
        private DevExpress.XtraBars.BarButtonItem btnThuKy2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnThuKy3;
        private System.Windows.Forms.ImageList smallimgs;
        private System.Windows.Forms.ImageList BigImgs;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}