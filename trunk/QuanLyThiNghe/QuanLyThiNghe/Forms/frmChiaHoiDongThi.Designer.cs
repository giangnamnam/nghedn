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
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.treeListTruong = new DevExpress.XtraTreeList.TreeList();
         this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
         this.treeListHDT = new DevExpress.XtraTreeList.TreeList();
         this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
         this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
         this.comboBoxKyThi = new System.Windows.Forms.ComboBox();
         this.radioButton1 = new System.Windows.Forms.RadioButton();
         this.radioButton2 = new System.Windows.Forms.RadioButton();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.treeListTruong)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.treeListHDT)).BeginInit();
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
         this.tableLayoutPanel1.Controls.Add(this.treeListTruong, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.treeListHDT, 1, 0);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 514F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 514);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // treeListTruong
         // 
         this.treeListTruong.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
         this.treeListTruong.CustomizationFormBounds = new System.Drawing.Rectangle(389, 327, 208, 168);
         this.treeListTruong.Dock = System.Windows.Forms.DockStyle.Fill;
         this.treeListTruong.Location = new System.Drawing.Point(3, 3);
         this.treeListTruong.Name = "treeListTruong";
         this.treeListTruong.Size = new System.Drawing.Size(402, 508);
         this.treeListTruong.TabIndex = 1;
         // 
         // treeListColumn1
         // 
         this.treeListColumn1.Caption = "treeListColumn1";
         this.treeListColumn1.FieldName = "treeListColumn1";
         this.treeListColumn1.Name = "treeListColumn1";
         this.treeListColumn1.Visible = true;
         this.treeListColumn1.VisibleIndex = 0;
         // 
         // treeListHDT
         // 
         this.treeListHDT.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
         this.treeListHDT.Dock = System.Windows.Forms.DockStyle.Fill;
         this.treeListHDT.Location = new System.Drawing.Point(411, 3);
         this.treeListHDT.Name = "treeListHDT";
         this.treeListHDT.Size = new System.Drawing.Size(403, 508);
         this.treeListHDT.TabIndex = 0;
         this.treeListHDT.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeListHDT_DragDrop);
         this.treeListHDT.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeListHDT_DragEnter);
         // 
         // treeListColumn2
         // 
         this.treeListColumn2.Caption = "Hội đồng thi";
         this.treeListColumn2.FieldName = "Hội đồng thi";
         this.treeListColumn2.Name = "treeListColumn2";
         this.treeListColumn2.Visible = true;
         this.treeListColumn2.VisibleIndex = 0;
         // 
         // simpleButtonLuu
         // 
         this.simpleButtonLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.simpleButtonLuu.Image = global::QuanLyThiNghe.Properties.Resources.pin;
         this.simpleButtonLuu.Location = new System.Drawing.Point(696, 2);
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
         // frmChiaHoiDongThi
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(817, 542);
         this.Controls.Add(this.radioButton2);
         this.Controls.Add(this.radioButton1);
         this.Controls.Add(this.comboBoxKyThi);
         this.Controls.Add(this.simpleButtonLuu);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "frmChiaHoiDongThi";
         this.Text = "Chia hội đồng thi";
         this.Load += new System.EventHandler(this.frmChiaHoiDongThi_Load);
         this.tableLayoutPanel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.treeListTruong)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.treeListHDT)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

     }

     #endregion

     private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
     private DevExpress.XtraTreeList.TreeList treeListTruong;
     private DevExpress.XtraTreeList.TreeList treeListHDT;
     private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
     private System.Windows.Forms.ComboBox comboBoxKyThi;
     private System.Windows.Forms.RadioButton radioButton1;
     private System.Windows.Forms.RadioButton radioButton2;
     private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
     private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;


   }
}
