<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="drikkevarer.aspx.cs" Inherits="Shop_drikkevarer" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="shopbox">
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" 
        RepeatColumns="5" RepeatDirection="Horizontal">
        <ItemTemplate>
            Billede:
            <asp:Label ID="BilledeLabel" runat="server" Text='<%# Eval("Billede") %>' />
            <br />
            Navn:
            <asp:Label ID="NavnLabel" runat="server" Text='<%# Eval("Navn") %>' />
            <br />
            Pris:
            <asp:Label ID="PrisLabel" runat="server" Text='<%# Eval("Pris") %>' />
            <br />
            liter:
            <asp:Label ID="literLabel" runat="server" Text='<%# Eval("liter") %>' />
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>  
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Drikkevarer.mdf;Integrated Security=True;User Instance=True" 
        ProviderName="System.Data.SqlClient" 
        SelectCommand="SELECT [Billede], [Navn], [Pris], [liter] FROM [Table1]"></asp:SqlDataSource>
</div>

<div class="undermenu">
    <a href="Shopforside.aspx">Shop</a></div>

<div class="fødevarer">    
    <asp:Menu ID="Menu1" runat="server">
        <Items>
            <asp:MenuItem Text="Fødevarer" Value="Fødevarer">
                <asp:MenuItem NavigateUrl="~/Shop/madvarer.aspx" Text="Madvarer" 
                    Value="Madvarer"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Shop/drikkevarer.aspx" Text="Drikkevarer" 
                    Value="Drikkevarer"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Shop/slik.aspx" Text="Slikvarer" Value="Slikvarer">
                </asp:MenuItem>
            </asp:MenuItem>
        </Items>
    </asp:Menu>
</div>
    
<div class="hygiejne">    
    <asp:Menu ID="Menu2" runat="server">
        <Items>
            <asp:MenuItem Text="Hygiejneprodukter" Value="Hygiejneprodukter">
                <asp:MenuItem NavigateUrl="~/Shop/rengøring.aspx" Text="Rengøring" 
                    Value="rengøringsprodukter"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Shop/sæbeogshampoo.aspx" Text="Sæbe/Shampoo" 
                    Value="Sæbe og Shampoo"></asp:MenuItem>
            </asp:MenuItem>
        </Items>
    </asp:Menu>
</div>

<div class="Ting">
    <a href="Ting.aspx">Ting</a>
</div>
    
</asp:Content>

