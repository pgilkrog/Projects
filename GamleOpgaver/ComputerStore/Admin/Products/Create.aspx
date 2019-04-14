<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Admin_Create" Title="Computer Store" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1>Add new Product</h1>

    <asp:Wizard ID="Wizard1" runat="server" DisplaySideBar="false" 
        FinishCompleteButtonText="Submit" FinishPreviousButtonText="Back" StartNextButtonText="Next" 
        StepNextButtonText="Next" StepPreviousButtonText="Back" 
        ActiveStepIndex="0" onfinishbuttonclick="Wizard1_FinishButtonClick">
        <WizardSteps>
            <asp:WizardStep ID="WizardStep1" runat="server" Title="Name, Description and Price">
            <table>
                <tr>
                    <td>
                        Name:
                    </td>
                    <td>
                        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Description:
                    </td>
                    <td>
                        <asp:TextBox ID="tbDescription" runat="server" Height="100px" width="300px"
                            TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Facts:
                    </td>
                    <td>
                        <asp:TextBox ID="tbFacts" runat="server" Height="50px" TextMode="MultiLine"></asp:TextBox>                    
                    </td>
                </tr>
                <tr>
                    <td>
                        Price:
                    </td>
                    <td>
                        <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Rating:
                    </td>
                    <td>
                        <cc1:Rating ID="Rating1" runat="server" StarCssClass="StarRating" FilledStarCssClass="FilledRatingStar" EmptyStarCssClass="EmptyRatingStar" 
                        WaitingStarCssClass="EmptyRatingStar" MaxRating="5">
                        </cc1:Rating><br />
                    </td>
                </tr>
            </table>
            </asp:WizardStep>
            
            <asp:WizardStep ID="WizardStep2" runat="server" Title="Categories">
                <asp:RadioButtonList ID="rblCategories" runat="server" DataSourceID="GetCategories" DataTextField="Name" DataValueField="CategoryID"
                RepeatDirection="Vertical" TextAlign="Left">
                </asp:RadioButtonList>
                <asp:ObjectDataSource ID="GetCategories" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetCategory" 
                    TypeName="CategoryBLL"></asp:ObjectDataSource>
            </asp:WizardStep>
            
            <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3">
                <asp:FileUpload ID="uplImage" runat="server" />
            </asp:WizardStep>
        </WizardSteps>
    </asp:Wizard>
    
    <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetProducts" InsertMethod="InsertProducts" TypeName="ProductsBLL">
    </asp:ObjectDataSource>

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    </asp:Content>

