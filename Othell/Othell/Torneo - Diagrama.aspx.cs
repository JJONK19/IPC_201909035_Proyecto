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
        public static List<string> J1e;  //Lista de Colores 1
        public static List<string> J2e;  //Lista de Colores 2
        public static List<string> J3e;  //Lista de Colores 1
        public static List<string> equipos;  //Lista de Colores 2
        protected void Page_Load(object sender, EventArgs e)
        {
            NomTor = (string)Session["NomTorneo"];
            equipos = (List<string>)Session["Equipos"];
            J1e=(List<string>)Session["J1e"];
            J2e=(List<string>)Session["J2e"];
            J3e=(List<string>)Session["J3e"];

            Titulo.Text = NomTor;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}