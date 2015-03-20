<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ViewEmployeeWebForm.aspx.cs" Inherits="EMS_Oddhoyon_Web.Employee.ViewEmployeeWebForm" %>

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
        <div class="row">
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
                    <ItemTemplate>
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
            </div>
        </div>
    </div>
    <!--//page-row-->
</asp:Content>
