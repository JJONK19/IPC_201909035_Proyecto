﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tablero - V.Dinamico.aspx.cs" Inherits="Othell.Tablero___V_Dinamico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<style type="text/css">
.tab {
        width: 580px;
        z-index: 1;
        left: 510px;
        top: 33px;
        position: absolute;
        height: 580px;
        right: -10px;
        background-color: #006B3C;
        text-align: center;
        border: 5px solid Black;
    }

td, tr{
    width: 66px;
    height: 66px;

}

.but{
    border-radius: 80%;
    width: 60px;
    height: 60px;
    border-color:#006B3C;
    background-color:#006B3C;
}

.auto-style86 {
        position: absolute;
        left: 17px;
        top: 16px;
        width: 405px;
    }
.auto-style82 {
        z-index: 1;
        left: 60px;
        top: 530px;
        position: absolute;
        height: 29px;
        width: 280px;
 }
.auto-style83 {
        z-index: 1;
        left: 61px;
        top: 577px;
        position: absolute;
        height: 29px;
        width: 280px;
        bottom: 30px;
}
</style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="tablero" runat="server" Border CssClass ="tab">
        </asp:Table>
        <asp:Panel ID="Panel2" runat="server" Height="636px" style="font-style: italic; font-family: 'Arial Narrow'; font-weight: 700; background-color: #83CC70" CssClass="auto-style86">
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; RESUMEN DE PARTIDA<br />
                <asp:Button ID="Button2" runat="server" BackColor="Black" BorderColor="Black" Font-Italic="True" ForeColor="White" Text="Guardar Partida" CssClass="auto-style83" OnClick="Button2_Click" />
                <asp:Button ID="Button1" runat="server" BackColor="Black" BorderColor="Black" Font-Italic="True" ForeColor="White" Text="Cargar Partida" OnClick="Button1_Click1" CssClass="auto-style82" />
                
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Direccion Archivo:<asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style84" style="width: 280px; height: 22px; font-style: italic; font-family: 'Arial Narrow'; font-weight: 700; position: absolute; top: 474px; left: 58px; background-color: #83CC70"></asp:TextBox>
                
            </asp:Panel>
    </form>
</body>
</html>
