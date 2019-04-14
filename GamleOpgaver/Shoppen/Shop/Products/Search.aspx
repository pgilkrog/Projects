<%@ Page Language="C#" MasterPageFile="~/Masterpages/FrontEnd.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    Søg efter: <asp:TextBox ID="tbName" runat="server"></asp:TextBox><br />
  <br />

    <asp:Button ID="btnSearch" runat="server" Text="Button" 
    onclick="btnSearch_Click" />
</asp:Content>

