<%@ Page Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="regform.Login.LoginPage" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="styles" >
    <link type="text/css" rel="stylesheet" href="../Content/RegistationForm.css" />
    
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="RegField">
    <asp:Login runat="server" 
        ID="login"
        CssClass="loginForm" 
        LoginButtonText="LogIn" 
        TitleText="Welcome" 
        UserNameLabelText="Login:" 
        PasswordLabelText="Password:" 
        OnAuthenticate="login_Authenticate"></asp:Login>
</asp:Content>