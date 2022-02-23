<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Baglanti.aspx.cs" Inherits="Bakara2_32._7_Veritabani_Islemleri.Baglanti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" method="post" runat="server">
        <div>
            
            <asp:TextBox ID="TextBox1" runat="server" placeholder="İsminde geçen harflere göre filtrele" Width="265px"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Getir" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            VeriTabanı Ekleme İşlemleri<br />
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Adı Giriniz"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" placeholder="SoyAdı Giriniz"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" placeholder="Meslek Giriniz"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" placeholder="Yaş Giriniz"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
            <br />
        </div>
    </form>
    
</body>
</html>
