<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Admin_Delete" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="ProductID" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" 
                SortExpression="Description" />
            <asp:BoundField DataField="Facts" HeaderText="Facts" SortExpression="Facts" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:ImageField DataImageUrlField="Image" DataImageUrlFormatString="~/Images/Products\\{0}">
            </asp:ImageField>
            <asp:BoundField DataField="Rating" HeaderText="Rating" 
                SortExpression="Rating" />
            <asp:BoundField DataField="Category" HeaderText="Category" ReadOnly="True" 
                SortExpression="Category" />
        </Columns>
    </asp:GridView>

<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    DeleteMethod="DeleteProducts" OldValuesParameterFormatString="original_{0}" 
    SelectMethod="GetProducts" TypeName="ProductsBLL">
    <DeleteParameters>
        <asp:Parameter Name="Original_ProductID" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>

</asp:Content>

