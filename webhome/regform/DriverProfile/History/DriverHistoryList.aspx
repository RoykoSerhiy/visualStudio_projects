<%@ Page Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="DriverHistoryList.aspx.cs" Inherits="regform.DriverProfile.History.DriverHistoryList" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="styles" >
    <link type="text/css" rel="stylesheet" href="../../Content/RegistationForm.css" />
     <link type="text/css" rel="stylesheet" href="../../Content/GridStyle.css" />
   <link type="text/css" rel="stylesheet" href="../../Content/MenuList.css" />
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="hrefs">
    
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="RegField">
    <asp:ObjectDataSource ID="odsHistory" 
            DataObjectTypeName="CodeFirst.History" 
            runat="server"
            TypeName="managerDll.HistoryManager" 
            SelectMethod="GetDHRange" 
            EnablePaging="true"
            StartRowIndexParameterName="startIndex"
            MaximumRowsParameterName="count"
            SelectCountMethod="HistoryCountDrivers"
            DeleteMethod="Delete">

        <SelectParameters>
                <asp:QueryStringParameter Name="id" QueryStringField="uid" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
        <asp:GridView runat="server" ID="gwHistory" DataSourceID="odsHistory" DataKeyNames="Id" AutoGenerateColumns="false"
            OnPageIndexChanging="gwHistory_PageIndexChanging" PageSize="10" AllowPaging="true" CssClass="Grid" AlternatingRowStyle-CssClass="alt"
            PagerStyle-CssClass="pgr">
            <Columns>
            <asp:BoundField HeaderText="Driver" DataField="Driver.Name" />
            <asp:BoundField HeaderText="Client" DataField="User.Name" />
            <asp:BoundField HeaderText="Car" DataField="Driver.Car.CarBrand" />
            <asp:BoundField HeaderText="StartTime" DataField="StartTime" />
            <asp:BoundField HeaderText="FinishTime" DataField="FinishTime" />
            <asp:BoundField HeaderText="DepatureAddress" DataField="DepatureAddress" />
            <asp:BoundField HeaderText="DestinationAddress" DataField="DestinationAddress" />
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                   <asp:LinkButton ID="LinkButton1" runat="server" Text="Delete" CommandName="Delete" OnClientClick="return confirm('Realy Delete this History?')"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="edit">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" Text="edit" NavigateUrl='<%#string.Format("~/DriverProfile/History/DriverHistoryEdit.aspx?uid={0}", Eval("Id"))%>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        </asp:GridView>
    
</asp:Content>