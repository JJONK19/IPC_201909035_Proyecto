using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using System.Xml;

namespace Othell
{
    //Mensajes Adaptado de: https://stackoverflow.com/questions/9720143/asp-net-web-application-message-box
    public static class Mensaje
    {
        public static void Mostrar(this Page Page, String Mensaje)
        {
            Page.ClientScript.RegisterStartupScript(
               Page.GetType(),
               "Mensaje",
               "<script language='javascript'>alert('" + Mensaje + "');</script>"
            );
        }
    }

    public partial class Tablero___V_Dinamico : System.Web.UI.Page
    {

        int ver = 0; //Verifica si se inicia el codigo
        public static int x = 1;  //1 para jugador 1, 2 para jugador 2 en donde x es el turno
                                  //Blancas J2, Negras J1
        Button[,] bot = null;
        int TN = 1; //Indica si el turno anterior de las negras no existe
        int TB = 1; //Indica si el turno anterior de las blancas no existe
        int conn = 0; //Contador de fichas negras
        int conb = 0; //Contador de fichas blancas
        int turn = 1;
     


        protected void Page_Load(object sender, EventArgs e)
        {
            
                if (ver == 0)
                {
                    bot = new Button[8, 8];
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {   
                            Button b = new Button();
                            char a = (char) (65 + j);
                            int b1 = i + 1;
                            string tem = a.ToString() + b1.ToString(); 
                            b.ID = tem;
                            b.Text = "";
                            b.Click += new EventHandler(this.Evento);
                            b.Attributes.Add("class", "but");
                            if(j == 3 && i == 3)
                            {
                                b.BackColor = Color.White;
                            }
                            if (j == 3 && i == 4)
                            {
                                b.BackColor = Color.Black;
                            }

                            if (j == 4 && i == 4)
                            {
                                 b.BackColor = Color.White;
                            }
                            if (j == 4 && i == 3)
                            {
                                b.BackColor = Color.Black;
                            }
                            bot[i, j] = b;
                          }
                    }
                    ver = 1;
                    Session["Tablero"] = bot;
                    TableRow f;
                    TableCell c;
                    Turno.Text = "Negras";
                    Blancas.Text = "2";
                    Negras.Text = "2";
                    for(int k = 0; k<9; k++)
                    {
                        f = new TableRow();
                        f.BorderColor = Color.Black;
                        if(k < 8)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                c = new TableCell();
                                c.BorderColor = Color.Black;
                                c.Controls.Add(bot[k, l]);
                                f.Cells.Add(c);
                            }
                            c = new TableCell();
                            c.BorderColor = Color.Black;
                            c.Text = (k + 1).ToString();
                            c.ForeColor = Color.White;
                            c.BackColor = Color.Black;
                            f.Cells.Add(c);
                        }
                        if (k == 8)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                            c = new TableCell();
                            c.BorderColor = Color.Black;
                            char a = (char)(65 + l);
                            c.Text = a.ToString();
                            c.ForeColor = Color.White;
                            c.BackColor = Color.Black;
                            f.Cells.Add(c);
                            }
                        }
                        
                            

                        tablero.Rows.Add(f);
                    }
                }

            
            

            if (Page.IsPostBack)
            {
                
                
               
            }

           
        }

        public void Evento(object sender, System.EventArgs e)
        {
            Button temp = (Button)sender;
            int b = 0; //Bandera que indica si esta o no coloreada la casilla
            int mov = 0; //Bandera que indica si existe movimiento 
            conn = 0; //Contador de fichas negras
            conb = 0; //Contador de fichas blancas
            List<int> posif = new List<int>();  //Array de posiciones iniciales Fila
            List<int> posic  = new List<int>(); ; //Array de posiciones iniciales Columna
            List<int> posff = new List<int>(); ; //Array de posiciones finales Fila
            List<int> posfc = new List<int>(); ; //Array de posiciones finales Columna
            List<string> dir = new List<string>(); ; //Array de direccion

            
            //Contar
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (bot[i,j].BackColor == Color.Black)
                    {
                        conn += 1;
                    }

                    if (bot[i, j].BackColor == Color.White)
                    {
                        conb += 1;
                    }
                }
            }

            int tot = conn + conb;
            if(tot == 64)
            {
                TN = 0;
                TB = 0;
                String gan = "";
                if (conn > conb)
                {
                    gan = "Jugador 1 (Negras).";
                }else{
                    gan = "Jugador 2 (Blancas).";
                }
                MessageBox.Show(this.Page, "Final del Juego. Gana "+ gan);
               
            }
            else
            {
                if (temp.BackColor == Color.Black || temp.BackColor == Color.White)
                {
                    b = 1; //No esta vacia
                    Mensaje.Mostrar(this.Page, "Seleccione una casilla vacia.");
                }

                if (b == 0)
                {
                    if (x == 1)
                    {
                        //Verificar posible movimientos
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Button tem = bot[i, j];
                                Color bus = Color.Red; //Opuesto
                                Color ori = Color.Red; //Original

                                if (tem.BackColor == Color.White)
                                {
                                    ori = Color.White;
                                    bus = Color.Black;

                                }

                                if (bus == Color.Red)
                                {

                                }
                                else
                                {
                                    //Revision de posiciones
                                    //Arriba Vertical (UV)
                                    if ((i - 1) < 0)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i - 1), j].BackColor == Color.Black || bot[(i - 1), j].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit += 1;

                                                if (fit > 7)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add(i - 1);
                                                        posic.Add(j);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("UV");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Abajo Vertical (DV)
                                    if ((i + 1) > 7)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i + 1), j].BackColor == Color.Black || bot[(i + 1), j].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit -= 1;
                                                if (fit < 0)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add((i + 1));
                                                        posic.Add(j);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("DV");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }


                                    //Revision de posiciones
                                    //Izquierda Horizontal (HI)
                                    if ((j - 1) < 0)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[i, (j - 1)].BackColor == Color.Black || bot[i, (j - 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {

                                                cot += 1;
                                                if (cot > 7)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add(i);
                                                        posic.Add(j - 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("HI");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Derecha Horizontal (HD)
                                    if ((j + 1) > 7)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[i, (j + 1)].BackColor == Color.Black || bot[i, (j + 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {

                                                cot -= 1;
                                                if (cot < 0)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add((i));
                                                        posic.Add(j + 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("HD");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Diagonal Izquierda Superior (DIS)
                                    if ((i - 1) < 0 || (j - 1) < 0)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i - 1), (j - 1)].BackColor == Color.Black || bot[(i - 1), (j - 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit += 1;
                                                cot += 1;
                                                if (fit > 7 || cot > 7)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add(i - 1);
                                                        posic.Add(j - 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("DIS");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Diagonal Izquierda Inferior (DII) //pen
                                    if ((i + 1) > 7 || (j - 1) < 0)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i + 1), (j - 1)].BackColor == Color.Black || bot[(i + 1), (j - 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit -= 1;
                                                cot += 1;
                                                if (fit < 0 || cot > 7)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add((i + 1));
                                                        posic.Add(j - 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("DII");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Diagonal Derecha Superior (DDS)
                                    if ((i - 1) < 0 || (j + 1) > 7)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i - 1), (j + 1)].BackColor == Color.Black || bot[(i - 1), (j + 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit += 1;
                                                cot -= 1;
                                                if (fit > 7 || cot < 0)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add((i - 1));
                                                        posic.Add(j + 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("DDS");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Diagonal Derecha Inferior (DDI) //pen
                                    if ((i + 1) > 7 || (j + 1) > 7)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i + 1), (j + 1)].BackColor == Color.Black || bot[(i + 1), (j + 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit -= 1;
                                                cot -= 1;
                                                if (fit < 0 || cot < 0)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add((i + 1));
                                                        posic.Add(j + 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("DDI");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Validar Movimiento
                        if (mov == 0)
                        {
                            TN = 0; //Cambiar esto dependiendo del color
                            if(TN == 0 && TB == 0)
                            {
                                String gan = "";
                                if (conn > conb)
                                {
                                    gan = "Jugador 1 (Negras).";
                                }
                                else
                                {
                                    gan = "Jugador 2 (Blancas).";
                                }
                                MessageBox.Show(this.Page, "Final del Juego. Gana " + gan);
                            }
                            else
                            {
                                x = 2;
                                MessageBox.Show(this.Page, "Las fichas negras no tienen movimientos disponibles.");
                            }
                
                        }
                        else
                        {

                            TN = 1;
                            int c = posif.Count;
                            //Encontrar posicion en el tablero
                            String Pos = temp.ID;
                            int Fila = (int)Char.GetNumericValue(Pos[1]) - 1;
                            int Columna = (int)(Pos[0]) - 65;
                            List<int> posicion = new List<int>();
                            for (int i = 0; i < c; i++)
                            {
                                if (posif[i] == Fila && posic[i] == Columna)
                                {
                                    posicion.Add(i);
                                }
                            }

                            //Validar Movimiento
                            int d = posicion.Count;
                            if (d == 0)
                            {
                                MessageBox.Show(this.Page, "El movimiento que desea ejecutar no es valido. Intentelo de nuevo.");
                                Turno.Text = "Negras";
                            }
                            else
                            {
                                
                                Turno.Text = "Blancas";
                                //Colorear
                                for (int i = 0; i < d; i++)
                                {
                                    int temfi = posif[posicion[i]];
                                    int temci = posic[posicion[i]];
                                    int temff = posff[posicion[i]];
                                    int temcf = posfc[posicion[i]];
                                    string dirt = dir[posicion[i]];

                                    switch (dirt)
                                    {
                                        case "UV":
                                            for (int o = temfi; o < temff; o++)
                                            {
                                                bot[o, temci].BackColor = Color.Black; //Cambiar dependiendo del color
                                                x = 2;
                                            }
                                            break;

                                        case "DV":
                                            for (int o = temff; o < (temfi + 1); o++)
                                            {
                                                bot[o, temci].BackColor = Color.Black; //Cambiar dependiendo del color
                                                x = 2;
                                            }
                                            break;

                                        case "HI":
                                            for (int o = temci; o < temcf; o++)
                                            {
                                                bot[temfi, o].BackColor = Color.Black; //Cambiar dependiendo del color
                                                x = 2;
                                            }
                                            break;

                                        case "HD":
                                            for (int o = temcf; o < (temci + 1); o++)
                                            {
                                                bot[temfi, o].BackColor = Color.Black; //Cambiar dependiendo del color
                                                x = 2;
                                            }
                                            break;

                                        case "DIS":
                                            int a = temff - temfi;

                                            for (int g = 0; g < a; g++)
                                            {

                                                bot[temfi + g, temci + g].BackColor = Color.Black; //Cambiar dependiendo del color
                                                x = 2;

                                            }
                                            break;

                                        case "DII":
                                            int a1 = temfi - temff;
                                            for (int g = 0; g < (a1); g++)
                                            {

                                                bot[temfi - g, temci + g].BackColor = Color.Black; //Cambiar dependiendo del color
                                                x = 2;

                                            }
                                            break;

                                        case "DDS":
                                            int a2 = temff - temfi;
                                            for (int g = 0; g < a2; g++)
                                            {

                                                bot[temfi + g, temci - g].BackColor = Color.Black; //Cambiar dependiendo del color
                                                x = 2;

                                            }
                                            break;

                                        case "DDI":
                                            int a3 = temfi - temff;

                                            for (int g = 0; g < a3; g++)
                                            {

                                                bot[temfi - g, temci - g].BackColor = Color.Black; //Cambiar dependiendo del color
                                                x = 2;

                                            }
                                            break;
                                    }
                                }

                            }



                        }
                    }
                    else
                    {
                        //Verificar posible movimientos
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Button tem = bot[i, j];
                                Color bus = Color.Red; //Opuesto
                                Color ori = Color.Red; //Original

                                if (tem.BackColor == Color.Black)
                                {
                                    bus = Color.White;
                                    ori = Color.Black;

                                }

                                if (bus == Color.Red)
                                {

                                }
                                else
                                {
                                    //Revision de posiciones
                                    //Arriba Vertical (UV)
                                    if ((i - 1) < 0)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i - 1), j].BackColor == Color.Black || bot[(i - 1), j].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit += 1;

                                                if (fit > 7)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add(i - 1);
                                                        posic.Add(j);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("UV");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Abajo Vertical (DV)
                                    if ((i + 1) > 7)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i + 1), j].BackColor == Color.Black || bot[(i + 1), j].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit -= 1;
                                                if (fit < 0)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add((i + 1));
                                                        posic.Add(j);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("DV");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }


                                    //Revision de posiciones
                                    //Izquierda Horizontal (HI)
                                    if ((j - 1) < 0)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[i, (j - 1)].BackColor == Color.Black || bot[i, (j - 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {

                                                cot += 1;
                                                if (cot > 7)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add(i);
                                                        posic.Add(j - 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("HI");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Derecha Horizontal (HD)
                                    if ((j + 1) > 7)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[i, (j + 1)].BackColor == Color.Black || bot[i, (j + 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {

                                                cot -= 1;
                                                if (cot < 0)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add((i));
                                                        posic.Add(j + 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("HD");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Diagonal Izquierda Superior (DIS)
                                    if ((i - 1) < 0 || (j - 1) < 0)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i - 1), (j - 1)].BackColor == Color.Black || bot[(i - 1), (j - 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit += 1;
                                                cot += 1;
                                                if (fit > 7 || cot > 7)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add(i - 1);
                                                        posic.Add(j - 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("DIS");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Diagonal Izquierda Inferior (DII) //pen
                                    if ((i + 1) > 7 || (j - 1) < 0)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i + 1), (j - 1)].BackColor == Color.Black || bot[(i + 1), (j - 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit -= 1;
                                                cot += 1;
                                                if (fit < 0 || cot > 7)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add((i + 1));
                                                        posic.Add(j - 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("DII");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Diagonal Derecha Superior (DDS)
                                    if ((i - 1) < 0 || (j + 1) > 7)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i - 1), (j + 1)].BackColor == Color.Black || bot[(i - 1), (j + 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit += 1;
                                                cot -= 1;
                                                if (fit > 7 || cot < 0)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add((i - 1));
                                                        posic.Add(j + 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("DDS");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //Revision de posiciones
                                    //Diagonal Derecha Inferior (DDI) //pen
                                    if ((i + 1) > 7 || (j + 1) > 7)
                                    {

                                    }
                                    else
                                    {
                                        if (bot[(i + 1), (j + 1)].BackColor == Color.Black || bot[(i + 1), (j + 1)].BackColor == Color.White)
                                        {

                                        }
                                        else
                                        {
                                            int ba = 0;
                                            int fit = i;
                                            int cot = j;
                                            while (ba != 1)
                                            {
                                                fit -= 1;
                                                cot -= 1;
                                                if (fit < 0 || cot < 0)
                                                {
                                                    ba = 1;
                                                }
                                                else
                                                {
                                                    if (bot[fit, cot].BackColor == bus)
                                                    {
                                                        posif.Add((i + 1));
                                                        posic.Add(j + 1);
                                                        posff.Add(fit);
                                                        posfc.Add(cot);
                                                        dir.Add("DDI");
                                                        ba = 1;
                                                        mov = 1;
                                                    }
                                                    else
                                                    {
                                                        if (bot[fit, cot].BackColor == ori)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            ba = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Validar Movimiento
                        if (mov == 0)
                        {
                            TB = 0; //Cambiar esto dependiendo del color
                            if (TN == 0 && TB == 0)
                            {
                                String gan = "";
                                if (conn > conb)
                                {
                                    gan = "Jugador 1 (Negras).";
                                }
                                else
                                {
                                    gan = "Jugador 2 (Blancas).";
                                }
                                MessageBox.Show(this.Page, "Final del Juego. Gana " + gan);

                            }
                            else
                            {
                                x = 1;
                                MessageBox.Show(this.Page, "Las fichas blancas no tienen movimientos disponibles.");
                            }

                            //Meter aca el fin del juego
                        }
                        else
                        {

                            TB = 1;
                            int c = posif.Count;
                            //Encontrar posicion en el tablero
                            String Pos = temp.ID;
                            int Fila = (int)Char.GetNumericValue(Pos[1]) - 1;
                            int Columna = (int)(Pos[0]) - 65;
                            List<int> posicion = new List<int>();
                            for (int i = 0; i < c; i++)
                            {
                                if (posif[i] == Fila && posic[i] == Columna)
                                {
                                    posicion.Add(i);
                                }
                            }

                            //Validar Movimiento
                            int d = posicion.Count;
                            if (d == 0)
                            {
                                MessageBox.Show(this.Page, "El movimiento que desea ejecutar no es valido. Intentelo de nuevo.");
                                Turno.Text = "Blancas";
                            }
                            else
                            {
                                Turno.Text = "Negras";
                                //Colorear
                                for (int i = 0; i < d; i++)
                                {
                                    int temfi = posif[posicion[i]];
                                    int temci = posic[posicion[i]];
                                    int temff = posff[posicion[i]];
                                    int temcf = posfc[posicion[i]];
                                    string dirt = dir[posicion[i]];

                                    switch (dirt)
                                    {
                                        case "UV":
                                            for (int o = temfi; o < temff; o++)
                                            {
                                                bot[o, temci].BackColor = Color.White; //Cambiar dependiendo del color
                                                x = 1;
                                            }
                                            break;

                                        case "DV":
                                            for (int o = temff; o < (temfi + 1); o++)
                                            {
                                                bot[o, temci].BackColor = Color.White; //Cambiar dependiendo del color
                                                x = 1;
                                            }
                                            break;

                                        case "HI":
                                            for (int o = temci; o < temcf; o++)
                                            {
                                                bot[temfi, o].BackColor = Color.White; //Cambiar dependiendo del color
                                                x = 1;
                                            }
                                            break;

                                        case "HD":
                                            for (int o = temcf; o < (temci + 1); o++)
                                            {
                                                bot[temfi, o].BackColor = Color.White; //Cambiar dependiendo del color
                                                x = 1;
                                            }
                                            break;

                                        case "DIS":
                                            int a = temff - temfi;

                                            for (int g = 0; g < a; g++)
                                            {

                                                bot[temfi + g, temci + g].BackColor = Color.White; //Cambiar dependiendo del color
                                                x = 1;

                                            }
                                            break;

                                        case "DII":
                                            int a1 = temfi - temff;
                                            for (int g = 0; g < (a1); g++)
                                            {

                                                bot[temfi - g, temci + g].BackColor = Color.White; //Cambiar dependiendo del color
                                                x = 1;

                                            }
                                            break;

                                        case "DDS":
                                            int a2 = temff - temfi;
                                            for (int g = 0; g < a2; g++)
                                            {

                                                bot[temfi + g, temci - g].BackColor = Color.White; //Cambiar dependiendo del color
                                                x = 1;

                                            }
                                            break;

                                        case "DDI":
                                            int a3 = temfi - temff;

                                            for (int g = 0; g < a3; g++)
                                            {

                                                bot[temfi - g, temci - g].BackColor = Color.White; //Cambiar dependiendo del color
                                                x = 1;

                                            }
                                            break;
                                    }
                                }

                            }
                           



                        }
                    }







                }
            }
            conn = 0;
            conb = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (bot[i, j].BackColor == Color.Black)
                    {
                        conn += 1;
                    }

                    if (bot[i, j].BackColor == Color.White)
                    {
                        conb += 1;
                    }
                }
            }
            Blancas.Text = conb.ToString();
            Negras.Text = conn.ToString();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        }
        //Cargar https://www.kyocode.com/2018/12/cargar-archivo-con-fileupload-asp-net-c/
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Byte[] Archivo = null;
           
            if (Subir.HasFile == true)
            {
                using (BinaryReader reader = new BinaryReader(Subir.PostedFile.InputStream))
                {
                    Archivo = reader.ReadBytes(Subir.PostedFile.ContentLength);
                }
                
            }
            MemoryStream m = new MemoryStream(Archivo);
            XmlDataDocument xml = new XmlDataDocument();
            XmlNodeList node;
            XmlNodeList node1;
            xml.Load(m);
            node = xml.GetElementsByTagName("ficha");
            node1 = xml.GetElementsByTagName("siguienteTiro");

            //Almacenar Tiro
            String Tiro = null;
            node1[0].ChildNodes.Item(0).InnerText.Trim();
            Tiro = node1[0].ChildNodes.Item(0).InnerText.Trim();

            //Almacenar Posiciones y colores
            int i = 0;
            var pos = new List<String>();
            var col = new List<String>(); ;
            for (i = 0; i <= node.Count - 1; i++)
            {
                node[i].ChildNodes.Item(0).InnerText.Trim();
                pos.Add(node[i].ChildNodes.Item(1).InnerText.Trim() + node[i].ChildNodes.Item(2).InnerText.Trim());
                col.Add(node[i].ChildNodes.Item(0).InnerText.Trim());
            }

            //Settear todos al color original
            Color co = ColorTranslator.FromHtml("#006B3C");
            for (int p = 0; p < 8; p++)
            {
                for (int q = 0; q < 8; q++)
                {
                    bot[p, q].BackColor = co;
                }
            }

            //Cargar Datos
            if (Tiro == "negro")
            {
                x = 1;
            }
            else
            {
                x = 2;
            }
        }


        //Salir
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx");
        }

        
    }
}