<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="regform.Error.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../Content/Error.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="text">
        <p class="text" id="title">Error:<asp:Label runat="server" ID="ErrorCode" CssClass="text" Text=""/></p>
        <p>The reason for this error may be: curved hands programmer or user
        , problems with the Internet, nuclear disaster, zombie apocalypse, or alien invasion.
        But now it does not matter anyway because everything broke.</p>
        <p>You do not even decide if you call to prezident.Solve the problem may only administrator.</p>
        For beauty here are some unimportant codes:<br />
        0x0000003A<br />
        0x0000003B<br />
        0x0000003C<br />
        0x0000003D<br />
        0x0000003E<br />
        0x0000003F<br />
        0x00000040<br />
        0x00000041<br />
        <p>Okay, enough jokes your realy problem is:<asp:Label runat="server" ID="lblWhat" Text=""/></p>
        <p>It could be due to:<asp:Label runat="server" ID="lblWhy" Text="" /></p>
        <p>This problem can be solved if:<asp:Label runat="server" ID="lblSuggestion" Text=""/></p>
        <p>If the problem persists please let the site administrator!!!</p>
        <p>Go to:<a class="text" href="../DriverProfile/ListPage.aspx">Home Page</a></p>
    </div>
    </form>
</body>
</html>
