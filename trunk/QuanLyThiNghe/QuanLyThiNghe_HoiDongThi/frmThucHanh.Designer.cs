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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaPhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSTT,
            this.cMaThiSinh,
            this.cSBD,
            this.cMaPhach,
            this.CDiem});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(461, 262);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // cSTT
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cSTT.DefaultCellStyle = dataGridViewCellStyle1;
            this.cSTT.FillWeight = 30.89489F;
            this.cSTT.HeaderText = "STT";
            this.cSTT.MinimumWidth = 20;
            this.cSTT.Name = "cSTT";
            this.cSTT.ReadOnly = true;
            // 
            // cMaThiSinh
            // 
            this.cMaThiSinh.DataPropertyName = "MaThiSinh";
            this.cMaThiSinh.HeaderText = "Mã thí sinh";
            this.cMaThiSinh.MinimumWidth = 50;
            this.cMaThiSinh.Name = "cMaThiSinh";
            this.cMaThiSinh.ReadOnly = true;
            this.cMaThiSinh.Visible = false;
            // 
            // cSBD
            // 
            this.cSBD.DataPropertyName = "SBD";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cSBD.DefaultCellStyle = dataGridViewCellStyle2;
            this.cSBD.FillWeight = 86.02319F;
            this.cSBD.HeaderText = "Số báo danh";
            this.cSBD.MinimumWidth = 50;
            this.cSBD.Name = "cSBD";
            this.cSBD.ReadOnly = true;
            // 
            // cMaPhach
            // 
            this.cMaPhach.DataPropertyName = "MaPhach";
            this.cMaPhach.HeaderText = "Mã phách";
            this.cMaPhach.Name = "cMaPhach";
            this.cMaPhach.ReadOnly = true;
            this.cMaPhach.Visible = false;
            // 
            // CDiem
            // 
            this.CDiem.DataPropertyName = "DiemTH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CDiem.DefaultCellStyle = dataGridViewCellStyle3;
            this.CDiem.FillWeight = 187.3966F;
            this.CDiem.HeaderText = "Điểm thực hành";
            this.CDiem.Name = "CDiem";
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
            this.Activated += new System.EventHandler(this.frmLyThuyet_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLyThuyet_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaPhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDiem;


    }
}