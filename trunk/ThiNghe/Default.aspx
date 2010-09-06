<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxDataView" tagprefix="dxdv" %>

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
        CssPostfix="Aqua" DataSourceID="SqlDataSource1" KeyFieldName="MaThiSinh">
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
            <dxwgv:GridViewDataTextColumn FieldName="MaThiSinh" VisibleIndex="0" 
                ReadOnly="True">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="MaKyThi" VisibleIndex="1">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="MaTruong" VisibleIndex="2">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="MaMonThi" VisibleIndex="3">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="Ho" VisibleIndex="4">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="Ten" VisibleIndex="5">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="NgaySinh" VisibleIndex="6">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="NoiSinh" VisibleIndex="7">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="Lop" VisibleIndex="8">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="SBD" VisibleIndex="9">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="PhongThi" VisibleIndex="10">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="MaPhach" VisibleIndex="11">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="MaHoiDong" VisibleIndex="12">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="DiemLT" VisibleIndex="13">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="DiemTH" VisibleIndex="14">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="TongDiem" VisibleIndex="15">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="XepLoai" VisibleIndex="16">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="NguoiTao" VisibleIndex="17">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataDateColumn FieldName="NgayTao" VisibleIndex="18">
            </dxwgv:GridViewDataDateColumn>
            <dxwgv:GridViewDataTextColumn FieldName="ThuKy1" VisibleIndex="19">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="ThuKy2" VisibleIndex="20">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="ThuKy3" VisibleIndex="21">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="NguoiCapNhat" VisibleIndex="22">
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataDateColumn FieldName="NgayCapNhat" VisibleIndex="23">
            </dxwgv:GridViewDataDateColumn>
            <dxwgv:GridViewDataCheckColumn FieldName="DaXoa" VisibleIndex="24">
            </dxwgv:GridViewDataCheckColumn>
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [ThiSinh]"></asp:SqlDataSource>
    </form>
</body>
</html>
