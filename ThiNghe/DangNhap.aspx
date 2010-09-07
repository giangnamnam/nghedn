<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DangNhap.aspx.cs" Inherits="DangNhap" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .btn
        {
            background-position: center center;
            border: 1px solid #82A2CA;
            float: left;
            height: 20px;
            background-image: url('img/edtButtonBack.gif');
            color: #253A54;
        }
    </style>
</head>
<body style="margin: 0; padding: 0; color: #2B4362;">
    <form id="form1" runat="server">
    <div id="header" style="border-color: #80A0C9; width: 100%; background-image: url('img/DialogBackRepeat.gif');
        background-color: #90B0D3; height: 87px;">
        <div style="background-position: right; float: right; border-color: #80A0C9; width: 100%;
            background-image: url('img/DialogBackImage.jpg'); height: 87px; background-repeat: no-repeat;">
        
        <h1 style="line-height:75px; margin:0; margin-left:20px;"> HùngVQ</h1>
        </div>
    </div>
    <center>
        <table style="width: 500px; margin-top: 60px; text-align: left">
            <tr>
                <td rowspan="6" width="80px" valign="top">
                    <img alt="" src="img/lock.png" style="width: 72px; height: 72px; padding-top: 10px;" />
                </td>
                <td colspan="2" style="color: #666666">
                    Chào bạn, xin vui lòng điền thông tin tài khoản đăng nhập.
                </td>
            </tr>
            <tr>
                <td>
                    Tài khoản
                </td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="txt" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                        ErrorMessage="Xin vui lòng nhập tài khoản">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Mật khẩu
                </td>
                <td>
                    <asp:TextBox ID="txtPass" runat="server" CssClass="txt" Width="300px" 
                        TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass"
                        ErrorMessage="Xin vui lòng nhập mật khẩu">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >
                    
                </td>
                <td >
                    <asp:Button ID="btnDangNhap" runat="server" CssClass="btn" Text="Đăng nhập" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                        ForeColor="Maroon" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="color: #333333">
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </td>
            </tr>
        </table>
    </center>
    </form>
</body>
</html>
