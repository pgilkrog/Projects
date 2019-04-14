<%@ Page Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="ManageAccount.aspx.cs" Inherits="ManageAccount" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="GrayContent">
    <div class="PageMenu"><h2>Manage Account</h2></div>
</div>
        <br /><br />
<div class="PageContent">
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
        RepeatDirection="Horizontal" RepeatColumns="1">
        <asp:ListItem>Skift Adgangskode</asp:ListItem>
        <asp:ListItem>Skift Email</asp:ListItem>
    </asp:RadioButtonList>
        <br /><br />
 <asp:MultiView ID="MultiView1" runat="server">
<asp:View id="view1" runat="server">
    <asp:ChangePassword ID="ChangePassword1" runat="server">
    </asp:ChangePassword>
</asp:View>

<asp:View ID="view3" runat="server">
    <h2>Skift din email addresse</h2>
</asp:View>
</asp:MultiView>
</div>
</asp:Content>