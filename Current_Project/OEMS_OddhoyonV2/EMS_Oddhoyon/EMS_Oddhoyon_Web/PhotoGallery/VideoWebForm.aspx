<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VideoWebForm.aspx.cs" Inherits="EMS_Oddhoyon_Web.PhotoGallery.VedioWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <h1 class="section-heading text-highlight">
						<span class="line">Video</span>
						</h1>
                        <div class="row">
                        <div class="section-content">
                        
                          <section class="video" >
                        <div class="carousel-controls">
                            <a class="prev" href="#videos-carousel" data-slide="prev"><i class="fa fa-caret-left"></i></a>
                            <a class="next" href="#videos-carousel" data-slide="next"><i class="fa fa-caret-right"></i></a>
                        </div><!--//carousel-controls-->
                        <div class="section-content">    
                           <div id="videos-carousel" class="videos-carousel carousel slide">
                                <div class="carousel-inner">
                                    <div class="item active" style="min-height:500px;">            
                                        <iframe style="min-height:500px;" class="video-iframe" src="//www.youtube.com/embed/KM4Xe6Dlp0Y?rel=0&amp;wmode=transparent" frameborder="0" allowfullscreen=""></iframe>
                                    </div><!--//item-->
                                    <div class="item" style="min-height:500px;">            
                                        <iframe style="min-height:500px;" class="video-iframe" src="//www.youtube.com/embed/RcGyVTAoXEU?rel=0&amp;wmode=transparent" frameborder="0" allowfullscreen=""></iframe>
                                    </div><!--//item-->
                                    <div class="item" style="min-height:500px;">            
                                        <iframe style="min-height:500px;" class="video-iframe" src="//www.youtube.com/embed/Ks-_Mh1QhMc?rel=0&amp;wmode=transparent" frameborder="0" allowfullscreen=""></iframe>
                                    </div><!--//item-->
                                </div><!--//carousel-inner-->
                           </div><!--//videos-carousel-->                            
                            <p class="description">Aenean feugiat a diam tempus sodales. Quisque lorem nulla, ultrices imperdiet malesuada at, suscipit vel lorem. Nulla dignissim nisi ac aliquet semper.</p>
                        </div><!--//section-content-->
                    </section><!--//video-->

                    </div><!--//page-row-->
                         </div>
          
</asp:Content>
