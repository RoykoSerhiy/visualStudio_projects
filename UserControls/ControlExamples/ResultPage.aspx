<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" 
    AutoEventWireup="true" CodeBehind="ResultPage.aspx.cs" 
    Inherits="ControlExamples.ResultPage" %>

<asp:Content ContentPlaceHolderID="styles" runat="server">
</asp:Content>

<asp:Content ContentPlaceHolderID="cphBody" runat="server">
    <div class="userGreetings">
        <span runat="server" id="greetingMsg"></span>
    </div>
</asp:Content>
