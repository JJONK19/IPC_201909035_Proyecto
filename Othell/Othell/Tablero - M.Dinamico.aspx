﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tablero - M.Dinamico.aspx.cs" Inherits="Othell.Tablero___M_Dinamico" %>

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
        height: 600px;
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
        border: 5px solid Black;
    }
.auto-style82 {
        z-index: 1;
        left: 65px;
        top: 483px;
        position: absolute;
        height: 29px;
        width: 280px;
 }
.auto-style83 {
        z-index: 1;
        left: 64px;
        top: 526px;
        position: absolute;
        height: 29px;
        width: 280px;
        bottom: 81px;
}
    
    .auto-style89 {
        width: 280px;
        height: 22px;
        position: absolute;
        left: 69px;
        top: 440px;
        right: 56px;
    }
    .auto-style90 {
        width: 150px;
        height: 22px;
        position: absolute;
        left: 218px;
        top: 137px;
        text-align: center;
        
    }
    
    .auto-style92 {
        width: 402px;
        height: 22px;
        position: absolute;
        left: 1px;
        top: 401px;
        text-align: center;
    }
    .auto-style93 {
        width: 150px;
        height: 22px;
        position: absolute;
        left: 36px;
        top: 306px;
        text-align:center;
    }
    .auto-style94 {
        width: 150px;
        height: 22px;
        position: absolute;
        left: 36px;
        top: 255px;
        text-align:center;
    }
    .auto-style95 {
        width: 150px;
        height: 22px;
        position: absolute;
        left: 38px;
        top: 123px;
        text-align:center;
    }
    .auto-style96 {
        width: 403px;
        height: 37px;
        position: absolute;
        left: -1px;
        top: 56px;
        text-align:center;
    }
    .auto-style97 {
        width: 405px;
        height: 22px;
        position: absolute;
        left: 1px;
        top: 200px;
        text-align:center;
        text-decoration:underline;
    }
    .auto-style98 {
        width: 150px;
        height: 22px;
        position: absolute;
        left: 218px;
        top: 266px;
        text-align: center;
    }
    .auto-style99 {
        width: 150px;
        height: 22px;
        position: absolute;
        left: 218px;
        top: 319px;
        text-align: center;
    }
</style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="tablero" runat="server" Border CssClass ="tab">
        </asp:Table>
        <asp:Panel ID="Panel2" runat="server" Height="636px" style="font-style: italic; font-family: 'Arial Narrow'; font-weight: 700; background-color: #006B3C" CssClass="auto-style86">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <h1 class="auto-style96">RESUMEN DE PARTIDA</h1><br />
                <asp:Button ID="Button2" runat="server" BackColor="Black" BorderColor="Black" Font-Italic="True" ForeColor="White" Text="Guardar Partida" CssClass="auto-style83" OnClick="Button2_Click" />
                <asp:Button ID="Button1" runat="server" BackColor="Black" BorderColor="Black" Font-Italic="True" ForeColor="White" Text="Cargar Partida" OnClick="Button1_Click1" CssClass="auto-style82" />
                <asp:FileUpload ID="Subir" runat="server" BackColor="Black" BorderColor="Black" CssClass="auto-style89" style="font-style: italic; font-family: 'Arial Narrow'; font-weight: 700; background-color: #006B3C" accept= ".xml" />

                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:TextBox ID="Turno" runat="server" CssClass="auto-style90" ReadOnly="True" style="font-style: italic; font-family: 'Arial Narrow'; font-weight: 700; background-color: #006B3C"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:TextBox ID="Negras" runat="server" CssClass="auto-style99" ReadOnly="True" style="font-style: italic; font-family: 'Arial Narrow'; font-weight: 700; background-color: #006B3C"></asp:TextBox>
                <h3 class="auto-style95">Turno</h3>
            <br />
            <br />
            <h2 class="auto-style97">Fichas</h2>
            <br />
            <br />
            <asp:TextBox ID="Blancas" runat="server" CssClass="auto-style98"  ReadOnly="True" style="font-style: italic; font-family: 'Arial Narrow'; font-weight: 700; background-color: #006B3C"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<h3 class="auto-style93">NEGRAS</h3>
            <h3 class="auto-style94">BLANCAS</h3>
            <h3 class="auto-style92">Seleccionar Archivo</h3>
        </asp:Panel>
        <asp:Button ID="Button3" runat="server" CssClass="auto-style88" Text="Salir" BackColor="Black" BorderColor="Black" ForeColor="White" Font-Italic="True" OnClick="Button3_Click" style="width: 280px; height: 26px; position: absolute; left: 87px; top: 589px" />
    </form>
</body>
</html>
