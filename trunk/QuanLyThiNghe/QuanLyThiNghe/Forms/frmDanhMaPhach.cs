using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Diagnostics;
using QuanLyThiNghe.Reports;
using System.Linq;

namespace QuanLyThiNghe.Forms
{
    public partial class frmDanhMaPhach : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities en = new QLTN_Entities();
        public frmDanhMaPhach()
        {
            InitializeComponent();
        }
        public DMKyThi KyThiHienTai { get; set; }
        private void frmDanhMaPhach_Load(object sender, EventArgs e)
        {
            KyThiHienTai = HeThong.KyThiHienTai();
            dataGridView1.AutoGenerateColumns = false;
            loadCSDL();
        }
        public void DanhMaPhach()
        {
            List<ThiSinh> TSDT = en.ThiSinh.Where(t => t.MaKyThi == KyThiHienTai.MaKyThi && (t.DaXoa == false || t.DaXoa == null)).ToList();
            var DMKs = en.ThiSinh.Where( t => t.MaKyThi == KyThiHienTai.MaKyThi && (t.DaXoa == false || t.DaXoa == null))
                .Select(t => new { t.DMTruong.DMKhoi.MaKhoi, t.DMTruong.DMKhoi.TenKhoi }).Distinct().ToList();
            int soLuongHoanThanh = 0;
            int Tong = TSDT.Count;
            bool MaNgauNhien = chk.Checked;
            bool BatDauBangDauPhach = radioButton1.Checked;
            string pHONGfORMAT = textEdit1.Text;
            string sTTfORMAT = textEdit2.Text;
            try
            {
                for (int i = 0; i < DMKs.Count(); i++)
                {
                    int maKhoiThi = DMKs[i].MaKhoi;
                    var DMMTs = en.ThiSinh.Where(t => 
                        t.MaKyThi == KyThiHienTai.MaKyThi && 
                        (t.DaXoa == false || t.DaXoa == null) && 
                        t.DMTruong.DMKhoi.MaKhoi == maKhoiThi)
                        .Select(t => new { t.DMMonThi.MaMonThi, t.DMMonThi.TenMonThi }).Distinct().ToList();

                    #region Lap mon thi
                    for (int j = 0; j < DMMTs.Count; j++)
                    {
                        int intmamonthi = DMMTs[j].MaMonThi;
                        DMMonThi monthien = en.DMMonThi.Include("DMPhach").Where(m => m.MaMonThi == intmamonthi).First();
                        string TDN = monthien.DMPhach.First().GiaTri;
                        var HDTs = en.ThiSinh.Where(t => 
                            t.MaKyThi == KyThiHienTai.MaKyThi && 
                            (t.DaXoa == false || t.DaXoa == null) && 
                            t.DMMonThi.MaMonThi == intmamonthi &&
                            t.HoiDongThi!=null)
                            .Select(t => new { t.HoiDongThi.MaHoiDong }).Distinct().ToList();
                        int P = 0;
                        int countSoPhongTheoMon = en.ThiSinh.Where(t =>
                            t.MaKyThi == KyThiHienTai.MaKyThi &&
                            (t.DaXoa == false || t.DaXoa == null) &&
                            t.DMTruong.DMKhoi.MaKhoi == maKhoiThi && 
                            t.DMMonThi.MaMonThi == intmamonthi &&
                            t.HoiDongThi != null)
                            .Select(t => new { t.HoiDongThi.MaHoiDong, t.PhongThi }).Distinct().Count();
                        System.Collections.ArrayList arr = new System.Collections.ArrayList();
                        for (int k = 1; k <= countSoPhongTheoMon; k++)
                            arr.Add(k);


                        #region Lap hoi dong thi
                        for (int l = 0; l < HDTs.Count; l++)
                        {
                            int mahoidong = HDTs[l].MaHoiDong;
                            var PhongThis = en.ThiSinh.Where(t =>
                                t.MaKyThi == KyThiHienTai.MaKyThi &&
                                (t.DaXoa == false || t.DaXoa == null) && 
                                t.DMTruong.DMKhoi.MaKhoi == maKhoiThi && 
                                t.DMMonThi.MaMonThi == intmamonthi && 
                                t.HoiDongThi.MaHoiDong == mahoidong &&
                                t.PhongThi !=null
                                )
                                .Select(t => new { t.PhongThi }).Distinct().ToList();

                            #region Lap phong thi
                            for (int m = 0; m < PhongThis.Count; m++)
                            {
                                if (MaNgauNhien)
                                {
                                    Random r = new Random();
                                    int index = r.Next(0, arr.Count - 1);
                                    P = (int)arr[index];
                                    arr.RemoveAt(index);
                                }
                                else
                                {
                                    P++;
                                }

                                int phong = PhongThis[m].PhongThi.Value;
                                List<ThiSinh> DSTSTheoPhongThi = en.ThiSinh.Where(t =>
                                    t.MaKyThi == KyThiHienTai.MaKyThi &&
                                    (t.DaXoa == false || t.DaXoa == null) &&
                                    t.DMTruong.DMKhoi.MaKhoi == maKhoiThi
                                    && t.DMMonThi.MaMonThi == intmamonthi
                                    && t.HoiDongThi.MaHoiDong == mahoidong
                                    && t.PhongThi == phong
                                    ).OrderBy(t=>t.SBD).ToList();

                                int randomNumber = 0;
                                #region lapThiSinh
                                foreach (ThiSinh item in DSTSTheoPhongThi)
                                {
                                    randomNumber++;
                                    string strMaPhach = "";
                                    if (BatDauBangDauPhach)
                                        strMaPhach = TDN + String.Format(pHONGfORMAT, P) + String.Format(sTTfORMAT, randomNumber);
                                    else
                                        strMaPhach = String.Format(pHONGfORMAT, P) + TDN + String.Format(sTTfORMAT, randomNumber);
                                    soLuongHoanThanh++;
                                    item.MaPhach = strMaPhach;
                                }
                                #endregion
                                progressBarControl1.Text = ((soLuongHoanThanh * 100) / Tong).ToString();
                                progressBarControl1.Update();
                            }
                            #endregion
                        }
                        #endregion
                    }
                    #endregion
                }
                en.SaveChanges();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                XtraMessageBox.Show("Đã đánh mã phách thành công cho " + soLuongHoanThanh.ToString() + " thí sinh", "Đánh mã phách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBarControl1.Visible = false;
                this.Cursor = Cursors.Default;
            }

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int MaKyThiHienTai = KyThiHienTai.MaKyThi;
            bool pass = true;

            List<ThiSinh> ThiSinhKhongCoHoiDongThi = en.ThiSinh.Where(t => t.MaKyThi == KyThiHienTai.MaKyThi && (t.DaXoa == false || t.DaXoa == null) && t.HoiDongThi == null).ToList();
            //t.HoiDongThi!=null
            List<ThiSinh> ThiSinhKhongBietMonThi = en.ThiSinh.Where(t => t.MaKyThi == KyThiHienTai.MaKyThi && (t.DaXoa == false || t.DaXoa == null) && t.DMMonThi == null).ToList();
            //t.DMMonThi
            List<ThiSinh> ThiSinhKhongBietTruong = en.ThiSinh.Where(t => t.MaKyThi == KyThiHienTai.MaKyThi && (t.DaXoa == false || t.DaXoa == null) && t.DMTruong == null).ToList();
            //t.DMTruong
            List<ThiSinh> ThiSinhKhongBietPhongThi = en.ThiSinh.Where(t => t.MaKyThi == KyThiHienTai.MaKyThi && (t.DaXoa == false || t.DaXoa == null) && t.PhongThi == null).ToList();
            //t.PhongThi

            if (ThiSinhKhongCoHoiDongThi.Count > 0)
            {
                pass = false;
                XtraMessageBox.Show("Hiện đang có: " + ThiSinhKhongCoHoiDongThi.Count + " thí sinh chưa xếp hội đồng thi.", "Đánh mã phách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ThiSinhKhongBietMonThi.Count > 0)
            {
                pass = false;
                XtraMessageBox.Show("Hiện có: " + ThiSinhKhongBietMonThi.Count + " thí sinh không biết môn thi.", "Đánh mã phách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ThiSinhKhongBietTruong.Count > 0)
            {
                pass = false;
                XtraMessageBox.Show("Hiện có: " + ThiSinhKhongBietTruong.Count + " thí sinh không biết thuộc trường nào.", "Đánh mã phách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ThiSinhKhongBietPhongThi.Count > 0)
            {
                pass = false;
                XtraMessageBox.Show("Hiện có:  " + ThiSinhKhongBietPhongThi.Count + " thí sinh chưa được chia phòng thi.", "Đánh mã phách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (pass == false)
            {
                XtraMessageBox.Show("Xin vui lòng kiểm tra lại trước khi đánh mã phách.", "Đánh mã phách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int intDaCoMaPhach = en.ThiSinh.Where(t => t.MaKyThi == MaKyThiHienTai && t.MaPhach!=null).Count();
            if (intDaCoMaPhach == 0 || XtraMessageBox.Show("Đã có " + intDaCoMaPhach.ToString() + " thí sinh được đánh mã phách rồi, bạn có muốn đánh mã phách lại không?",
                    "Đánh mã phách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Update();
                DataTable newTable = new DataTable();
                newTable = dt.GetChanges();
                if (newTable != null)
                {
                    DialogResult re =
                    XtraMessageBox.Show("Định nghĩa đầu phách có thay đổi, bạn có muốn lưu lại các thay đổi này không?",
                        "Đánh mã phách", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);// 
                    if (re == DialogResult.Yes)
                    {
                        try
                        {
                            SqlCommandBuilder cmb = new SqlCommandBuilder(adap);
                            adap.TableMappings.Clear();
                            adap.TableMappings.Add("GiaTri", dt.TableName);
                            adap.Update(newTable);
                            loadCSDL();
                            CapNhatMaPhachChoThiSinh();
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    CapNhatMaPhachChoThiSinh();
                }
            }
        }
        public void CapNhatMaPhachChoThiSinh()
        {
            this.Cursor = Cursors.WaitCursor;
            progressBarControl1.Visible = true;
            //new Thread(DanhMaPhach).Start();
            DanhMaPhach();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlDataAdapter adap;
        DataTable dt;
        public void loadCSDL()
        {
            String sql;//WHERE MaKyThi = (SELECT TOP 1 KyThiHienTai FROM dbo.Config)
            sql = @"SELECT TenMonThi, MP.* FROM (
                    SELECT * FROM dbo.DMPhach 
                    
                    ) AS MP INNER JOIN
                    dbo.DMMonThi ON MP.MaMonThi = dbo.DMMonThi.MaMonThi";
            //sql = @"SELECT * FROM dbo.DMPhach WHERE MaKyThi = (SELECT TOP 1 KyThiHienTai FROM dbo.Config)";
            string myConnection = @"Data Source=.\sqlexpress;Initial Catalog=ThiNge;Integrated Security=True";
            SqlConnection c = new SqlConnection(myConnection);
            adap = new SqlDataAdapter(sql, c);
            string strUpdate = "chuTich_CapNhatDauPhach";
            SqlCommand cmdUpdate = new SqlCommand(strUpdate, c);
            cmdUpdate.CommandType = CommandType.StoredProcedure;
            SqlParameter pCol1 = new SqlParameter("@MaPhach", SqlDbType.Int, 4, "MaPhach");
            cmdUpdate.Parameters.Add(pCol1);
            SqlParameter pCol2 = new SqlParameter("@GiaTri", SqlDbType.NVarChar, 50, "GiaTri");
            cmdUpdate.Parameters.Add(pCol2);
            adap.UpdateCommand = cmdUpdate;
            SqlCommandBuilder cb = new SqlCommandBuilder(adap);
            if (c.State == ConnectionState.Closed)
                c.Open();
            dt = new DataTable("tbl");
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv["cSTT", e.RowIndex].Value = (e.RowIndex + 1).ToString();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
                    //adap.Update(dt);
                    dataGridView1.Update();
                    DataTable newTable = new DataTable();
                    newTable = dt.GetChanges();
                    if (newTable != null)
                    {
                        if (XtraMessageBox.Show("Nếu thay đổi đầu phách, bạn có thể phải đánh lại toàn bộ mã phách. \nBạn vẫn muốn cập nhật lại đầu phách?", "Đánh mã phách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                SqlCommandBuilder cmb = new SqlCommandBuilder(adap);
                                adap.TableMappings.Clear();
                                adap.TableMappings.Add("GiaTri", dt.TableName);
                                adap.Update(newTable);
                                loadCSDL();

                                if (XtraMessageBox.Show("Đã lưu đầu phách thành công. Bạn có muốn đánh mã phách theo đầu phách mới này ngay không?", "Đánh mã phách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    CapNhatMaPhachChoThiSinh();
                                }
                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.Message);
                            }
                        }
                        else
                            loadCSDL();
                
            }
        }
        private void progressBarControl1_TextChanged(object sender, EventArgs e)
        {
            progressBarControl1.Text = progressBarControl1.Text;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            InMaPhach rpt = new InMaPhach();
            //rpt.ShowDesigner();
            //rpt.ShowDesignerDialog();
            //rpt.ShowPreview();
            rpt.ShowPreviewDialog();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InMaPhach rpt = new InMaPhach();
            rpt.ShowPreviewDialog();
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InMaPhach rpt = new InMaPhach();
            rpt.ShowDesignerDialog();
            
        }

        
    }
}