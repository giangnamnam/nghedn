using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraNavBar;
using System.Threading;

namespace QuanLyThiNghe.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TaiKhoan TaiKhoanHienTai { get; set; }
        public DMKyThi KyThiHienTai { get; set; }

        public frmMain()
        {
            
            InitializeComponent();
            InitClock();

            frmDangNhap frm = new frmDangNhap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TaiKhoanHienTai = frm.TaiKhoanDangNhap;
                KyThiHienTai = frm.KyThiHienTai;
                this.Tag = TaiKhoanHienTai;

                TaiKhoanHienTai.PhanQuyenReference.Load();
                bSI_AboutUs.Caption = TaiKhoanHienTai.TenDangNhap + " (" + TaiKhoanHienTai.HoVaTen + " - " + TaiKhoanHienTai.PhanQuyen.TenQuyen + ") ";
                btnKyThiHienTai.Caption = "kỳ thi hiện tại: " + KyThiHienTai.TenKyThi+" ("+(KyThiHienTai.DaKetThuc.GetValueOrDefault(false)==true?"Đã kết thúc":"Chưa kết thúc")+")";
                this.Text = KyThiHienTai.TenKyThi;
                //ghi log đăng nhập

            }
            else
            {
                this.Close();
            }
        }

        #region Functions

        void InitClock()
        {
            GioHeThong = HeThong.LayGioHeThong();
            string Day = "";

            switch (GioHeThong.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    Day = "Thứ sáu";
                    break;
                case DayOfWeek.Monday:
                    Day = "Thứ hai";
                    break;
                case DayOfWeek.Saturday:
                    Day = "Thứ bảy";
                    break;
                case DayOfWeek.Sunday:
                    Day = "Chủ nhật";
                    break;
                case DayOfWeek.Thursday:
                    Day = "Thứ năm";
                    break;
                case DayOfWeek.Tuesday:
                    Day = "Thứ ba";
                    break;
                case DayOfWeek.Wednesday:
                    Day = "Thứ tư";
                    break;
                default:
                    break;
            }

            string Date = "Ngày " + GioHeThong.ToString("dd - MM - yyyy");

            lblDate.Caption = Day + ", " + Date;
            tTime.Start();

            if (GioHeThong.ToString("yyyyZ") == GioHeThong.ToString("yyyy1"))
                lblZone.Caption = "AM";
            else
                lblZone.Caption = "PM";
        }




        private void OpenFormInTheadProcess(object Frm)
        {
            if (InvokeRequired)
            {
                // after we've done all the processing, 
                this.Invoke(new MethodInvoker(delegate
                {
                    //load the control with the appropriate data
                    Form frm = (Form)Frm;
                    frm.Show();
                }));
                return;
            }
            else
            {
                Form frm = (Form)Frm;
                frm.Show();
            }
        }
        public void OpenForm(Form frm)
        {
            if (Application.OpenForms[frm.Name] != null)
            {
                Application.OpenForms[frm.Name].Activate();
                //frm.Show();
            }
            else
            {
                frm.MdiParent = this;

                //ShowLoading();
                OpenFormInTheadProcess(frm);
                //EndLoading();
                //System.Threading.Thread
                //newDoStuff = new System.Threading.Thread(
                //new System.Threading.ParameterizedThreadStart(OpenFormInTheadProcess));
                //newDoStuff.Start(frm);


                if (!nBI_CloseAllButCurrent.Enabled)
                    nBI_CloseAllButCurrent.Enabled = true;
                else if (!nBI_CloseAllWindows.Enabled)
                    nBI_CloseAllWindows.Enabled = true;

                NavBarItem nBI = new NavBarItem();
                nBI.Caption = frm.Text;
                nBI.Name = frm.Name;
                nBI.SmallImage = global::QuanLyThiNghe.Properties.Resources.icon22;
                nBI.LinkClicked += new NavBarLinkEventHandler(nBI_LinkClicked);
                nBG_OpenWindows.ItemLinks.Add(nBI);
            }
        }

        void CloseForm(Form frm)
        {
            foreach (Control trl in frm.Controls)
            {
                trl.Dispose();
            }
            frm.Close();
        }

        void AddOpenWindow(object Frm)
        {
            Form frm = (Form)Frm;
            if (!nBI_CloseAllButCurrent.Enabled)
                nBI_CloseAllButCurrent.Enabled = true;
            else if (!nBI_CloseAllWindows.Enabled)
                nBI_CloseAllWindows.Enabled = true;

            NavBarItem nBI = new NavBarItem();
            nBI.Caption = frm.Text;
            nBI.Name = frm.Name;
            nBI.SmallImage = global::QuanLyThiNghe.Properties.Resources.icon22;
            nBI.LinkClicked += new NavBarLinkEventHandler(nBI_LinkClicked);

            nBG_OpenWindows.ItemLinks.Add(nBI);
        }

        void RemoveOpenWindow(string frmName)
        {
            if (xtraTabbedMdiManager1.Pages.Count == 0)
                nBI_CloseAllWindows.Enabled = nBI_CloseAllButCurrent.Enabled = bSI_CloseAll.Enabled = bSI_CloseAllButCurrent.Enabled = false;
            else if (xtraTabbedMdiManager1.Pages.Count == 1)
            {
                nBI_CloseAllButCurrent.Enabled = false;
                bSI_CloseAllButCurrent.Enabled = false;
            }

            foreach (NavBarItemLink item in nBG_OpenWindows.ItemLinks)
            {
                if (item.Item.Name == frmName)
                {
                    nBG_OpenWindows.ItemLinks.Remove(item);
                    break;
                }
            }
        }

        void nBI_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Application.OpenForms[e.Link.ItemName].Activate();
        }

        #endregion

        private void nBI_Districts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmHuyen frm = new frmHuyen();
            OpenForm(frm);
        }
        public DateTime GioHeThong { get; set; }
        private void tTime_Tick(object sender, EventArgs e)
        {
            GioHeThong = GioHeThong.AddSeconds(1.0);
            lblTime.Caption = GioHeThong.ToString("hh:mm:ss");
        }

        private void nBI_KyThi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKyThi frm = new frmKyThi();
            OpenForm(frm);
        }

        private void nBI_HDT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmHoiDongThi frm = new frmHoiDongThi();
            OpenForm(frm);
        }

        private void nBI_MonThi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmMonThi frm = new frmMonThi();
            OpenForm(frm);
        }

        private void nBI_Truong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTruong frm = new frmTruong();
            OpenForm(frm);
        }

        private void nBI_ThiSinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThiSinh frm = new frmThiSinh();
            OpenForm(frm);
        }

        private void nBI_TaiKhoan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThanhVien frm = new frmThanhVien();
            OpenForm(frm);
        }

        private void nBI_PhanQuyen_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmQuyen frm = new frmQuyen();
            OpenForm(frm);
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            RemoveOpenWindow(e.Page.MdiChild.Name);
        }

        private void nBI_CloseAllWindows_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            int openforms = nBG_OpenWindows.ItemLinks.Count;
            for (int i = 3; i < openforms; i++)
            {
                NavBarItemLink nBIL = nBG_OpenWindows.ItemLinks[3];
                CloseForm(Application.OpenForms[nBIL.Item.Name]);
            }
        }

        private void nBI_CloseAllButCurrent_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            int openforms = nBG_OpenWindows.ItemLinks.Count;
            for (int i = 3; i < openforms; i++)
            {
                NavBarItemLink nBIL = nBG_OpenWindows.ItemLinks[3];
                if (nBIL.Item.Name != xtraTabbedMdiManager1.SelectedPage.MdiChild.Name)
                {
                    CloseForm(Application.OpenForms[nBIL.Item.Name]);
                }
            }
        }

        private void bSI_AboutUs_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void bSI_LogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void nBI_Log_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmNhatKyDangNhap frm = new frmNhatKyDangNhap();
            OpenForm(frm);
        }

        private void nBI_Help_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmTroGiup frm = new frmTroGiup();
            OpenForm(frm);
        }

        private void bSI_CloseAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            int openforms = nBG_OpenWindows.ItemLinks.Count;
            for (int i = 3; i < openforms; i++)
            {
                NavBarItemLink nBIL = nBG_OpenWindows.ItemLinks[3];
                CloseForm(Application.OpenForms[nBIL.Item.Name]);
            }
        }

        private void bSI_CloseAllButCurrent_ItemClick(object sender, ItemClickEventArgs e)
        {
            int openforms = nBG_OpenWindows.ItemLinks.Count;
            for (int i = 3; i < openforms; i++)
            {
                NavBarItemLink nBIL = nBG_OpenWindows.ItemLinks[3];
                if (nBIL.Item.Name != xtraTabbedMdiManager1.SelectedPage.MdiChild.Name)
                {
                    CloseForm(Application.OpenForms[nBIL.Item.Name]);
                }
            }
        }

        

        private void frmMain_Load(object sender, EventArgs e)
        {
            

        }

        private void navBarItem13_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmCauHinh frm = new frmCauHinh();
            if (Application.OpenForms[frm.Name] != null)
                Application.OpenForms[frm.Name].Activate();
            else
            {
                //pictureBoxLoading.Visible = true; 
                frm.ShowDialog(); 
                //pictureBoxLoading.Visible = false;
            }

            
        }

        private void navBarItem14_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmSaoLuuPhucHoi frm = new frmSaoLuuPhucHoi();
            OpenForm(frm);
        }

        private void btnMaPhach_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmDanhMaPhach frm = new frmDanhMaPhach();
            OpenForm(frm);
        }

        private void tbnInMaPhach_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmInDanhSach frm = new frmInDanhSach();
            OpenForm(frm);
            
        }

        private void navBarItemChiaHoiDong_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmChiaHoiDongThi frm = new frmChiaHoiDongThi();
            OpenForm(frm);
        }

        private void btnKyThiHienTai_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCauHinh frm = new frmCauHinh();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            //pictureBoxLoading.Visible = true; 
            frm.ShowDialog(); 
            //pictureBoxLoading.Visible = false;
        }

        private void barButtonCauHinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCauHinh frm = new frmCauHinh();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            //pictureBoxLoading.Visible = true; 
            frm.ShowDialog(); 
            //pictureBoxLoading.Visible = false;
        }

        private void barButtonNhatKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhatKyDangNhap frm = new frmNhatKyDangNhap();
            OpenForm(frm);
        }

        private void ribbon_ApplicationButtonClick(object sender, EventArgs e)
        {
            if (navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Collapsed)
                navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded;
            else
                navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed;

        }
        public void EndLoading()
        {
            if (Application.OpenForms["frmLoading"] != null)
            {
                if (InvokeRequired)
                {
                    // after we've done all the processing, 
                    this.Invoke(new MethodInvoker(delegate
                    {
                        //load the control with the appropriate data
                        Application.OpenForms["frmLoading"].Close();
                    }));
                    return;
                }
                else
                    Application.OpenForms["frmLoading"].Close();
            }
            
        }

        public void ShowLoading()
        {

            frmLoading frm = new frmLoading();
            if (InvokeRequired)
            {
                // after we've done all the processing, 
                this.Invoke(new MethodInvoker(delegate
                {
                    //load the control with the appropriate data
                    if (Application.OpenForms["frmLoading"] == null)
                        frm.Show();
                    else
                        Application.OpenForms["frmLoading"].Activate();
                }));
                return;
            }
            else
                if (Application.OpenForms["frmLoading"] == null)
                    frm.Show();
                else
                    Application.OpenForms["frmLoading"].Activate();


        }

        private void navBarItem4_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmHoiDongThi frm = new frmHoiDongThi();
            OpenForm(frm);
        }

        private void navBarItemNhapDanhSachThiSinh_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmNhapDanhSachThiSinhDuThi frm = new frmNhapDanhSachThiSinhDuThi();
            OpenForm(frm);
        }
        
    }
}