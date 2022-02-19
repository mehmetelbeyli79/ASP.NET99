<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrossPage.aspx.cs" Inherits="Bakara2_32._3_Cross_Page_Posting.CrossPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cross Page Örneği</title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <?-- TextBox'daki veriyi Diğer Sayfaya kullanması için atıyoruz. -->
            <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
            <asp:Button ID="cmdPost" runat="server" Text="Diğer Sayfaya Veri Aktar" PostBackUrl="~/3-Cross-Page-Posting/CrossPage2.aspx" />
        </div>
    </form>
</body>
</html>
