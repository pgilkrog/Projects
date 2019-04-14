<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Admin_DropDownSearch_Edit" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel1" runat="server"> 
    <asp:GridView ID="pnlGrid" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" DataKeyNames="DropDownID" 
            DataSourceID="ObjectDataSource1" 
            onselectedindexchanged="pnlGrid_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="DropDownID" HeaderText="DropDownID" 
                InsertVisible="False" ReadOnly="True" SortExpression="DropDownID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        </Columns>
    </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetDropDown" TypeName="DropDownBLL" 
            OldValuesParameterFormatString="original_{0}">
        </asp:ObjectDataSource>
        <br />
        <asp:Label ID="lblUpdate" runat="server"></asp:Label>
    </asp:Panel>      
          
        <asp:Panel ID="pnlDetails" runat="server" Visible="False">
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
                AutoGenerateRows="False" DataKeyNames="DropDownID" DefaultMode="Edit"
                DataSourceID="ObjectDataSource2" onitemupdated="DetailsView1_ItemUpdated" >
                <FooterTemplate>
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </FooterTemplate>
                <Fields>
                    <asp:BoundField DataField="DropDownID" HeaderText="DropDownID" 
                        InsertVisible="False" ReadOnly="True" SortExpression="DropDownID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:CommandField ShowEditButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                SelectMethod="GetDropDownByDropDownID" TypeName="DropDownBLL" 
                UpdateMethod="UpdateDropDown" 
                OldValuesParameterFormatString="original_{0}">
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Original_DropDownID" Type="Int32" />
                </UpdateParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="pnlGrid" Name="DropDownID" 
                        PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </asp:Panel>

</asp:Content>

