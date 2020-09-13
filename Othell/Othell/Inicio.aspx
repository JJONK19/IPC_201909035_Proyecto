<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Othell.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 653px;
            height: 626px;
            position: absolute;
            top: 7px;
            left: 495px;
            z-index: 1;
        }
        .auto-style2 {
            margin-left: 200px;
            font-family:Impact, Haettenschweiler, 'Arial Narrow Bold', sans-serif;
             font-size: medium;
        }
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            </div>
        <div class="auto-style2">
            OTHELLO</div>
        <p>
            <asp:Button ID="Button2" runat="server" BackColor="#99FF33" CssClass="auto-style3" Font-Bold="True" Font-Italic="True" Text="Registrate" OnClick="Button2_Click" />
        </p>
        <asp:Button ID="Button1" runat="server" BackColor="#99FF33" CssClass="auto-style4" Font-Bold="True" Font-Italic="True" Text="Log In" OnClick="Button1_Click" />
    </form>
</body>
</html>
