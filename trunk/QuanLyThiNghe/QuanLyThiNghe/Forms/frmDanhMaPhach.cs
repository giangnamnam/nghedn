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

namespace QuanLyThiNghe.Forms
{
    public partial class frmDanhMaPhach : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMaPhach()
        {
            InitializeComponent();
        }

        private void frmDanhMaPhach_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            loadCSDL();
        }
        public void DanhMaPhach()
        {
            if (InvokeRequired)
            {
                // after we've done all the processing, 
                this.Invoke(new MethodInvoker(delegate
                {
                    // load the control with the appropriate data
                    lib.DanhMaPhach MP = new QuanLyThiNghe.lib.DanhMaPhach();
                    DataTable MonThi = MP.DS_MonThi_HoiDongThi_PhongThi.DefaultView.ToTable(true, "GiaTri", "MaMonThi");
                    int soLuongHoanThanh = 0;
                    int Tong = MP.LayTongSoThiSinhCanDanhMaPhach();
                    bool MaNgauNhien = chk.Checked;
                    bool BatDauBangDauPhach = radioButton1.Checked;
                    string pHONGfORMAT = textEdit1.Text;
                    string sTTfORMAT = textEdit2.Text;

                    SqlConnection con = new SqlConnection(MP.StrConnection);
                    SqlCommand com = new SqlCommand("chuTich_CapNhatMaPhach", con);
                    com.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    try
                    {

                        #region Lap mon thi
                        foreach (DataRow MT in MonThi.Rows)
                        {
                            string TDN = MT["GiaTri"].ToString();
                            string expression = "(Convert(" + "MaMonThi" + ",'System.String') = " + MT["MaMonThi"].ToString() + ")";
                            DataTable HDThi = MP.LayTheoDieuKien(expression).DefaultView.ToTable(true, "MaHoiDong");
                            int P = 0;

                            #region Lap hoi dong thi
                            foreach (DataRow HD in HDThi.Rows)
                            {
                                string expressionHD = "(Convert(" + "MaMonThi" + ",'System.String') = " + MT["MaMonThi"].ToString() + ")";
                                expressionHD += "AND (Convert(" + "MaHoiDong" + ",'System.String') = " + HD["MaHoiDong"].ToString() + ")";
                                DataTable PhongThi = MP.LayTheoDieuKien(expressionHD).DefaultView.ToTable(true, "PhongThi");
                                #region Lap phong thi
                                foreach (DataRow PT in PhongThi.Rows)
                                {
                                    P++;
                                    int mamonthi = int.Parse(MT["MaMonThi"].ToString());
                                    int mahoidong = int.Parse(HD["MaHoiDong"].ToString());
                                    int phong = int.Parse(PT["PhongThi"].ToString());
                                    DataTable DSTS = MP.LayDanhSachThiSinhTheoPhong(mamonthi, mahoidong, phong);

                                    System.Collections.ArrayList arr = new System.Collections.ArrayList();
                                    for (int i = 1; i <= 24; i++)
                                        arr.Add(i);
                                    int randomNumber = 0;
                                    #region lapThiSinh
                                    foreach (DataRow item in DSTS.Rows)
                                    {
                                        if (MaNgauNhien)
                                        {
                                            Random r = new Random();
                                            int index = r.Next(0, arr.Count - 1);
                                            randomNumber = (int)arr[index];
                                            arr.RemoveAt(index);
                                        }
                                        else
                                            randomNumber++;

                                        int mathisinh = int.Parse(item["MaThiSinh"].ToString());

                                        string strMaPhach = "";
                                        if (BatDauBangDauPhach)
                                            strMaPhach = TDN + String.Format(pHONGfORMAT, P) + String.Format(sTTfORMAT, randomNumber);
                                        else
                                            strMaPhach = String.Format(pHONGfORMAT, P) + TDN + String.Format(sTTfORMAT, randomNumber);
                                        //string strMaPhach = TDN + String.Format("{0:0000}", P) + String.Format("{0:00}", randomNumber);
                                        //string strMaPhach = P.ToString()+ TDN +  randomNumber.ToString();
                                        soLuongHoanThanh++;
                                        com.Parameters.Clear();
                                        com.Parameters.Add("@MaThiSinh", mathisinh);
                                        com.Parameters.Add("@MaPhach", strMaPhach);
                                        com.ExecuteNonQuery();
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
                    catch (Exception ex)
                    {
                    }
                    finally
                    {
                        XtraMessageBox.Show("Đã đánh mã phách thành công cho " + soLuongHoanThanh.ToString() + " thí sinh", "Đánh mã phách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        com.Clone();
                        progressBarControl1.Visible = false;
                        this.Cursor = Cursors.Default;
                    }
                }));
                return;
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhatMaPhachChoThiSinh();
        }
        public void CapNhatMaPhachChoThiSinh()
        {
            this.Cursor = Cursors.WaitCursor;
            progressBarControl1.Visible = true;
            new Thread(DanhMaPhach).Start();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlDataAdapter adap;
        DataTable dt;
        public void loadCSDL()
        {
            String sql;
            sql = @"SELECT TenMonThi, MP.* FROM (
                    SELECT * FROM dbo.DMPhach WHERE MaKyThi = (SELECT TOP 1 KyThiHienTai FROM dbo.Config)
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
            if (XtraMessageBox.Show("Nếu thay đổi đầu phách, bạn có thể phải đánh lại toàn bộ mã phách. \nBạn vẫn muốn cập nhật lại đầu phách?", "Đánh mã phách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //adap.Update(dt);
                    dataGridView1.Update();
                    DataTable newTable = new DataTable();
                    newTable = dt.GetChanges();
                    if (newTable != null)
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
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        private void progressBarControl1_TextChanged(object sender, EventArgs e)
        {
            progressBarControl1.Text = progressBarControl1.Text;
        }

        
    }
}