<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="SingleNewsWebForm.aspx.cs" Inherits="EMS_Oddhoyon_Web.Information.SingleNewsWebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="section-heading text-highlight">
        <span class="line">News Details</span>
    </h1>
    <div class="section-content">
        <asp:ListView ItemPlaceholderID="PlaceHolderNews" runat="server" ID="listviewNews">
            <LayoutTemplate>
                <asp:PlaceHolder runat="server" ID="PlaceHolderNews" />
            </LayoutTemplate>
            <ItemTemplate>
                <div class="row page-row">
                    <div class="news-wrapper col-md-8 col-sm-7">
                        <p class="featured-image">
                            <asp:Image ID="NewsImage" runat="server" CssClass="img-responsive" AlternateText="News photo" />
                        </p>
                        <article class="news-item page-row has-divider clearfix row">
                      
                               
                        
                            <div class="details col-md-10 col-sm-9 col-xs-8">
                                <%-- <h3 class="title"><a href="news-single.html"><asp:Label ID="lblEmpName" Text='<%#Eval("News_Title") %>' runat="server"></asp:Label></a></h3>--%>
                                <h3 class="title">
                                    <asp:Label ID="lblEmpNamew" Text='<%#Eval("News_Title") %>' runat="server"></asp:Label></h3>
                                <%-- <p><asp:Label ID="lblDesignation" Text='<%#Eval("News_Description") %>' runat="server"></asp:Label></p>--%>
                                <asp:Label ID="lblDesignation" Text='<%#Eval("News_Description") %>' runat="server"></asp:Label>
                            </div>
                        </article>
                    </div>
                </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
</asp:Content>
