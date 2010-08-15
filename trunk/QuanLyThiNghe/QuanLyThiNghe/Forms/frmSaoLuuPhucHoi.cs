using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Microsoft.SqlServer.Management;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;


namespace QuanLyThiNghe.Forms
{
    public partial class frmSaoLuuPhucHoi : DevExpress.XtraEditors.XtraForm
    {
        public frmSaoLuuPhucHoi()
        {
            InitializeComponent();
        }

        private void frmSaoLuuPhucHoi_Load(object sender, EventArgs e)
        {
            LoadNhatKy();
        }
        public void BackupDatabase(String databaseName, String userName, String password, String serverName, String destinationPath)
        {

            Backup sqlBackup = new Backup();
            sqlBackup.Action = BackupActionType.Database;
            DateTime ht = HeThong.LayGioHeThong();//8/14/2010 9:32:24 PM
            sqlBackup.BackupSetDescription = "ArchiveDataBase:" + ht;
            sqlBackup.BackupSetName = "Archive";

            sqlBackup.Database = databaseName;
            destinationPath = destinationPath + "ThiNghe" + ht.ToString("dd-MM-yyyy-HH-mm-ss") + ".bak";
            BackupDeviceItem deviceItem = new BackupDeviceItem(destinationPath, DeviceType.File);
            ServerConnection connection = new ServerConnection(serverName, userName, password);
            Server sqlServer = new Server(connection);

            Database db = sqlServer.Databases[databaseName];

            sqlBackup.Initialize = true;
            sqlBackup.Checksum = true;
            sqlBackup.ContinueAfterError = true;
            sqlBackup.Devices.Add(deviceItem);
            sqlBackup.Incremental = false;
            //sqlBackup.ExpirationDate = DateTime.Now.AddDays(3);
            sqlBackup.LogTruncation = BackupTruncateLogType.Truncate;
            sqlBackup.FormatMedia = false;
            sqlBackup.SqlBackup(sqlServer);

            XuLyForm.LuuFile(@"C:\ThiNgheDatabaseBackupList.bin", "Backup dữ liệu (" + ht.ToString("dd/MM/yyyy HH:mm:ss") + ")|" + destinationPath+"|"+ht.ToString("MM/dd/yyyy hh:mm:ss tt"));
            
        }
        public void RestoreDatabase(String databaseName, String filePath, String serverName, String userName, String password, String dataFilePath, String logFilePath)
        {
            Restore sqlRestore = new Restore();

            BackupDeviceItem deviceItem = new BackupDeviceItem(filePath, DeviceType.File);
            sqlRestore.Devices.Add(deviceItem);
            sqlRestore.Database = databaseName;

            ServerConnection connection = new ServerConnection(serverName, userName, password);
            Server sqlServer = new Server(connection);
            
            Database db = sqlServer.Databases[databaseName];
            sqlRestore.Action = RestoreActionType.Database;
            String dataFileLocation = dataFilePath;// +databaseName + ".mdf";
            String logFileLocation = logFilePath;// +databaseName + "_Log.ldf";
            db = sqlServer.Databases[databaseName];
            RelocateFile rf = new RelocateFile(databaseName, dataFileLocation);

            sqlRestore.RelocateFiles.Add(new RelocateFile(databaseName, dataFileLocation));
            sqlRestore.RelocateFiles.Add(new RelocateFile(databaseName + "_log", logFileLocation));
            sqlRestore.ReplaceDatabase = true;
            sqlRestore.RestrictedUser = true;
            sqlRestore.Complete += new ServerMessageEventHandler(sqlRestore_Complete);
            sqlRestore.PercentCompleteNotification = 10;
            sqlRestore.PercentComplete += new PercentCompleteEventHandler(sqlRestore_PercentComplete);
            sqlRestore.ContinueAfterError = true;
            //sqlRestore.ClearSuspectPageTable(sqlServer);
            //sqlRestore.KeepReplication = true;
            sqlRestore.Partial = true;
            sqlServer.KillAllProcesses(databaseName);
            sqlRestore.Wait();
            sqlRestore.SqlRestore(sqlServer);
            
            db = sqlServer.Databases[databaseName];
            db.SetOnline();
            sqlServer.Refresh();
        }
        public event EventHandler<PercentCompleteEventArgs> PercentComplete;
        void sqlRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            if (PercentComplete != null)
                PercentComplete(sender, e);
        }
        public event EventHandler<ServerMessageEventArgs> Complete;
        void sqlRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (Complete != null)
                Complete(sender, e);
        }
        private void BackupDuLieu()
        {
            try
            {
                BackupDatabase("ThiNge", "thinge", "tn123@", "designpro.vn", @"C:\Inetpub\vhosts\gdtrhdongnai.edu.vn\httpdocs\Uploads\ThiNgheBak\");
                XuLyForm.LuuNhatKy("Backup database thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                XuLyForm.LuuNhatKy("Backup database thất bại: " + ex.Message);
            }
            LoadNhatKy();
        }
        private void PhucHoiDuLieu()
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                if (XtraMessageBox.Show("Quá trình phục hồi dữ liệu sẽ xóa hết các dữ liệu hiện tại của hệ thống,\nbạn có chắc rằng vẫn muốn phục hồi lại dữ liệu này?", "Phục hồi dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int index = gridView1.GetSelectedRows()[0];
                        string Ma1 = gridView1.GetRowCellValue(index, "GiaTri").ToString();
                        BackupDuLieu();
                        RestoreDatabase("ThiNge", Ma1, "designpro.vn", "thinge", "tn123@",
                        @"C:\Program Files\Parallels\Plesk\Databases\MSSQL\MSSQL.1\MSSQL\Data\ThiNge.mdf",
                        @"C:\Program Files\Parallels\Plesk\Databases\MSSQL\MSSQL.1\MSSQL\Data\ThiNge_log.LDF");
                        
                        
                        XuLyForm.LuuNhatKy("Phục hồi lại dữ liệu thành công. File phục hồi: " + Ma1);
                        XtraMessageBox.Show("Phục hồi dữ liệu thành công", "Phục hồi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex)
                    {
                        XuLyForm.LuuNhatKy("Phục hồi dữ liệu thất bại: " + ex.Message + "; inner: " + ex.InnerException!=null? ex.InnerException.Message:"");
                    }
                }
            }
        }
        public void LoadNhatKy()
        {
            if (File.Exists(@"C:\ThiNgheDatabaseBackupList.bin"))
            {
                try
                {
                    string filepath = @"C:\ThiNgheDatabaseBackupList.bin";
                    TextReader trs = new StreamReader(filepath);
                    string NoiDung = trs.ReadToEnd();

                    NoiDung = NoiDung.Replace("\r\n", "!");//.Replace("\n","!").Replace("\r","!");
                    string[] lbk = NoiDung.Split('!');
                    DataTable tbl = new DataTable();
                    tbl.Columns.Add("Ten");
                    tbl.Columns.Add("GiaTri");
                    tbl.Columns.Add("NgayTao");
                    
                    for (int i = 0; i < lbk.Length-1; i++)
                    {
                        string[] el = lbk[i].Split('|');
                        DataRow rw = tbl.NewRow();
                        rw[0] = el[0];
                        rw[1] = el[1];
                        tbl.Rows.Add(rw);
                    }
                    gridControl1.DataSource = tbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BackupDuLieu();
        }
        private void thêmHuyệnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //backup
            BackupDuLieu();
        }
        private void xemDanhSáchTrườngTrongHuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //phục hồi
            PhucHoiDuLieu();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //phục hồi
            PhucHoiDuLieu();
        }
    }
}