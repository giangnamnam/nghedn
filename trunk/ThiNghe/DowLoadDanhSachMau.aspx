<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DowLoadDanhSachMau.aspx.cs" Inherits="DowLoadDanhSachMau" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownListCap" runat="server" 
            onselectedindexchanged="DropDownListCap_SelectedIndexChanged" 
            AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <asp:DropDownList ID="DropDownListTruong" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownListTruong_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnDownload" runat="server" Text="Download" 
            onclick="btnDownload_Click" />
    </div>
    <p>
        <asp:Label ID="lblFileName" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
