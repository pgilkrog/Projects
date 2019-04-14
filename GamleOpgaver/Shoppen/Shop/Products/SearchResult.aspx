<%@ Page Language="C#" MasterPageFile="~/Masterpages/FrontEnd.master" AutoEventWireup="true" CodeFile="SearchResult.aspx.cs" Inherits="SearchResult" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="ProductID" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" 
                SortExpression="Description" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:ImageField DataImageUrlField="Image" 
                DataImageUrlFormatString="~/Images/Products\\{0}">
                </asp:ImageField>
            <asp:BoundField DataField="Category" HeaderText="Category" ReadOnly="True" 
                SortExpression="Category" />
        </Columns>
    </asp:GridView>
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetProductBySearch" TypeName="ProductsBLL">
        <SelectParameters>
            <asp:QueryStringParameter Name="Name" QueryStringField="Keyword" 
                Type="String" />
            <asp:QueryStringParameter Name="Description" QueryStringField="Keyword" 
                Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>

