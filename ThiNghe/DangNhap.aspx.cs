using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThiNgeModel;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;

public partial class DangNhap : System.Web.UI.Page
{
    ThiNgeEntities en = new ThiNgeEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        Config c = en.Config.First();

        
        if (c.HienThiThongBaoTrenWeb==true)
        {
            Literal1.Text = c.NoiDungThongBaoTrenWeb;
        }

        if (c.ChoLoginWeb == false)
        {
            txtUserName.Enabled = txtPass.Enabled = btnDangNhap.Enabled = false;
        }
        else
        {
            loadStatus();
        }
    }


    protected void loadStatus()
    {
        if (Session["ThanhVien"] != null)
        {
            //NotLogged.Visible = false; Logged.Visible = true;
            System.Collections.ArrayList arr = new ArrayList();
            arr = (ArrayList)(Session["ThanhVien"]);
           // UserLink.Text = arr[2].ToString();
        }
        else
        {
            //NotLogged.Visible = true; Logged.Visible = false;
        }
    }
    protected DataView UserLog(string UserName, string Password)
    {
        SqlDataSource data = new SqlDataSource(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, "UserLog");
        //M.MemberID, M.GroupID, M.UserName, M.MemberName, M.Email, M.ShowEmail, P.NewsCategoryID
        data.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
        data.SelectParameters.Add("Name", UserName);
        data.SelectParameters.Add("Password", Password);
        return (DataView)data.Select(DataSourceSelectArguments.Empty);
        //string NewsID = dw.Table.Rows[0]["NewsID"].ToString();
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        DataView dtv = UserLog(txtUserName.Text, txtPass.Text);
        if (dtv.Count > 0)
        {
            System.Collections.ArrayList Attrib = new ArrayList();
            Attrib.AddRange(dtv.Table.Rows[0].ItemArray);
            Session["ThanhVien"] = Attrib;
            loadStatus();

            if (Request.QueryString["r"] != null)
                Response.Redirect(Request.QueryString["r"]);
        }

    }
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        if (Session["ThanhVien"] != null)
        {
            Session.Remove("ThanhVien");
            loadStatus();
        }
        Response.Redirect("default.aspx");
    }

}
