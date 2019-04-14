<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 120px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>Products</h2>
<table>
    <tr>
        <td class="style1">
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/edit.gif" PostBackUrl="~/Admin/Products/Update.aspx" 
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
    <br />
<h2>Categories</h2>
<table>
    <tr>
        <td class="style1">
            <asp:ImageButton ID="ImageButton4" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/edit.gif" PostBackUrl="~/Admin/Categories/Update.aspx" 
                ToolTip="Edit Categories" />
        </td>
        <td class="style1">
            <asp:ImageButton ID="ImageButton5" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/create.gif" PostBackUrl="~/Admin/Categories/Create.aspx" 
                ToolTip="Create New Categories" />
        </td>
        <td class="style1">
            <asp:ImageButton ID="ImageButton6" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/delete.gif" PostBackUrl="~/Admin/Categories/Delete.aspx" 
                ToolTip="Delete Categories" />
        </td>
    </tr>
</table>
    <br />
<h2>Search DropDown</h2>
<table>
    <tr>
        <td class="style1">
            <asp:ImageButton ID="ImageButton8" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/edit.gif" PostBackUrl="~/Admin/DropDownSearch/Edit.aspx" 
                ToolTip="Edit Categories" />
        </td>
        <td class="style1">
            <asp:ImageButton ID="ImageButton9" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/create.gif" PostBackUrl="~/Admin/DropDownSearch/Create.aspx" 
                ToolTip="Create New Categories" />
        </td>
        <td class="style1">
            <asp:ImageButton ID="ImageButton10" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/delete.gif" PostBackUrl="~/Admin/DropDownSearch/Delete.aspx" 
                ToolTip="Delete Categories" />
        </td>
    </tr>
</table>
    <br />
<h2>Forside Banner</h2>
<table>
    <tr>
        <td class="style1">
            <asp:ImageButton ID="ImageButton12" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/create.gif" PostBackUrl="~/Admin/Banner/Create.aspx" />
        </td>
        <td class="style1">
            <asp:ImageButton ID="ImageButton13" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/delete.gif" PostBackUrl="~/Admin/Banner/Delete.aspx" />
        </td>
    </tr>
</table>
    <br />           
    <h2>Contact Info</h2>
<table>
    <tr>
        <td class="style1">
            <asp:ImageButton ID="ImageButton7" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/edit.gif" PostBackUrl="~/Admin/UpdateInfo.aspx" />
        </td>
    </tr>
</table>
    <br />
<h2>Edit SideText</h2>
<table>
    <tr>
        <td class="style1">
            <asp:ImageButton ID="ImageButton11" runat="server" 
                ImageUrl="~/Admin/Image/Buttons/edit.gif" PostBackUrl="~/Admin/EditSideText.aspx" />
        </td>
    </tr>
</table>
</asp:Content>

