<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Othell.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 223px;
            height: 26px;
            position: absolute;
            left: 137px;
            top: 344px;
        }
        .auto-style4 {
            width: 223px;
            height: 26px;
            position: absolute;
            left: 135px;
            top: 382px;
        }
        .auto-style5 {
            width: 207px;
            height: 22px;
            position: absolute;
            left: 140px;
            top: 296px;
        }
        .auto-style6 {
            width: 207px;
            height: 22px;
            position: absolute;
            left: 141px;
            top: 253px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
      
        <asp:Button ID="Button2" runat="server" BackColor="#99FF33" CssClass="auto-style3" Font-Bold="True" Font-Italic="True" Text="Registrate" OnClick="Button2_Click" />
       
        <asp:Button ID="Button1" runat="server" BackColor="#99FF33" CssClass="auto-style4" Font-Bold="True" Font-Italic="True" Text="Log In" OnClick="Button1_Click" />
        
        
        <p>
            &nbsp;</p>
        <p>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style6"></asp:TextBox>
      
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style5" TextMode="Password"></asp:TextBox>
      
        </p>
        
        
    </form>
</body>
</html>
