<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="AccessData.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="256px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="540px"></asp:ListBox>
    </form>
</body>
</html>
