<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webpage.aspx.cs" Inherits="AbetsprovEnkelLosning.Webpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        Meddelanden från Consolen:<br />
        <br />
        <asp:ListBox ID="ListBoxMessanges" runat="server" Height="226px" OnSelectedIndexChanged="ListBoxMessanges_SelectedIndexChanged" Width="396px"></asp:ListBox>
        <br />
        <asp:Button ID="ButtonGetMessanges" runat="server" OnClick="ButtonGetMessanges_Click" Text="Hämta/Uppdatera" />
    </form>
</body>
</html>
