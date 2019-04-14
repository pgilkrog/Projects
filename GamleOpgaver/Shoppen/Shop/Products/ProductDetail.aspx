<%@ Page Language="C#" MasterPageFile="~/Masterpages/FrontEnd.master" AutoEventWireup="true" CodeFile="ProductDetail.aspx.cs" Inherits="ProductDetail" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
        AutoGenerateRows="False" DataKeyNames="ProductID" 
        DataSourceID="ObjectDataSource1" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <Fields>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" 
                SortExpression="Description" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:ImageField DataImageUrlField="Image" 
                DataImageUrlFormatString="~/Images/TempImages\\{0}" />
            <asp:BoundField DataField="Category" HeaderText="Category" ReadOnly="True" 
                SortExpression="Category" />
        </Fields>
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:DetailsView>
    
    <cc1:Rating ID="RateProduct" runat="server" StarCssClass="StarRating" FilledStarCssClass="FilledRatingStar" EmptyStarCssClass="EmptyRatingStar" 
    WaitingStarCssClass="EmptyRatingStar" MaxRating="5" ReadOnly="true">
    </cc1:Rating><br /><br />
    
    <cc1:Rating ID="Rating1" runat="server" StarCssClass="StarRating" FilledStarCssClass="FilledRatingStar" EmptyStarCssClass="EmptyRatingStar" 
        WaitingStarCssClass="EmptyRatingStar" MaxRating="5">
    </cc1:Rating>
    <asp:Button ID="btnRate" runat="server" Text="Rate" onclick="btnRate_Click" />
    <asp:Label ID="lblRate" runat="server" Text="Label"></asp:Label>
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetProductsByProductID" TypeName="ProductsBLL">
        <SelectParameters>
            <asp:QueryStringParameter Name="ProductID" QueryStringField="ProductID" 
                Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
</asp:Content>

