<%@ Page Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="regform.DriverProfile.EditPage" %>


<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="styles" >
    <link type="text/css" rel="stylesheet" href="../Content/RegistationForm.css" />
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="RegField">
    <asp:ObjectDataSource ID="dsDrivers" runat="server" DataObjectTypeName="CodeFirst.Driver" TypeName="managerDll.DriverManager"
        SelectMethod="GetById" UpdateMethod="Update" OnUpdating="dsDrivers_Updating">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="uid" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
    <asp:FormView runat="server" ID="fvEditDriver" DataSourceID="dsDrivers" DataKeyNames="Id" DefaultMode="Edit" >
        <EditItemTemplate>
    <div class="regConteiner">
        <div class="row">
            <div class="title">Name:</div> 
            <div class="inputData">
                <asp:TextBox runat="server" ID="txtName" Text='<%#Bind("Name")%>'></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="error" runat="server" ID="valid" ControlToValidate="txtName" ErrorMessage="Name should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
       
            </div>
        </div>
            <div class="row">
            <div class="title">Surname:</div> 
            <div class="inputData">
                <asp:TextBox runat="server" ID="txtSurname" Text='<%#Bind("Surname")%>'></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="error"  runat="server" ControlToValidate="txtSurname" ErrorMessage="Surname should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
                
            </div>
        </div>
        <div class="row">
            <div class="title">Middle Name:</div> 
            <div class="inputData">
                <asp:TextBox runat="server" ID="txtMiddleName" Text='<%#Bind("MiddleName")%>'></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="error" runat="server" ControlToValidate="txtMiddleName" ErrorMessage="Middle Name should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
                
            </div>
        </div>
         
       
        <div class="row">
            <div class="title">Mobile Phone:</div> 
            <div class="inputData">
                <asp:TextBox runat="server" TextMode="Phone" Text='<%#Bind("Phone")%>' ID="txtPhone"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="error" ID="RequiredFieldValidator3"  runat="server" ControlToValidate="txtPhone" Text="+380" ErrorMessage="Phone should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
                
             </div>
        </div>
         <div class="row">
             <div class="title">Nationality:</div> 
             <div class="inputData">
                 <asp:DropDownList runat="server" DataMember="Nationality" SelectedValue='<%#Bind("Nationality")%>' ID="ddlNationality" OnInit="ddlNationality_Init"></asp:DropDownList>     
             </div>
         </div>
     <div class="row">
       <div class="title">Login:</div> 
          <div class="inputData">
              <asp:TextBox runat="server" ID="txtLogin" Text='<%#Bind("Login")%>'></asp:TextBox>
              <asp:RequiredFieldValidator CssClass="error" runat="server" ID="RequiredFieldValidator4" ControlToValidate="txtLogin" ErrorMessage="Login should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
             
          </div>
    </div>
    <div class="row">
       <div class="title">Password:</div> 
          <div class="inputData">
              <asp:TextBox runat="server" ID="txtPassword" Text='<%#Bind("Password")%>'></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="error" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
             
          </div>
    </div>
    <div class="row">
            <div class="title">License Number:</div> 
            <div class="inputData">
                <asp:TextBox runat="server" Text='<%#Bind("LicenseNum")%>' ID="txtLicenseNumber"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" CssClass="error" runat="server" ControlToValidate="txtLicenseNumber" Text="" ErrorMessage="License number should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="error" runat="server" ControlToValidate="txtLicenseNumber" ValidationExpression="^[0-9]{6}$" ErrorMessage="License Number dosen`t match the rules" Display="Dynamic"></asp:RegularExpressionValidator>
                    <div>
                        <div>Valid until</div>
                        <asp:TextBox runat="server" TextMode="Date" Text='<%#Bind("LicenseValidDate")%>' ID="txtLN_valid_until"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" CssClass="error" runat="server" ControlToValidate="txtLN_valid_until" Text="" ErrorMessage="Date should be not empty"></asp:RequiredFieldValidator>
                    </div>
           </div>
        </div>
    <div class="row">
             <div class="title">Car brand:</div> 
             <div class="inputData">
                 <asp:TextBox runat="server" ID="txtCarBrand" Text='<%#Eval("Car.CarBrand")%>'></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator7" CssClass="error" runat="server" ControlToValidate="txtCarBrand" Text="" ErrorMessage="Car brand should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
              </div>
         </div>
         <div class="row">
             <div class="title">Car model:</div> 
             <div class="inputData">
                 <asp:TextBox runat="server" ID="txtCarModel" Text='<%#Eval("Car.CarModel")%>'></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator8" CssClass="error" runat="server" ControlToValidate="txtCarModel" Text="" ErrorMessage="Car model should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
              </div>
         </div>
          <div class="row">
             <div class="title">Car number:</div> 
             <div class="inputData">
                 <asp:TextBox runat="server" ID="txtCarNumber" Text='<%#Eval("Car.CarNumber")%>'></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator10" CssClass="error" runat="server" ControlToValidate="txtCarModel" Text="" ErrorMessage="Car model should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
              </div>
         </div>
         <div class="row">
             <div class="title">Car class:</div> 
             <div class="inputData">
                 <asp:TextBox runat="server" ID="txtCarClass" Text='<%#Eval("Car.CarClass")%>'></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator11" CssClass="error" runat="server" ControlToValidate="txtCarModel" Text="" ErrorMessage="Car model should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
              </div>
         </div>
         <div class="row">
             <div class="title">Body Type:</div> 
             <div class="inputData">
                 <asp:DropDownList runat="server" DataMember="Car.VehicleType" SelectedValue='<%#Eval("Car.VehicleType")%>' OnInit="ddlBody_type_Init" ID="ddlBody_type"></asp:DropDownList>     
             </div>
         </div>
         
     <div class="row buttons">
           <asp:Button ID="btnSave" CommandName="Update" Text="Save"  runat="server" OnClick="btnSave_Click"/>
     </div>
</div>
            </EditItemTemplate>
        </asp:FormView>
</asp:Content>

