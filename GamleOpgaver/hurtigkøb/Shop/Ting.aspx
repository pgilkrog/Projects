<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ting.aspx.cs" Inherits="Shop_Ting" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



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

