namespace QuanLyThiNghe.Forms
{
    partial class frmCapNhatTruong
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtSchoolName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbHuyen = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchoolName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHuyen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QuanLyThiNghe.Properties.Resources.save_16;
            this.btnSave.Location = new System.Drawing.Point(135, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Location = new System.Drawing.Point(95, 14);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(140, 20);
            this.txtSchoolName.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.Appearance.Options.UseImage = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(9, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 20);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tên trường:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(9, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 20);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Huyện:";
            // 
            // cbHuyen
            // 
            this.cbHuyen.EditValue = "";
            this.cbHuyen.Location = new System.Drawing.Point(95, 45);
            this.cbHuyen.Margin = new System.Windows.Forms.Padding(0);
            this.cbHuyen.MaximumSize = new System.Drawing.Size(250, 0);
            this.cbHuyen.MinimumSize = new System.Drawing.Size(140, 0);
            this.cbHuyen.Name = "cbHuyen";
            this.cbHuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, false)});
            this.cbHuyen.Properties.DropDownRows = 10;
            this.cbHuyen.Size = new System.Drawing.Size(140, 20);
            this.cbHuyen.TabIndex = 9;
            // 
            // frmCapNhatTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 115);
            this.Controls.Add(this.cbHuyen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSchoolName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapNhatTruong";
            this.Text = "Thêm/Cập nhật thông tin trường";
            this.Load += new System.EventHandler(this.frmCapNhatHuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSchoolName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHuyen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        public DevExpress.XtraEditors.TextEdit txtSchoolName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.ComboBoxEdit cbHuyen;
    }
}