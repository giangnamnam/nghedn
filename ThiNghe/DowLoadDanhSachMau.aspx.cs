using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class DowLoadDanhSachMau : System.Web.UI.Page
{
    ThiNgeModel.ThiNgeEntities en = new ThiNgeModel.ThiNgeEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadKhoi();
        }
    }
    void LoadKhoi()
    {
        DropDownListCap.DataTextField = "TenKhoi";
        DropDownListCap.DataValueField = "MaKhoi";
        DropDownListCap.DataSource = en.DMKhoi.OrderBy(k => k.TenKhoi).ToList();
        DropDownListCap.DataBind();
        LoadTruong();
    }
    void LoadTruong()
    {
        DropDownListTruong.DataTextField = "TenTruong";
        DropDownListTruong.DataValueField = "MaTruong";
        int Ma = int.Parse(DropDownListCap.SelectedValue);
        DropDownListTruong.DataSource = en.DMTruong.Where(t => t.DMKhoi.MaKhoi == Ma &&(t.DaXoa==null||t.DaXoa==false)).OrderBy(t=>t.TenTruong).ToList();
        DropDownListTruong.DataBind();
    }
    protected void DropDownListCap_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadTruong();
    }
    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileName = DropDownListCap.SelectedItem.Text + " " + DropDownListTruong.SelectedItem.Text + "." + en.Config.First().KyThiHienTai + "." + DropDownListTruong.SelectedItem.Value + ".xls";
        DownloadFile(@"DanhSachThiSinh\Template.xls",FileName , true);
        lblFileName.Text = "Xin vui lòng đặt tên file là: " + FileName;
    }
    private void DownloadFile(string fname, string ClientName, bool forceDownload)
    {
        ClientName = lib.stringFunction.StringUtil.RemoveSign4VietnameseString(ClientName);
        string path = MapPath(fname);
        string name = Path.GetFileName(path);
        string ext = Path.GetExtension(path);
        string type = "";
        // set known types based on file extension  
        if (ext != null)
        {
            switch (ext.ToLower())
            {
                case ".htm":
                case ".html":
                    type = "text/HTML";
                    break;

                case ".txt":
                    type = "text/plain";
                    break;

                case ".doc":
                case ".rtf":
                    type = "Application/msword";
                    break;
            }
        }
        if (forceDownload)
        {
            if (string.IsNullOrEmpty(ClientName))
            {
                Response.AppendHeader("content-disposition",
                "attachment; filename=" + name);
            }
            else
                Response.AppendHeader("content-disposition",
                "attachment; filename=" + ClientName);

        }
        if (type != "")
            Response.ContentType = type;
        Response.WriteFile(path);
        Response.End();
    }
    protected void DropDownListTruong_SelectedIndexChanged(object sender, EventArgs e)
    {
        string FileName = DropDownListCap.SelectedItem.Text + " " + DropDownListTruong.SelectedItem.Text + "." + en.Config.First().KyThiHienTai + "." + DropDownListTruong.SelectedItem.Value + ".xls";
        lblFileName.Text = "Xin vui lòng đặt tên file là: " + lib.stringFunction.StringUtil.RemoveSign4VietnameseString(FileName);
    }
}
