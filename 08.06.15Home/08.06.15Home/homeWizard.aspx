<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeWizard.aspx.cs" Inherits="_08._06._15Home.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Wizard runat="server" ID="mainWizard" OnNextButtonClick="mainWizard_NextButtonClick">
            <WizardSteps>
                <asp:WizardStep runat="server">
                    <asp:Label runat="server"  Text="Product has been installed into your PC"></asp:Label>
                </asp:WizardStep>
                <asp:WizardStep runat="server" OnActivate="Unnamed_Activate1">
                    <asp:Panel ScrollBars="Auto" runat="server">
                        LicenseLicenseLicensLicenseLicenseLicenseLicenseLicenseLicense
                        LicenseLicenseLicenseLicenseLicenseLicenseLicenseLicenseLicense
                        LicenseLicenseLicenseLicenseLicenseLicenseLicenseLicenseLicense
                         LicenseLicenseLicensLicenseLicenseLicenseLicenseLicenseLicense
                        LicenseLicenseLicenseLicenseLicenseLicenseLicenseLicenseLicense
                        LicenseLicenseLicenseLicenseLicenseLicenseLicenseLicenseLicense
                         LicenseLicenseLicensLicenseLicenseLicenseLicenseLicenseLicense
                        LicenseLicenseLicenseLicenseLicenseLicenseLicenseLicenseLicense
                        LicenseLicenseLicenseLicenseLicenseLicenseLicenseLicenseLicense
                         LicenseLicenseLicensLicenseLicenseLicenseLicenseLicenseLicense
                        LicenseLicenseLicenseLicenseLicenseLicenseLicenseLicenseLicense
                        LicenseLicenseLicenseLicenseLicenseLicenseLicenseLicenseLicense
                    </asp:Panel>
                    <asp:CheckBox runat="server" ID="chkLicense" OnCheckedChanged="chkLicense_CheckedChanged"/>

                </asp:WizardStep>
                <asp:WizardStep runat="server" OnActivate="Unnamed_Activate">
                    <asp:TextBox runat="server" ID="tbxPath">

                    </asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" OnActivate="WizardStep1_Activate">
                </asp:WizardStep>
                <asp:WizardStep runat="server" OnActivate="Unnamed_Activate1">
                </asp:WizardStep>
             </WizardSteps>
            
        </asp:Wizard>
        <asp:Label runat="server" ID="lbl_act"></asp:Label>
    </div>
    </form>
</body>
</html>
