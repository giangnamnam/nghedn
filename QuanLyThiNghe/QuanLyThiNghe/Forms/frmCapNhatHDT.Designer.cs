namespace QuanLyThiNghe.Forms
{
    partial class frmCapNhatHDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatHDT));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoPhong = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoThiSinh = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpHuyen = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpTruong = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoThiSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTruong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QuanLyThiNghe.Properties.Resources.save_16;
            this.btnSave.Location = new System.Drawing.Point(140, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.Appearance.Options.UseImage = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(10, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 20);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Huyện:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(10, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 20);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Số thí sinh dự tính:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.Appearance.Options.UseImage = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(10, 124);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 20);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Số phòng dự tính:";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoPhong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoPhong.Location = new System.Drawing.Point(140, 124);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSoPhong.Properties.IsFloatValue = false;
            this.txtSoPhong.Properties.Mask.EditMask = "N00";
            this.txtSoPhong.Properties.MaxValue = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtSoPhong.Properties.NullValuePrompt = "0";
            this.txtSoPhong.Size = new System.Drawing.Size(137, 20);
            this.txtSoPhong.TabIndex = 15;
            // 
            // txtSoThiSinh
            // 
            this.txtSoThiSinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoThiSinh.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoThiSinh.Location = new System.Drawing.Point(140, 68);
            this.txtSoThiSinh.Name = "txtSoThiSinh";
            this.txtSoThiSinh.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSoThiSinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSoThiSinh.Properties.IsFloatValue = false;
            this.txtSoThiSinh.Properties.Mask.EditMask = "N00";
            this.txtSoThiSinh.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtSoThiSinh.Properties.NullText = "0";
            this.txtSoThiSinh.Size = new System.Drawing.Size(137, 20);
            this.txtSoThiSinh.TabIndex = 16;
            this.txtSoThiSinh.EditValueChanged += new System.EventHandler(this.txtSoThiSinh_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl4.Appearance.Options.UseImage = true;
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl4.Location = new System.Drawing.Point(10, 40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 20);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Trường:";
            // 
            // spinEdit1
            // 
            this.spinEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spinEdit1.EditValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(140, 96);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.IsFloatValue = false;
            this.spinEdit1.Properties.Mask.EditMask = "N00";
            this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.spinEdit1.Properties.NullValuePrompt = "0";
            this.spinEdit1.Size = new System.Drawing.Size(137, 20);
            this.spinEdit1.TabIndex = 18;
            this.spinEdit1.EditValueChanged += new System.EventHandler(this.spinEdit1_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl5.Appearance.Options.UseImage = true;
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl5.Location = new System.Drawing.Point(10, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 20);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Thí sinh/Phòng:";
            // 
            // lookUpHuyen
            // 
            this.lookUpHuyen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpHuyen.EditValue = "";
            this.lookUpHuyen.Location = new System.Drawing.Point(140, 9);
            this.lookUpHuyen.Name = "lookUpHuyen";
            this.lookUpHuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.lookUpHuyen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenHuyen", 5, "Tên Huyện")});
            this.lookUpHuyen.Properties.DisplayMember = "TenHuyen";
            this.lookUpHuyen.Properties.NullText = "Chọn huyện..";
            this.lookUpHuyen.Properties.ShowFooter = false;
            this.lookUpHuyen.Properties.ShowHeader = false;
            this.lookUpHuyen.Properties.ValueMember = "MaHuyen";
            this.lookUpHuyen.Size = new System.Drawing.Size(137, 20);
            this.lookUpHuyen.TabIndex = 19;
            this.lookUpHuyen.EditValueChanged += new System.EventHandler(this.lookUpHuyen_EditValueChanged);
            // 
            // lookUpTruong
            // 
            this.lookUpTruong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpTruong.Location = new System.Drawing.Point(140, 40);
            this.lookUpTruong.Name = "lookUpTruong";
            this.lookUpTruong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.lookUpTruong.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTruong", 5, "Tên Trường")});
            this.lookUpTruong.Properties.DisplayMember = "TenTruong";
            this.lookUpTruong.Properties.NullText = "Chọn trường..";
            this.lookUpTruong.Properties.ShowFooter = false;
            this.lookUpTruong.Properties.ShowHeader = false;
            this.lookUpTruong.Properties.ValueMember = "MaTruong";
            this.lookUpTruong.Size = new System.Drawing.Size(137, 20);
            this.lookUpTruong.TabIndex = 20;
            // 
            // frmCapNhatHDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 199);
            this.Controls.Add(this.lookUpTruong);
            this.Controls.Add(this.lookUpHuyen);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtSoThiSinh);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapNhatHDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm/Cập nhật Hội đồng thi";
            this.Load += new System.EventHandler(this.frmCapNhatHDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoThiSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTruong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit txtSoPhong;
        private DevExpress.XtraEditors.SpinEdit txtSoThiSinh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lookUpHuyen;
        private DevExpress.XtraEditors.LookUpEdit lookUpTruong;
    }
}