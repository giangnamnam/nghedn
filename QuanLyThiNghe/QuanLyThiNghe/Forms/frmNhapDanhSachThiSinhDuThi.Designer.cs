namespace QuanLyThiNghe.Forms
{
    partial class frmNhapDanhSachThiSinhDuThi
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnNhapDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblSoLuongThiSinh = new DevExpress.XtraEditors.LabelControl();
            this.lblSoTruong = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTenKyThi = new DevExpress.XtraEditors.LabelControl();
            this.gridControlDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditTruong = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditChon = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.progressBarControl1);
            this.groupControl1.Controls.Add(this.btnNhapDuLieu);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.lblSoLuongThiSinh);
            this.groupControl1.Controls.Add(this.lblSoTruong);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lblTenKyThi);
            this.groupControl1.Location = new System.Drawing.Point(13, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(571, 81);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin kỳ thi hiện tại";
            // 
            // btnNhapDuLieu
            // 
            this.btnNhapDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapDuLieu.Enabled = false;
            this.btnNhapDuLieu.Image = global::QuanLyThiNghe.Properties.Resources.application_put;
            this.btnNhapDuLieu.Location = new System.Drawing.Point(422, 53);
            this.btnNhapDuLieu.Name = "btnNhapDuLieu";
            this.btnNhapDuLieu.Size = new System.Drawing.Size(144, 23);
            this.btnNhapDuLieu.TabIndex = 7;
            this.btnNhapDuLieu.Text = "Nhập dữ liệu thí sinh";
            this.btnNhapDuLieu.Click += new System.EventHandler(this.btnNhapDuLieu_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Image = global::QuanLyThiNghe.Properties.Resources.Add_16x16;
            this.simpleButton1.Location = new System.Drawing.Point(422, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Thêm danh sách thí sinh";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblSoLuongThiSinh
            // 
            this.lblSoLuongThiSinh.Location = new System.Drawing.Point(138, 64);
            this.lblSoLuongThiSinh.Name = "lblSoLuongThiSinh";
            this.lblSoLuongThiSinh.Size = new System.Drawing.Size(24, 13);
            this.lblSoLuongThiSinh.TabIndex = 5;
            this.lblSoLuongThiSinh.Text = "5000";
            // 
            // lblSoTruong
            // 
            this.lblSoTruong.Location = new System.Drawing.Point(138, 45);
            this.lblSoTruong.Name = "lblSoTruong";
            this.lblSoTruong.Size = new System.Drawing.Size(12, 13);
            this.lblSoTruong.TabIndex = 4;
            this.lblSoTruong.Text = "20";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(41, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Số thí sinh hiện tại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Số trường đăng ký dự thi:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(63, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kỳ thi hiện tại:";
            // 
            // lblTenKyThi
            // 
            this.lblTenKyThi.Location = new System.Drawing.Point(138, 26);
            this.lblTenKyThi.Name = "lblTenKyThi";
            this.lblTenKyThi.Size = new System.Drawing.Size(69, 13);
            this.lblTenKyThi.TabIndex = 0;
            this.lblTenKyThi.Text = "Thi nghề đợt 2";
            // 
            // gridControlDanhSach
            // 
            this.gridControlDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDanhSach.Location = new System.Drawing.Point(13, 103);
            this.gridControlDanhSach.MainView = this.gridView1;
            this.gridControlDanhSach.Name = "gridControlDanhSach";
            this.gridControlDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditTruong,
            this.repositoryItemCheckEditChon});
            this.gridControlDanhSach.Size = new System.Drawing.Size(571, 426);
            this.gridControlDanhSach.TabIndex = 1;
            this.gridControlDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Green;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Expression = "[check] == True";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControlDanhSach;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên trường";
            this.gridColumn1.FieldName = "Tên trường";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 66;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tổng TS";
            this.gridColumn2.FieldName = "Tổng thí sinh";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 51;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Điện";
            this.gridColumn3.FieldName = "Điện dân dụng";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 34;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tin học";
            this.gridColumn4.FieldName = "Tin học văn phòng";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 46;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nấu ăn";
            this.gridColumn5.FieldName = "Nấu ăn";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            this.gridColumn5.Width = 46;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Thêu tay";
            this.gridColumn6.FieldName = "Thêu tay";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 8;
            this.gridColumn6.Width = 55;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Cắt may";
            this.gridColumn7.FieldName = "Cắt may";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 9;
            this.gridColumn7.Width = 52;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Trồng rừng";
            this.gridColumn8.FieldName = "Trồng rừng";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 10;
            this.gridColumn8.Width = 66;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Làm vườn";
            this.gridColumn9.FieldName = "Làm vườn";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 11;
            this.gridColumn9.Width = 59;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Nuôi cá";
            this.gridColumn10.FieldName = "Chăn nuôi cá";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 12;
            this.gridColumn10.Width = 47;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Đường dẫn file";
            this.gridColumn11.FieldName = "FilePath";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            this.gridColumn11.Width = 83;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Mã File của trường";
            this.gridColumn12.ColumnEdit = this.repositoryItemGridLookUpEditTruong;
            this.gridColumn12.FieldName = "MaTruong";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 101;
            // 
            // repositoryItemGridLookUpEditTruong
            // 
            this.repositoryItemGridLookUpEditTruong.AutoHeight = false;
            this.repositoryItemGridLookUpEditTruong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditTruong.DisplayMember = "TenTruong";
            this.repositoryItemGridLookUpEditTruong.Name = "repositoryItemGridLookUpEditTruong";
            this.repositoryItemGridLookUpEditTruong.NullText = "Chọn trường";
            this.repositoryItemGridLookUpEditTruong.ShowFooter = false;
            this.repositoryItemGridLookUpEditTruong.ValueMember = "MaTruong";
            this.repositoryItemGridLookUpEditTruong.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Chọn";
            this.gridColumn13.ColumnEdit = this.repositoryItemCheckEditChon;
            this.gridColumn13.FieldName = "check";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            this.gridColumn13.Width = 37;
            // 
            // repositoryItemCheckEditChon
            // 
            this.repositoryItemCheckEditChon.AutoHeight = false;
            this.repositoryItemCheckEditChon.Name = "repositoryItemCheckEditChon";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl1.EditValue = "0";
            this.progressBarControl1.Location = new System.Drawing.Point(171, 3);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.EndColor = System.Drawing.SystemColors.HighlightText;
            this.progressBarControl1.Size = new System.Drawing.Size(395, 15);
            this.progressBarControl1.TabIndex = 26;
            this.progressBarControl1.Visible = false;
            // 
            // frmNhapDanhSachThiSinhDuThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 541);
            this.Controls.Add(this.gridControlDanhSach);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmNhapDanhSachThiSinhDuThi";
            this.Text = "Nhập danh sách thí sinh dự thi";
            this.Load += new System.EventHandler(this.frmNhapDanhSachThiSinhDuThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTenKyThi;
        private DevExpress.XtraEditors.LabelControl lblSoLuongThiSinh;
        private DevExpress.XtraEditors.LabelControl lblSoTruong;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnNhapDuLieu;
        private DevExpress.XtraGrid.GridControl gridControlDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditTruong;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditChon;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
    }
}