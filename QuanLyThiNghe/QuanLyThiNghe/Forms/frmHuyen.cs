using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThiNghe;

namespace QuanLyThiNghe.Forms
{
    public partial class frmHuyen : Form
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        int MaHuyen = 0;
        public frmHuyen()
        {
            InitializeComponent();
        }

        private void frmHuyen_Load(object sender, EventArgs e)
        {
            LoadDistricts();
        }

        public void LoadDistricts()
        {
            var Huyen = _Entities.DMHuyen.OrderBy(h => h.TenHuyen);//.Select(h => new { h.TenHuyen, h.MaHuyen, SoTruong = h.DMTruong.Count })
            gvDistricts.DataSource = Huyen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            
            //frmCapNhatHuyen frm = new frmCapNhatHuyen();
            //frm.ShowDialog();

            //frm.btnSave.ToolTipTitle = "insert";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var h = _Entities.DMHuyen.First(d => d.MaHuyen == MaHuyen);

            _Entities.DeleteObject(h);

            try
            {
                _Entities.SaveChanges();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Có lỗi xảy ra: " + exp.Message);
                return;
            }
            finally
            {
                MessageBox.Show("Đã xoá thành công.");

                LoadDistricts();
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            try
            {
                gridView1.DeleteSelectedRows();
                gvDistricts.RefreshDataSource();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Xoá thành công: " + exp.Message);
                return;

            }
            finally
            {
                MessageBox.Show("Đã xoá thành công.");
            }
        }

        private void btnViewSchoolInDistricts_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(e.RowHandle);

            row["TenHuyen"] = "";
            row["SoTruong"] = 0;
        }
    }
}
