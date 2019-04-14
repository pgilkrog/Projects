<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Admin_Banner_Create" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    Name:
    <asp:TextBox ID="tbName" runat="server"></asp:TextBox><br />
    Image:
    <asp:FileUpload ID="uplImage" runat="server" /><br />
    <asp:Button ID="btnCreate" runat="server" Text="Insert" onclick="btnCreate_Click" />
    <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
                        


</asp:Content>

