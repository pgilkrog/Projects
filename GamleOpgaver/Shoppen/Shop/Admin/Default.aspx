<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 110px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table>
    <tr>
        <td>
            <h2>Products</h2>
        </td>
    </tr>
    <tr>
        <td class="style1">
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/edit.gif" PostBackUrl="~/Admin/Products/Edit.aspx" 
                ToolTip="Edit Products" />
        </td>
        <td class="style1">
            <asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/create.gif" PostBackUrl="~/Admin/Products/Create.aspx" 
                ToolTip="Create New Products" />
        </td>
        <td class="style1">
            <asp:ImageButton ID="ImageButton3" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/delete.gif" PostBackUrl="~/Admin/Products/Delete.aspx" 
                ToolTip="Delete Products" />
        </td>
    </tr>
</table>
</asp:Content>

