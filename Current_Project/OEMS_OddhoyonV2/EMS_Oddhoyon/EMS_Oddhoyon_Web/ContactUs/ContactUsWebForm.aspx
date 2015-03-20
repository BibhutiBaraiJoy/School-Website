<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ContactUsWebForm.aspx.cs" Inherits="ProjectSOS.ContactUs.ContactUsWebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<style>
      #map-canvas {
        width: 800px;
        height: 400px;
      }
    </style>
    <script src="https://maps.googleapis.com/maps/api/js"></script>
    <script>
        function initialize() {
            var mapCanvas = document.getElementById('map-canvas');
            var mapOptions = {
                center: new google.maps.LatLng(44.5403, -78.5463),
                zoom: 8,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            }
            var map = new google.maps.Map(mapCanvas, mapOptions)
        }
        google.maps.event.addDomListener(window, 'load', initialize);
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="section-heading text-highlight">
        <span class="line">Contuct Us</span>
    </h1>
    <article class="contact-form col-md-8 col-sm-7  page-row">
        <h3 class="title">
            Get in touch</h3>
        <p>
            We’d love to hear from you. Lorem ipsum dolor sit amet, consectetur adipiscing elit.
            Nullam ut erat magna. Aliquam porta sem a lacus imperdiet posuere. Integer semper
            eget ligula id eleifend.
        </p>
        <form>
        <div class="form-group name">
            <label for="name">
                Name</label>
            <input id="name" type="text" class="form-control" placeholder="Enter your name">
        </div>
        <!--//form-group-->
        <div class="form-group email">
            <label for="email">
                Email<span class="required">*</span></label>
            <input id="email" type="email" class="form-control" placeholder="Enter your email">
        </div>
        <!--//form-group-->
        <div class="form-group phone">
            <label for="phone">
                Phone</label>
            <input id="phone" type="tel" class="form-control" placeholder="Enter your contact number">
        </div>
        <!--//form-group-->
        <div class="form-group message">
            <label for="message">
                Message<span class="required">*</span></label>
            <textarea id="message" class="form-control" rows="6" placeholder="Enter your message here..."></textarea>
        </div>
        <!--//form-group-->
        <button type="submit" class="btn btn-theme">
            Send message</button>
        </form>
    </article>
    <!--//contact-form-->
    <aside class="page-sidebar  col-md-3 col-md-offset-1 col-sm-4 col-sm-offset-1">
        <section class="widget has-divider">
            <h3 class="title">
                Download Prospectus</h3>
            <p>
                Donec pulvinar arcu lacus, vel aliquam libero scelerisque a. Cras mi tellus, vulputate
                eu eleifend at, consectetur fringilla lacus. Nulla ut purus.</p>
            <a class="btn btn-theme" href="#"><i class="fa fa-download"></i>Download now</a>
        </section>
        <!--//widget-->
        <section class="widget has-divider">
            <h3 class="title">
                Postal Address</h3>
            <p class="adr">
                <span class="adr-group"><span class="street-address">Barisal Model School and College</span><br>
                    <span class="region">Raja Bahadur Sarak</span><br>
                    <span class="region">Bangabandhu Uddan</span><br>
                    <span class="postal-code">Barisal</span><br>
                    <span class="country-name">Bangladesh</span> </span>
            </p>
        </section>
        <!--//widget-->
        <section class="widget">
            <h3 class="title">
                All Enquiries</h3>
            <p class="tel">
                <i class="fa fa-phone"></i>Tel: 0431-2176233</p>
            <p class="email">
                <i class="fa fa-envelope"></i>Email: <a href="#">bmscbarisal@yahoo.com</a></p>
        </section>
    </aside>
    <article class="contact-form col-md-12 col-sm-12  page-row">
    <div class="page-row">
        <article class="map-section">
            <h3 class="title">
                How to find us</h3>
            <div class="row">
            <div id="map-canvas" style="width:100%;margin-bottom:20px;margin-left:15px;" class="col-md-12 col-sm-12">
            </div>
            </div>
            <!--//map-->
        </article><!--//map-->
        </div>
        </article>
           <script type="text/javascript" src="<%=ResolveUrl("~/assets/plugins/jquery-1.10.2.min.js")%>"></script>
<%--<script type="text/javascript" src="<%=ResolveUrl("~/assets/js/map.js")%>"></script>--%>
        <script src="../assets/plugins/gmaps/gmaps.js" type="text/javascript"></script>
        <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=true"></script>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7/jquery.min.js"></script>
<script type="text/javascript" src="../assets/plugins/jquery.ui.map.js"></script>
<script type="text/javascript" src="../assets/plugins/jquery.ui.map.extensions.js"></script>
    <script src="../Scripts/gmaps.js" type="text/javascript"></script>

<script type="text/javascript">
    new GMaps({
        div: '#map_canvas',
        lat: 23.740651,
        lng: 90.378421
    });
//    $('#map_canvas').gmap({ 'center': '23.740651,90.378421' });
    </script>


</asp:Content>
