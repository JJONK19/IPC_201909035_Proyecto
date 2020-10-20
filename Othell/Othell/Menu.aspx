<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Othell.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 480px;
        }
        .auto-style2 {
            height: 26px;
            position: absolute;
            left: 390px;
            top: 157px;
            background-color: #99FF33;
        }
        .auto-style3 {
            height: 26px;
            position: absolute;
            left: 393px;
            top: 216px;
            background-color: #99FF33;
        }
         .auto-style4 {
            height: 26px;
            position: absolute;
            left: 393px;
            top: 275px;
            background-color: #99FF33;
            right: 406px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
            MENÚ</p>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="Partida  vs.  Maquina" Width="279px" />
        <p>
        <asp:Button ID="Button2" runat="server" CssClass="auto-style2" OnClick="Button2_Click" Text="Partida  vs.  Jugador" Width="279px" />
        <asp:Button ID="Button3" runat="server" CssClass="auto-style4" OnClick="Button3_Click" Text="Modo Xtreme" Width="279px" />
        </p>
    </form>
</body>
</html>
