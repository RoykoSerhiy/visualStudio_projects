<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainUserControl.ascx.cs" Inherits="regform.CommonControls.MainUserControl" %>



<div class="regConteiner">
        <div class="row">
            <div class="title">Name:</div> 
            <div class="inputData">
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="error" runat="server" ID="valid" ControlToValidate="txtName" ErrorMessage="Name should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
       
            </div>
        </div>
            <div class="row">
            <div class="title">Surname:</div> 
            <div class="inputData">
                <asp:TextBox runat="server" ID="txtSurname"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="error"  runat="server" ControlToValidate="txtSurname" ErrorMessage="Surname should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
                
            </div>
        </div>
        <div class="row">
            <div class="title">Middle Name:</div> 
            <div class="inputData">
                <asp:TextBox runat="server" ID="txtMiddleName"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="error" runat="server" ControlToValidate="txtMiddleName" ErrorMessage="Middle Name should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
                
            </div>
        </div>
         
       <div class="row">
            <div class="title">Age:</div> 
            <div class="inputData">
                <asp:TextBox runat="server" Text="18" TextMode="Number" ID="txtAge"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" CssClass="error" runat="server" ControlToValidate="txtAge" ErrorMessage="Value is out of range" MinimumValue="18" MaximumValue="150" Type="Integer" Display="Dynamic"></asp:RangeValidator>
             </div>
        </div>
        <div class="row">
            <div class="title">Mobile Phone:</div> 
            <div class="inputData">
                <asp:TextBox runat="server" TextMode="Phone" Text="+380" ID="txtPhone"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="error" ID="RequiredFieldValidator3"  runat="server" ControlToValidate="txtPhone" Text="+380" ErrorMessage="Phone should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
                
             </div>
        </div>
     <!--<div class="row">
            <div class="title">Gender:</div> 
            <div class="inputData">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </div>
        </div>-->
</div>


