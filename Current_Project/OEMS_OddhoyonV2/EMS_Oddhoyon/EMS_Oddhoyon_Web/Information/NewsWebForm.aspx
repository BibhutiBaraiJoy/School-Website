<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewsWebForm.aspx.cs" Inherits="EMS_Oddhoyon_Web.Information.NewsWebForm" %>
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
        <span class="line">News</span>
    </h1>
    <div class="section-content">
        <asp:ListView ItemPlaceholderID="PlaceHolderNews" runat="server" ID="listviewNews">
            <LayoutTemplate>
                <asp:PlaceHolder runat="server" ID="PlaceHolderNews" />
            </LayoutTemplate>
            <ItemTemplate>
                <div class="row page-row">
                  <div class="news-wrapper col-md-8 col-sm-7"> 
                         <article class="news-item page-row has-divider clearfix row">       
                                <figure class="thumb col-md-2 col-sm-3 col-xs-4">
                                    <asp:Image ID="NewsImage" runat="server" CssClass="img-responsive" AlternateText="News photo" />
                                </figure>
                                <div class="details col-md-10 col-sm-9 col-xs-8">
                                   <%-- <h3 class="title"><a href="news-single.html"><asp:Label ID="lblEmpName" Text='<%#Eval("News_Title") %>' runat="server"></asp:Label></a></h3>--%>
                                   <h3 class="title"><asp:Label ID="lblEmpName" Text='<%#Eval("News_Title") %>' runat="server"></asp:Label></h3>
                                   <%-- <p><asp:Label ID="lblDesignation" Text='<%#Eval("News_Description") %>' runat="server"></asp:Label></p>--%>
                                   <asp:Label ID="lblDesignation" Text='<%#Eval("News_Description") %>' runat="server"></asp:Label>
                                   
                                  
                                </div>
                            </article>
                        </div>
                    </div>
            </ItemTemplate>
        </asp:ListView>
        <asp:DataPager ID="DataPagerNews" runat="server" PagedControlID="listviewNews"
            PageSize="3" OnPreRender="DataPagerNews_PreRender">
            <Fields>
                <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowNextPageButton="False" />
                 <asp:NumericPagerField NumericButtonCssClass="numeric_button" CurrentPageLabelCssClass="current_page"
                    NextPreviousButtonCssClass="next_button" />
                <asp:NextPreviousPagerField ShowLastPageButton="True" ShowPreviousPageButton="False" />
            </Fields>
        </asp:DataPager>
    </div>
</asp:Content>
