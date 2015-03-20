<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NoticeWebForm.aspx.cs" Inherits="EMS_Oddhoyon_Web.Information.NoticeWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  <style type="text/css">
        .numeric_button
        {
            background-color: #6091BA;
            color: #FFFFFF;
            font-family: Arial;
            font-weight: bold;
            padding: 5px;
            border: none;
            font-size: 12px;
        }
        .current_page
        {
            background-color: #4678A1;
            color: #FFFFFF;
            font-family: Arial;
            font-weight: bold;
            padding: 5px;
            font-size: 12px;
        }
        .next_button
        {
            background-color: #6091BA;
            color: #FFFFFF;
            font-family: Arial;
            font-weight: bold;
            padding: 5px;
            font-size: 12px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="section-heading text-highlight">
        <span class="line">Notice</span>
    </h1>
    <div class="section-content">
        <asp:ListView ItemPlaceholderID="PlaceHolderNotice" runat="server" ID="listviewNotice">
            <LayoutTemplate>
                <asp:PlaceHolder runat="server" ID="PlaceHolderNotice" />
            </LayoutTemplate>
            <ItemTemplate>
            <div class="row page-row">
            <div class="events-wrapper col-md-8 col-sm-7"> 
            <article class="events-item page-row has-divider clearfix">
            <div class="date-label-wrapper col-md-1 col-sm-2">
            <p class="date-label">
                <span class="month"><asp:Label ID="lblNoticeMonthName"  runat="server"></asp:Label></span>
                <span class="date-number"><asp:Label ID="lblNoticeDateName"  runat="server"></asp:Label></span>
            </p>
            </div>
            <div class="details col-md-11 col-sm-10">
            <h3 class="title"><asp:Label ID="lblNoticetitle" Text='<%#Eval("Notice_Title") %>' runat="server"></asp:Label></h3>
                <p class="time text-muted"><asp:Label ID="LabeStartTime"  runat="server"></asp:Label></p>     
                <p class="desc"><asp:Label ID="lblNoticetDesc" Text='<%#Eval("Notice_Description") %>' runat="server"></asp:Label></p>                 
            </div><!--//details-->  
            </article> 
            </div>
            </div>
            
            </ItemTemplate>

        </asp:ListView>
        <asp:DataPager ID="DataPagerNotice" runat="server" PagedControlID="listviewNotice"
            PageSize="2" OnPreRender="DataPagerNotice_PreRender">
            <Fields>
                <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowNextPageButton="False" />
                 <asp:NumericPagerField NumericButtonCssClass="numeric_button" CurrentPageLabelCssClass="current_page"
                    NextPreviousButtonCssClass="next_button" />
                <asp:NextPreviousPagerField ShowLastPageButton="True" ShowPreviousPageButton="False" />
            </Fields>
        </asp:DataPager>
    </div>
</asp:Content>
