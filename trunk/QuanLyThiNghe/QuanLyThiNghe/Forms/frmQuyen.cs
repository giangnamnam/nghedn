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
    public partial class frmQuyen : Form
    {
        QLTN_Entities en = new QLTN_Entities();

        public frmQuyen()
        {
            InitializeComponent();
        }

        private void frmQuyen_Load(object sender, EventArgs e)
        {
            var PhanQuyens = en.PhanQuyen.Where(x=> (x.DaXoa == null || x.DaXoa==false)).Select(q => new {q.MaPhanQuyen,q.TenQuyen,q.GiaTri,q.GhiChu,q.NguoiTao,q.NguoiCapNhat,q.NgayCapNhat} ); //.Where(t => t.DMHuyen.TenHuyen == tenhuyen).Select(t1 => new { t1.TenTruong, SoThiSinh = t1.ThiSinh.Count });
            gridControl1.DataSource = PhanQuyens;
        }
    }
}
