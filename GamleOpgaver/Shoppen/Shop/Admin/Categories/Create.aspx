<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Admin_Categories_Create" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
        AutoGenerateRows="False" DataKeyNames="CategoryID" 
        DataSourceID="ObjectDataSource1">
        <Fields>
            <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" 
                InsertVisible="False" ReadOnly="True" SortExpression="CategoryID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" 
                SortExpression="Description" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        InsertMethod="InsertCategory" SelectMethod="GetCategory" TypeName="CategoryBLL">
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>

</asp:Content>

