<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegLogControl.ascx.cs" Inherits="regform.CommonControls.RegLogControl" %>

<div class="regConteiner">
    <div class="row">
       <div class="title">Login:</div> 
          <div class="inputData">
              <asp:TextBox runat="server" ID="txtLogin"></asp:TextBox>
              <asp:RequiredFieldValidator CssClass="error" runat="server" ID="valid" ControlToValidate="txtLogin" ErrorMessage="Login should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
             
          </div>
    </div>
    <div class="row">
       <div class="title">Password:</div> 
          <div class="inputData">
              <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
              <asp:RequiredFieldValidator CssClass="error" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
             
          </div>
    </div>
    <div class="row">
       <div class="title">Retry Password:</div> 
          <div class="inputData">
              <asp:TextBox runat="server" ID="txtrtPassword" TextMode="Password"></asp:TextBox>
              <asp:RequiredFieldValidator CssClass="error" runat="server" ControlToValidate="txtrtPassword" ErrorMessage="Password should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
              <asp:CompareValidator CssClass="error" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtrtPassword" ErrorMessage="Passwords don`t mach" Display="Dynamic"></asp:CompareValidator>
          </div>
    </div>
</div>