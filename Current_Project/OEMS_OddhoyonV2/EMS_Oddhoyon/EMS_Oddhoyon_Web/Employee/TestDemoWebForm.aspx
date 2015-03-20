<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="TestDemoWebForm.aspx.cs" Inherits="EMS_Oddhoyon_Web.AboutUs.TestDemoWebForm" %>

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
        <span class="line">Employee List</span>
    </h1>
    <div class="section-content">
        <asp:ListView ItemPlaceholderID="PlaceHolderEmployee" runat="server" ID="listviewEmployee">
            <LayoutTemplate>
                <asp:PlaceHolder runat="server" ID="PlaceHolderEmployee" />
            </LayoutTemplate>
            <ItemTemplate>
                <div class="row page-row">
                    <div class="team-wrapper col-md-8 col-sm-7">
                        <div class="row page-row" style="margin-bottom: 20px;">
                            <figure class="thumb col-md-3 col-sm-4 col-xs-6">
                                <asp:Image ID="empImage" runat="server" CssClass="img-responsive" AlternateText="Employee photo" />
                            </figure>
                            <div class="details col-md-9 col-sm-8 col-xs-6">
                                <h3 class="title">
                                    <asp:Label ID="lblEmpName" Text='<%#Eval("EmployeeBasicInfo_Name") %>' runat="server"></asp:Label></h3>
                                <h4>
                                    <asp:Label ID="lblDesignation" Text='<%#Eval("Designation_Name") %>' runat="server"></asp:Label></h4>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam, tellus
                                    id pellentesque viverra, metus lacus lobortis augue, sed malesuada urna sapien id
                                    orci. Maecenas pharetra mauris quis tincidunt egestas. Sed condimentum felis quis
                                    id pellentesque viverra, metus lacus lobortis augue, sed malesuada urna sapien id
                                    orci. Maecenas pharetra mauris quis tincidunt egestas. Sed condimentum felis quis
                              </p>
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <asp:DataPager ID="DataPagerEmployee" runat="server" PagedControlID="listviewEmployee"
            PageSize="3" OnPreRender="DataPagerEmployee_PreRender">
            <Fields>
                <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowNextPageButton="False" />
                 <asp:NumericPagerField NumericButtonCssClass="numeric_button" CurrentPageLabelCssClass="current_page"
                    NextPreviousButtonCssClass="next_button" />
                <asp:NextPreviousPagerField ShowLastPageButton="True" ShowPreviousPageButton="False" />
            </Fields>
        </asp:DataPager>
    </div>
</asp:Content>
