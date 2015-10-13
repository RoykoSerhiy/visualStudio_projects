<%@ Page Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="regform.UserRegistration" %>

<%@ Register TagPrefix="common" TagName="DriverRegistration" Src="~/CommonControls/DriverRegistration.ascx"%>
<%@ Register TagPrefix="common" TagName="RegLogControl" Src="~/CommonControls/RegLogControl.ascx" %>
<%@ Register TagPrefix="common" TagName="CarRegistration" Src="~/CommonControls/CarRegistration.ascx" %>
<%@ Register TagPrefix="common" TagName="UserInfo" Src="~/CommonControls/MainUserControl.ascx" %>

<asp:Content runat="server" ContentPlaceHolderID="styles" >
    <link type="text/css" rel="stylesheet" href="Content/RegistationForm.css" />
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="RegField">
       <common:UserInfo ID="userInfoCtrl" runat="server" />
    <common:RegLogControl ID="regLogCtrl" runat="server" />
    <div class="regConteiner">
            <div class="row">
                <asp:RadioButton ID="radioUser" 
            runat="server" 
            autopostback="true" 
            GroupName="SearchType" 
            Text="User" 
            OnCheckedChanged="RadioButton_CheckedChanged" />
        &nbsp;
        <asp:RadioButton ID="radioDriver" 
            runat="server" 
            autopostback="true" 
            GroupName="SearchType" 
            Text="Driver" 
            OnCheckedChanged="RadioButton_CheckedChanged"/>
            </div>
            <div>
                 <asp:MultiView runat="server" ID="multiViewUserReg">
                     <asp:View ID="viewUserReg" runat="server">
                     </asp:View>
                     <asp:View ID="viewDriverReg" runat="server">
                          <common:DriverRegistration ID="driverReg" runat="server" />
                     </asp:View>
                 </asp:MultiView>
            </div>
       
       
        
            <div class="row">
                <asp:CheckBox ID="chkLicense" AutoPostBack="true" CausesValidation="false" OnCheckedChanged="chkLicense_CheckedChanged" runat="server" Text="agrre with rules" />
            </div>
            <div class="row buttons">
            <button type="reset">Clear</button>
                <asp:Button OnLoad="btnSubmit_Load" ID="btnSubmit" Text="Save"  runat="server" OnClick="btnSubmit_Click"/>
            </div>
        </div>
    
</asp:Content>
