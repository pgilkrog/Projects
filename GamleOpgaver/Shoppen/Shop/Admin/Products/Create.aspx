<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Admin_Create" Title="Untitled Page" %>

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
                Name: <br />
                <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                <br />
                Description: <br />
                <asp:TextBox ID="tbDescription" runat="server"></asp:TextBox>
                <br />
                Price: <br />
                <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
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

    </asp:Content>

