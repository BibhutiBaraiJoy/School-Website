<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExtraCurricularActivitiesWebForm.aspx.cs" Inherits="EMS_Oddhoyon_Web.Curriculum.ExtraCurricularActivitiesWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<style type="text/css">

ul.no_bullet {
list-style-type: none;
padding: 0;
margin: 0;
}
li.leaf {
background: url('../assets/images/leaf_bullet.gif') no-repeat left top;
height: 30px;
padding-left: 44px;
padding-top: 3px;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h1 class="section-heading text-highlight">
	<span class="line">Extra Curricular Activities</span>
	</h1>
    <div class="section-content">  
		<div class="entry-content">
		<ul class="no_bullet">
            <li class="leaf" style="text-align: justify;">Annual Sports</li>
            <li class="leaf" style="text-align: justify;">Picnic</li>
            <li class="leaf" style="text-align: justify;">Study Tour</li>
            <li class="leaf" style="text-align: justify;">Annual Cultural Program</li>
            <li class="leaf" style="text-align: justify;">Pohela Baisakh Celebration</li>
            <li class="leaf" style="text-align: justify;">Observing all National Programs</li>
            <li class="leaf" style="text-align: justify;">Debate Program and Quiz Competition</li>
            <li class="leaf" style="text-align: justify;">Club Scouting</li>
            <li class="leaf" style="text-align: justify;">Inter Class Football and Cricket Tournament</li>
            <li class="leaf" style="text-align: justify;">Art and Music Competition</li>
            <li class="leaf" style="text-align: justify;">Training Activities of Band Group</li>
          </ul>
		</div><!-- .entry-content -->
   </div><!--//page-row-->	
</asp:Content>
