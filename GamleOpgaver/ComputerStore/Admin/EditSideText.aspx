<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="EditSideText.aspx.cs" Inherits="Admin_EditSideText" Title="Computer Store" validateRequest="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:FormView ID="FormView1" runat="server" DataKeyNames="SideID" 
        DataSourceID="ObjectDataSource1">
        <EditItemTemplate>
            SideID:
            <asp:Label ID="SideIDLabel1" runat="server" Text='<%# Eval("SideID") %>' />
            <br />
            Headline:
            <asp:TextBox ID="HeadlineTextBox" runat="server" 
                Text='<%# Bind("Headline") %>' />
            <br />
            Text:
            <asp:TextBox ID="TextTextBox" runat="server" Text='<%# Bind("Text") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            Headline:
            <asp:TextBox ID="HeadlineTextBox" runat="server" 
                Text='<%# Bind("Headline") %>' />
            <br />
            Text:
            <asp:TextBox ID="TextTextBox" runat="server" Text='<%# Bind("Text") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            SideID:
            <asp:Label ID="SideIDLabel" runat="server" Text='<%# Eval("SideID") %>' />
            <br />
            Headline:
            <asp:Label ID="HeadlineLabel" runat="server" Text='<%# Bind("Headline") %>' />
            <br />
            Text:
            <asp:Label ID="TextLabel" runat="server" Text='<%# Bind("Text") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                CommandName="Edit" Text="Edit" />
        </ItemTemplate>
    </asp:FormView>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetText" TypeName="SideTextBLL" UpdateMethod="UpdateText">
        <UpdateParameters>
            <asp:Parameter Name="Headline" Type="String" />
            <asp:Parameter Name="Text" Type="String" />
            <asp:Parameter Name="SideID" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>

    </asp:Content>

