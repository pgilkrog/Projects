<%@ Page Language="C#" MasterPageFile="~/Masterpages/FrontEnd.master" AutoEventWireup="true" CodeFile="ManageAccount.aspx.cs" Inherits="ManageAccount" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Velkommen <asp:LoginName ID="LoginName1" runat="server" />
        <br /><br />

    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
        RepeatDirection="Horizontal" RepeatColumns="1">
        <asp:ListItem>Skift Adgangskode</asp:ListItem>
        <asp:ListItem>Skift Brugernavn</asp:ListItem>
        <asp:ListItem>Skift Email</asp:ListItem>
    </asp:RadioButtonList>
        <br /><br />
 <asp:MultiView ID="MultiView1" runat="server">
<asp:View id="view1" runat="server">
    <asp:ChangePassword ID="ChangePassword1" runat="server">
    </asp:ChangePassword>
</asp:View>

<asp:View ID="view2" runat="server">
    <h2>Skift dit brugernavn</h2>
</asp:View>

<asp:View ID="view3" runat="server">
    <h2>Skift din email addresse</h2>
</asp:View>
</asp:MultiView>
</asp:Content>