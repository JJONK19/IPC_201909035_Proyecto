<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Intermedio - Torneo.aspx.cs" Inherits="Othell.Intermedio___Torneo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

    .auto-style86 {
        display:block;
        margin-left: auto;
        margin-right: auto;
        vertical-align:central;
        width: 405px;
        border: 5px solid Black;
       height: 900px;
        }

        .auto-style87 {
            width: 405px;
            height: 37px;
            position: absolute;
            text-align:center;
            text-decoration:underline;
            left: 371px;
            top: 28px;
        }

        .auto-style112 {
            width: 405px;
            height: 37px;
            position: absolute;
            text-align: center;
            text-decoration: underline;
            left: 373px;
            top: 91px;
        }
        
        .auto-style89 {
            width: 357px;
            height: 26px;
            position: absolute;
            left: 398px;
            top: 206px;
            margin-top: 0px;
        }
         .auto-style92 {
            width: 409px;
            height: 26px;
            position: absolute;
            left: 373px;
            top: 152px;
            text-align:center;
        }
          .auto-style82 {
        z-index: 1;
        left: 390px;
        top: 260px;
        position: absolute;
        height: 29px;
        width: 375px;
 }
        .auto-style113 {
            width: 1151px;
        }
        </style>
</head>
<body style="margin-left: 328px; width: 740px; height: 330px; position: absolute; left: -320px; top: 1px;">
    <form id="form1" runat="server" class="auto-style113">
        
        <asp:Panel ID="Panel2" runat="server" style="font-style: italic; font-family: 'Arial Narrow'; font-weight: 700; background-color: #006B3C" CssClass="auto-style86" BackColor="#006B3C" Height="320px">
            <br />
            <br />
            <br />
            <br />
            <br />
            <h1 class="auto-style87">TORNEO</h1>
            <h2 class="auto-style112">Detalles del Torneo</h2>
            <asp:FileUpload ID="Subir" runat="server" accept=".xml" BackColor="Black" BorderColor="Black" CssClass="auto-style89" style="font-style: italic; font-family: 'Arial Narrow'; font-weight: 700; background-color: #006B3C" />
            <h3 class="auto-style92">Seleccionar Archivo</h3>
            <asp:Button ID="Button2" runat="server" BackColor="Black" BorderColor="Black" CssClass="auto-style82" Font-Italic="True" ForeColor="White" OnClick="Button1_Click1" Text="Generar Torneo" />
        </asp:Panel>
        
    </form>
</body>
</html>
