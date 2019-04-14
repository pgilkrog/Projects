<%@ Page Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="AboutUs" Title="Computer Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="margin-top: -1px; margin-left: -1px;">
        <asp:DataList ID="DataList1" runat="server" DataKeyField="SideID" 
            DataSourceID="ObjectDataSource1">
            <ItemTemplate>
                <div class="GrayContent">
                <div class="PageMenu"><h2><asp:Label ID="HeadlineLabel" runat="server" Text='<%# Eval("Headline") %>' /></h2></div>
                </div>
                
                <div class="PageContent"><p>
                <asp:Label ID="TextLabel" runat="server" Text='<%# Eval("Text") %>' />
                </p></div>
            </ItemTemplate>
        </asp:DataList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetText" TypeName="SideTextBLL"></asp:ObjectDataSource>
</div>
</asp:Content>

