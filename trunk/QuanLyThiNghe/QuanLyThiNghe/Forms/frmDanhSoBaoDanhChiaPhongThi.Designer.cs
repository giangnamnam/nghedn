namespace QuanLyThiNghe.Forms
{
    partial class frmDanhSoBaoDanhChiaPhongThi
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
            this.btnDanhSoBaoDanhVaChiaPhongThi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDanhSoBaoDanhVaChiaPhongThi
            // 
            this.btnDanhSoBaoDanhVaChiaPhongThi.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.btnDanhSoBaoDanhVaChiaPhongThi.Location = new System.Drawing.Point(206, 82);
            this.btnDanhSoBaoDanhVaChiaPhongThi.Name = "btnDanhSoBaoDanhVaChiaPhongThi";
            this.btnDanhSoBaoDanhVaChiaPhongThi.Size = new System.Drawing.Size(205, 23);
            this.btnDanhSoBaoDanhVaChiaPhongThi.TabIndex = 6;
            this.btnDanhSoBaoDanhVaChiaPhongThi.Text = "Đánh số báo danh và chia phòng thi";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(399, 164);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Kỳ thi hiện tại";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.btnDanhSoBaoDanhVaChiaPhongThi);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(517, 224);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Kỳ thi hiện tại: thi nghệ đợt 2 năm học 2010 - 2011";
            // 
            // frmDanhSoBaoDanhChiaPhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 507);
            this.Controls.Add(this.groupControl2);
            this.Name = "frmDanhSoBaoDanhChiaPhongThi";
            this.Text = "frmDanhSoBaoDanhChiaPhongThi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDanhSoBaoDanhVaChiaPhongThi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}