<%@ Page Language="C#" MasterPageFile="~/Masterpages/FrontEnd.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h2>Login</h2>

    <asp:Login ID="Login1" runat="server" 
    DestinationPageUrl="~/Login/ManageAccount.aspx" 
    PasswordRecoveryText="Har du mistet dit password?" 
    PasswordRecoveryUrl="~/Login/ForgotPassword.aspx" CreateUserText="Opret Bruger" 
    CreateUserUrl="~/Login/CreateUser.aspx">
    </asp:Login>

</asp:Content>

