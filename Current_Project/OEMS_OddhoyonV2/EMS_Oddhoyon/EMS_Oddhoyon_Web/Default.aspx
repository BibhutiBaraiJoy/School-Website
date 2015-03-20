<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="EMS_Oddhoyon_Web._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<style type="text/css">
.loginFrame
{
border:none;
width: 400px; 
height: 800px; 
margin-top: -310px;
margin-left: -80px;
}

.logdiv
{
border:none; 
width: 312px;
 height: 220px;
  overflow: hidden;    
}
</style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-9 clearMargin">
        <div id="promo-slider" class="slider flexslider">
            <ul class="slides">
                <li>
                    <img src="assets/images/slides/slide-1.jpg" alt="" />
                </li>
                <li>
                    <img src="assets/images/slides/slide-2.jpg" alt="" />
                </li>
                <li>
                    <img src="assets/images/slides/slide-3.jpg" alt="" />
                </li>
                <li>
                    <img src="assets/images/slides/slide-4.jpg" alt="" />
                </li>
                <li>
                    <img src="assets/images/slides/slide-5.jpg" alt="" />
                </li>
                <li>
                    <img src="assets/images/slides/slide-6.jpg" alt="" />
                </li>
                <li>
                    <img src="assets/images/slides/slide-7.jpg" alt="" />
                </li>
                <li>
                    <img src="assets/images/slides/slide-8.jpg" alt="" />
                </li>
            </ul>
            <!--//slides-->
        </div>
        <div id="PnlAdmission" visible="false" runat="server">
            <section class="promo box box-dark">
                <div class="col-md-9">
                    <h1 class="section-heading">
                        Why College Green</h1>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed bibendum orci eget
                        nulla mattis, quis viverra tellus porta. Donec vitae neque ut velit eleifend commodo.
                        Maecenas turpis odio, placerat eu lorem ut, suscipit commodo augue.
                    </p>
                </div>
                <div class="col-md-3">
                    <a class="btn btn-cta" href="#"><i class="fa fa-play-circle"></i>Apply Now</a>
                </div>
            </section>
        </div>
        <section class="news">
            <h1 class="section-heading text-highlight">
                <span class="line">Latest News</span></h1>
            <div class="carousel-controls">
                <a class="prev" href="#news-carousel" data-slide="prev"><i class="fa fa-caret-left">
                </i></a><a class="next" href="#news-carousel" data-slide="next"><i class="fa fa-caret-right">
                </i></a>
            </div>
            <!--//carousel-controls-->
            <div class="section-content clearfix">
                <div id="news-carousel" class="news-carousel carousel slide">
                    <div id="newsContentDiv" runat="server" class="carousel-inner">
                       
                        <!--//item-->
                    </div>
                    <!--//carousel-inner-->
                </div>
                <!--//news-carousel-->
            </div>
            <!--//section-content-->
        </section><!--//news-->
        <div class="section-content">
            <h1 class="section-heading text-highlight">
                <span class="line">Barisal Model School & College</span>
            </h1>
            <p>
                It is a fact that modern, proper and quality education is essential for the desired
                development and prosperity of a nation. And to ensure this kind of education there
                is a necessity of good and quality educational institutions. But this kind of educational
                institution is small in number in our country. Against this backdrop, Tangail Residential
                School & College has established Tangail Residential School & College in the heart
                of Savar, Dhaka.
            </p>
            <p>
                So far as I know, this institution has been established on the basis of a new idea
                and meticulous planning with a view to meeting the present need and the future demand
                of the nation. I think the main objective of this idea and planning is to materialise
                the commitment of ensuring modern, proper and demand-oriented quality education
                for the nation.
            </p>
            <p>
                Adopting constructive and multi-dimensional programmes to materialize this commitment,
                this modern institute named Tangail Residential School & College has been established.
            </p>
            <p>
                It is my belief, the modernity of this institution will be manifested through the
                creation and maintenance of congenial, excellent and proper academic environment
                suitable for quality education and imparting education utilizing hi-tech modern
                technology and through proper coordination among meritorious and experienced teachers
                and the talented vibrant young students.
            </p>
            <p>
                I believe, possessing this modernism Tangail Residential School & Collegewill bring
                about a radical change in the field of education and will provide the nation citizens
                having all qualities of a proper and perfect human being.
            </p>
            <p>
                I render my cordial thanks to all involved directly or indirectly in the vast activities
                to materialize this great objective of Tangail Residential School & College. It
                is my deep expectation that the initiative, efforts and all kinds of cooperation
                of all concerned will help this college reach the peak of success and glory and
                will thus earn the distinction of becoming the most modern educational institution
                of international standard.
            </p>
            <a class="read-more" href="courses.html">read more<i class="fa fa-chevron-right"></i></a>
        </div>
    </div>
    <div class="col-md-3" style="padding-right: 0px;">
        <section class="testimonialsC" hidden="hidden">
            <h1 class="section-heading text-highlight">
                <span class="line">Chairman's Corner</span>
            </h1>
            <div class="section-content">
                <div id="testimonialsC-carousel" class="testimonialsC-carousel carousel slide">
                    <div class="carousel-inner">
                        <img class="profile col-md-9" src="assets/images/testimonials/chariman.png" alt="" />
                        <p class="people col-md-9 col-sm-3 col-xs-9">
                            <span class="people cusTitle">Name of the Chairman</span><br />
                        </p>
                        <p class="people col-md-8 col-sm-3 col-xs-8">
                            <a href="#">Message</a>
                        </p>
                    </div>
                </div>
            </div>
        </section>
       <section class="links">
            <h1 class="section-heading text-highlight">
                <span class="line">OEMS Login</span></h1>
            <div id="Div1"  runat="server" class="section-content logdiv">
             <iframe class="loginFrame"  src="http://bmsc.oemsbd.com/" ></iframe> 
            </div>
            <!--//section-content-->
        </section>
        <section class="links">
            <h1 class="section-heading text-highlight">
                <span class="line">Quick Links</span></h1>
            <div id="QuickLinksDiv" runat="server" class="section-content">
            </div>
            <!--//section-content-->
        </section>
        <section class="events">
            <h1 class="section-heading text-highlight">
                <span class="line">Events</span></h1>
            <div id="eventsDiv" runat="server" class="section-content">
            </div>
            <!--//section-content-->
        </section>
        <!--//events-->
    </div>
    <!--//section-content-->
</asp:Content>
