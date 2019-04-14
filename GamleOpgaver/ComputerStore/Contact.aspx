<%@ Page Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" Title="Computer Store" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="GrayContent">
        <div class="PageMenu"><h2>Contact</h2></div>
</div>
<div class="PageContent">
<table>
    <tr>
        <td>
            Name:
        </td>
        <td>
            <asp:TextBox ID="tbName" runat="server" Width="220px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="tbName" ValidationGroup="c"></asp:RequiredFieldValidator>
        </td>
    </tr>
        <tr>
        <td>
            Address:
        </td>
        <td>
            <asp:TextBox ID="tbAddress" runat="server" Width="220px"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td>
            ZipCode/City:
        </td>
        <td>
            <asp:TextBox ID="tbZip" runat="server" Width="59px"></asp:TextBox>
            <asp:TextBox ID="tbCity" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td>
            Email:
        </td>
        <td>
            <asp:TextBox ID="tbEmail" runat="server" Width="220px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="REVMail" runat="server" ControlToValidate="tbEmail" ErrorMessage="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="c" />
        </td>
    </tr>
        <tr>
        <td>
            Phone:
        </td>
        <td>
            <asp:TextBox ID="tbPhone" runat="server" Width="220px"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td>
            Subject:
        </td>
        <td>
            <asp:TextBox ID="tbSubject" runat="server" Width="220px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="tbSubject" ValidationGroup="c"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Description:
        </td>
        <td>
            <asp:TextBox ID="tbDesc" runat="server" Width="390px" Height="100px" 
                TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                    runat="server" ErrorMessage="*" ControlToValidate="tbDesc" ValidationGroup="c"></asp:RequiredFieldValidator>
        </td>
    </tr>
        <tr>
        <td>
        
        </td>
        <td>
            <asp:Button ID="btnSend" runat="server" Text="Send" ValidationGroup="c" onclick="btnSend_Click" />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </td>
    </tr>
</table>
<div style="float:right; margin-top: -300px; margin-right: 5px;">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="InfoID" 
        DataSourceID="ObjectDataSource1">
        <ItemTemplate>
                            <p>
                            <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>' />
                                <br />
                            <asp:Label ID="AddressLabel" runat="server" Text='<%# Bind("Address") %>' />
                                <br />
                            <asp:Label ID="Zip_CodeLabel" runat="server" Text='<%# Bind("ZipCode") %>' />
                            <asp:Label ID="CityLabel" runat="server" Text='<%# Bind("City") %>' />
                                <br />
                            Phone:
                            <asp:Label ID="PhoneLabel" runat="server" Text='<%# Bind("Phone") %>' />
                            <br />
                            Fax:
                            <asp:Label ID="FaxLabel" runat="server" Text='<%# Bind("Fax") %>' />
                            <br />
                            <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
                            <br /></p>
        </ItemTemplate>
    </asp:DataList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetInfo" TypeName="InfoBLL"></asp:ObjectDataSource>
</div>
</div>
</asp:Content>

