<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculater.aspx.cs" Inherits="calculater30_11.calculater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Sumation" OnClick="Button1_Click" />
             <asp:Button ID="Button2" runat="server" Text="Subtract" OnClick="Button2_Click" />
           <asp:Button ID="Button3" runat="server" Text="Multiple" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Divide" OnClick="Button4_Click" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </form>
</body>
</html>
