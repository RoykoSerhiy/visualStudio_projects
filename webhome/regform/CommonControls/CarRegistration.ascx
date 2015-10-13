<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CarRegistration.ascx.cs" Inherits="regform.CommonControls.CarRegistration" %>

<div class="regConteiner"> 
 <div class="row">
             <div class="title">Car brand:</div> 
             <div class="inputData">
                 <asp:TextBox runat="server" ID="txtCarBrand"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" CssClass="error" runat="server" ControlToValidate="txtCarBrand" Text="" ErrorMessage="Car brand should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
              </div>
         </div>
         <div class="row">
             <div class="title">Car model:</div> 
             <div class="inputData">
                 <asp:TextBox runat="server" ID="txtCarModel"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator7" CssClass="error" runat="server" ControlToValidate="txtCarModel" Text="" ErrorMessage="Car model should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
              </div>
         </div>
         <div class="row">
             <div class="title">Extent engine:</div> 
             <div class="inputData">
                 <asp:TextBox runat="server" ID="txtExtent_engine"></asp:TextBox><span>L</span>
                 <asp:RangeValidator ID="RangeValidator2" CssClass="error" runat="server" ControlToValidate="txtExtent_engine" ErrorMessage="Value is out of range" MinimumValue="1,0" MaximumValue="6,0" Type="Double" Display="Dynamic"></asp:RangeValidator>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator8" CssClass="error" runat="server" ControlToValidate="txtExtent_engine" Text="" ErrorMessage="Extent engine should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
              </div>
         </div>
         <div class="row">
             <div class="title">Body Type:</div> 
             <div class="inputData">
                 <asp:DropDownList runat="server" ID="ddlBody_type"></asp:DropDownList>     
             </div>
         </div>
         <div class="row">
             <div class="title">Amount of trunk:</div> 
             <div class="inputData">
                 <asp:TextBox runat="server" ID="txtAmount_of_trunk"></asp:TextBox><span>L</span>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator9" CssClass="error" runat="server" ControlToValidate="txtAmount_of_trunk" Text="" ErrorMessage="Amount of trunk should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
              </div>
         </div>
         <div class="row">
             <div class="title">Passenger seats:</div> 
             <div class="inputData">
                 <asp:TextBox runat="server" TextMode="Number" Text="1" ID="txtPassenger_seats"></asp:TextBox><span>seats</span>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator10" CssClass="error" runat="server" ControlToValidate="txtPassenger_seats" Text="" ErrorMessage="The number of passenger seats should be not empty" Display="Dynamic"></asp:RequiredFieldValidator>
                 <asp:RangeValidator ID="RangeValidator3" CssClass="error" runat="server" ControlToValidate="txtPassenger_seats" ErrorMessage="Value is out of range" MinimumValue="1" MaximumValue="20" Type="Integer" Display="Dynamic"></asp:RangeValidator> 
             </div>
         </div>
    </div>