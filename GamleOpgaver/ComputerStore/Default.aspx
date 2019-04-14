<%@ Page Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="BlackContent">
    <asp:DataList ID="DataList2" runat="server" DataKeyField="BannerID" 
        DataSourceID="ObjectDataSource2">
        <ItemTemplate>
            <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("Image", "~/Images/Banner/Image\\{0}") %>' />
        </ItemTemplate>
    </asp:DataList>
    
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
        SelectMethod="GetBannerByRandom" TypeName="BannerBLL">
    </asp:ObjectDataSource>
    
    <div class="FeaturedProducts">
        <div style="float: left; margin-left: 5px; margin-top: 5px;">Featured Products</div>
    </div>
    
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductID" 
        DataSourceID="ObjectDataSource1" RepeatColumns="3" 
    RepeatDirection="Horizontal" CellPadding="4">
        <ItemTemplate>            
            <asp:Image ID="Image1" runat="server" Width="178px" Height="178px" ImageUrl='<%# Eval("Image", "~/Images/TempImages\\{0}") %>' />
                <br />
            <p style="color: #e76205;"><asp:Label ID="Label1" runat="server" Text='<%# GenerateString(Eval("Name").ToString()) %>'></asp:Label>...</p>
            
            <i><asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl='<%# Eval("ProductID", "~/Products/ProductDetail.aspx?ProductID={0}") %>' Text="View Detail" ForeColor="#E76205"></asp:HyperLink></i>
        </ItemTemplate>
    </asp:DataList>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetProductByRandom" TypeName="ProductsBLL">
    </asp:ObjectDataSource>
</div>
</asp:Content>

