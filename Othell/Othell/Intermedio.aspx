<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Intermedio.aspx.cs" Inherits="Othell.Intermedio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <style>
    .auto-style86 {
        display:block;
        margin-left: auto;
        margin-right: auto;
        vertical-align:central;
        width: 405px;
        border: 5px solid Black;
       height: 625px;
        }

        .auto-style87 {
            width: 405px;
            height: 37px;
            position: absolute;
            text-align:center;
            text-decoration:underline;
            left: 480px;
            top: 99px;
        }

        .auto-style88 {
            width: 405px;
            height: 37px;
            position: absolute;
            text-align: center;
            text-decoration: underline;
            left: 480px;
            top: 168px;
        }

        .auto-style89 {
            width: 204px;
            height: 26px;
            position: absolute;
            left: 580px;
            top: 285px;
        }
        .auto-style90 {
            width: 204px;
            height: 26px;
            position: absolute;
            left: 580px;
            top: 385px;
        }
        .auto-style91 {
            width: 204px;
            height: 26px;
            position: absolute;
            left: 580px;
            top: 485px;
        }

    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel2" runat="server" style="font-style: italic; font-family: 'Arial Narrow'; font-weight: 700; background-color: #006B3C" CssClass="auto-style86" BackColor="#006B3C">
            <br />
            <br />
            <br />
            <br />
            <br />
            <h2 class="auto-style88">Color del Usuario</h2>
            <h1 class="auto-style87">SELECCIÓN DE FICHAS</h1>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style90" OnClick="Button1_Click" Text="Blancas" BackColor="White" BorderColor="White" Font-Italic="True" Font-Names="Arial Narrow" />
            <asp:Button ID="Button2" runat="server" CssClass="auto-style89" Text="Negras" BackColor="Black" BorderColor="Black" Font-Italic="True" Font-Names="Arial Narrow" ForeColor="White" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" CssClass="auto-style91" Text="No Importa" BackColor="#006B3C" BorderColor="#009933" Font-Italic="True" Font-Names="Arial Narrow" OnClick="Button3_Click" />
        </asp:Panel>
    </form>
</body>
</html>
