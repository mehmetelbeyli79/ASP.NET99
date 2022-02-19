<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ornek1.aspx.cs" Inherits="Bakara2_32.Ornek1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <?-- Bu Örnekte PostBack Nasıl yapılır ve Sunucu Cevabı Konuları İşlendi -->
            <asp:Label ID="ad" runat="server" Text="Label"></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
