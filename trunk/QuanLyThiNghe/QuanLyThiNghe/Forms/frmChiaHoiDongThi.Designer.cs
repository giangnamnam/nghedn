namespace QuanLyThiNghe.Forms
{
   partial class frmChiaHoiDongThi
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiaHoiDongThi));
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
         this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
         this.treeViewTruong = new System.Windows.Forms.TreeView();
         this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
         this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
         this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
         this.treeViewHDT = new System.Windows.Forms.TreeView();
         this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
         this.comboBoxKyThi = new System.Windows.Forms.ComboBox();
         this.radioButton1 = new System.Windows.Forms.RadioButton();
         this.radioButton2 = new System.Windows.Forms.RadioButton();
         this.imageList1 = new System.Windows.Forms.ImageList(this.components);
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
         this.groupControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
         this.groupControl2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 32);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(910, 552);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // groupControl1
         // 
         this.groupControl1.Controls.Add(this.simpleButton1);
         this.groupControl1.Controls.Add(this.treeViewTruong);
         this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupControl1.Location = new System.Drawing.Point(3, 3);
         this.groupControl1.Name = "groupControl1";
         this.groupControl1.Size = new System.Drawing.Size(449, 546);
         this.groupControl1.TabIndex = 7;
         this.groupControl1.Text = "Danh sách các trường dự thi";
         // 
         // simpleButton1
         // 
         this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.simpleButton1.Image = global::QuanLyThiNghe.Properties.Resources.pin;
         this.simpleButton1.Location = new System.Drawing.Point(370, 2);
         this.simpleButton1.Name = "simpleButton1";
         this.simpleButton1.Size = new System.Drawing.Size(76, 19);
         this.simpleButton1.TabIndex = 7;
         this.simpleButton1.Text = "Rút gọn";
         this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
         // 
         // treeViewTruong
         // 
         this.treeViewTruong.AllowDrop = true;
         this.treeViewTruong.Dock = System.Windows.Forms.DockStyle.Fill;
         this.treeViewTruong.ImageIndex = 0;
         this.treeViewTruong.ImageList = this.imageList1;
         this.treeViewTruong.Location = new System.Drawing.Point(2, 22);
         this.treeViewTruong.Name = "treeViewTruong";
         this.treeViewTruong.SelectedImageIndex = 0;
         this.treeViewTruong.Size = new System.Drawing.Size(445, 522);
         this.treeViewTruong.TabIndex = 8;
         this.treeViewTruong.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewTruong_DragEnter);
         this.treeViewTruong.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewTruong_ItemDrag);
         // 
         // groupControl2
         // 
         this.groupControl2.Controls.Add(this.simpleButton2);
         this.groupControl2.Controls.Add(this.progressBarControl1);
         this.groupControl2.Controls.Add(this.treeViewHDT);
         this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupControl2.Location = new System.Drawing.Point(458, 3);
         this.groupControl2.Name = "groupControl2";
         this.groupControl2.Size = new System.Drawing.Size(449, 546);
         this.groupControl2.TabIndex = 8;
         this.groupControl2.Text = "Danh sách hội đồng thi";
         // 
         // simpleButton2
         // 
         this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.simpleButton2.Image = global::QuanLyThiNghe.Properties.Resources.pin;
         this.simpleButton2.Location = new System.Drawing.Point(371, 2);
         this.simpleButton2.Name = "simpleButton2";
         this.simpleButton2.Size = new System.Drawing.Size(76, 19);
         this.simpleButton2.TabIndex = 9;
         this.simpleButton2.Text = "Rút gọn";
         this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
         // 
         // progressBarControl1
         // 
         this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.progressBarControl1.EditValue = "0";
         this.progressBarControl1.Location = new System.Drawing.Point(2, 526);
         this.progressBarControl1.Name = "progressBarControl1";
         this.progressBarControl1.Properties.EndColor = System.Drawing.SystemColors.HighlightText;
         this.progressBarControl1.Size = new System.Drawing.Size(445, 18);
         this.progressBarControl1.TabIndex = 26;
         this.progressBarControl1.Visible = false;
         // 
         // treeViewHDT
         // 
         this.treeViewHDT.AllowDrop = true;
         this.treeViewHDT.Dock = System.Windows.Forms.DockStyle.Fill;
         this.treeViewHDT.ImageIndex = 0;
         this.treeViewHDT.ImageList = this.imageList1;
         this.treeViewHDT.Location = new System.Drawing.Point(2, 22);
         this.treeViewHDT.Name = "treeViewHDT";
         this.treeViewHDT.SelectedImageIndex = 0;
         this.treeViewHDT.Size = new System.Drawing.Size(445, 522);
         this.treeViewHDT.TabIndex = 10;
         this.treeViewHDT.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewHDT_DragDrop);
         this.treeViewHDT.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewHDT_DragEnter);
         // 
         // simpleButtonLuu
         // 
         this.simpleButtonLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.simpleButtonLuu.Image = global::QuanLyThiNghe.Properties.Resources.pin;
         this.simpleButtonLuu.Location = new System.Drawing.Point(792, 2);
         this.simpleButtonLuu.Name = "simpleButtonLuu";
         this.simpleButtonLuu.Size = new System.Drawing.Size(118, 23);
         this.simpleButtonLuu.TabIndex = 3;
         this.simpleButtonLuu.Text = "Chia hội đồng thi";
         // 
         // comboBoxKyThi
         // 
         this.comboBoxKyThi.DisplayMember = "TenKyThi";
         this.comboBoxKyThi.FormattingEnabled = true;
         this.comboBoxKyThi.Location = new System.Drawing.Point(3, 4);
         this.comboBoxKyThi.Name = "comboBoxKyThi";
         this.comboBoxKyThi.Size = new System.Drawing.Size(268, 21);
         this.comboBoxKyThi.TabIndex = 4;
         this.comboBoxKyThi.ValueMember = "MaKyThi";
         this.comboBoxKyThi.SelectedIndexChanged += new System.EventHandler(this.comboBoxKyThi_SelectedIndexChanged);
         // 
         // radioButton1
         // 
         this.radioButton1.AutoSize = true;
         this.radioButton1.Location = new System.Drawing.Point(279, 7);
         this.radioButton1.Name = "radioButton1";
         this.radioButton1.Size = new System.Drawing.Size(51, 17);
         this.radioButton1.TabIndex = 5;
         this.radioButton1.TabStop = true;
         this.radioButton1.Text = "THCS";
         this.radioButton1.UseVisualStyleBackColor = true;
         this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
         // 
         // radioButton2
         // 
         this.radioButton2.AutoSize = true;
         this.radioButton2.Checked = true;
         this.radioButton2.Location = new System.Drawing.Point(335, 7);
         this.radioButton2.Name = "radioButton2";
         this.radioButton2.Size = new System.Drawing.Size(50, 17);
         this.radioButton2.TabIndex = 6;
         this.radioButton2.TabStop = true;
         this.radioButton2.Text = "THPT";
         this.radioButton2.UseVisualStyleBackColor = true;
         this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
         // 
         // imageList1
         // 
         this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
         this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
         this.imageList1.Images.SetKeyName(0, "stop-red.ico");
         this.imageList1.Images.SetKeyName(1, "bar_chart.ico");
         this.imageList1.Images.SetKeyName(2, "pie_chart.ico");
         this.imageList1.Images.SetKeyName(3, "Check_16x16.png");
         this.imageList1.Images.SetKeyName(4, "Remove_16x16.png");
         this.imageList1.Images.SetKeyName(5, "Add_16x16.png");
         this.imageList1.Images.SetKeyName(6, "inkscape.ico");
         this.imageList1.Images.SetKeyName(7, "invoice.ico");
         // 
         // frmChiaHoiDongThi
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(913, 584);
         this.Controls.Add(this.radioButton2);
         this.Controls.Add(this.radioButton1);
         this.Controls.Add(this.comboBoxKyThi);
         this.Controls.Add(this.simpleButtonLuu);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "frmChiaHoiDongThi";
         this.Text = "Chia hội đồng thi";
         this.Load += new System.EventHandler(this.frmChiaHoiDongThi_Load);
         this.tableLayoutPanel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
         this.groupControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
         this.groupControl2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

     }

     #endregion

     private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
     private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
     private System.Windows.Forms.ComboBox comboBoxKyThi;
     private System.Windows.Forms.RadioButton radioButton1;
     private System.Windows.Forms.RadioButton radioButton2;
     private System.Windows.Forms.TreeView treeViewTruong;
     private System.Windows.Forms.TreeView treeViewHDT;
     private DevExpress.XtraEditors.GroupControl groupControl1;
     private DevExpress.XtraEditors.GroupControl groupControl2;
     private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
     private DevExpress.XtraEditors.SimpleButton simpleButton1;
     private DevExpress.XtraEditors.SimpleButton simpleButton2;
     private System.Windows.Forms.ImageList imageList1;


   }
}
