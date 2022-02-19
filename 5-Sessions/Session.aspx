<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="Bakara2_32._5_Sessions.Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" PostBackUrl="~/5-Sessions/Session_kullan.aspx" runat="server" Text="Session Oluştur" OnClick="Button1_Click" />
        </div>
        
    </form>
</body>
</html>
