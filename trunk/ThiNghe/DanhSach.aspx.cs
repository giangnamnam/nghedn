using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class DanhSach : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void DownloadFile(string fname, string ClientName, bool forceDownload)
    {
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
}
