using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace QuanLyThiNghe.Forms
{
    public partial class frmNhapDanhSachThiSinhDuThi : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapDanhSachThiSinhDuThi()
        {
            InitializeComponent();
        }
        public string LastChoice { get; set; }
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
                string dr = fdl.SelectedPath;
                LastChoice = dr;
                foreach (string FPath in Directory.GetFiles(dr, "*.xls"))
                {
                    DataSet ds = new DataSet();
                     System.Data.DataTable tbl = GetExcelData(FPath, "LayTenCacSheet");
                     foreach (DataRow item in tbl.Rows)
                     {
                         ds.Tables.Add(GetExcelData(FPath, item["TABLE_NAME"].ToString()).Copy());
                     }
                }
            }
        }

        public DataSet GetExcelDataByApp(string fileName, int sheetIndex)
        {
            Excel.Application oXL;
            Workbook oWB;
            Worksheet oSheet;
            Range oRng;
            DataSet ds = new DataSet();
            try
            {
                //  creat a Application object
                oXL = new Excel.ApplicationClass();
                //   get   WorkBook  object
                oWB = oXL.Workbooks.Open(fileName, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value);

                for (int k = 1; k <= oWB.Sheets.Count; k++)
                {
                    //   get   WorkSheet object
                    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oWB.Sheets[k];
                    System.Data.DataTable dt = new System.Data.DataTable(oSheet.Name);
                    ds.Tables.Add(dt);
                    DataRow dr;

                    StringBuilder sb = new StringBuilder();
                    int jValue = oSheet.UsedRange.Cells.Columns.Count;
                    int iValue = oSheet.UsedRange.Cells.Rows.Count;
                    //  get data columns
                    for (int j = 1; j <= jValue; j++)
                    {
                        dt.Columns.Add("column" + j, System.Type.GetType("System.String"));
                    }

                    //  get data in cell
                    for (int i = 1; i <= iValue; i++)
                    {
                        dr = ds.Tables[oSheet.Name].NewRow();
                        for (int j = 1; j <= jValue; j++)
                        {
                            oRng = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[i, j];
                            string strValue = oRng.Text.ToString();
                            dr["column" + j] = strValue;
                        }
                        ds.Tables[oSheet.Name].Rows.Add(dr);
                    }
                }
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Dispose();
            }
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
    }
}