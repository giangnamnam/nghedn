namespace QuanLyThiNghe_ThuKy
{
    partial class frmDangNhap
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.clientPanel = new DevExpress.XtraEditors.PanelControl();
            this.txtPass3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTK3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPass2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTK2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtPass1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTK1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).BeginInit();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ApplicationIcon = global::QuanLyThiNghe_ThuKy.Properties.Resources.Copy_v2_24x24;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(295, 30);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ItemLinks.Add(this.barButtonItem1);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.BottomPaneControlContainer = null;
            this.applicationMenu1.ItemLinks.Add(this.barButtonItem2);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            this.applicationMenu1.RightPaneControlContainer = null;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Cập nhật dữ liệu thi nghề để làm việc offline";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "Copyright © 2010 Phòng GDTrH";
            this.barStaticItem1.Glyph = global::QuanLyThiNghe_ThuKy.Properties.Resources.logo1;
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Tải dữ liệu";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 284);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(295, 23);
            // 
            // clientPanel
            // 
            this.clientPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.clientPanel.Appearance.Options.UseBackColor = true;
            this.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clientPanel.Controls.Add(this.txtPass3);
            this.clientPanel.Controls.Add(this.labelControl5);
            this.clientPanel.Controls.Add(this.txtTK3);
            this.clientPanel.Controls.Add(this.labelControl6);
            this.clientPanel.Controls.Add(this.txtPass2);
            this.clientPanel.Controls.Add(this.labelControl3);
            this.clientPanel.Controls.Add(this.txtTK2);
            this.clientPanel.Controls.Add(this.labelControl4);
            this.clientPanel.Controls.Add(this.simpleButton2);
            this.clientPanel.Controls.Add(this.simpleButton1);
            this.clientPanel.Controls.Add(this.txtPass1);
            this.clientPanel.Controls.Add(this.labelControl2);
            this.clientPanel.Controls.Add(this.txtTK1);
            this.clientPanel.Controls.Add(this.labelControl1);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 30);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(295, 254);
            this.clientPanel.TabIndex = 2;
            // 
            // txtPass3
            // 
            this.txtPass3.Location = new System.Drawing.Point(90, 156);
            this.txtPass3.Name = "txtPass3";
            this.txtPass3.Properties.PasswordChar = '*';
            this.txtPass3.Size = new System.Drawing.Size(201, 20);
            this.txtPass3.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Appearance.Image = global::QuanLyThiNghe_ThuKy.Properties.Resources._20;
            this.labelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseImage = true;
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl5.Location = new System.Drawing.Point(13, 156);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 20);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Mật khẩu";
            // 
            // txtTK3
            // 
            this.txtTK3.AllowDrop = true;
            this.txtTK3.Location = new System.Drawing.Point(90, 130);
            this.txtTK3.Name = "txtTK3";
            this.txtTK3.Size = new System.Drawing.Size(201, 20);
            this.txtTK3.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Appearance.Image = global::QuanLyThiNghe_ThuKy.Properties.Resources._20;
            this.labelControl6.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseImage = true;
            this.labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl6.Location = new System.Drawing.Point(13, 130);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 20);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Thư ký 3";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(90, 98);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Properties.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(201, 20);
            this.txtPass2.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Appearance.Image = global::QuanLyThiNghe_ThuKy.Properties.Resources._20;
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseImage = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(13, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 20);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // txtTK2
            // 
            this.txtTK2.Location = new System.Drawing.Point(90, 72);
            this.txtTK2.Name = "txtTK2";
            this.txtTK2.Size = new System.Drawing.Size(201, 20);
            this.txtTK2.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Appearance.Image = global::QuanLyThiNghe_ThuKy.Properties.Resources._20;
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseImage = true;
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl4.Location = new System.Drawing.Point(13, 72);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 20);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Thư ký 2";
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(13, 188);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(116, 25);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Đóng";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(135, 188);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(155, 25);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Đăng nhập hệ thống";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(90, 40);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Properties.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(201, 20);
            this.txtPass1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Image = global::QuanLyThiNghe_ThuKy.Properties.Resources._20;
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseImage = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(13, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // txtTK1
            // 
            this.txtTK1.AllowDrop = true;
            this.txtTK1.Location = new System.Drawing.Point(90, 14);
            this.txtTK1.Name = "txtTK1";
            this.txtTK1.Size = new System.Drawing.Size(201, 20);
            this.txtTK1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Image = global::QuanLyThiNghe_ThuKy.Properties.Resources._20;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(13, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thư ký 1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButtonItem1);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.simpleButton1;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton2;
            this.ClientSize = new System.Drawing.Size(295, 307);
            this.ControlBox = false;
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Đăng nhập - thư ký";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).EndInit();
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl clientPanel;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraEditors.TextEdit txtTK1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPass1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit txtPass2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTK2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPass3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTK3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}