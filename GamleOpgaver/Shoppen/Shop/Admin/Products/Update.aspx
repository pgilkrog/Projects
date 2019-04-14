<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Admin_Products_Update" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Panel ID="Panel1" runat="server"> 
       
    <asp:GridView ID="pnlGrid" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" DataKeyNames="ProductID" 
            DataSourceID="ObjectDataSource1" 
            onselectedindexchanged="pnlGrid_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:TemplateField HeaderText="Description" SortExpression="Description">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" 
                        Text='<%# GenerateString(Eval("Description").ToString()) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Description" HeaderText="Description" 
                SortExpression="Description" />
            <asp:BoundField DataField="Price" HeaderText="Price" 
                SortExpression="Price" />
            <asp:ImageField DataImageUrlField="Image" 
                DataImageUrlFormatString="~/Images/Products{0}">
            </asp:ImageField>
        </Columns>
    </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetProducts" TypeName="ProductsBLL"></asp:ObjectDataSource>
    </asp:Panel>      
          
        <asp:Panel ID="pnlDetails" runat="server" Visible="False">
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
                AutoGenerateRows="False" DataKeyNames="ProductID" DefaultMode="Edit"
                DataSourceID="ObjectDataSource2" 
                onitemupdating="DetailsView1_ItemUpdating">
                <Fields>
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                        InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" 
                        SortExpression="Description" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
                    <asp:TemplateField HeaderText="Category" SortExpression="Category">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" 
                                DataSourceID="ObjectDataSource1" DataTextField="Name" 
                                DataValueField="CategoryID">
                                <asp:ListItem Selected="True" Value="0">Change Category</asp:ListItem>
                            </asp:DropDownList>
                            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" 
                                SelectMethod="GetCategory" TypeName="CategoryBLL"></asp:ObjectDataSource>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Category") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                SelectMethod="GetProductsByProductID" TypeName="ProductsBLL" 
                UpdateMethod="UpdateProducts" >
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Description" Type="String" />
                    <asp:Parameter Name="Price" Type="Decimal" />
                    <asp:Parameter Name="Image" Type="String" />
                    <asp:Parameter Name="ProductID" Type="Int32" />
                </UpdateParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="pnlGrid" Name="ProductID" 
                        PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </asp:Panel>
    



</asp:Content>

