<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="label_hello" Text="hello world" />
        <asp:TextBox runat="server" ID="NameText" />
        <asp:Button runat="server" Text="ClickME" OnClick="Unnamed_Click" />
    </div>
    </form>
    
</body>
</html>
