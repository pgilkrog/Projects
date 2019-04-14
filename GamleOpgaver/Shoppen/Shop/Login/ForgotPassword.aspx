<%@ Page Language="C#" MasterPageFile="~/Masterpages/FrontEnd.master" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="ForgotPassword" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
        <MailDefinition From="noreply@mail.com" IsBodyHtml="True" Priority="High" 
            Subject="Dit nye, midlertidige password">
        </MailDefinition>
    </asp:PasswordRecovery>

</asp:Content>

