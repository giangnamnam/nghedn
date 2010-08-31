namespace QuanLyThiNghe_ThuKy
{
    partial class frmThucHanh
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSTT,
            this.cSBD,
            this.CDiem,
            this.cGhiChu});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(461, 262);
            this.dataGridView1.TabIndex = 2;
            // 
            // cSTT
            // 
            this.cSTT.DataPropertyName = "STT";
            this.cSTT.HeaderText = "STT";
            this.cSTT.Name = "cSTT";
            // 
            // cSBD
            // 
            this.cSBD.HeaderText = "Số báo danh";
            this.cSBD.Name = "cSBD";
            this.cSBD.ReadOnly = true;
            // 
            // CDiem
            // 
            this.CDiem.HeaderText = "Điểm lý thuyết";
            this.CDiem.Name = "CDiem";
            // 
            // cGhiChu
            // 
            this.cGhiChu.HeaderText = "Ghi chú";
            this.cGhiChu.Name = "cGhiChu";
            // 
            // frmThucHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmThucHanh";
            this.Text = "Nhập điểm thi thực hành";
            this.Load += new System.EventHandler(this.frmThucHanh_Load);
            this.Activated += new System.EventHandler(this.frmThucHanh_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;

    }
}