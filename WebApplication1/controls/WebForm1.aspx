<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="controls.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView runat="server" ID="DayCloseGridView" ></asp:GridView>
        <asp:Label runat="server" ID="lblInfo" Text="Day Open" />
        <asp:Button runat="server" OnClick="Unnamed_Click" Text="Close Day" />
         <asp:Button  runat="server" OnClick="Unnamed_Click2" Text="Open Day" />
        <asp:ScriptManager id="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel runat="server" ID="updatePanel">
            <ContentTemplate>
                <asp:GridView runat="server" ID="during_the_day" ></asp:GridView>
                <asp:Label runat="server" Text="ID" />
                <asp:TextBox runat="server" ID="id" />
                <asp:Label runat="server" Text="Name" />
                <asp:TextBox runat="server" ID="name" />
                <asp:Button runat="server" ID="btnAdd" OnClick="Unnamed_Click1" Text="Add"/>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
