<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Admin_DropDownSearch_Delete" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="DropDownID" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:BoundField DataField="DropDownID" HeaderText="DropDownID" 
                InsertVisible="False" ReadOnly="True" SortExpression="DropDownID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        </Columns>
    </asp:GridView>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DeleteMethod="DeleteDropDown" SelectMethod="GetDropDown" TypeName="DropDownBLL">
        <DeleteParameters>
            <asp:Parameter Name="DropDownID" Type="Int32" />
        </DeleteParameters>
    </asp:ObjectDataSource>

</asp:Content>

