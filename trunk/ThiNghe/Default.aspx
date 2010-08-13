<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
        AutoGenerateColumns="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
        CssPostfix="Aqua" DataSourceID="AccessDataSource1">
        <Styles CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua">
        </Styles>
        <SettingsLoadingPanel Text="" />
        <SettingsPager>
            <AllButton>
                <Image Height="19px" Width="27px" />
            </AllButton>
            <FirstPageButton>
                <Image Height="19px" Width="23px" />
            </FirstPageButton>
            <LastPageButton>
                <Image Height="19px" Width="23px" />
            </LastPageButton>
            <NextPageButton>
                <Image Height="19px" Width="19px" />
            </NextPageButton>
            <PrevPageButton>
                <Image Height="19px" Width="19px" />
            </PrevPageButton>
        </SettingsPager>
        <Images ImageFolder="~/App_Themes/Aqua/{0}/">
            <CollapsedButton Height="15px" 
                Url="~/App_Themes/Aqua/GridView/gvCollapsedButton.png" Width="15px" />
            <ExpandedButton Height="15px" 
                Url="~/App_Themes/Aqua/GridView/gvExpandedButton.png" Width="15px" />
            <DetailCollapsedButton Height="15px" 
                Url="~/App_Themes/Aqua/GridView/gvDetailCollapsedButton.png" Width="15px" />
            <DetailExpandedButton Height="15px" 
                Url="~/App_Themes/Aqua/GridView/gvDetailExpandedButton.png" Width="15px" />
            <HeaderFilter Height="19px" Url="~/App_Themes/Aqua/GridView/gvHeaderFilter.png" 
                Width="19px" />
            <HeaderActiveFilter Height="19px" 
                Url="~/App_Themes/Aqua/GridView/gvHeaderFilterActive.png" Width="19px" />
            <HeaderSortDown Height="5px" 
                Url="~/App_Themes/Aqua/GridView/gvHeaderSortDown.png" Width="7px" />
            <HeaderSortUp Height="5px" Url="~/App_Themes/Aqua/GridView/gvHeaderSortUp.png" 
                Width="7px" />
            <FilterRowButton Height="13px" Width="13px" />
            <WindowResizer Height="13px" Url="~/App_Themes/Aqua/GridView/WindowResizer.png" 
                Width="13px" />
        </Images>
        <Columns>
            <dxwgv:GridViewDataTextColumn FieldName="HO" VisibleIndex="0">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="TEN" VisibleIndex="1">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="NGAYSINH" VisibleIndex="2">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="NOISINH" VisibleIndex="3">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="LOP" VisibleIndex="4">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="TENNGHE" VisibleIndex="5">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="TENTRUONG" VisibleIndex="6">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="HUYEN" VisibleIndex="7">
            </dxwgv:GridViewDataTextColumn>
        </Columns>
        <StylesEditors>
            <ProgressBar Height="25px">
            </ProgressBar>
        </StylesEditors>
        <ImagesEditors>
            <CalendarFastNavPrevYear Height="19px" 
                Url="~/App_Themes/Aqua/Editors/edtCalendarFNPrevYear.png" Width="19px" />
            <CalendarFastNavNextYear Height="19px" 
                Url="~/App_Themes/Aqua/Editors/edtCalendarFNNextYear.png" Width="19px" />
            <DropDownEditDropDown Height="7px" 
                Url="~/App_Themes/Aqua/Editors/edtDropDown.png" 
                UrlDisabled="~/App_Themes/Aqua/Editors/edtDropDownDisabled.png" 
                UrlHottracked="~/App_Themes/Aqua/Editors/edtDropDownHottracked.png" 
                Width="9px" />
            <SpinEditIncrement Height="7px" 
                Url="~/App_Themes/Aqua/Editors/edtSpinEditIncrementImage.png" 
                UrlDisabled="~/App_Themes/Aqua/Editors/edtSpinEditIncrementDisabledImage.png" 
                UrlHottracked="~/App_Themes/Aqua/Editors/edtSpinEditIncrementHottrackedImage.png" 
                UrlPressed="~/App_Themes/Aqua/Editors/edtSpinEditIncrementHottrackedImage.png" 
                Width="7px" />
            <SpinEditDecrement Height="7px" 
                Url="~/App_Themes/Aqua/Editors/edtSpinEditDecrementImage.png" 
                UrlDisabled="~/App_Themes/Aqua/Editors/edtSpinEditDecrementDisabledImage.png" 
                UrlHottracked="~/App_Themes/Aqua/Editors/edtSpinEditDecrementHottrackedImage.png" 
                UrlPressed="~/App_Themes/Aqua/Editors/edtSpinEditDecrementHottrackedImage.png" 
                Width="7px" />
            <SpinEditLargeIncrement Height="9px" 
                Url="~/App_Themes/Aqua/Editors/edtSpinEditLargeIncImage.png" 
                UrlDisabled="~/App_Themes/Aqua/Editors/edtSpinEditLargeIncDisabledImage.png" 
                UrlHottracked="~/App_Themes/Aqua/Editors/edtSpinEditLargeIncHottrackedImage.png" 
                UrlPressed="~/App_Themes/Aqua/Editors/edtSpinEditLargeIncHottrackedImage.png" 
                Width="7px" />
            <SpinEditLargeDecrement Height="9px" 
                Url="~/App_Themes/Aqua/Editors/edtSpinEditLargeDecImage.png" 
                UrlDisabled="~/App_Themes/Aqua/Editors/edtSpinEditLargeDecDisabledImage.png" 
                UrlHottracked="~/App_Themes/Aqua/Editors/edtSpinEditLargeDecHottrackedImage.png" 
                UrlPressed="~/App_Themes/Aqua/Editors/edtSpinEditLargeDecHottrackedImage.png" 
                Width="7px" />
        </ImagesEditors>
    </dxwgv:ASPxGridView>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/App_Data/DataTHPT00.mdb" SelectCommand="SELECT        DS_THISINH.HO, DS_THISINH.TEN, DS_THISINH.NGAYSINH, DS_THISINH.NOISINH, DS_THISINH.LOP, DS_NGHE.TENNGHE, DS_TRUONG.TENTRUONG, 
                         DS_THISINH.HUYEN
FROM            ((DS_THISINH INNER JOIN
                         DS_TRUONG ON DS_THISINH.MATRUONG = DS_TRUONG.MATRUONG) INNER JOIN
                         DS_NGHE ON DS_THISINH.MANGHE = DS_NGHE.MANGHE)
ORDER BY DS_THISINH.HUYEN, DS_NGHE.TENNGHE, DS_TRUONG.TENTRUONG">
    </asp:AccessDataSource>
    
    
    
    
    <script type="text/javascript">
    var macAddress = "";
    var ipAddress = "";
    var computerName = "";
    var wmi = GetObject("winmgmts:{impersonationLevel=impersonate}");
    e = new Enumerator(wmi.ExecQuery("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True"));
    for(; !e.atEnd(); e.moveNext()) {
        var s = e.item(); 
        macAddress = s.MACAddress;
        ipAddress = s.IPAddress(0);
        computerName = s.DNSHostName;
    } 
</script>

Instead of Win32_Processor, here we'll access Win32_NetworkAdapterConfiguration to read network related details like the MAC Address, IP Address and the computer name.

Then we can simply use textboxes to display that information or whatever you like.

<input type="text" id="txtMACAdress" />
<input type="text" id="txtIPAdress" />
<input type="text" id="txtComputerName" />

<script type="text/javascript">
    document.getElementById("txtMACAdress").value = unescape(macAddress);
    document.getElementById("txtIPAdress").value = unescape(ipAddress);
    document.getElementById("txtComputerName").value = unescape(computerName);
</script>
    </form>
</body>
</html>
