<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tablero - V.Dinamico.aspx.cs" Inherits="Othell.Tablero___V_Dinamico" %>

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
        background-color: #83CC70;
        text-align: center;
        
    }

td, tr{
    width: 66px;
    height: 66px;

}

.but{
    border-radius: 80%;
    width: 60px;
    height: 60px;
    border-color:#83CC70;
    background-color:#83CC70;
}
</style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="tablero" runat="server" CssClass ="tab">
        </asp:Table>
    </form>
</body>
</html>
