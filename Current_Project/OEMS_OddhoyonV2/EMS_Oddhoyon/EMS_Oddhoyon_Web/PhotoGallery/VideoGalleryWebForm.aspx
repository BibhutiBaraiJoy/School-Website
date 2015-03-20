<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="VideoGalleryWebForm.aspx.cs" Inherits="EMS_Oddhoyon_Web.PhotoGallery.VideoGalleryWebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .PagerNormal
        {
            font: 9pt Verdana;
            border: solid 1px #eeeeee;
            padding: 6px 12px;
            text-decoration: none;
            background-color: #eeeeee;
            border-radius: 5px;
        }
        .PagerCurrent
        {
            font: 9pt Verdana;
            border: solid 1px #428bca;
            padding: 6px 12px;
            background-color: #428bca;
            border-radius: 5px;
            color: #ffffff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <h1 class="section-heading text-highlight">
						<span class="line">Gallery of ADDIE Soft Ltd.</span>
						</h1>
            <asp:ListView runat="server" ID="GalleryListView" OnPreRender="GalleryListView_PreRender" DataKeyNames="Gallery_ID">
                <LayoutTemplate>
                    <div class="container" runat="server" id="lstProducts">
                    <%--<h3 class="heading_title">Gallery of ADDIE Soft Ltd.</h3>--%>
                        <div runat="server" id="itemPlaceholder" />
                    </div>
                    <div class="container">
                        <ul class="pagination">
                            <asp:DataPager ID="dpPagination" runat="server" PageSize="6" PagedControlID="GalleryListView">
                                <Fields>
                                    <asp:TemplatePagerField>
                                        <PagerTemplate>
                                            <b>Page
                                                <asp:Label runat="server" ID="CurrentPageLabel" Text="<%# Container.TotalRowCount>0 ? (Container.StartRowIndex / Container.PageSize) + 1 : 0 %>" />
                                                of
                                                <asp:Label runat="server" ID="TotalPagesLabel" Text="<%# Math.Ceiling ((double)Container.TotalRowCount / Container.PageSize) %>" />
                                            </b>
                                        </PagerTemplate>
                                    </asp:TemplatePagerField>
                                    <asp:NumericPagerField CurrentPageLabelCssClass="PagerCurrent" NumericButtonCssClass="PagerNormal" />
                                </Fields>
                            </asp:DataPager>
                        </ul>
                    </div>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
            <div class="col-md-6 col-sm-12" id="VedioType" runat="server" visible='<%# (string)Eval("Gallery_Type")=="video" %>'>
                <object width="100%" height="350">
                    <param name="movie" value='<%# DataBinder.Eval(Container.DataItem, "Video_Path") %>' />
                    <embed src='<%# DataBinder.Eval(Container.DataItem, "Video_Path") %>?rel=0'
                        type="application/x-shockwave-flash" width="100%" height="350" />
                </object>
            </div>
            <div class="col-md-6 col-sm-12" id="PhotoType" runat="server" visible='<%# (string)Eval("Gallery_Type")=="Photo" %>'>
                    <asp:Image ID="GalleryPhoto" runat="server" CssClass="img-responsive img-rounded img-thumbnail" ImageUrl='<%# "~/gallery/" + Eval("Photo_Path") %>' />
            </div>
        </ItemTemplate>
            </asp:ListView>

</asp:Content>
