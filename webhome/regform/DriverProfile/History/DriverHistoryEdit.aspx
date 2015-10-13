<%@ Page Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="DriverHistoryEdit.aspx.cs" Inherits="regform.DriverProfile.History.DriverHistoryEdit" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="styles">
     <% string stylePath = this.ResolveUrl("~/Content"); %>
    <link type="text/css" rel="stylesheet" href='<%=stylePath%>"/RegistationForm.css'/>
    <link type="text/css" rel="stylesheet" href='<%=stylePath%>/calendar-blue.css' />
    
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="scripts">
    <% string scriptPath = this.ResolveUrl("~/Content/script"); %>
    
    <script src='<%=scriptPath%>/jquery-1.4.1.min.js'></script>
    <script src='<%=scriptPath%>/jquery.dynDateTime.min.js'></script>
    <script src='<%=scriptPath%>/calendar-en.min.js'></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#<%=fvEditHistory.FindControl("txtSDate").ClientID %>").dynDateTime({
                showsTime: true,
                ifFormat: "%Y/%m/%d %H:%M",
                daFormat: "%l;%M %p, %e %m,  %Y",
                align: "BR",
                electric: false,
                singleClick: false,
                displayArea: ".siblings('.dtcDisplayArea')",
                button: ".next()"
            });
        });
        </script>
        <script type="text/javascript">
            $(document).ready(function () {
                $("#<%=fvEditHistory.FindControl("txtFDate").ClientID %>").dynDateTime({
                showsTime: true,
                ifFormat: "%Y/%m/%d %H:%M",
                daFormat: "%l;%M %p, %e %m,  %Y",
                align: "BR",
                electric: false,
                singleClick: false,
                displayArea: ".siblings('.dtcDisplayArea')",
                button: ".next()"
            });
        });
    </script>
</asp:Content>

<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="RegField">
    <asp:ObjectDataSource ID="dsHistory" runat="server" DataObjectTypeName="CodeFirst.History" TypeName="managerDll.HistoryManager"
        SelectMethod="GetById" UpdateMethod="Update" OnUpdating="dsHistory_Updating">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="uid" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="dsDrivers" runat="server" DataObjectTypeName="CodeFirst.Driver" TypeName="managerDll.DriverManager"
        SelectMethod="GetAll"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="dsUsers" runat="server" DataObjectTypeName="CodeFirst.User" TypeName="managerDll.UserManager"
        SelectMethod="GetAll"></asp:ObjectDataSource>
    <asp:FormView runat="server" ID="fvEditHistory" DataSourceID="dsHistory" DataKeyNames="Id" DefaultMode="Edit">
        <EditItemTemplate>
            <div class="regConteiner">
                <div class="row">
                    <div class="title">Driver:</div>
                    <div class="inputData">
                        <asp:DropDownList runat="server" ID="ddlDrivers" DataSourceID="dsDrivers" DataValueField="Id" DataTextField="Name" SelectedValue='<%#Eval("Driver.Id")%>'></asp:DropDownList>
                    </div>
                </div>
                
                <div class="row">
                    <div class="title">User:</div>
                    <div class="inputData">
                        <asp:DropDownList runat="server" ID="ddlUsers" DataSourceID="dsUsers" DataValueField="Id" DataTextField="Name" SelectedValue='<%#Eval("User.Id")%>'></asp:DropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="title">Car:</div>
                    <div class="inputData">
                        <asp:TextBox runat="server" ID="car" ReadOnly="true" Text='<%#Eval("Driver.Car.CarBrand")%>'></asp:TextBox>

                    </div>
                </div>


                <div class="row">
                    <div class="title">Depature Address:</div>
                    <div class="inputData">
                        <asp:TextBox runat="server" TextMode="Phone" Text='<%#Bind("DepatureAddress")%>' ID="txtdepAddres"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="error" ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtdepAddres" Text="+380" ErrorMessage="Phone should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>

                    </div>
                </div>
                <div class="row">
                    <div class="title">Destanation Address:</div>
                    <div class="inputData">
                        <asp:TextBox runat="server" Text='<%#Bind("DestinationAddress")%>' ID="txtdestAddres"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="error" runat="server" ControlToValidate="txtdestAddres" Text="+380" ErrorMessage="Phone should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="title">Start Time:</div>
                    <div class="inputData">
                        
                        <asp:TextBox ID="txtSDate" TextMode="DateTime" runat="server" ReadOnly="true" Text='<%#Bind("StartTime") %>'></asp:TextBox>
                        <img src="../../Content/images/calender.png"/>
                    </div>
                </div>
                <div class="row">
                    <div class="title">Finish Time:</div>
                    <div class="inputData">
                      
                        
                        <asp:TextBox ID="txtFDate" TextMode="DateTime" runat="server" ReadOnly="true" Text='<%#Bind("FinishTime") %>'></asp:TextBox>
                        <img src="../../Content/images/calender.png"/>
                    </div>
                </div>


                <div class="row buttons">
                    <asp:Button ID="btnSave" CommandName="Update" Text="Save" runat="server" OnClick="btnSave_Click" />
                    <asp:Button ID="btcCancel" runat="server" Text="Cancel" OnClick="btcCancel_Click" />
                </div>
            </div>
        </EditItemTemplate>
    </asp:FormView>
</asp:Content>

