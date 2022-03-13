<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="Bakara2_32._8_File_Upload.Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="GÖNDER" OnClick="Button1_Click" Height="22px" Width="107px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
