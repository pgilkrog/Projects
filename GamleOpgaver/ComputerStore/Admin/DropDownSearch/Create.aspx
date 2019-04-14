<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Admin_DropDownSearch_Create" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
    <asp:Button ID="btnCreate" runat="server" Text="Insert" onclick="btnCreate_Click" />
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="DropDownID" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="DropDownID" HeaderText="DropDownID" 
                InsertVisible="False" ReadOnly="True" SortExpression="DropDownID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        </Columns>
    </asp:GridView>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetDropDown" TypeName="DropDownBLL"></asp:ObjectDataSource>

</asp:Content>

