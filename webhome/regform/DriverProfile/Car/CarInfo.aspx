<%@ Page Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="CarInfo.aspx.cs" Inherits="regform.DriverProfile.CarInfo" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="styles" >
    <link type="text/css" rel="stylesheet" href="../../Content/RegistationForm.css" />
    <link type="text/css" rel="stylesheet" href="../../Content/GridStyle.css" />
    <link type="text/css" rel="stylesheet" href="../../Content/MenuList.css" />
</asp:Content>

<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="hrefs">
    
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="RegField">
        <asp:ObjectDataSource ID="odsCar" DataObjectTypeName="CodeFirst.Driver" runat="server"
             TypeName="managerDll.DriverManager" SelectMethod="GetById" DeleteMethod="Delete">
            <SelectParameters>
                <asp:QueryStringParameter Name="id" QueryStringField="uid" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView runat="server" ID="gwCar" CssClass="Grid" DataSourceID="odsCar" DataKeyNames="Id" AutoGenerateColumns="false">
          <Columns>
              <asp:BoundField HeaderText="Brand" DataField="Car.CarBrand" />
              <asp:BoundField HeaderText="Model" DataField="Car.CarModel" />
              <asp:BoundField HeaderText="Number" DataField="Car.CarNumber" />
              <asp:BoundField HeaderText="Class" DataField="Car.CarClass" />
              <asp:BoundField HeaderText="Body Type" DataField="Car.VehicleType" />
               <%--<asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" Text="car" NavigateUrl='<%#string.Format("~/DriverProfile/Car/EditCar.aspx?uid={0}", Eval("Id"))%>' />
                </ItemTemplate>
            </asp:TemplateField>--%>
                <%--<asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                   <asp:LinkButton ID="LinkButton1" runat="server" Text="Delete" CommandName="Delete" OnClientClick="return confirm('Realy Delete this Car?')"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>--%>
          </Columns>
        </asp:GridView>

</asp:Content>