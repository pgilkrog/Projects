<%@ Page Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products_Products" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="GrayContent">
<div class="PageMenu">
    <h2>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="CategoryID" 
        DataSourceID="ObjectDataSource2">
        <ItemTemplate>
            <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
        </ItemTemplate>
    </asp:DataList></h2>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
        SelectMethod="GetCategoryByCategory" TypeName="CategoryBLL">
        <SelectParameters>
            <asp:QueryStringParameter Name="CategoryID" QueryStringField="cat" 
                Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</div></div>
<div style="float: left; margin-top: -23px;">
    <asp:GridView ID="GridView1" runat="server" 
    DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" 
    DataKeyNames="ProductID" CellPadding="4" ForeColor="#333333" GridLines="None" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" AllowPaging="True" 
        PageIndex="8" Width="556px" PageSize="8">
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <Columns>
            <asp:ImageField DataImageUrlField="Image" 
                DataImageUrlFormatString="~/Images/Products\\{0}">
            </asp:ImageField>
            <asp:TemplateField>
                <ItemTemplate>
                    <b><asp:Label ID="Label2" runat="server" Text='<%# Eval("Name") %>'></asp:Label></b><br />
                    <asp:Label ID="Label1" runat="server" Text='<%# GenerateString(Eval("Description").ToString()) %>'></asp:Label>...
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Price", "{0:##0.00}") %>'></asp:Label><br />DKK
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" 
                        PostBackUrl='<%# Eval("ProductID", "~/Products/ProductDetail.aspx?ProductID={0}") %>' ImageUrl="~/Images/MereInfo.png" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                InsertVisible="False" ReadOnly="True" SortExpression="ProductID" 
                Visible="False" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" 
                Visible="False" />
            <asp:BoundField DataField="Description" HeaderText="Description" 
                SortExpression="Description" Visible="False" />
            <asp:BoundField DataField="Facts" HeaderText="Facts" SortExpression="Facts" 
                Visible="False" />
            <asp:BoundField DataField="Rating" HeaderText="Rating" 
                SortExpression="Rating" Visible="False" />
            <asp:BoundField DataField="Category" HeaderText="Category" ReadOnly="True" 
                SortExpression="Category" Visible="False" />
        </Columns>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetProductsByCategory" TypeName="ProductsBLL">
        <SelectParameters>
            <asp:QueryStringParameter Name="CategoryID" QueryStringField="cat" 
                Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</div>
</asp:Content>

