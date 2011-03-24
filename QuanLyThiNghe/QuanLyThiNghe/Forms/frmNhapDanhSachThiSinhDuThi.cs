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

namespace QuanLyThiNghe.Forms
{
    public partial class frmNhapDanhSachThiSinhDuThi : DevExpress.XtraEditors.XtraForm
    {
        public DMKyThi KTHT { get; set; }
        QLTN_Entities en = new QLTN_Entities();
        public DataTable DanhSachTruong { get; set; }


        public frmNhapDanhSachThiSinhDuThi()
        {
            InitializeComponent();
        }
        public string LastChoice { get; set; }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable tbl = null;
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
                string dr = fdl.SelectedPath;
                LastChoice = dr;
                foreach (string FPath in Directory.GetFiles(dr, "*."+KTHT.MaKyThi+".*"+".xls"))
                {

                    int[] Ma = LayMaKyThi_MaTruong(Path.GetFileName(FPath));
                     
                    
                    
                    try
                    {
                        DataTable tbl2 = new DataTable();
                        tbl2 = (GetExcelData(FPath, "Info$").Copy());
                        tbl2.Columns.Add("FilePath");
                        tbl2.Columns.Add("MaTruong");
                        tbl2.Columns.Add("TenTruong");
                        tbl2.Columns.Add("check");

                        int MaTruong = Ma[1];

                        tbl2.Rows[0]["FilePath"] = FPath;
                        tbl2.Rows[0]["MaTruong"] = MaTruong;
                        //if (en.DMTruong.Where(t => t.MaTruong == MaTruong).Count() > 0)
                        //    tbl2.Rows[0]["TenTruong"] = en.DMTruong.Where(t => t.MaTruong == MaTruong).First().TenTruong;
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
                    gridControlDanhSach.DataSource = DanhSachTruong;
                    btnNhapDuLieu.Enabled = true;

                }
                else
                {
                    DanhSachTruong = null;
                    btnNhapDuLieu.Enabled = false;
                }
            }
        }
        //public DataSet GetExcelDataByApp(string fileName, int sheetIndex)
        //{
        //    Excel.Application oXL;
        //    Workbook oWB;
        //    Worksheet oSheet;
        //    Range oRng;
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        //  creat a Application object
        //        oXL = new Excel.ApplicationClass();
        //        //   get   WorkBook  object
        //        oWB = oXL.Workbooks.Open(fileName, Missing.Value, Missing.Value,
        //                Missing.Value, Missing.Value, Missing.Value,
        //                Missing.Value, Missing.Value, Missing.Value,
        //                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
        //                Missing.Value, Missing.Value);

        //        for (int k = 1; k <= oWB.Sheets.Count; k++)
        //        {
        //            //   get   WorkSheet object
        //            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oWB.Sheets[k];
        //            System.Data.DataTable dt = new System.Data.DataTable(oSheet.Name);
        //            ds.Tables.Add(dt);
        //            DataRow dr;

        //            StringBuilder sb = new StringBuilder();
        //            int jValue = oSheet.UsedRange.Cells.Columns.Count;
        //            int iValue = oSheet.UsedRange.Cells.Rows.Count;
        //            //  get data columns
        //            for (int j = 1; j <= jValue; j++)
        //            {
        //                dt.Columns.Add("column" + j, System.Type.GetType("System.String"));
        //            }

        //            //  get data in cell
        //            for (int i = 1; i <= iValue; i++)
        //            {
        //                dr = ds.Tables[oSheet.Name].NewRow();
        //                for (int j = 1; j <= jValue; j++)
        //                {
        //                    oRng = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[i, j];
        //                    string strValue = oRng.Text.ToString();
        //                    dr["column" + j] = strValue;
        //                }
        //                ds.Tables[oSheet.Name].Rows.Add(dr);
        //            }
        //        }
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        Dispose();
        //    }
        //}

        public int[] LayMaKyThi_MaTruong(string FileName)
        {
            int[] a = { 0, 0 };
            //string returnV = "0";
            string pattern = @".[\d]{1,2}";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(FileName);
            while (match.Success)
            {
                a[0] = int.Parse(match.Value.Replace(".",""));
                a[1] = int.Parse(match.NextMatch().Value.Replace(".", ""));
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
        private void frmNhapDanhSachThiSinhDuThi_Load(object sender, EventArgs e)
        {
            KTHT = HeThong.KyThiHienTai();
            repositoryItemGridLookUpEditTruong.DataSource = en.DMTruong.Where(t=>t.DaXoa==false||t.DaXoa==null).Select(t=>new{t.MaTruong,t.TenTruong}).ToList();
            repositoryItemGridLookUpEditTruong.
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
            //System.Data.DataTable tbl = GetExcelData(FPath, "LayTenCacSheet");
            //foreach (DataRow item in tbl.Rows)
            //{
            //    ds.Tables.Add(GetExcelData(FPath, item["TABLE_NAME"].ToString()).Copy());
            //}
        }
    }
}