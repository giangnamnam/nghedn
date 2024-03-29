using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;

namespace QuanLyThiNghe.Forms
{
    public partial class frmNhapDanhSachThiSinhDuThi : DevExpress.XtraEditors.XtraForm
    {
        public DMKyThi KTHT { get; set; }
        QLTN_Entities en = new QLTN_Entities();
        public DataTable DanhSachTruong { get; set; }
        public string LastChoice { get; set; }

        public frmNhapDanhSachThiSinhDuThi()
        {
            InitializeComponent();
        }
        


        public int[] LayMaKyThi_MaTruong(string FileName)
        {
            int[] a = { 0, 0 };
            //string returnV = "0";
            string pattern = @".[\d]{1,2}";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(FileName);
            while (match.Success)
            {
                a[0] = int.Parse(match.Value.Replace(".", ""));
                a[1] = int.Parse(match.NextMatch().Value.Replace(".", ""));
                break;
            }
            return a;
        }
        private int LayMaMonThi(string p)
        {
            int a = 0;
            string pattern = @"[\d]{1,2}";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(p);
            while (match.Success)
            {
                a = int.Parse(match.Value.Replace("#", ""));
                break;
            }
            return a;
        }
        public System.Data.DataTable GetExcelData(string fileName, string worksheetName)
        {
            System.Data.DataTable tbl = null;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                                fileName + "; Extended Properties=\"Excel 8.0; HDR=YES;IMEX=1\"";
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbDataAdapter da = new OleDbDataAdapter("select * from [" + worksheetName + "]", con);
            con.Open();
            if (worksheetName == "LayTenCacSheet")
            {
                tbl = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            }
            else
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    tbl = ds.Tables[0];
                    tbl.TableName = worksheetName;
                }
            }
            con.Close();
            return tbl;
        }
        void ThemDuLieu()
        {
            try
            {
                #region ThemDuLieu
                int TongThiSinhPhaiThem = 0; foreach (DataRow item in DanhSachTruong.Rows) if (item["check"].ToString() == "True") TongThiSinhPhaiThem += int.Parse(item["Tổng thí sinh"].ToString());
                int DaThem = 0;
                if (TongThiSinhPhaiThem < 1)
                    return;
                #region Lập danh sách các file dữ liệu thí sinh dự thi
                foreach (DataRow r in DanhSachTruong.Rows)
                {
                    if (r["check"].ToString() == "True")
                    {
                        string FPath = r["FilePath"].ToString();
                        int MaTruong = int.Parse(r["MaTruong"].ToString());
                        DMTruong Truong = en.DMTruong.Where(t => t.MaTruong == MaTruong).First();
                        if (en.ThiSinh.Where(d=>d.DMTruong.MaTruong==MaTruong&&d.MaKyThi==KTHT.MaKyThi&&(d.DaXoa==false||d.DaXoa==null)).Count()>0)
                        {
                            DialogResult res = XtraMessageBox.Show("Trường " + Truong.TenTruong + " đã được nhập danh sách thí sinh, bạn có muốn nhập lại danh sách thí sinh?\nLưu ý, thông tin của các thí sinh hiện tại sẽ bị ghi đề mất.",
                        "Thêm thí sinh dự thi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (res == DialogResult.No)
                            {
                                continue;
                            }
                            else
                            {
                                foreach (ThiSinh item in en.ThiSinh.Where(d => d.DMTruong.MaTruong == MaTruong && d.MaKyThi == KTHT.MaKyThi && (d.DaXoa == false || d.DaXoa == null)).ToList())
                                {
                                    item.DaXoa = true;   
                                }
                            }
                        }
                        DataTable tblSheet = GetExcelData(FPath, "LayTenCacSheet");
                        #region Lập lấy danh sách các môn thi
                        foreach (DataRow item in tblSheet.Rows)
                        {
                            if (!item["TABLE_NAME"].ToString().Contains("Danh sách$") && !item["TABLE_NAME"].ToString().Contains("Info$"))
                            {
                                DataTable DanhSachTheoMon = GetExcelData(FPath, item["TABLE_NAME"].ToString()).Copy();
                                int MaMonThi = LayMaMonThi(item["TABLE_NAME"].ToString());
                                DMMonThi MonThi = en.DMMonThi.Where(d => d.MaMonThi == MaMonThi && (d.DaXoa == null || d.DaXoa == false)).First();
                                #region thêm thí sinh vào trường và môn thi
                                foreach (DataRow ts in DanhSachTheoMon.Rows)
                                {
                                    #region Hiển thị thanh trạng thái
                                    DaThem++;
                                    if (InvokeRequired)
                                    {
                                        // after we've done all the processing, 
                                        this.Invoke(new MethodInvoker(delegate
                                        {
                                            // load the control with the appropriate data
                                            progressBarControl1.Text = ((DaThem * 100) / TongThiSinhPhaiThem).ToString();
                                        }));
                                        //return;
                                    }
                                    else
                                        progressBarControl1.Text = ((DaThem * 100) / TongThiSinhPhaiThem).ToString();
                                    #endregion

                                    ThiSinh TS = new ThiSinh();
                                    TS.Ho = ts["Họ và chữ lót"].ToString();
                                    TS.Ten = ts["Tên"].ToString();
                                    TS.NgaySinh = ts["Ngày sinh"].ToString();
                                    TS.NoiSinh = ts["Nơi sinh"].ToString();
                                    TS.Lop = ts["Lớp"].ToString();
                                    TS.GhiChu = ts["Ghi chú"].ToString();
                                    TS.MaKyThi = KTHT.MaKyThi;
                                    Truong.ThiSinh.Add(TS);
                                    MonThi.ThiSinh.Add(TS);
                                }
                                #endregion
                            }
                        }
                        #endregion
                        string dir = Path.GetDirectoryName(FPath);
                        if (!Directory.Exists(dir + @"\DaXong\"))
                            Directory.CreateDirectory(dir + @"\DaXong\");
                        Directory.Move(FPath, dir + @"\DaXong\" + Path.GetFileName(FPath));

                    }
                }
                #endregion
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (InvokeRequired)
                {
                    // after we've done all the processing, 
                    this.Invoke(new MethodInvoker(delegate
                    {
                        // load the control with the appropriate data
                        progressBarControl1.Visible = false;
                        en.SaveChanges();
                        LayDanhSachThiSinhCacTruong();
                    }));
                }
                else
                {
                    progressBarControl1.Visible = false;
                    LayDanhSachThiSinhCacTruong();
                }
            }
            
        }
        void LayDanhSachThiSinhCacTruong()
        {
            DataTable tbl = null;

            foreach (string FPath in Directory.GetFiles(LastChoice, "*." + KTHT.MaKyThi + ".*" + ".xls"))
            {
                int[] Ma = LayMaKyThi_MaTruong(Path.GetFileName(FPath));
                try
                {
                    DataTable tbl2 = new DataTable();
                    tbl2 = (GetExcelData(FPath, "Info$").Copy());
                    tbl2.Columns.Add("FilePath");
                    tbl2.Columns.Add("MaTruong");
                    tbl2.Columns.Add("TenTruong");
                    tbl2.Columns.Add("check", Type.GetType("System.Boolean"));
                    int MaTruong = Ma[1];
                    tbl2.Rows[0]["FilePath"] = FPath;
                    tbl2.Rows[0]["MaTruong"] = MaTruong;
                    tbl2.Rows[0]["check"] = true;
                    if (tbl == null)
                    {
                        tbl = tbl2.Copy();
                    }
                    else
                    {
                        tbl.ImportRow(tbl2.Rows[0]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (tbl != null && tbl.Rows.Count > 0)
            {
                DanhSachTruong = tbl.Copy();
                btnNhapDuLieu.Enabled = true;
                
            }
            else
            {
                
                DanhSachTruong = null;
                btnNhapDuLieu.Enabled = false;
            }
            gridControlDanhSach.DataSource = DanhSachTruong;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdl = new FolderBrowserDialog();
            try
            {
                fdl.SelectedPath = LastChoice;
            }
            catch (Exception)
            {
                throw;
            }
            if (fdl.ShowDialog()== DialogResult.OK)
            {
                LastChoice = fdl.SelectedPath;
                LayDanhSachThiSinhCacTruong();
            }
        }
        private void frmNhapDanhSachThiSinhDuThi_Load(object sender, EventArgs e)
        {
            KTHT = HeThong.KyThiHienTai();
            repositoryItemGridLookUpEditTruong.DataSource = en.DMTruong.Where(t=>t.DaXoa==false||t.DaXoa==null).Select(t=>new{t.MaTruong,t.TenTruong}).OrderBy(t=>t.TenTruong).ToList();
            LoadThongTinKyThiHienTai();
        }
        private void LoadThongTinKyThiHienTai()
        {
            lblTenKyThi.Text = KTHT.TenKyThi;
            lblSoTruong.Text = en.ThiSinh.Where(t => t.MaKyThi == KTHT.MaKyThi).Select(t => t.DMTruong.MaTruong).Distinct().Count().ToString();
            lblSoLuongThiSinh.Text = en.ThiSinh.Where(t => t.MaKyThi == KTHT.MaKyThi).Count().ToString();
        }
        private void btnNhapDuLieu_Click(object sender, EventArgs e)
        {
            progressBarControl1.Visible = true;
            new Thread(ThemDuLieu).Start();
            
        }
        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            repositoryItemGridLookUpEditTruong.View.Columns["MaTruong"].Visible = false;
            e.Cancel = false;
        }
    }
}