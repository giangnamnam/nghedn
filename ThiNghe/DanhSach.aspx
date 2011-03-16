<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DanhSach.aspx.cs" Inherits="DanhSach" %>

<%@ Register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" 
        AutoGenerateColumns="False" DataSourceID="AccessDataSource1">
        <Columns>
            <dxwgv:GridViewDataTextColumn FieldName="SBD" VisibleIndex="0">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="Ho" VisibleIndex="1">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="Ten" VisibleIndex="2">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="NgaySinh" VisibleIndex="3">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="NoiSinh" VisibleIndex="4">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="Phong" VisibleIndex="5">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="Lop" VisibleIndex="6">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="TenNgheThi" VisibleIndex="7">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="TenHD" VisibleIndex="8">
            </dxwgv:GridViewDataTextColumn>
        </Columns>
    </dxwgv:ASPxGridView>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/App_Data/DataPhongThi2011.mdb" 
        SelectCommand="SELECT ThiSinh.SBD, ThiSinh.Ho, ThiSinh.Ten, ThiSinh.NgaySinh, ThiSinh.NoiSinh, ThiSinh.Phong, ThiSinh.Lop, NgheThi.TenNgheThi, HoiDongThi.TenHD FROM ((ThiSinh INNER JOIN NgheThi ON ThiSinh.MaNgheThi = NgheThi.MaNgheThi) INNER JOIN HoiDongThi ON ThiSinh.MaHD = HoiDongThi.MaHD) WHERE (ThiSinh.TenTruong = 'THPT Bùi Thị Xuân') ORDER BY ThiSinh.Phong, ThiSinh.SBD">
    </asp:AccessDataSource>
    </form>
</body>
</html>
