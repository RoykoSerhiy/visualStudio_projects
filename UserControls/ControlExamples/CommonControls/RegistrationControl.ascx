<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegistrationControl.ascx.cs" Inherits="ControlExamples.CommonControls.RegistrationControl" %>


<div class="registrationContainer">
            <div class="formHeader">
                <span id="title" runat="server"></span>
            </div>
            <div class="row">
                <div class="title">Name:</div>
                <div class="inputData">
                    <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                    <asp:CustomValidator runat="server" ControlToValidate="txtName" ErrorMessage="Name doesn't match the rules" ClientValidationFunction="ValidateName"></asp:CustomValidator>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName" ErrorMessage="Name should not be empty"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row">
                <div class="title">Surname:</div>
                <div class="inputData">
                    <asp:TextBox runat="server" ID="txtSurname"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtSurname" ErrorMessage="Name should not be empty"></asp:RequiredFieldValidator>
                   <%-- <asp:RegularExpressionValidator runat="server" ValidationExpression="\S" ControlToValidate="txtSurname"  ErrorMessage="Surname doesn't match the rules" Display="Dynamic"  ></asp:RegularExpressionValidator>--%>
                </div>
            </div>
            <div class="row">
                <div class="title">Age:</div>
                <div class="inputData">
                    <asp:TextBox runat="server" Text="18" TextMode="Number"  ID="txtAge"></asp:TextBox>
                    <asp:RangeValidator  Display="Dynamic" runat="server" ControlToValidate="txtAge" ErrorMessage="Value is out of range" MinimumValue="18" Enabled="true" MaximumValue="150" Type="Integer" ></asp:RangeValidator>
                </div>
            </div>
            <div class="row">
                <div class="title">Gender:</div>
                <div class="inputData">
                    <asp:RadioButtonList runat="server">
                        <asp:ListItem Selected="True">Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="row">
                <asp:CheckBox ID="chkLicense" AutoPostBack="true" CausesValidation="false" OnCheckedChanged="chkLicense_CheckedChanged" Text="I agree blah... blah..." runat="server" />
            </div>
            <div class="row buttons">
                <button type="reset">Clear</button>
                <asp:Button OnClick="btnSubmit_Click" OnLoad="btnSubmit_Load" ID="btnSubmit" Text="Save" runat="server" />
            </div>
</div>