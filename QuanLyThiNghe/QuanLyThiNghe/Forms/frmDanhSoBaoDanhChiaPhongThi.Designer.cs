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
            this.SuspendLayout();
            // 
            // btnDanhSoBaoDanhVaChiaPhongThi
            // 
            this.btnDanhSoBaoDanhVaChiaPhongThi.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.btnDanhSoBaoDanhVaChiaPhongThi.Location = new System.Drawing.Point(836, 221);
            this.btnDanhSoBaoDanhVaChiaPhongThi.Name = "btnDanhSoBaoDanhVaChiaPhongThi";
            this.btnDanhSoBaoDanhVaChiaPhongThi.Size = new System.Drawing.Size(203, 27);
            this.btnDanhSoBaoDanhVaChiaPhongThi.TabIndex = 6;
            this.btnDanhSoBaoDanhVaChiaPhongThi.Text = "Đánh số báo danh và chia phòng thi";
            // 
            // frmDanhSoBaoDanhChiaPhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 507);
            this.Controls.Add(this.btnDanhSoBaoDanhVaChiaPhongThi);
            this.Name = "frmDanhSoBaoDanhChiaPhongThi";
            this.Text = "frmDanhSoBaoDanhChiaPhongThi";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDanhSoBaoDanhVaChiaPhongThi;
    }
}