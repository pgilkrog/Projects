<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="tekstbox">

<h1>Velkommen<br />Til HurtigKøb</h1><br />
<p>Her på siden kan du købe alle dine daglig vare,<br /> på meget få minuter, og til billige priser.<br /><br />Bestiller du dine varer inden kl 11,<br /> 
vil vi bringe dem ud imellem kl. 13-17.<br /><br />Håber du finder hvad du står og mangler.</p>
</div>

<div class="tilbudbil">
    <a href="Ugenstilbud.aspx">
        <asp:Image ID="Image1" runat="server" 
        ImageUrl="~/Billeder/ugenstilbud.bmp" /></a>
        
    <a href="Shop.aspx">
        <asp:Image ID="Image2" runat="server" 
        ImageUrl="~/Billeder/shoppen.bmp" />
    </a>
    
    <a href="Om%20os.aspx">
        <asp:Image ID="Image3" runat="server" 
        ImageUrl="~/Billeder/omos.bmp" />
    </a>
    
</div>


</asp:Content>



