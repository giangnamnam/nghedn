namespace QuanLyThiNghe.Forms
{
    partial class frmCapNhatKyThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatKyThi));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenKyThi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.cbDaKetThuc = new DevExpress.XtraEditors.CheckEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKyThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThi.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDaKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QuanLyThiNghe.Properties.Resources.save_16;
            this.btnSave.Location = new System.Drawing.Point(172, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTenKyThi
            // 
            this.txtTenKyThi.Location = new System.Drawing.Point(93, 12);
            this.txtTenKyThi.Name = "txtTenKyThi";
            this.txtTenKyThi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTenKyThi.Size = new System.Drawing.Size(160, 20);
            this.txtTenKyThi.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.Appearance.Options.UseImage = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(11, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 20);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Tên kỳ thi:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(11, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 20);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Ngày thi:";
            // 
            // txtNgayThi
            // 
            this.txtNgayThi.EditValue = null;
            this.txtNgayThi.Location = new System.Drawing.Point(93, 38);
            this.txtNgayThi.Name = "txtNgayThi";
            this.txtNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayThi.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtNgayThi.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtNgayThi.Size = new System.Drawing.Size(100, 20);
            this.txtNgayThi.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.Appearance.Options.UseImage = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(11, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 20);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(93, 64);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(179, 20);
            this.txtGhiChu.TabIndex = 10;
            // 
            // cbDaKetThuc
            // 
            this.cbDaKetThuc.Location = new System.Drawing.Point(12, 94);
            this.cbDaKetThuc.Name = "cbDaKetThuc";
            this.cbDaKetThuc.Properties.Caption = "Đã kết thúc";
            this.cbDaKetThuc.Size = new System.Drawing.Size(86, 19);
            this.cbDaKetThuc.TabIndex = 13;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmCapNhatKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.cbDaKetThuc);
            this.Controls.Add(this.txtNgayThi);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTenKyThi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCapNhatKyThi";
            this.Text = "Thêm/Cập nhật kỳ thi";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKyThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThi.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDaKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnSave;
        public DevExpress.XtraEditors.TextEdit txtTenKyThi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtNgayThi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.CheckEdit cbDaKetThuc;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}