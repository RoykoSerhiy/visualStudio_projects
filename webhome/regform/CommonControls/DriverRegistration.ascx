<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DriverRegistration.ascx.cs" Inherits="regform.CommonControls.DriverRegistration" %>
 
    <%@ Register TagPrefix="common" TagName="CarRegistration" Src="~/CommonControls/CarRegistration.ascx" %>
    <div class="regConteiner">
        <div class="row">
            <div class="title">License Number:</div> 
            <div class="inputData">
                <asp:TextBox runat="server" ID="txtLicenseNumber"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="error" runat="server" ControlToValidate="txtLicenseNumber" Text="" ErrorMessage="License number should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" CssClass="error" runat="server" ControlToValidate="txtLicenseNumber" ValidationExpression="^[0-9]{6}$" ErrorMessage="License Number dosen`t match the rules" Display="Dynamic"></asp:RegularExpressionValidator>
                    <div>
                        <div>Valid until</div>
                        <asp:TextBox runat="server" TextMode="Date" ID="txtLN_valid_until"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="error" runat="server" ControlToValidate="txtLN_valid_until" Text="" ErrorMessage="Date should be not empty"></asp:RequiredFieldValidator>
                    </div>
           </div>
        </div>
        
    </div>
    <common:CarRegistration ID="carReg" runat="server"/>