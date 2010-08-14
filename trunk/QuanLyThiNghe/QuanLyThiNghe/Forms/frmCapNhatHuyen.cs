using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThiNghe.Forms
{
    public partial class frmCapNhatHuyen : Form
    {
        QLTN_Entities _Entities = new QLTN_Entities();
        public int MaHuyen;

        public frmCapNhatHuyen()
        {
            InitializeComponent();
        }

        private void frmCapNhatHuyen_Load(object sender, EventArgs e)
        {

        }

        public void LoadDistrictsByID(int ID)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.ToolTipTitle == "insert")
            {
                DMHuyen h = new DMHuyen();

                h.DaXoa = false;
                h.NgayCapNhat = h.NgayTao = DateTime.Now;
                h.NguoiCapNhat = h.NguoiTao = "";
                h.TenHuyen = txtDistrictName.Text;

                try
                {
                    _Entities.AddToDMHuyen(h);
                    _Entities.SaveChanges();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Có lối xảy ra: " + exp.Message);
                    return;
                }
                finally
                {
                    frmHuyen f = (frmHuyen)Application.OpenForms["frmHuyen"];
                    f.LoadDistricts();

                    txtDistrictName.Text = "";
                }
            }
            else
            {
                var h = _Entities.DMHuyen.Where(d => d.MaHuyen == MaHuyen).FirstOrDefault();

                h.DaXoa = false;
                h.NgayCapNhat = DateTime.Now;
                h.NguoiCapNhat = "";
                h.TenHuyen = txtDistrictName.Text;

                try
                {
                    _Entities.SaveChanges();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Có lối xảy ra: " + exp.Message);
                    return;
                }
                finally
                {
                    MessageBox.Show("Đã cập nhật thành công.");

                    frmHuyen f = (frmHuyen)Application.OpenForms["frmHuyen"];
                    f.LoadDistricts();
                }
            }
        }
    }
}
