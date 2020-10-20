using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Othell
{
    //Mensajes Adaptado de: https://stackoverflow.com/questions/9720143/asp-net-web-application-message-box
    public static class Mensajes
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

    public partial class Tablero___X : System.Web.UI.Page
    {

      
        int ver = 0; //Verifica si se inicia el codigo
        public static int x = 1;  //1 para jugador 1, 2 para jugador 2 en donde x es el turno
                                  //Blancas J2, Negras J1
        Button[,] bot = null;
        public static int TN = 1; //Indica si el turno anterior de las negras no existe
        public static int TB = 1; //Indica si el turno anterior de las blancas no existe
        int conn = 0; //Contador de fichas negras
        int conb = 0; //Contador de fichas blancas
        int turn = 1;
        String Jug; //Indica el color del usuario
        public static int ID = 0;
        
        public static Stopwatch neg; //Cronometro
        public static Stopwatch bla; //Cronometro
        public static int FI; //No de filas
        public static int CO; //No de Columnas
        public static int RI; //Reto Inverso
        public static List<string> J1;  //Lista de Colores 1
        public static List<string> J2;  //Lista de Colores 2
        public static List<string> Colores;
        public static int apertura = 0; //Determina si ya se pusieron 
        public static int aperturab = 0; //Determina si ya se pusieron 
        public static int aperturaC= 0; //Determina si los espacios centrados estan coloreados
        public static int aperturaA = 0;
        public static int PCN = 0; //Posicion de color
        public static int PCB = 0; //Posicion de color

        protected void Page_Load(object sender, EventArgs e)
        {

            Jug = "N";
            ID = (int)Session["ID"];
            FI = (int)Session["M"];
            CO = (int)Session["N"];
            RI = (int)Session["RI"];
            J1 = (List<string>)Session["J1"];
            J2 = (List<string>)Session["J2"];
            



            if (!Page.IsPostBack)
            {
                Text1.Text = "00:00";
                Text2.Text = "00:00";
                x = 1;
                neg = new Stopwatch();
                neg.Start();
                bla = new Stopwatch();

            }
            if (ver == 0)
            {

                bot = new Button[FI, CO];
                for (int i = 0; i < FI; i++)
                {
                    for (int j = 0; j < CO; j++)
                    {
                        Button b = new Button();
                        char a = (char)(65 + j);
                        int b1 = i + 1;
                        string tem = a.ToString() + b1.ToString();
                        b.ID = tem;
                        b.Text = "";
                        b.Click += new EventHandler(this.Evento);
                        b.Attributes.Add("class", "but");
                        
                        bot[i, j] = b;
                    }
                }
                ver = 1;
                Session["Tablero"] = bot;
                TableRow f;
                TableCell c;
                Turno.Text = "Jugador 1";
                Blancas.Text = "0";
                Negras.Text = "0";
                int a1 = FI + 1;
                for (int k = 0; k < a1; k++)
                {
                    f = new TableRow();
                    f.BorderColor = Color.Black;
                    if (k < FI)
                    {
                        for (int l = 0; l < CO; l++)
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
                    if (k == FI)
                    {
                        for (int l = 0; l < CO; l++)
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

                Jug = "N";
                ID = (int)Session["ID"];
                FI = (int)Session["M"];
                CO = (int)Session["N"];
                RI = (int)Session["RI"];

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
            List<int> posic = new List<int>(); ; //Array de posiciones iniciales Columna
            List<int> posff = new List<int>(); ; //Array de posiciones finales Fila
            List<int> posfc = new List<int>(); ; //Array de posiciones finales Columna
            List<string> dir = new List<string>(); ; //Array de direccion





            //Contar
            for (int i = 0; i < FI; i++)
            {
                for (int j = 0; j < CO; j++)
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

            int tot = conn + conb;
            if (tot == (FI*CO))
            {
                TN = 0;
                TB = 0;
                String gan = "";
                if (conn == conb)
                {

                    
                    
                        const string FMT = "yyyy-MM-dd";
                        DateTime hoy = DateTime.Now;
                        string nom = hoy.ToString(FMT);
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                        con.Open();
                        SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Empate', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                        con.Close();
                       
                    

                    int f = 1;
                    if (f == 1)
                    {
                        
                        MessageBox.Show(this.Page, "Final del Juego. Empatados. ");
                    }


                }
                else
                {
                    if (conn > conb)
                    {
                        //Reto Inverso
                        if (RI == 0)
                        {
                            gan = "Jugador 1 (Negras).";
                            //Agregar a Base
                            if (Jug == "N")
                            {


                                const string FMT = "yyyy-MM-dd";
                                DateTime hoy = DateTime.Now;
                                string nom = hoy.ToString(FMT);
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                con.Open();
                                SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                con.Close();


                            }
                            else
                            {


                                const string FMT = "yyyy-MM-dd";
                                DateTime hoy = DateTime.Now;
                                string nom = hoy.ToString(FMT);
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                con.Open();
                                SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                con.Close();


                            }
                        }
                        else
                        {
                            gan = "Jugador 2 (Blancas).";
                            //Agregar a Base
                            if (Jug == "B")
                            {


                                const string FMT = "yyyy-MM-dd";
                                DateTime hoy = DateTime.Now;
                                string nom = hoy.ToString(FMT);
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                con.Open();
                                SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                con.Close();


                            }
                            else
                            {


                                const string FMT = "yyyy-MM-dd";
                                DateTime hoy = DateTime.Now;
                                string nom = hoy.ToString(FMT);
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                con.Open();
                                SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                con.Close();


                            }
                        }

                    }
                    else
                    {
                        //Reto Inverso
                        if (RI == 1)
                        {
                            gan = "Jugador 1 (Negras).";
                            //Agregar a Base
                            if (Jug == "N")
                            {


                                const string FMT = "yyyy-MM-dd";
                                DateTime hoy = DateTime.Now;
                                string nom = hoy.ToString(FMT);
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                con.Open();
                                SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                con.Close();


                            }
                            else
                            {


                                const string FMT = "yyyy-MM-dd";
                                DateTime hoy = DateTime.Now;
                                string nom = hoy.ToString(FMT);
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                con.Open();
                                SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                con.Close();


                            }
                        }
                        else
                        {
                            gan = "Jugador 2 (Blancas).";
                            //Agregar a Base
                            if (Jug == "B")
                            {


                                const string FMT = "yyyy-MM-dd";
                                DateTime hoy = DateTime.Now;
                                string nom = hoy.ToString(FMT);
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                con.Open();
                                SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                con.Close();


                            }
                            else
                            {


                                const string FMT = "yyyy-MM-dd";
                                DateTime hoy = DateTime.Now;
                                string nom = hoy.ToString(FMT);
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                con.Open();
                                SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                con.Close();


                            }
                        }


                    }
                    int f = 1;
                    if (f == 1)
                    {
                       
                        MessageBox.Show(this.Page, "Final del Juego. Gana " + gan);
                    }

                }


            }
            else
            {
                if (temp.BackColor == Color.Black || temp.BackColor == Color.White || temp.BackColor == Color.Red || temp.BackColor == Color.Yellow || temp.BackColor == Color.Blue || temp.BackColor == Color.Orange || temp.BackColor == Color.Green || temp.BackColor == Color.MediumPurple || temp.BackColor == Color.SkyBlue || temp.BackColor == Color.Gray)
                {
                    b = 1; //No esta vacia
                    Mensaje.Mostrar(Page, "Seleccione una casilla vacia.");
                }

                if (b == 0)
                {
                    if (x == 1)
                    {
                        if (PCN == J1.Count)
                        {
                            apertura = 1;
                            PCN = 0;
                        }
                        else
                        {
                            apertura = 0;
                        }


                        if (apertura == 0)
                        {
                            //Contar si ya esta coloreado centro
                            int P1C = (CO / 2) - 1;
                            int P1F = (FI / 2) - 1;
                            int P2C = (CO / 2) - 1;
                            int P2F = FI / 2;
                            int P3C = CO / 2;
                            int P3F = FI / 2;
                            int P4C = CO / 2;
                            int P4F = (FI / 2) - 1;
                            int conc = 0; //Cuenta piezas de centro
                            if (bot[P1F, P1C].BackColor == Color.Black || bot[P1F, P1C].BackColor == Color.White || bot[P1F, P1C].BackColor == Color.Red || bot[P1F, P1C].BackColor == Color.Yellow || bot[P1F, P1C].BackColor == Color.Blue || bot[P1F, P1C].BackColor == Color.Orange || bot[P1F, P1C].BackColor == Color.Green || bot[P1F, P1C].BackColor == Color.MediumPurple || bot[P1F, P1C].BackColor == Color.SkyBlue || bot[P1F, P1C].BackColor == Color.Gray)
                            {
                                conc = conc + 1;
                            }

                            if (bot[P2F, P2C].BackColor == Color.Black || bot[P2F, P2C].BackColor == Color.White || bot[P2F, P2C].BackColor == Color.Red || bot[P2F, P2C].BackColor == Color.Yellow || bot[P2F, P2C].BackColor == Color.Blue || bot[P2F, P2C].BackColor == Color.Orange || bot[P2F, P2C].BackColor == Color.Green || bot[P2F, P2C].BackColor == Color.MediumPurple || bot[P2F, P2C].BackColor == Color.SkyBlue || bot[P2F, P2C].BackColor == Color.Gray)
                            {
                                conc = conc + 1;
                            }

                            if (bot[P3F, P3C].BackColor == Color.Black || bot[P3F, P3C].BackColor == Color.White || bot[P3F, P3C].BackColor == Color.Red || bot[P3F, P3C].BackColor == Color.Yellow || bot[P3F, P3C].BackColor == Color.Blue || bot[P3F, P3C].BackColor == Color.Orange || bot[P3F, P3C].BackColor == Color.Green || bot[P3F, P3C].BackColor == Color.MediumPurple || bot[P3F, P3C].BackColor == Color.SkyBlue || bot[P3F, P3C].BackColor == Color.Gray)
                            {
                                conc = conc + 1;
                            }

                            if (bot[P4F, P4C].BackColor == Color.Black || bot[P4F, P4C].BackColor == Color.White || bot[P4F, P4C].BackColor == Color.Red || bot[P4F, P4C].BackColor == Color.Yellow || bot[P4F, P4C].BackColor == Color.Blue || bot[P4F, P4C].BackColor == Color.Orange || bot[P4F, P4C].BackColor == Color.Green || bot[P4F, P4C].BackColor == Color.MediumPurple || bot[P4F, P4C].BackColor == Color.SkyBlue || bot[P4F, P4C].BackColor == Color.Gray)
                            {
                                conc = conc + 1;
                            }

                            if (conc == 4)
                            {
                                aperturaC = 1;
                            }
                            else
                            {
                                aperturaC = 0;
                            }


                            if (aperturaC == 0)
                            {
                                //Encontrar posicion en el tablero
                                String Pos = temp.ID;
                                int Fila = (int)Char.GetNumericValue(Pos[1]) - 1;
                                int Columna = (int)(Pos[0]) - 65;
                                Color pin = Color.Lavender;
                                String tempco = J1[PCN];
                                PCN = PCN + 1;
                                

                                switch (tempco)
                                {
                                    case "Rojo":
                                        pin = Color.Red;
                                        break;

                                    case "Amarillo":
                                        pin = Color.Yellow;
                                        break;

                                    case "Azul":
                                        pin = Color.Blue;
                                        break;

                                    case "Naranja":
                                        pin = Color.Orange;
                                        break;

                                    case "Verde":
                                        pin = Color.Green;
                                        break;

                                    case "Violeta":
                                        pin = Color.MediumPurple;
                                        break;

                                    case "Blanco":
                                        pin = Color.White;
                                        break;

                                    case "Negro":
                                        pin = Color.Black;
                                        break;

                                    case "Celeste":
                                        pin = Color.SkyBlue;
                                        break;

                                    case "Gris":
                                        pin = Color.Gray;
                                        break;

                                }


                                if (Fila == P1F && Columna == P1C)
                                {

                                    temp.BackColor = pin;
                                    x = 2;
                                    Turno.Text = "Jugador 2";
                                }
                                else
                                {

                                    if (Fila == P2F && Columna == P2C)
                                    {
                                        temp.BackColor = pin;
                                        x = 2;
                                        Turno.Text = "Jugador 2";
                                    }
                                    else
                                    {

                                        if (Fila == P3F && Columna == P3C)
                                        {
                                            temp.BackColor = pin;
                                            x = 2;
                                            Turno.Text = "Jugador 2";
                                        }
                                        else
                                        {

                                            if (Fila == P4F && Columna == P4C)
                                            {
                                                temp.BackColor = pin;
                                                x = 2;
                                                Turno.Text = "Jugador 2";
                                            }
                                            else
                                            {
                                                Page.ClientScript.RegisterStartupScript(
                                                Page.GetType(),
                                                "Mensaje",
                                                "<script language='javascript'>alert('Movimiento no valido. Debe llenar el centro primero.');</script>");
                                            }
                                        }
                                    }
                                }

                            }
                            else
                            {
                                //Encontrar posicion en el tablero
                                String Pos = temp.ID;
                                int Fila = (int)Char.GetNumericValue(Pos[1]) - 1;
                                int Columna = (int)(Pos[0]) - 65;
                                Color pin = Color.Lavender;
                                String tempco = J1[PCN];
                                PCN = PCN + 1;
                                

                                switch (tempco)
                                {
                                    case "Rojo":
                                        pin = Color.Red;
                                        break;

                                    case "Amarillo":
                                        pin = Color.Yellow;
                                        break;

                                    case "Azul":
                                        pin = Color.Blue;
                                        break;

                                    case "Naranja":
                                        pin = Color.Orange;
                                        break;

                                    case "Verde":
                                        pin = Color.Green;
                                        break;

                                    case "Violeta":
                                        pin = Color.MediumPurple;
                                        break;

                                    case "Blanco":
                                        pin = Color.White;
                                        break;

                                    case "Negro":
                                        pin = Color.Black;
                                        break;

                                    case "Celeste":
                                        pin = Color.SkyBlue;
                                        break;

                                    case "Gris":
                                        pin = Color.Gray;
                                        break;

                                }

                                int PCSF = P1F - 1; //Fila superior a cuadrado central
                                int PCSCI = P1C - 1; //Inicio de columna
                                int PCSCF = P3C + 1; //Inicio de columna

                                int PCIF = P2F + 1; //Fila Inferior a cuadrado central
                                int PCICI = P1C - 1; //Inicio de columna
                                int PCICF = P3C + 1; //Inicio de columna

                                int PCFII = P1F; //Fila inicial a cuadrado central
                                int PCFFD = P2F; //Fila Final a cuadrado central
                                int PCI = P1C-1; //columna izquierda

                               
                                int PCF = P4C + 1; //columna derecha

                                if (Fila == PCIF && Columna >=PCICI && Columna <=PCICF) 
                                {
                                    temp.BackColor = pin;
                                    x = 2;
                                    Turno.Text = "Jugador 2";

                                }
                                else
                                {
                                    if (Fila == PCSF && Columna >= PCSCI && Columna <= PCSCF)
                                    {
                                        temp.BackColor = pin;
                                        x = 2;
                                        Turno.Text = "Jugador 2";

                                    }
                                    else
                                    {
                                        if (Columna == PCI && Fila >= PCFII && Fila <= PCFFD)
                                        {
                                            temp.BackColor = pin;
                                            x = 2;
                                            Turno.Text = "Jugador 2";

                                        }
                                        else
                                        {
                                            if (Columna == PCF && Fila >= PCFII && Fila <= PCFFD)
                                            {
                                                temp.BackColor = pin;
                                                x = 2;
                                                Turno.Text = "Jugador 2";

                                            }
                                            else
                                            {
                                                Page.ClientScript.RegisterStartupScript(
                                               Page.GetType(),
                                               "Mensaje",
                                               "<script language='javascript'>alert('Movimiento no valido. Debe llenar las casillas que rodean al centro hasta que tenga una ficha de cada color en el tablero.');</script>");
                                            }
                                        }
                                    }
                                }


                            }
                        }
                        else
                        {
                            mov = 0;
                            int FM = FI - 1;
                            int CM = CO - 1;
                            //Verificar posible movimientos
                            for (int i = 0; i < FI; i++)
                            {
                                for (int j = 0; j < CO; j++)
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

                                                    if (fit > FM)
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

                                        if ((i + 1) > FM)
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

                                                    if (cot > CM)
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

                                        if ((j + 1) > CM)
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

                                                    if (fit > FM || cot > CM)
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

                                        if ((i + 1) > FM || (j - 1) < 0)
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

                                                    if (fit < 0 || cot > CM)
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

                                        if ((i - 1) < 0 || (j + 1) > CM)
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

                                                    if (fit > FM || cot < 0)
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

                                        if ((i + 1) > FM || (j + 1) > CM)
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
                                if (TN == 0 && TB == 0)
                                {
                                    String gan = "";
                                    if (conn == conb)
                                    {



                                        const string FMT = "yyyy-MM-dd";
                                        DateTime hoy = DateTime.Now;
                                        string nom = hoy.ToString(FMT);
                                        SqlConnection con = new SqlConnection();
                                        con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                        con.Open();
                                        SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Empate', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                        con.Close();



                                        int f = 1;
                                        if (f == 1)
                                        {

                                            MessageBox.Show(this.Page, "Final del Juego. Empatados. ");
                                        }


                                    }
                                    else
                                    {
                                        if (conn > conb)
                                        {
                                            //Reto Inverso
                                            if (RI == 0)
                                            {
                                                gan = "Jugador 1 (Negras).";
                                                //Agregar a Base
                                                if (Jug == "N")
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                                else
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                            }
                                            else
                                            {
                                                gan = "Jugador 2 (Blancas).";
                                                //Agregar a Base
                                                if (Jug == "B")
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                                else
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                            }





                                        }
                                        else
                                        {
                                            //Reto Inverso
                                            if (RI == 1)
                                            {
                                                gan = "Jugador 1 (Negras).";
                                                //Agregar a Base
                                                if (Jug == "N")
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                                else
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                            }
                                            else
                                            {
                                                gan = "Jugador 2 (Blancas).";
                                                //Agregar a Base
                                                if (Jug == "B")
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                                else
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                            }


                                        }
                                        int f = 1;
                                        if (f == 1)
                                        {

                                            MessageBox.Show(this.Page, "Final del Juego. Gana " + gan);
                                        }

                                    }
                                }
                                else
                                {
                                    TN = 0;
                                    MessageBox.Show(this.Page, "Las fichas negras no tienen movimientos disponibles.");
                                    x = 2;
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
                                    Turno.Text = "Jugador 1";
                                }
                                else
                                {

                                    Turno.Text = "Jugador 2";

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
                        
                    }
                    else
                    {
                        if (PCB == J2.Count)
                        {
                            aperturab = 1;
                            PCB = 0;
                        }
                        else
                        {
                            aperturab = 0;
                        }
                        if (aperturab == 0)
                        {
                            //Contar si ya esta coloreado centro
                            int P1C = (CO / 2) - 1;
                            int P1F = (FI / 2) - 1;
                            int P2C = (CO / 2) - 1;
                            int P2F = FI / 2;
                            int P3C = CO / 2;
                            int P3F = FI / 2;
                            int P4C = CO / 2;
                            int P4F = (FI / 2) - 1;
                            int conc = 0; //Cuenta piezas de centro
                            if (bot[P1F, P1C].BackColor == Color.Black || bot[P1F, P1C].BackColor == Color.White || bot[P1F, P1C].BackColor == Color.Red || bot[P1F, P1C].BackColor == Color.Yellow || bot[P1F, P1C].BackColor == Color.Blue || bot[P1F, P1C].BackColor == Color.Orange || bot[P1F, P1C].BackColor == Color.Green || bot[P1F, P1C].BackColor == Color.MediumPurple || bot[P1F, P1C].BackColor == Color.SkyBlue || bot[P1F, P1C].BackColor == Color.Gray)
                            {
                                conc = conc + 1;
                            }

                            if (bot[P2F, P2C].BackColor == Color.Black || bot[P2F, P2C].BackColor == Color.White || bot[P2F, P2C].BackColor == Color.Red || bot[P2F, P2C].BackColor == Color.Yellow || bot[P2F, P2C].BackColor == Color.Blue || bot[P2F, P2C].BackColor == Color.Orange || bot[P2F, P2C].BackColor == Color.Green || bot[P2F, P2C].BackColor == Color.MediumPurple || bot[P2F, P2C].BackColor == Color.SkyBlue || bot[P2F, P2C].BackColor == Color.Gray)
                            {
                                conc = conc + 1;
                            }

                            if (bot[P3F, P3C].BackColor == Color.Black || bot[P3F, P3C].BackColor == Color.White || bot[P3F, P3C].BackColor == Color.Red || bot[P3F, P3C].BackColor == Color.Yellow || bot[P3F, P3C].BackColor == Color.Blue || bot[P3F, P3C].BackColor == Color.Orange || bot[P3F, P3C].BackColor == Color.Green || bot[P3F, P3C].BackColor == Color.MediumPurple || bot[P3F, P3C].BackColor == Color.SkyBlue || bot[P3F, P3C].BackColor == Color.Gray)
                            {
                                conc = conc + 1;
                            }

                            if (bot[P4F, P4C].BackColor == Color.Black || bot[P4F, P4C].BackColor == Color.White || bot[P4F, P4C].BackColor == Color.Red || bot[P4F, P4C].BackColor == Color.Yellow || bot[P4F, P4C].BackColor == Color.Blue || bot[P4F, P4C].BackColor == Color.Orange || bot[P4F, P4C].BackColor == Color.Green || bot[P4F, P4C].BackColor == Color.MediumPurple || bot[P4F, P4C].BackColor == Color.SkyBlue || bot[P4F, P4C].BackColor == Color.Gray)
                            {
                                conc = conc + 1;
                            }

                            if (conc == 4)
                            {
                                aperturaC = 1;
                            }
                            else
                            {
                                aperturaC = 0;
                            }


                            if (aperturaC == 0)
                            {
                                //Encontrar posicion en el tablero
                                String Pos = temp.ID;
                                int Fila = (int)Char.GetNumericValue(Pos[1]) - 1;
                                int Columna = (int)(Pos[0]) - 65;
                                Color pin = Color.Lavender;
                                String tempco = J2[PCB];
                                PCB = PCB + 1;
                                

                                switch (tempco)
                                {
                                    case "Rojo":
                                        pin = Color.Red;
                                        break;

                                    case "Amarillo":
                                        pin = Color.Yellow;
                                        break;

                                    case "Azul":
                                        pin = Color.Blue;
                                        break;

                                    case "Naranja":
                                        pin = Color.Orange;
                                        break;

                                    case "Verde":
                                        pin = Color.Green;
                                        break;

                                    case "Violeta":
                                        pin = Color.MediumPurple;
                                        break;

                                    case "Blanco":
                                        pin = Color.White;
                                        break;

                                    case "Negro":
                                        pin = Color.Black;
                                        break;

                                    case "Celeste":
                                        pin = Color.SkyBlue;
                                        break;

                                    case "Gris":
                                        pin = Color.Gray;
                                        break;

                                }


                                if (Fila == P1F && Columna == P1C)
                                {

                                    temp.BackColor = pin;
                                    x = 1;
                                    Turno.Text = "Jugador 1";
                                }
                                else
                                {

                                    if (Fila == P2F && Columna == P2C)
                                    {
                                        temp.BackColor = pin;
                                        x = 1;
                                        Turno.Text = "Jugador 1";
                                    }
                                    else
                                    {

                                        if (Fila == P3F && Columna == P3C)
                                        {
                                            temp.BackColor = pin;
                                            x = 1;
                                            Turno.Text = "Jugador 1";
                                        }
                                        else
                                        {

                                            if (Fila == P4F && Columna == P4C)
                                            {
                                                temp.BackColor = pin;
                                                x = 1;
                                                Turno.Text = "Jugador 1";
                                            }
                                            else
                                            {
                                                Page.ClientScript.RegisterStartupScript(
                                                Page.GetType(),
                                                "Mensaje",
                                                "<script language='javascript'>alert('Movimiento no valido. Debe llenar el centro primero.');</script>");
                                            }
                                        }
                                    }
                                }

                            }
                            else
                            {
                                //Encontrar posicion en el tablero
                                String Pos = temp.ID;
                                int Fila = (int)Char.GetNumericValue(Pos[1]) - 1;
                                int Columna = (int)(Pos[0]) - 65;
                                Color pin = Color.Lavender;
                                String tempco = J2[PCB];
                                PCB = PCB + 1;
                                

                                switch (tempco)
                                {
                                    case "Rojo":
                                        pin = Color.Red;
                                        break;

                                    case "Amarillo":
                                        pin = Color.Yellow;
                                        break;

                                    case "Azul":
                                        pin = Color.Blue;
                                        break;

                                    case "Naranja":
                                        pin = Color.Orange;
                                        break;

                                    case "Verde":
                                        pin = Color.Green;
                                        break;

                                    case "Violeta":
                                        pin = Color.MediumPurple;
                                        break;

                                    case "Blanco":
                                        pin = Color.White;
                                        break;

                                    case "Negro":
                                        pin = Color.Black;
                                        break;

                                    case "Celeste":
                                        pin = Color.SkyBlue;
                                        break;

                                    case "Gris":
                                        pin = Color.Gray;
                                        break;

                                }

                                int PCSF = P1F - 1; //Fila superior a cuadrado central
                                int PCSCI = P1C - 1; //Inicio de columna
                                int PCSCF = P3C + 1; //Inicio de columna

                                int PCIF = P2F + 1; //Fila Inferior a cuadrado central
                                int PCICI = P1C - 1; //Inicio de columna
                                int PCICF = P3C + 1; //Inicio de columna

                                int PCFII = P1F; //Fila inicial a cuadrado central
                                int PCFFD = P2F; //Fila Final a cuadrado central
                                int PCI = P1C - 1; //columna izquierda


                                int PCF = P4C + 1; //columna derecha

                                if (Fila == PCIF && Columna >= PCICI && Columna <= PCICF)
                                {
                                    temp.BackColor = pin;
                                    x = 1;
                                    Turno.Text = "Jugador 1";

                                }
                                else
                                {
                                    if (Fila == PCSF && Columna >= PCSCI && Columna <= PCSCF)
                                    {
                                        temp.BackColor = pin;
                                        x = 1;
                                        Turno.Text = "Jugador 1";

                                    }
                                    else
                                    {
                                        if (Columna == PCI && Fila >= PCFII && Fila <= PCFFD)
                                        {
                                            temp.BackColor = pin;
                                            x = 1;
                                            Turno.Text = "Jugador 1";

                                        }
                                        else
                                        {
                                            if (Columna == PCF && Fila >= PCFII && Fila <= PCFFD)
                                            {
                                                temp.BackColor = pin;
                                                x = 1;
                                                Turno.Text = "Jugador 1";

                                            }
                                            else
                                            {
                                                Page.ClientScript.RegisterStartupScript(
                                               Page.GetType(),
                                               "Mensaje",
                                               "<script language='javascript'>alert('Movimiento no valido. Debe llenar las casillas que rodean al centro hasta que tenga una ficha de cada color en el tablero.');</script>");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            mov = 0;
                            TB = 0;
                            int FM = FI - 1;
                            int CM = CO - 1;
                            //Verificar posible movimientos
                            for (int i = 0; i < FI; i++)
                            {
                                for (int j = 0; j < CO; j++)
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

                                                    if (fit > FM)
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
                                        if ((i + 1) > FM)
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
                                                    if (cot > CM)
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
                                        if ((j + 1) > CM)
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
                                                    if (fit > FM || cot > CM)
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
                                        if ((i + 1) > FM || (j - 1) < 0)
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
                                                    if (fit < 0 || cot > CM)
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
                                        if ((i - 1) < 0 || (j + 1) > CM)
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
                                                    if (fit > FM || cot < 0)
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
                                        if ((i + 1) > FM || (j + 1) > CM)
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
                                    if (conn == conb)
                                    {



                                        const string FMT = "yyyy-MM-dd";
                                        DateTime hoy = DateTime.Now;
                                        string nom = hoy.ToString(FMT);
                                        SqlConnection con = new SqlConnection();
                                        con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                        con.Open();
                                        SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Empate', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                        con.Close();



                                        int f = 1;
                                        if (f == 1)
                                        {
                                            neg.Stop();
                                            bla.Stop();
                                            MessageBox.Show(this.Page, "Final del Juego. Empatados. ");
                                        }


                                    }
                                    else
                                    {
                                        if (conn > conb)
                                        {
                                            //Reto Inverso
                                            if (RI == 0)
                                            {
                                                gan = "Jugador 1 (Negras).";
                                                //Agregar a Base
                                                if (Jug == "N")
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                                else
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                            }
                                            else
                                            {
                                                gan = "Jugador 2 (Blancas).";
                                                //Agregar a Base
                                                if (Jug == "B")
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                                else
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                            }

                                        }
                                        else
                                        {
                                            //Reto Inverso
                                            if (RI == 1)
                                            {
                                                gan = "Jugador 1 (Negras).";
                                                //Agregar a Base
                                                if (Jug == "N")
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                                else
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                            }
                                            else
                                            {
                                                gan = "Jugador 2 (Blancas).";
                                                //Agregar a Base
                                                if (Jug == "B")
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Ganador', " + conb.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                                else
                                                {


                                                    const string FMT = "yyyy-MM-dd";
                                                    DateTime hoy = DateTime.Now;
                                                    string nom = hoy.ToString(FMT);
                                                    SqlConnection con = new SqlConnection();
                                                    con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                                                    con.Open();
                                                    SqlCommand c = new SqlCommand("Insert Into Partida (IDJugador,Modo,Estado,Movimientos,Fecha) values (" + ID.ToString() + "," + "'Maquina', 'Perdedor', " + conn.ToString() + ", " + "'" + nom + "'" + ")", con);
                                                    con.Close();


                                                }
                                            }

                                        }
                                        int f = 1;
                                        if (f == 1)
                                        {
                                            neg.Stop();
                                            bla.Stop();
                                            MessageBox.Show(this.Page, "Final del Juego. Gana " + gan);
                                        }

                                    }

                                }
                                else
                                {

                                    MessageBox.Show(this.Page, "Las fichas blancas no tienen movimientos disponibles.");
                                    x = 1;
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
                                    Turno.Text = "Jugador 2";
                                }
                                else
                                {
                                    Turno.Text = "Jugador 1";

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
            }
            conn = 0;
            conb = 0;
            for (int i = 0; i < FI; i++)
            {
                for (int j = 0; j < CO; j++)
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


        //Guardar
        protected void Button2_Click(object sender, EventArgs e)
        {
            const string FMT = "yyyy-MM-dd-HH-mm-ss";
            DateTime hoy = DateTime.Now;
            string nom = hoy.ToString(FMT);

            using (XmlWriter a = XmlWriter.Create("C:/Users/Usuario/Desktop/T/IPC2/r/P/IPC_201909035_Proyecto/Othell" + nom + ".xml"))
            {
                a.WriteStartDocument();
                a.WriteStartElement("tablero");

                //Ingresar Fichas
                for (int i = 0; i < FI; i++)
                {
                    for (int j = 0; j < CO; j++)
                    {
                        if (bot[i, j].BackColor == Color.Black || bot[i, j].BackColor == Color.White)
                        {
                            a.WriteStartElement("ficha");
                            if (bot[i, j].BackColor == Color.Black)
                            {
                                a.WriteElementString("color", "negro");
                            }
                            else
                            {
                                a.WriteElementString("color", "blanco");
                            }

                            char l = (char)(65 + j);
                            a.WriteElementString("columna", l.ToString());
                            a.WriteElementString("fila", i.ToString());
                            a.WriteEndElement();
                        }
                    }
                }

                //Tiro

                if (x == 1)
                {
                    a.WriteStartElement("siguienteTiro");
                    a.WriteElementString("color", "blanco");
                    a.WriteEndElement();
                }
                else
                {
                    a.WriteStartElement("siguienteTiro");
                    a.WriteElementString("color", "negro");
                    a.WriteEndElement();
                }
                a.WriteEndElement();
                a.Flush();
                a.Close();

            }
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
                for (int p = 0; p < FI; p++)
                {
                    for (int q = 0; q < CO; q++)
                    {
                        bot[p, q].BackColor = co;
                    }
                }
                
                //Cargar Datos
                if (Tiro == "negro")
                {
                    x = 1;
                    Turno.Text = "Negras";
                    Session["Color"] = "B";
                    Jug = (string)Session["Color"];
                }
                else
                {
                    x = 2;
                    Turno.Text = "Blancas";
                    Session["Color"] = "B";
                    Jug = (string)Session["Color"];
                }
                conn = 0;
                conb = 0;

                for (i = 0; i <= pos.Count - 1; i++)
                {
                    String posi = pos[i];
                    String colo = col[i];
                    int Fila = (int)Char.GetNumericValue(posi[1]) - 1;
                    int Columna = (int)(posi[0]) - 65;

                    if (Fila > (FI-1) || Columna > (CO-1) || Fila < 0 || Columna < 0)
                    {

                    }
                    else
                    {
                        if (colo == "blanco")
                        {
                            bot[Fila, Columna].BackColor = Color.White;
                            
                            conb += 1;
                        }
                        else
                        {
                            bot[Fila, Columna].BackColor = Color.Black;
                            
                            conn += 1;
                        }
                    }

                }
                Blancas.Text = conb.ToString();
                Negras.Text = conn.ToString();
                MessageBox.Show(this.Page, "Partida Cargada.");
            }
            else
            {
                MessageBox.Show(this.Page, "Seleccione un archivo primero.");
            }



        }


        //Salir
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx");
        }

        //Cronometro Basado en https://stackoverflow.com/questions/9223884/stopwatch-timer-in-asp-net
        //Blancas
        protected void T(object sender, EventArgs e)
        {
            long s;
            long min;

            if (x == 2)
            {
                bla.Start();
                neg.Stop();
                s = bla.Elapsed.Seconds;
                min = bla.Elapsed.Minutes;

                if (min < 60)
                {
                    if (min < 10)
                    {
                        Text1.Text = "0" + min;

                    }
                    else
                    {
                        Text1.Text = min.ToString();

                    }
                    Text1.Text += " : ";


                    if (s < 10)
                    {
                        Text1.Text += "0" + s;

                    }

                    else
                    {
                        Text1.Text += s.ToString();

                    }
                }
                else
                {
                    bla.Stop();
                    Response.Redirect("~/Menu");
                }
            }
            else
            {
                neg.Start();
                bla.Stop();
                s = neg.Elapsed.Seconds;
                min = neg.Elapsed.Minutes;

                if (min < 60)
                {
                    if (min < 10)
                    {

                        Text2.Text = "0" + min;
                    }
                    else
                    {

                        Text2.Text = min.ToString();
                    }

                    Text2.Text += " : ";

                    if (s < 10)
                    {

                        Text2.Text += "0" + s;
                    }

                    else
                    {

                        Text2.Text += s.ToString();
                    }
                }
                else
                {
                    neg.Stop();
                    Response.Redirect("~/Menu");
                }
            }

        }
    }
}