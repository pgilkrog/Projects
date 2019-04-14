<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ugenstilbud.aspx.cs" Inherits="Ugenstilbud" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="tilbud">
    <a href="avis.aspx">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Billeder/avislille.jpg" /></a>
</div>

<div class="tekstbox">
<h1>Ugens tilbud</h1>
<h3>Se alle de varer som er på tilbud i denne uge<br />klik på billdet for at gøre det større.</h3></div>

</asp:Content>

