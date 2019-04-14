<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Shop.aspx.cs" Inherits="Shop" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="shopbillede">
        <a runat="server" href="Shop/shopforside.aspx">
        <asp:Image ID="Image1" runat="server" 
        ImageUrl="~/Billeder/shopbillede.jpg" /></a></div>
</asp:Content>

