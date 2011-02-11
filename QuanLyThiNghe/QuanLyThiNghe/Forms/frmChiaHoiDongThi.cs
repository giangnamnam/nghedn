using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;

namespace QuanLyThiNghe.Forms
{
    public partial class frmChiaHoiDongThi : DevExpress.XtraEditors.XtraForm
    {
        QLTN_Entities en = new QLTN_Entities();
        public frmChiaHoiDongThi()
        {
            InitializeComponent();
        }

        private void frmChiaHoiDongThi_Load(object sender, EventArgs e)
        {
            List<DMKyThi> ListKyThi = en.DMKyThi.OrderByDescending(k => k.NgayTao).ToList();

            if (ListKyThi.Count > 0)
            {
                comboBoxKyThi.DataSource = ListKyThi;
                comboBoxKyThi.SelectedIndex = 0;
            }
        }

        private void treeListTruong_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        void LoadKyThi()
        {

        }
        void BindTreeTruong()
        {

        }
        void BindTreeHoiDongThi()
        {

        }
    }
}