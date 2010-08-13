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
    public partial class frmTruong : Form
    {
        QLTN_Entities en = new QLTN_Entities();
        public frmTruong()
        {
            InitializeComponent();

            comboBoxEdit1.Properties.Items.AddRange(en.DMHuyen.Select(h => h.TenHuyen).ToList());
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenhuyen = comboBoxEdit1.SelectedText;

            var schools = en.DMTruong.Where(t => t.DMHuyen.TenHuyen == tenhuyen).Select(t1 => new { t1.TenTruong, SoThiSinh = t1.ThiSinh.Count });

            gridControl1.DataSource = schools;
        }
    }
}
