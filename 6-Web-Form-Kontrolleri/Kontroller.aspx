<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kontroller.aspx.cs" UnobtrusiveValidationMode="None" Inherits="Bakara2_32._6_Web_Form_Kontrolleri.Kontroller" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    
    <script runat="server">
        void yaz(Object Sender,EventArgs E)
        {
            Response.Write(Text1.Value);
        }
    </script>
    
    <form id="form1" runat="server">
        <div>
            <h2>HTML SUNUCU KONTROLLERİ</h2>
            <p>
                <input id="Text1" type="text" runat="server" />
                <input id="Button1" type="submit" value="button"  OnClick="yaz1"  runat="server" onserverclick="yaz" />
                Burada HTML Olan Konrolleri Server'da Çalıştırdık ve Yazdığımız bir Scripti Sunucu Taraflı Çalıştırdık.
            </p>
            <h2>WEB SUNUCU KONTROLLERİ</h2>
            <asp:CheckBoxList ID="secenek_listesi" runat="server" CellPadding="5" CellSpacing="5">
                <asp:ListItem>kitap</asp:ListItem>
                <asp:ListItem>CD</asp:ListItem>
                <asp:ListItem>Poster</asp:ListItem>
                <asp:ListItem>Bilgisayar</asp:ListItem>
                <asp:ListItem>DVD</asp:ListItem>
            </asp:CheckBoxList><br /><br />
            CheckBox Olayında hangisi iş yapacaksa değişim için Mutlaka AutoPostBack="true" yazılmalıdır özelliklerine<br />
            <asp:CheckBox ID="t_gorun" runat="server" Text="Seçenekleri Tablo Halinde Göster" AutoPostBack="true" OnCheckedChanged="t_gorun_CheckedChanged" /><br />
            <asp:CheckBox ID="y_gorun" runat="server" Text="Yatay Göster" OnCheckedChanged="y_gorun_CheckedChanged" AutoPostBack="true" /><br />
            <asp:Button ID="s_yaz" runat="server" Text="Seçilenleri Yaz" OnClick="s_yaz_Click" /><br /><br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br />

            60-100 Arası Bir Sayı Giriniz:<asp:TextBox ID="sayiGirisi" runat="server"></asp:TextBox><br /><br />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="sayiGirisi" ErrorMessage="Boş Geçme"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" ControlToValidate="sayiGirisi" MaximumValue="100" MinimumValue="60" Type="Integer" runat="server" ErrorMessage="60-100 Arası Gir"></asp:RangeValidator>
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        </div>
    </form>
    <script>
        function yaz1() {
            prompt("Bu Client Taraflı bir mesaj.");
            document.write("Merhaba");
        }
    </script>
</body>
</html>
