<%@ Page Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="ProductDetail.aspx.cs" Inherits="Products_ProductDetail" Title="Computer Store" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="margin-top: -1px; margin-left: -1px;">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductID" 
        DataSourceID="ObjectDataSource1">
        <ItemTemplate>
            <div class="GrayContent">
                <div class="PageMenu"><h2><asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' /></h2></div>
            </div>
            <div class="DetailImage"><br />
                <asp:Image ID="Image1" runat="server" Width="50%" Height="50%" ImageUrl='<%# Eval("Image", "~/Images/TempImages\\{0}") %>' />
            </div>
            <div class="PageContent">
                <div><p>
                <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                <br /><br />
                Pris: <b><asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price", "{0:##0.00}") %>' /></b> DKK
                <br /><br />
                <asp:Label ID="FactsLabel" runat="server" Text='<%# Eval("Facts") %>' />
                <br /><br />
                <asp:Label ID="CategoryLabel" runat="server" Text='<%# Eval("Category") %>' />
                </p></div>            
                <div style="position:relative; width:80px; height:30px;">
                <cc1:Rating ID="Rating1" runat="server" StarCssClass="StarRating" FilledStarCssClass="FilledRatingStar" EmptyStarCssClass="EmptyRatingStar" 
                WaitingStarCssClass="EmptyRatingStar" MaxRating="5" ReadOnly="true" CurrentRating='<%# Eval("Rating") %>'>
                </cc1:Rating>
            </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetProductByProductID" TypeName="ProductsBLL">
        <SelectParameters>
            <asp:QueryStringParameter Name="ProductID" QueryStringField="ProductID" 
                Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
</div>
    </asp:Content>

