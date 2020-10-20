<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Intermedio - X.aspx.cs" Inherits="Othell.Intermedio___X" %>

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
            top: 49px;
        }

        .auto-style88 {
            width: 405px;
            height: 37px;
            position: absolute;
            text-align: center;
            text-decoration: underline;
            left: 480px;
            top: 99px;
        }

        .auto-style89 {
            width: 204px;
            height: 26px;
            position: absolute;
            left: 580px;
            top: 600px;
        }
         .auto-style92 {
            width: 150px;
            height: 26px;
            position: absolute;
            left: 480px;
            top: 150px;
            text-align:center;
        }
          .auto-style93 {
            width: 150px;
            height: 26px;
            position: absolute;
            left: 480px;
            top: 190px;
            text-align:center;
        }

        .auto-style94 {
            width: 225px;
            height: 26px;
            position: absolute;
            left: 620px;
            top: 170px;
            text-align:center;
            font-family: 'Arial Narrow';
        }

        .auto-style95 {
            width: 225px;
            height: 26px;
            position: absolute;
            left: 620px;
            top: 210px;
            text-align:center;
            font-family: 'Arial Narrow';
        }
        .auto-style96 {
            width: 405px;
            height: 37px;
            position: absolute;
            text-align: center;
            text-decoration: underline;
            left: 480px;
            top: 240px;
        }
         .auto-style97 {
            width: 150px;
            height: 26px;
            position: absolute;
            left: 480px;
            top: 290px;
            text-align:center;
            font-family: 'Arial Narrow';
        }

         .auto-style98 {
            width: 405px;
            height: 37px;
            position: absolute;
            text-align: center;
            text-decoration: underline;
            left: 480px;
            top: 330px;
        }
        .auto-style99 {
            width: 112px;
            height: 29px;
            position: absolute;
            left: 710px;
            top: 310px;
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
            <h2 class="auto-style88">Tamaño del Tablero</h2>
             <h2 class="auto-style96">Reto Inverso</h2>
            <h2 class="auto-style98">Colores</h2>
            <h3 class="auto-style92">Filas:</h3>
            <h3 class="auto-style97">Activado:</h3>
            <h3 class="auto-style93">Columnas:</h3>
            <h1 class="auto-style87">DETALLES DE LA PARTIDA</h1>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style89" Text="Comenzar Partida" BackColor="Black" BorderColor="Black" Font-Italic="True" Font-Names="Arial Narrow" ForeColor="White" OnClick="Button1_Click" />
            <asp:TextBox ID="Box1" runat="server" CssClass="auto-style94" BackColor="#006B3C"></asp:TextBox>
            <asp:TextBox ID="Box2" runat="server" CssClass="auto-style95" BackColor="#006B3C" OnTextChanged="Box2_TextChanged"></asp:TextBox>
            <asp:CheckBox ID="Check" runat="server" CssClass="auto-style99" OnCheckedChanged="CheckBox1_CheckedChanged" />
        </asp:Panel>
    </form>
</body>
</html>
