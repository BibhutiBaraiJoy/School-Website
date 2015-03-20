<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowEventsWebForm.aspx.cs" Inherits="EMS_Oddhoyon_Web.Information.ShowEventsWebForm" %>
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
        <span class="line">Events</span>
    </h1>
    <div class="section-content">
        <asp:ListView ItemPlaceholderID="PlaceHolderEvents" runat="server" ID="listviewEvents">
            <LayoutTemplate>
                <asp:PlaceHolder runat="server" ID="PlaceHolderEvents" />
            </LayoutTemplate>
            <ItemTemplate>
            <div class="row page-row">
            <div class="events-wrapper col-md-8 col-sm-7"> 
            <article class="events-item page-row has-divider clearfix">
            <div class="date-label-wrapper col-md-1 col-sm-2">
            <p class="date-label">
                <span class="month"><asp:Label ID="lblEventMonthName"  runat="server"></asp:Label></span>
                <span class="date-number"><asp:Label ID="lblEveentDateName"  runat="server"></asp:Label></span>
            </p>
            </div>
            <div class="details col-md-11 col-sm-10">
            <h3 class="title"><asp:Label ID="lblEventtitle" Text='<%#Eval("Events_Title") %>' runat="server"></asp:Label></h3>
                <p class="time text-muted"><asp:Label ID="LabeStartTime"  runat="server"></asp:Label> - <asp:Label ID="lblendTime" runat="server"></asp:Label><span class="location"><i class="fa fa-map-marker"></i><a href="#"><asp:Label ID="lblCampusName" Text='<%#Eval("Events_Location") %>' runat="server"></asp:Label></a></span></p>     
                <p class="desc"><asp:Label ID="lblEventDesc" Text='<%#Eval("Events_Description") %>' runat="server"></asp:Label></p>                 
            </div><!--//details-->  
            </article> 
            </div>
            </div>
            
            </ItemTemplate>

        </asp:ListView>
        <asp:DataPager ID="DataPagerEvent" runat="server" PagedControlID="listviewEvents"
            PageSize="2" OnPreRender="DataPagerEvents_PreRender">
            <Fields>
                <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowNextPageButton="False" />
                 <asp:NumericPagerField NumericButtonCssClass="numeric_button" CurrentPageLabelCssClass="current_page"
                    NextPreviousButtonCssClass="next_button" />
                <asp:NextPreviousPagerField ShowLastPageButton="True" ShowPreviousPageButton="False" />
            </Fields>
        </asp:DataPager>
    </div>
</asp:Content>
