<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Admin_Categories_Update" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel1" runat="server"> 
       
    <asp:GridView ID="pnlGrid" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" DataKeyNames="CategoryID" 
            DataSourceID="ObjectDataSource1" 
            onselectedindexchanged="pnlGrid_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" 
                InsertVisible="False" ReadOnly="True" SortExpression="CategoryID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        </Columns>
    </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetCategory" TypeName="CategoryBLL" 
            OldValuesParameterFormatString="original_{0}">
        </asp:ObjectDataSource>
        <br />
        <asp:Label ID="lblUpdate" runat="server"></asp:Label>
    </asp:Panel>      
          
        <asp:Panel ID="pnlDetails" runat="server" Visible="False">
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
                AutoGenerateRows="False" DataKeyNames="CategoryID" DefaultMode="Edit"
                DataSourceID="ObjectDataSource2" onitemupdated="DetailsView1_ItemUpdated" >
                <FooterTemplate>
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </FooterTemplate>
                <Fields>
                    <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" 
                        InsertVisible="False" ReadOnly="True" SortExpression="CategoryID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:CommandField ShowEditButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                SelectMethod="GetCategoryByCategory" TypeName="CategoryBLL" 
                UpdateMethod="UpdateCategory" InsertMethod="InsertCategory" 
                OldValuesParameterFormatString="original_{0}">
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Original_CategoryID" Type="Int32" />
                </UpdateParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="pnlGrid" Name="CategoryID" 
                        PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </asp:Panel>
    </asp:Content>

