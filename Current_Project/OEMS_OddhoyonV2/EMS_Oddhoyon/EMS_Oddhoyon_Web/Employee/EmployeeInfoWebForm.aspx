<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeInfoWebForm.aspx.cs" Inherits="EMS_Oddhoyon_Web.Employee.EmployeeInfoWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        table tr td, th
        {
            text-align: center;
            padding: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="section-heading text-highlight">
        <span class="line">Employee Information</span>
    </h1>
    <div class="section-content">

        <%--<div class="row">
            <div class="col-md-9">
                <asp:ListView ID="empListView" runat="server">
                    <LayoutTemplate>
                    
                        <table>
                            <tr style="background-color: #E5E5FE">
                                <th>
                                    <asp:LinkButton ID="lnkId" runat="server">Employee Id</asp:LinkButton>
                                </th>
                                <th>
                                    <asp:LinkButton ID="lnkName" runat="server">Employee Name</asp:LinkButton>
                                </th>
                                <th>
                                    <asp:LinkButton ID="lnkType" runat="server">Employee Designation</asp:LinkButton>
                                </th>
                                <th>
                                    <asp:LinkButton ID="LinkButton1" runat="server">Employee Photo</asp:LinkButton>
                                </th>
                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </LayoutTemplate>
                    <%-- <ItemTemplate>
                        <asp:Image ID="empImage" runat="server" />
                    </ItemTemplate>--%>
              <%--      <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label ID="lblempID" Text='<%#Eval("EmployeeBasicInfo_EmployeeID") %>' runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblempName" Text='<%#Eval("EmployeeBasicInfo_Name") %>' runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblempDesignation" Text='<%#Eval("Designation_Name") %>' runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:Image ID="empImage" runat="server" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </div>--%>
<%--        </div>--%>
       <div class="row page-row">
         <div class="team-wrapper col-md-8 col-sm-7">
               // <div class="row page-row" style=" margin-bottom:20px;">
                    //<figure class="thumb col-md-3 col-sm-4 col-xs-6">
                        <img class="img-responsive" src="../assets/images/team/team-1.jpg" alt="" />
                   // </figure>
                   // <div class="details col-md-9 col-sm-8 col-xs-6">
                        <h3 class="title">
                            Dr. Dan Scarsbrook</h3>
                        <h4>
                            Principle</h4>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam, tellus
                            id pellentesque viverra, metus lacus lobortis augue, sed malesuada urna sapien id
                            orci. Maecenas pharetra mauris quis tincidunt egestas. Sed condimentum felis quis
                            nulla varius. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam diam
                            diam, porttitor quis mollis non, suscipit id tellus. Nullam a ultrices sem, vel
                            tincidunt felis. Sed eu suscipit erat. Nam malesuada, leo porta rhoncus blandit,
                            ipsum tellus fringilla mi, ac pretium nisl turpis sit amet purus. Mauris pellentesque
                            tincidunt lacus commodo lobortis. Nulla consectetur scelerisque molestie.</p>
                   // </div>
               // </div>
            </div>
        </div>
    </div>
    <!--//page-row-->

</asp:Content>
