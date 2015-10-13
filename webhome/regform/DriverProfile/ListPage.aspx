<%@ Page Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="ListPage.aspx.cs" Inherits="regform.DriverProfile.ListPage" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="styles" >
    <link type="text/css" rel="stylesheet" href="../Content/RegistationForm.css" />
     <link type="text/css" rel="stylesheet" href="../Content/GridStyle.css" />
   <link type="text/css" rel="stylesheet" href="../Content/MenuList.css" />
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="hrefs">
    
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="RegField">
        <asp:ObjectDataSource ID="odsDrivers" 
            DataObjectTypeName="CodeFirst.Driver" 
            runat="server"
            TypeName="managerDll.DriverManager" 
            SelectMethod="GetRange" 
            EnablePaging="true"
            StartRowIndexParameterName="startIndex"
            MaximumRowsParameterName="count"
            SelectCountMethod="DriverCount"
            DeleteMethod="Delete"></asp:ObjectDataSource>
    
        <asp:GridView runat="server" ID="gwDrivers" DataSourceID="odsDrivers" DataKeyNames="Id" AutoGenerateColumns="false"
            OnPageIndexChanging="gwDrivers_PageIndexChanging" PageSize="10" AllowPaging="true" CssClass="Grid" AlternatingRowStyle-CssClass="alt"
            PagerStyle-CssClass="pgr" HorizontalAlign="Center">
            <Columns>
            <asp:BoundField HeaderText="Name" DataField="Name" />
            <asp:BoundField HeaderText="Surname" DataField="Surname" />
            <asp:BoundField HeaderText="MiddleName" DataField="MiddleName" />
            <asp:BoundField HeaderText="Phone" DataField="Phone" />
            <asp:BoundField HeaderText="Login" DataField="Login" />
            <asp:BoundField HeaderText="Password" DataField="Password" />
            <asp:BoundField HeaderText="LicenseNumber" DataField="LicenseNum" />
            <asp:BoundField HeaderText="LicenseValidDate" DataField="LicenseValidDate" />
            <asp:BoundField HeaderText ="Nationality" DataField="Nationality" />
            <asp:TemplateField HeaderText="edit">
                <ItemTemplate>
                    <asp:HyperLink runat="server" Text="edit" NavigateUrl='<%#string.Format("~/DriverProfile/EditPage.aspx?uid={0}", Eval("Id"))%>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="car">
                <ItemTemplate>
                    <asp:HyperLink runat="server" Text="car" NavigateUrl='<%#string.Format("~/DriverProfile/Car/CarInfo.aspx?uid={0}", Eval("Id"))%>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="History">
                <ItemTemplate>
                    <asp:HyperLink runat="server" Text="History" NavigateUrl='<%#string.Format("~/DriverProfile/History/DriverHistoryList.aspx?uid={0}", Eval("Id"))%>' />
                </ItemTemplate>
            </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                  
                    <asp:LinkButton runat="server" Text="Delete" CommandName="Delete" OnClientClick="return confirm('Realy Delete this Driver?')"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
           
        </Columns>
        </asp:GridView>
   
        <asp:Button runat="server" CssClass="buttonDriverAdd" ID="btnAdd" Text="Add Driver" OnClick="btnAdd_Click" />
</asp:Content>   