<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculater.aspx.cs" Inherits="_30_11_2022.calculater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="input"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="input"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="result"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
<p style="height: 38px; width: 1179px">
            <asp:Button ID="sum" runat="server" OnClick="Button1_Click" Text="+" Height="32px" Width="32px" />
&nbsp;
            <asp:Button ID="sub" runat="server" Text="-" Height="33px" Width="34px" OnClick="sub_Click" />
&nbsp;
            <asp:Button ID="multi" runat="server" Text="*" Height="32px" Width="34px" OnClick="multi_Click" />
&nbsp;
            <asp:Button ID="divid" runat="server" Text="÷" Height="32px" Width="35px" OnClick="divid_Click" />
        </p>
    </form>
</body>
</html>
