using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Othell
{
    public partial class Torneo___Diagrama : System.Web.UI.Page
    {
        public static String NomTor; //Mombre del Torneo
        public static List<string> J1e;  //Lista de jugadores 1
        public static List<string> J2e;  //Lista de jugadores 2
        public static List<string> J3e;  //Lista de jugadores 3
        public static List<string> equipos;  //Lista de Colores 2
        public static int partidas; //Indica el numero de equipos que falta hasta pasar a otra ronda
        public static int contador = 0; //Indica los miembros que han jugado. Si llega a 3 se pasa a los otros equipos
        public static int ban = 0; //Indica los miembros que han jugado. Si llega a 3 se pasa a los otros equipos
        public static int equipo1; //indica el equipo 1 actual
        public static int equipo2; //indica el equipo 2 actual
        public static String jug1; //jugador del equipo1
        public static String jug2; //jugador del equipo2
        public static int puntos1; //indica puntos del 1 actual
        public static int puntos2; //indica puntos del 2
        public static int partidaini; //Indica la cantidad inicial
        protected void Page_Load(object sender, EventArgs e)
        {
            NomTor = (string)Session["NomTorneo"];
            equipos = (List<string>)Session["Equipos"];
            J1e=(List<string>)Session["J1e"];
            J2e=(List<string>)Session["J2e"];
            J3e=(List<string>)Session["J3e"];

            if (!Page.IsPostBack)
            {
                equipo1 = 0;
                equipo2 = 1;
                if(equipos.Count == 16)
                {
                    partidaini = 8;
                }if(equipos.Count == 8)
                {
                    partidaini = 4;

                }if(equipos.Count == 4)
                {
                    partidaini = 2;
                }
            }

            Titulo.Text = NomTor;
            if(equipos.Count==16)
            {
                TextBox1.Text = equipos[0];
                TextBox2.Text = equipos[1];
                TextBox3.Text = equipos[2];
                TextBox4.Text = equipos[3];
                TextBox5.Text = equipos[4];
                TextBox6.Text = equipos[5];
                TextBox7.Text = equipos[6];
                TextBox8.Text = equipos[7];
                TextBox9.Text = equipos[8];
                TextBox10.Text = equipos[9];
                TextBox11.Text = equipos[10];
                TextBox12.Text = equipos[11];
                TextBox13.Text = equipos[12];
                TextBox14.Text = equipos[13];
                TextBox15.Text = equipos[14];
                TextBox16.Text = equipos[15];
                partidas = 8;
                
            }
            else
            {
                if(equipos.Count == 8)
                {
                    TextBox17.Text = equipos[0];
                    TextBox18.Text = equipos[1];
                    TextBox19.Text = equipos[2];
                    TextBox20.Text = equipos[3];
                    TextBox21.Text = equipos[4];
                    TextBox22.Text = equipos[5];
                    TextBox23.Text = equipos[6];
                    TextBox24.Text = equipos[7];
                    partidas = 4;
                }
                else
                {
                    TextBox25.Text = equipos[0];
                    TextBox26.Text = equipos[1];
                    TextBox27.Text = equipos[2];
                    TextBox28.Text = equipos[3];
                    partidas = 2;
                }
            }

            TextBox33.Text = equipos[equipo1] + "Vs. " + equipos[equipo2];
            if (contador == 0)
            {
                jug1 = J1e[equipo1];
                jug2 = J1e[equipo2];
                TextBox36.Text = "Ronda 1";
            }
            else
            {
                if (contador == 1)
                {
                    jug1 = J2e[equipo1];
                    jug2 = J2e[equipo2];
                    TextBox36.Text = "Ronda 2";
                }
                else
                {
                    if (contador == 2)
                    {
                        jug1 = J3e[equipo1];
                        jug2 = J3e[equipo2];
                        TextBox36.Text = "Ronda 3";
                    }
                    else
                    {
                        if (contador == 3)
                        {
                            jug1 = J1e[equipo1];
                            jug2 = J3e[equipo2];
                            TextBox36.Text = "Ronda Final";
                        }
                    }
                }
            }

            TextBox35.Text = jug1;
            TextBox32.Text = jug2;


        }











        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}