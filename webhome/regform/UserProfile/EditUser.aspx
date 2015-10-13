<%@ Page Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="regform.UserProfile.EditUser" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="styles" >
    <link type="text/css" rel="stylesheet" href="../Content/RegistationForm.css" />
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="RegField">
    <asp:ObjectDataSource ID="dsUsers" runat="server" DataObjectTypeName="CodeFirst.User" TypeName="managerDll.UserManager"
        SelectMethod="GetById" UpdateMethod="Update">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="uid" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
    <asp:FormView runat="server" ID="fvEditUser" DataSourceID="dsUsers" DataKeyNames="Id" DefaultMode="Edit" >
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
    
         
     <div class="row buttons">
           <asp:Button ID="btnSave" CommandName="Update" Text="Save"  runat="server" OnClick="btnSave_Click"/>
         <asp:Button ID="btcCancel" runat="server" Text="Cancel" OnClick="btcCancel_Click" />
     </div>
</div>
            </EditItemTemplate>
        </asp:FormView>
</asp:Content>