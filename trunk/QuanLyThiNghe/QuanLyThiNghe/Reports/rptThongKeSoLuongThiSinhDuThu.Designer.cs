namespace QuanLyThiNghe.Reports
{
    partial class rptThongKeSoLuongThiSinhDuThu
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.danhSachThiSinh1 = new QuanLyThiNghe.DanhSachThiSinh();
            this.rpt_LayDanhSachThiSinh_kyThiHienTaiTableAdapter = new QuanLyThiNghe.DanhSachThiSinhTableAdapters.rpt_LayDanhSachThiSinh_kyThiHienTaiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThiSinh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 30;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 30;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // danhSachThiSinh1
            // 
            this.danhSachThiSinh1.DataSetName = "DanhSachThiSinh";
            this.danhSachThiSinh1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpt_LayDanhSachThiSinh_kyThiHienTaiTableAdapter
            // 
            this.rpt_LayDanhSachThiSinh_kyThiHienTaiTableAdapter.ClearBeforeFill = true;
            // 
            // rptThongKeSoLuongThiSinhDuThu
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter});
            this.DataAdapter = this.rpt_LayDanhSachThiSinh_kyThiHienTaiTableAdapter;
            this.DataMember = "rpt_LayDanhSachThiSinh_kyThiHienTai";
            this.DataSource = this.danhSachThiSinh1;
            this.Version = "9.2";
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThiSinh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DanhSachThiSinh danhSachThiSinh1;
        private QuanLyThiNghe.DanhSachThiSinhTableAdapters.rpt_LayDanhSachThiSinh_kyThiHienTaiTableAdapter rpt_LayDanhSachThiSinh_kyThiHienTaiTableAdapter;
    }
}
