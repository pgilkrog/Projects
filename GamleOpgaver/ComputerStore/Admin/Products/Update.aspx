<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Admin_Products_Update" Title="Computer Store" validateRequest="false" %>

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
                        Text='<%# GenerateString(Eval("Description").ToString()) %>'></asp:Label>...
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Facts" HeaderText="Facts" 
                SortExpression="Facts" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="Rating" HeaderText="Rating" 
                SortExpression="Rating" />
            <asp:BoundField DataField="Category" HeaderText="Category" ReadOnly="True" 
                SortExpression="Category" />
                 <asp:ImageField DataImageUrlField="Image" 
                DataImageUrlFormatString="~/Images/Products{0}">
            </asp:ImageField>
        </Columns>
    </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetProducts" TypeName="ProductsBLL" 
            OldValuesParameterFormatString="original_{0}" UpdateMethod="UpdateProducts">
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="Facts" Type="String" />
                <asp:Parameter Name="Price" Type="Decimal" />
                <asp:Parameter Name="Image" Type="String" />
                <asp:Parameter Name="Rating" Type="Int32" />
                <asp:Parameter Name="ProductID" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:Label ID="lblUpdate" runat="server"></asp:Label>
    </asp:Panel>      
          
        <asp:Panel ID="pnlDetails" runat="server" Visible="False">
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
                AutoGenerateRows="False" DataKeyNames="ProductID" DefaultMode="Edit"
                DataSourceID="ObjectDataSource2" 
                onitemupdating="DetailsView1_ItemUpdating" 
                onitemupdated="DetailsView1_ItemUpdated">
                <FooterTemplate>
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </FooterTemplate>
                <Fields>
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                        InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:TemplateField HeaderText="Description" SortExpression="Description">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Width="500px" Height="300px" Text='<%# Bind("Description") %>' TextMode="MultiLine"></asp:TextBox>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Description") %>'></asp:TextBox>
                        </InsertItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Facts" SortExpression="Facts">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("Facts") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Width="500px" Height="300px" Text='<%# Bind("Facts") %>' TextMode="MultiLine"></asp:TextBox>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Facts") %>'></asp:TextBox>
                        </InsertItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Description" HeaderText="Description" 
                        SortExpression="Description" />
                    <asp:TemplateField HeaderText="Image" SortExpression="Image">
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("Image") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Image ID="imgProduct" runat="server" 
                                ImageUrl='<%# "~/Images/Products/" + Eval("Image") %>' />
                            <br />
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Image") %>'></asp:TextBox>
                        </InsertItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Rating" HeaderText="Rating" 
                        SortExpression="Rating" />
                    <asp:TemplateField HeaderText="Category" SortExpression="Category">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" 
                                DataSourceID="ObjectDataSource3" DataTextField="Name" 
                                DataValueField="CategoryID">
                                <asp:ListItem Selected="True" Value="0">Change Category</asp:ListItem>
                            </asp:DropDownList>
                            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" 
                                SelectMethod="GetCategory" TypeName="CategoryBLL" 
                                InsertMethod="InsertCategory" OldValuesParameterFormatString="original_{0}" 
                                UpdateMethod="UpdateCategories">
                                <UpdateParameters>
                                    <asp:Parameter Name="Name" Type="String" />
                                    <asp:Parameter Name="Description" Type="String" />
                                    <asp:Parameter Name="Original_CategoryID" Type="Int32" />
                                </UpdateParameters>
                                <InsertParameters>
                                    <asp:Parameter Name="Name" Type="String" />
                                    <asp:Parameter Name="Description" Type="String" />
                                </InsertParameters>
                            </asp:ObjectDataSource>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Category") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                SelectMethod="GetProductByProductID" TypeName="ProductsBLL" 
                UpdateMethod="UpdateProducts">
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Description" Type="String" />
                    <asp:Parameter Name="Facts" Type="String" />
                    <asp:Parameter Name="Price" Type="Decimal" />
                    <asp:Parameter Name="Rating" Type="Int32" />
                    <asp:Parameter Name="ProductID" Type="Int32" />
                </UpdateParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="pnlGrid" Name="ProductID" 
                        PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </asp:Panel>

</asp:Content>

