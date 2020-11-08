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
        .auto-style5 {
            height: 26px;
            position: absolute;
            left: 392px;
            top: 335px;
            background-color: #99FF33;
            right: 407px;
        }
        .auto-style6 {
            height: 26px;
            position: absolute;
            left: 393px;
            top: 393px;
            background-color: #99FF33;
            right: 406px;
        }
        .auto-style7 {
            height: 26px;
            position: absolute;
            left: 395px;
            top: 450px;
            background-color: #99FF33;
            right: 404px;
        }
        .auto-style10 {
            height: 26px;
            position: absolute;
            left: 397px;
            top: 497px;
            background-color: #99FF33;
            right: 402px;
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
        <asp:Button ID="Button3" runat="server" CssClass="auto-style6" OnClick="Button8_Click" Text="Campeonato" Width="279px" />
        </p>
        <p>
        <asp:Button ID="Button4" runat="server" CssClass="auto-style4" OnClick="Button3_Click" Text="Modo Xtreme" Width="279px" />
        <asp:Button ID="Button5" runat="server" CssClass="auto-style5" OnClick="Button4_Click" Text="Modo Xtreme - Maquina" Width="279px" />
        <asp:Button ID="Button7" runat="server" CssClass="auto-style7" OnClick="Button6_Click" Text="Perfil" Width="279px" />
        </p>
        <p>
        <asp:Button ID="Button8" runat="server" CssClass="auto-style10" OnClick="Button7_Click" Text="Salida" Width="279px" />
        </p>
    </form>
</body>
</html>
