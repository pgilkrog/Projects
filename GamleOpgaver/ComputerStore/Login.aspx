<%@ Page Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="GrayContent">
    <div class="PageMenu"><h2>Login</h2></div>
</div>
<div class="PageContent">
    <asp:Login ID="Login1" runat="server" 
    DestinationPageUrl="~/Login/ManageAccount.aspx" >
    </asp:Login><br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login/ForgotPassword.aspx">Glemt dit kodeord?</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Login/CreateUser.aspx">Opret en bruger!</asp:HyperLink>
</div>
</asp:Content>

