namespace QuanLyThiNghe.Reports
{
    partial class rptDanhSachMaPhachTheoPhong
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.inDauMaPhach1 = new QuanLyThiNghe.InDauMaPhach();
            this.chuTich_MaPhach_InDauMaPhachTableAdapter = new QuanLyThiNghe.InDauMaPhachTableAdapters.chuTich_MaPhach_InDauMaPhachTableAdapter();
            this.groupFooterBand2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.groupFooterBand3 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.groupHeaderBand2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.groupFooterBand4 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.groupFooterBand5 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this.inDauMaPhach1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel8});
            this.Detail.Height = 24;
            this.Detail.MultiColumn.ColumnSpacing = 5F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "chuTich_MaPhach_InDauMaPhach.PhongThi", "")});
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel7.Location = new System.Drawing.Point(117, 0);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrLabel7.Size = new System.Drawing.Size(170, 22);
            this.xrLabel7.StyleName = "DataField";
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "chuTich_MaPhach_InDauMaPhach.MaPhach", "")});
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel8.Location = new System.Drawing.Point(289, 0);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrLabel8.Size = new System.Drawing.Size(235, 22);
            this.xrLabel8.StyleName = "DataField";
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.Height = 1;
            this.groupFooterBand1.Name = "groupFooterBand1";
            // 
            // inDauMaPhach1
            // 
            this.inDauMaPhach1.DataSetName = "InDauMaPhach";
            this.inDauMaPhach1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chuTich_MaPhach_InDauMaPhachTableAdapter
            // 
            this.chuTich_MaPhach_InDauMaPhachTableAdapter.ClearBeforeFill = true;
            // 
            // groupFooterBand2
            // 
            this.groupFooterBand2.Height = 1;
            this.groupFooterBand2.Name = "groupFooterBand2";
            // 
            // groupFooterBand3
            // 
            this.groupFooterBand3.Height = 1;
            this.groupFooterBand3.Name = "groupFooterBand3";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.BorderColor = System.Drawing.SystemColors.ControlText;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.White;
            this.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1;
            this.FieldCaption.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.White;
            this.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1;
            this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.White;
            this.DataField.BorderColor = System.Drawing.SystemColors.ControlText;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1;
            this.DataField.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.DataField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "chuTich_MaPhach_InDauMaPhach.TenMonThi", "Môn thi: {0}")});
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel3.Location = new System.Drawing.Point(9, 27);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Size = new System.Drawing.Size(612, 22);
            this.xrLabel3.StyleName = "DataField";
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel9.Location = new System.Drawing.Point(9, 5);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Size = new System.Drawing.Size(612, 46);
            this.xrLabel9.StyleName = "Title";
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "DANH SÁCH MÃ PHÁCH THEO PHÒNG THI";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // groupHeaderBand2
            // 
            this.groupHeaderBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel6});
            this.groupHeaderBand2.Height = 35;
            this.groupHeaderBand2.Name = "groupHeaderBand2";
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Gray;
            this.xrLabel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel5.ForeColor = System.Drawing.Color.White;
            this.xrLabel5.Location = new System.Drawing.Point(117, 8);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrLabel5.Size = new System.Drawing.Size(170, 25);
            this.xrLabel5.StyleName = "FieldCaption";
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Phòng Thi";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.Gray;
            this.xrLabel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel6.ForeColor = System.Drawing.Color.White;
            this.xrLabel6.Location = new System.Drawing.Point(289, 8);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrLabel6.Size = new System.Drawing.Size(235, 25);
            this.xrLabel6.StyleName = "FieldCaption";
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Mã Phách";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2});
            this.pageFooterBand1.Height = 41;
            this.pageFooterBand1.Name = "pageFooterBand1";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrPageInfo2.Format = "Trang {0} / {1}";
            this.xrPageInfo2.Location = new System.Drawing.Point(17, 8);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Size = new System.Drawing.Size(249, 30);
            this.xrPageInfo2.StyleName = "PageInfo";
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // groupFooterBand4
            // 
            this.groupFooterBand4.Height = 1;
            this.groupFooterBand4.Name = "groupFooterBand4";
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 0;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.Gray;
            this.xrLabel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel11.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel11.ForeColor = System.Drawing.Color.White;
            this.xrLabel11.Location = new System.Drawing.Point(117, 0);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrLabel11.Size = new System.Drawing.Size(170, 25);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.StylePriority.UsePadding = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Tổng số phòng";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.Gray;
            this.xrLabel10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "chuTich_MaPhach_InDauMaPhach.PhongThi", "")});
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel10.ForeColor = System.Drawing.Color.White;
            this.xrLabel10.Location = new System.Drawing.Point(289, 0);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrLabel10.Size = new System.Drawing.Size(235, 25);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel10.Summary = xrSummary1;
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // groupFooterBand5
            // 
            this.groupFooterBand5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel11});
            this.groupFooterBand5.Height = 96;
            this.groupFooterBand5.Level = 1;
            this.groupFooterBand5.Name = "groupFooterBand5";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "chuTich_MaPhach_InDauMaPhach.HoiDongThi", "Hội đồng thi: {0}")});
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel4.Location = new System.Drawing.Point(9, 0);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Size = new System.Drawing.Size(612, 25);
            this.xrLabel4.StyleName = "DataField";
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4});
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("TenMonThi", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("HoiDongThi", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.Height = 58;
            this.groupHeaderBand1.Level = 2;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9});
            this.ReportHeader.Height = 51;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // rptDanhSachMaPhachTheoPhong
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.groupHeaderBand1,
            this.groupHeaderBand2,
            this.pageFooterBand1,
            this.groupFooterBand5,
            this.PageHeader,
            this.ReportHeader});
            this.DataAdapter = this.chuTich_MaPhach_InDauMaPhachTableAdapter;
            this.DataMember = "chuTich_MaPhach_InDauMaPhach";
            this.DataSource = this.inDauMaPhach1;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 50, 50);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.SnapToGrid = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "9.2";
            ((System.ComponentModel.ISupportInitialize)(this.inDauMaPhach1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
        private InDauMaPhach inDauMaPhach1;
        private QuanLyThiNghe.InDauMaPhachTableAdapters.chuTich_MaPhach_InDauMaPhachTableAdapter chuTich_MaPhach_InDauMaPhachTableAdapter;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand2;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand4;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    }
}
