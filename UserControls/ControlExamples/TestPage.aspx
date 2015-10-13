<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="ControlExamples.TestPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Страница с использованием Аякса</title>
    <style type="text/css">
        .white {
            background-color: none;
        }

        .headerRow {
            background-color: #bebebe;
        }

        .footerText {
            font-weight: 700;
        }

        .blue {
            background-color: #ddf8ed;
        }

        #repContainer {
            margin: 0 auto;
            max-width: 400px;
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="sm" EnablePageMethods="true" runat="server"></asp:ScriptManager>
        <div>
            <%----%>
            <ajaxtoolkit:AutoCompleteExtender runat="server"
                id="myautocomplete"
                TargetControlID="autocomplete"
                ServiceMethod="GetCompletionList"
                MinimumPrefixLength="2"
                CompletionInterval="1000"
                Enabled="true"
                ServicePath="WebService.asmx"
                >
            </ajaxtoolkit:AutoCompleteExtender>
            <asp:TextBox runat="server" ID="autocomplete"></asp:TextBox>
            <span>My dynamic grid application(sort of)</span>
            <br />
            <asp:DropDownList ID="drop1" runat="server" OnSelectedIndexChanged="drop1_TextChanged" AutoPostBack="true"></asp:DropDownList>
            <br />
            <asp:Label ID="lblCheck" runat="server" Text="" Visible="false"></asp:Label>
            <br />
            <asp:GridView ID="mygrid" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Name" DataField="Name" />
                    <asp:CheckBoxField HeaderText="HW Status" DataField="DoneHomeWork" />
                </Columns>
            </asp:GridView>
            <%--ServicePath="AutoComplete.asmx"--%>
            
            <div id="repContainer">
                <asp:Repeater ID="repeater" runat="server">
                    <FooterTemplate>
                        <span class="footerText">Some footer content
                        </span>
                    </FooterTemplate>
                    <HeaderTemplate>
                        <div class="headerRow">
                            Sudent list
                        </div>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="row white">
                            <span runat="server" class="header">Id: <%#Eval("Id") %></span>
                            <span runat="server" class="header">Name: <%#Eval("Name") %></span>

                        </div>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <div class="row blue">
                            <span runat="server" class="header">Id: <%#Eval("Id") %></span>
                            <span runat="server" class="header">Name: <%#Eval("Name") %></span>

                        </div>
                    </AlternatingItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
