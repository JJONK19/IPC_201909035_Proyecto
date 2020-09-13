<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tablero.aspx.cs" Inherits="Othell.Tablero" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

<style type="text/css">
  
   p {color:blue;}
   .button{
       border-radius: 1%;
   }
    .nuevoEstilo1 {
        font-family: "Arial Narrow";
        font-size: medium;
        text-decoration: underline;
        color: #000000;
        font-style: italic;
    }

    .nuevoEstilo2 {
        border-radius: 50%;
    }
    th{
        border: 3px solid black;
    }
    td{
        border: 3px solid black;
    }
    .auto-style5 {
        width: 580px;
        z-index: 1;
        left: 510px;
        top: 33px;
        position: absolute;
        height: 580px;
        right: -10px;
        background-color: #83CC70;
    }
    .auto-style7 {
        width: 66px;
        height: 66px;
   
   
    }
    .auto-style8 {
        width: 70px;
        height: 66px;
      
    }
    .auto-style12 {
        z-index: 1;
        left: 75px;
        top: 5px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
        right: 437px;
    }
    .auto-style13 {
        border-radius: 50%;
        z-index: 1;
        left: 5px;
        top: 75px;
        position: absolute;
        border-radius: 50%;
        right: 507px;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style14 {
        z-index: 1;
        left: 5px;
        top: 148px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
        }
    .auto-style15 {
        z-index: 1;
        left: 5px;
        top: 219px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
        }
    .auto-style16 {
        z-index: 1;
        left: 5px;
        top: 292px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;

        }
    .auto-style17 {
        z-index: 1;
        left: 5px;
        top: 364px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style19 {
        z-index: 1;
        left: 5px;
        top: 436px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style20 {
        z-index: 1;
        left: 5px;
        top: 508px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    
    .auto-style21 {
        z-index: 1;
        left: 75px;
        top: 75px;
        position: absolute;
        right: 70px;
        bottom: 437px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style22 {
        z-index: 1;
        left: 75px;
        top: 148px;
        position: absolute;
        right: 437px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style23 {
        z-index: 1;
        left: 75px;
        top: 219px;
        position: absolute;
        right: 70px;
        bottom: 293px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style24 {
        z-index: 1;
        left: 75px;
        top: 292px;
        position: absolute;
        right: 437px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style25 {
        z-index: 1;
        left: 75px;
        top: 364px;
        position: absolute;
        right: 70px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style26 {
        z-index: 1;
        left: 75px;
        top: 436px;
        position: absolute;
        right: 70px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style27 {
        z-index: 1;
        left: 75px;
        top: 508px;
        position: absolute;
        right: 70px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style28 {
        z-index: 1;
        left: 145px;
        top: 5px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style29 {
        z-index: 1;
        left: 145px;
        top: 75px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
        right: 367px;
    }
    .auto-style30 {
        z-index: 1;
        left: 145px;
        top: 148px;
        position: absolute;
        right: 140px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style31 {
        z-index: 1;
        left: 145px;
        top: 219px;
        position: absolute;
        right: 140px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style32 {
        z-index: 1;
        left: 145px;
        top: 292px;
        position: absolute;
        right: 364px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style33 {
        z-index: 1;
        left: 145px;
        top: 364px;
        position: absolute;
        right: 367px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style34 {
        z-index: 1;
        left: 145px;
        top: 436px;
        position: absolute;
        right: 140px;
        border-radius: 50%;
        bottom: 76px;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style35 {
        z-index: 1;
        left: 145px;
        top: 508px;
        position: absolute;
        right: 140px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style36 {
        z-index: 1;
        left: 218px;
        top: 5px;
        position: absolute;
        right: 210px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style37 {
        z-index: 1;
        left: 288px;
        top: 4px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style38 {
        z-index: 1;
        left: 359px;
        top: 5px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
        right: 153px;
    }
    .auto-style39 {
        z-index: 1;
        left: 432px;
        top: 5px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style40 {
        z-index: 1;
        left: 507px;
        top: 5px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style41 {
        z-index: 1;
        left: 218px;
        top: 75px;
        position: absolute;
        right: 210px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style42 {
        z-index: 1;
        left: 288px;
        top: 75px;
        position: absolute;
        right: 224px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style43 {
        z-index: 1;
        left: 359px;
        top: 75px;
        position: absolute;
        right: 153px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    #FileLoader1{
        display:none;
    }
    .auto-style44 {
        z-index: 1;
        left: 432px;
        top: 75px;
        position: absolute;
        right: 420px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style45 {
        z-index: 1;
        left: 507px;
        top: 75px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style46 {
        z-index: 1;
        left: 218px;
        top: 148px;
        position: absolute;
        right: 210px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style47 {
        z-index: 1;
        left: 288px;
        top: 148px;
        position: absolute;
        right: 280px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style48 {
        z-index: 1;
        left: 359px;
        top: 148px;
        position: absolute;
        right: 350px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style49 {
        z-index: 1;
        left: 432px;
        top: 148px;
        position: absolute;
        right: 420px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style50 {
        z-index: 1;
        left: 507px;
        top: 148px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style51 {
        z-index: 1;
        left: 218px;
        top: 219px;
        position: absolute;
        right: 210px;
        bottom: 293px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#FFFFFF;
    }
    .auto-style52 {
        z-index: 1;
        left: 288px;
        top: 219px;
        position: absolute;
        right: 280px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#000000;
    }
    .auto-style53 {
        z-index: 1;
        left: 359px;
        top: 219px;
        position: absolute;
        right: 350px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style54 {
        z-index: 1;
        left: 432px;
        top: 219px;
        position: absolute;
        right: 80px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style55 {
        z-index: 1;
        left: 507px;
        top: 219px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style56 {
        z-index: 1;
        left: 218px;
        top: 292px;
        position: absolute;
        right: 210px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#000000;
    }
    .auto-style57 {
        z-index: 1;
        left: 288px;
        top: 292px;
        position: absolute;
        right: 280px;
        bottom: 220px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#FFFFFF;
    }
    .auto-style58 {
        z-index: 1;
        left: 359px;
        top: 292px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style59 {
        z-index: 1;
        left: 432px;
        top: 292px;
        position: absolute;
        right: 420px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style60 {
        z-index: 1;
        left: 507px;
        top: 292px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style61 {
        z-index: 1;
        left: 218px;
        top: 364px;
        position: absolute;
        right: 210px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style62 {
        z-index: 1;
        left: 288px;
        top: 364px;
        position: absolute;
        right: 280px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style63 {
        z-index: 1;
        left: 359px;
        top: 364px;
        position: absolute;
        right: 350px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style64 {
        z-index: 1;
        left: 432px;
        top: 364px;
        position: absolute;
        right: 420px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style65 {
        z-index: 1;
        left: 507px;
        top: 364px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style66 {
        z-index: 1;
        left: 218px;
        top: 436px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style67 {
        z-index: 1;
        left: 288px;
        top: 436px;
        position: absolute;
        right: 280px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style68 {
        z-index: 1;
        left: 359px;
        top: 436px;
        position: absolute;
        right: 350px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style69 {
        z-index: 1;
        left: 432px;
        top: 436px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style70 {
        z-index: 1;
        left: 507px;
        top: 436px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style71 {
        z-index: 1;
        left: 218px;
        top: 508px;
        position: absolute;
        right: 210px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style72 {
        z-index: 1;
        left: 288px;
        top: 508px;
        position: absolute;
        right: 280px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style73 {
        z-index: 1;
        left: 359px;
        top: 508px;
        position: absolute;
        right: 350px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style74 {
        z-index: 1;
        left: 432px;
        top: 508px;
        position: absolute;
        right: 420px;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }
    .auto-style75 {
        z-index: 1;
        left: 507px;
        top: 508px;
        position: absolute;
        border-radius: 50%;
        border-color:#83CC70;
        background-color:#83CC70;
    }

    .auto-style78 {
        border-radius: 50%;
        position: absolute;
        left: 5px;
        top: 5px;
        bottom: 507px;
        right: 507px;
        border-color:#83CC70;
        background-color:#83CC70;
    }

    .auto-style79 {
        width: 580px;
        height: 31px;
        position: absolute;
        top: 622px;
        left: 512px;
        z-index: 1;
    }

    .auto-style80 {
        width: 225px;
    }
    .auto-style81 {
        width: 31px;
        height: 580px;
        position: absolute;
        top: 39px;
        left: 1099px;
        z-index: 1;
    }

    .auto-style82 {
        z-index: 1;
        left: 20px;
        top: 540px;
        position: absolute;
        height: 29px;
        width: 180px;
    }
    .auto-style83 {
        z-index: 1;
        left: 21px;
        top: 587px;
        position: absolute;
        height: 29px;
        width: 178px;
        bottom: 105px;
    }
    .auto-style84 {
        position: absolute;
        top: 505px;
        left: 23px;
        z-index: 1;
        width: 171px;
    }
    .auto-style85 {
        z-index: 1;
        left: 231px;
        top: -5px;
        position: absolute;
        height: 635px;
        width: 210px;
        right: -231px;
    }
    
    .auto-style86 {
        position: absolute;
        left: 10px;
        top: 16px;
    }
    
    </style>
    <title></title>
</head>

<body style="width: 351px; height: 640px; margin-right: 0px;">
    <form id="form1" runat="server">
        &nbsp;<asp:Panel ID="Panel1" runat="server" Height="636px" Width="209px">
            <asp:Panel ID="Panel2" runat="server" Height="636px" style="font-style: italic; font-family: 'Arial Narrow'; font-weight: 700; background-color: #83CC70" Width="210px" CssClass="auto-style86">
&nbsp;<asp:Panel ID="Panel3" runat="server" style="background-color: #000000; color: #FFFFFF; font-style: italic; " Width="210px" CssClass="auto-style85">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; JUGADAS REALIZADAS</asp:Panel>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; RESUMEN DE PARTIDA<br />
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Direccion Archivo:<asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style84"></asp:TextBox>
                
            </asp:Panel>
        </asp:Panel>
        <p>
            <table style="border-style: solid; border-width: medium; border-collapse: collapse; " class="auto-style5">
                <tr>
                    <td class="auto-style7">
            <asp:Button ID="Button75" runat="server" Height="60px" OnClick="Button75_Click" Width="60px" CssClass="auto-style12" />
            <asp:Button ID="Button77" runat="server" Height="60px" OnClick="Button77_Click" Width="60px" CssClass="auto-style13" />
            <asp:Button ID="Button78" runat="server" Height="60px" OnClick="Button78_Click" Width="60px" CssClass="auto-style14" />
            <asp:Button ID="Button79" runat="server" Height="60px" OnClick="Button79_Click" Width="60px" CssClass="auto-style15" />
            <asp:Button ID="Button85" runat="server" Height="60px" OnClick="Button85_Click" Width="60px" CssClass="auto-style22" />
                    </td>
                    <td class="auto-style7">
            <asp:Button ID="Button116" runat="server" Height="60px" OnClick="Button116_Click" Width="60px" CssClass="auto-style78" />
                    </td>
                    <td class="auto-style7">
            <asp:Button ID="Button83" runat="server" Height="60px" OnClick="Button83_Click" Width="60px" CssClass="auto-style20" />
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style7">
            <asp:Button ID="Button81" runat="server" Height="60px" OnClick="Button81_Click" Width="60px" CssClass="auto-style17" />
            <asp:Button ID="Button82" runat="server" Height="60px" OnClick="Button82_Click" Width="60px" CssClass="auto-style19" />
            <asp:Button ID="Button76" runat="server" Height="60px" OnClick="Button76_Click" Width="60px" CssClass="auto-style21" />
            <asp:Button ID="Button84" runat="server" Height="60px" OnClick="Button84_Click" Width="60px" CssClass="auto-style25" />
                    </td>
                    <td class="auto-style7">
            <asp:Button ID="Button92" runat="server" Height="60px" OnClick="Button92_Click" Width="60px" CssClass="auto-style30" />
            <asp:Button ID="Button93" runat="server" Height="60px" OnClick="Button93_Click" Width="60px" CssClass="auto-style29" />
            <asp:Button ID="Button94" runat="server" Height="60px" OnClick="Button94_Click" Width="60px" CssClass="auto-style35" />
            <asp:Button ID="Button95" runat="server" Height="60px" OnClick="Button95_Click" Width="60px" CssClass="auto-style40" />
            <asp:Button ID="Button96" runat="server" Height="60px" OnClick="Button96_Click" Width="60px" CssClass="auto-style38" />
            <asp:Button ID="Button97" runat="server" Height="60px" OnClick="Button97_Click" Width="60px" CssClass="auto-style31" />
            <asp:Button ID="Button98" runat="server" Height="60px" OnClick="Button98_Click" Width="60px" CssClass="auto-style33" />
            <asp:Button ID="Button99" runat="server" Height="60px" OnClick="Button99_Click" Width="60px" CssClass="auto-style36" />
            <asp:Button ID="Button100" runat="server" Height="60px" OnClick="Button100_Click" Width="60px" CssClass="auto-style41" />
            <asp:Button ID="Button101" runat="server" Height="60px" OnClick="Button101_Click" Width="60px" CssClass="auto-style34" />
            <asp:Button ID="Button102" runat="server" Height="60px" OnClick="Button102_Click" Width="60px" CssClass="auto-style66" />
            <asp:Button ID="Button103" runat="server" Height="60px" OnClick="Button103_Click" Width="60px" CssClass="auto-style37" />
            <asp:Button ID="Button104" runat="server" Height="60px" OnClick="Button104_Click" Width="60px" CssClass="auto-style32" />
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7">
            <asp:Button ID="Button105" runat="server" Height="60px" OnClick="Button105_Click" Width="60px" CssClass="auto-style48" />
            <asp:Button ID="Button106" runat="server" Height="60px" OnClick="Button106_Click" Width="60px" CssClass="auto-style63" />
            <asp:Button ID="Button107" runat="server" Height="60px" OnClick="Button107_Click" Width="60px" CssClass="auto-style61" />
            <asp:Button ID="Button108" runat="server" Height="60px" OnClick="Button108_Click" Width="60px" CssClass="auto-style46" />
            <asp:Button ID="Button109" runat="server" Height="60px" OnClick="Button109_Click" Width="60px" CssClass="auto-style64" />
            <asp:Button ID="Button110" runat="server" Height="60px" OnClick="Button110_Click" Width="60px" CssClass="auto-style52" />
            <asp:Button ID="Button111" runat="server" Height="60px" OnClick="Button111_Click" Width="60px" CssClass="auto-style42" />
            <asp:Button ID="Button112" runat="server" Height="60px" OnClick="Button112_Click" Width="60px" CssClass="auto-style71" />
            <asp:Button ID="Button113" runat="server" Height="60px" OnClick="Button113_Click" Width="60px" CssClass="auto-style54" />
            <asp:Button ID="Button114" runat="server" Height="60px" OnClick="Button114_Click" Width="60px" CssClass="auto-style47" />
            <asp:Button ID="Button115" runat="server" Height="60px" OnClick="Button115_Click" Width="60px" CssClass="auto-style53" />
            <asp:Button ID="Button117" runat="server" Height="60px" OnClick="Button117_Click" Width="60px" CssClass="auto-style56" />
            <asp:Button ID="Button118" runat="server" Height="60px" OnClick="Button118_Click" Width="60px" CssClass="auto-style49" />
            <asp:Button ID="Button119" runat="server" Height="60px" OnClick="Button119_Click" Width="60px" CssClass="auto-style67" />
            <asp:Button ID="Button120" runat="server" Height="60px" OnClick="Button120_Click" Width="60px" CssClass="auto-style70" />
            <asp:Button ID="Button121" runat="server" Height="60px" OnClick="Button121_Click" Width="60px" CssClass="auto-style57" />
            <asp:Button ID="Button122" runat="server" Height="60px" OnClick="Button122_Click" Width="60px" CssClass="auto-style51" />
            <asp:Button ID="Button123" runat="server" Height="60px" OnClick="Button123_Click" Width="60px" CssClass="auto-style44" />
            <asp:Button ID="Button124" runat="server" Height="60px" OnClick="Button124_Click" Width="60px" CssClass="auto-style43" />
            <asp:Button ID="Button125" runat="server" Height="60px" OnClick="Button125_Click" Width="60px" CssClass="auto-style58" />
            <asp:Button ID="Button126" runat="server" Height="60px" OnClick="Button126_Click" Width="60px" CssClass="auto-style68" />
            <asp:Button ID="Button127" runat="server" Height="60px" OnClick="Button127_Click" Width="60px" CssClass="auto-style55" />
            <asp:Button ID="Button129" runat="server" Height="60px" OnClick="Button129_Click" Width="60px" CssClass="auto-style59" />
            <asp:Button ID="Button130" runat="server" Height="60px" OnClick="Button130_Click" Width="60px" CssClass="auto-style69" />
            <asp:Button ID="Button131" runat="server" Height="60px" OnClick="Button131_Click" Width="60px" CssClass="auto-style50" />
            <asp:Button ID="Button132" runat="server" Height="60px" OnClick="Button132_Click" Width="60px" CssClass="auto-style60" />
            <asp:Button ID="Button133" runat="server" Height="60px" OnClick="Button133_Click" Width="60px" CssClass="auto-style45" />
            <asp:Button ID="Button134" runat="server" Height="60px" OnClick="Button134_Click" Width="60px" CssClass="auto-style62" />
            <asp:Button ID="Button135" runat="server" Height="60px" OnClick="Button135_Click" Width="60px" CssClass="auto-style72" />
            <asp:Button ID="Button136" runat="server" Height="60px" OnClick="Button136_Click" Width="60px" CssClass="auto-style65" />
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style7">
            <asp:Button ID="Button86" runat="server" Height="60px" OnClick="Button86_Click" Width="60px" CssClass="auto-style24" />
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style7">
            <asp:Button ID="Button87" runat="server" Height="60px" OnClick="Button87_Click" Width="60px" CssClass="auto-style23" />
            <asp:Button ID="Button88" runat="server" Height="60px" OnClick="Button88_Click" Width="60px" CssClass="auto-style28" />
            <asp:Button ID="Button89" runat="server" Height="60px" OnClick="Button89_Click" Width="60px" CssClass="auto-style27" />
            <asp:Button ID="Button90" runat="server" Height="60px" OnClick="Button90_Click" Width="60px" CssClass="auto-style26" />
            <asp:Button ID="Button91" runat="server" Height="60px" OnClick="Button91_Click" Width="60px" CssClass="auto-style39" />
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style7">
            <asp:Button ID="Button80" runat="server" Height="60px" OnClick="Button80_Click" Width="60px" CssClass="auto-style16" />
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7">
            <asp:Button ID="Button137" runat="server" Height="60px" OnClick="Button137_Click" Width="60px" CssClass="auto-style74" />
            <asp:Button ID="Button138" runat="server" Height="60px" OnClick="Button138_Click" Width="60px" CssClass="auto-style75" />
            <asp:Button ID="Button139" runat="server" Height="60px" OnClick="Button139_Click" Width="60px" CssClass="auto-style73" />
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                </tr>
            </table>
        <table class="auto-style79">
            <tr>
                <td>A</td>
                <td>B</td>
                <td>C</td>
                <td>D</td>
                <td>E</td>
                <td>F</td>
                <td>G</td>
                <td>H</td>
            </tr>
        </table>
        </p>
        <p>
            &nbsp;</p>
        <table class="auto-style81">
            <tr>
                <td class="auto-style80">1</td>
            </tr>
            <tr>
                <td class="auto-style80">2</td>
            </tr>
            <tr>
                <td class="auto-style80">3</td>
            </tr>
            <tr>
                <td class="auto-style80">4</td>
            </tr>
            <tr>
                <td class="auto-style80">5</td>
            </tr>
            <tr>
                <td class="auto-style80">6</td>
            </tr>
            <tr>
                <td class="auto-style80">7</td>
            </tr>
            <tr>
                <td class="auto-style80">8</td>
            </tr>
        </table>
    </form>
    </body>
</html>
