<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" 
    AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" 
    Inherits="ControlExamples.UserRegistration" %>
<%@ Register TagPrefix="common" TagName="Registration" Src="~/CommonControls/RegistrationControl.ascx" %>
<asp:Content runat="server" ContentPlaceHolderID="styles" >
    <link type="text/css" rel="stylesheet" href="Content/RegistrationForm.css" />
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="cphBody">
        <common:Registration ID="regCtrl"  runat="server"></common:Registration>
</asp:Content>