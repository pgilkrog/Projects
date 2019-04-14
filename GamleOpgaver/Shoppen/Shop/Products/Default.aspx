<%@ Page Language="C#" MasterPageFile="~/Masterpages/FrontEnd.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ProductID" DataSourceID="ObjectDataSource1" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
    onrowdatabound="GridView1_RowDataBound">
        <Columns>
            <asp:CommandField ShowSelectButton="True" SelectText="Detail" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" 
                SortExpression="Description" />
            <asp:ImageField DataImageUrlField="Image" 
                DataImageUrlFormatString="~/Images/Products\\{0}">
            </asp:ImageField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetProducts" TypeName="ProductsBLL"></asp:ObjectDataSource>
    </asp:Content>

