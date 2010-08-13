using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThiNghe.Forms
{
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn sẽ kông thể sửa điểm sau khi lưu, bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {

            }
        }
    }
}
