<%@ Page Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="regform.UserProfile.UserList" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="styles" >
    <link type="text/css" rel="stylesheet" href="../Content/RegistationForm.css" />
    <link type="text/css" rel="stylesheet" href="../Content/GridStyle.css" />
    <link type="text/css" rel="stylesheet" href="../Content/MenuList.css" />
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="hrefs">
    
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="RegField">
        <asp:ObjectDataSource ID="odsUsers" 
             DataObjectTypeName="CodeFirst.User" 
             runat="server"
             TypeName="managerDll.UserManager"
             SelectMethod="GetUserRange" 
             EnablePaging="true"
             StartRowIndexParameterName="startIndex"
             MaximumRowsParameterName="count"
             SelectCountMethod="UserCount"
             DeleteMethod="Delete"></asp:ObjectDataSource>
        <asp:GridView runat="server" ID="gwUsers" DataSourceID="odsUsers" DataKeyNames="Id" AutoGenerateColumns="false"
             OnPageIndexChanging="gwUsers_PageIndexChanging" PageSize="10" AllowPaging="true" CssClass="Grid" AlternatingRowStyle-CssClass="alt"
            PagerStyle-CssClass="pgr" HorizontalAlign="Center">
            <Columns>
            <asp:BoundField HeaderText="Name" DataField="Name" />
            <asp:BoundField HeaderText="Surname" DataField="Surname" />
            <asp:BoundField HeaderText="MiddleName" DataField="MiddleName" />
            <asp:BoundField HeaderText="Phone" DataField="Phone" />
            <asp:BoundField HeaderText="Login" DataField="Login" />
            <asp:BoundField HeaderText="Password" DataField="Password" />
            <asp:BoundField HeaderText ="Nationality" DataField="Nationality" />
            <asp:TemplateField HeaderText="edit">
                <ItemTemplate>
                    <asp:HyperLink runat="server" Text="edit" NavigateUrl='<%#string.Format("~/UserProfile/EditUser.aspx?uid={0}", Eval("Id"))%>' />
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="History">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" Text="History" NavigateUrl='<%#string.Format("~/UserProfile/History/UserHistoryList.aspx?uid={0}", Eval("Id"))%>' />
                </ItemTemplate>
            </asp:TemplateField>
           <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                   <asp:LinkButton ID="LinkButton1" runat="server" Text="Delete" CommandName="Delete" OnClientClick="return confirm('Realy Delete this User?')"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
           
        </Columns>
        </asp:GridView>
        <asp:Button runat="server" CssClass="buttonUserAdd" ID="btnAdd" Text="Add User" OnClick="btnAdd_Click" />
</asp:Content>