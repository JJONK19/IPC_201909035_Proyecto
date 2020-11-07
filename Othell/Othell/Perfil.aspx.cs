using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Othell
{
    public partial class Perfil : System.Web.UI.Page
    {
        public static int ID = 0; //ID del Usuario
        protected void Page_Load(object sender, EventArgs e)
        {
            ID = (int)Session["ID"];

            //Buscar y Cargar
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
            con.Open();
            
            SqlCommand d = new SqlCommand("SELECT Nombres from Jugador where IDJugador like '" + ID.ToString() + "'", con);
            SqlDataReader a = d.ExecuteReader();
            if (a.Read())
            {
                Box1.Text = a.GetString(0);
            }
            a.Close();

            SqlCommand d1 = new SqlCommand("SELECT Apellidos from Jugador where IDJugador like '" + ID.ToString() + "'", con);
            SqlDataReader a1 = d1.ExecuteReader();
            if (a1.Read())
            {
                Box3.Text = a1.GetString(0);
            }
            a1.Close();

            SqlCommand d2 = new SqlCommand("SELECT Username from Jugador where IDJugador like '" + ID.ToString() + "'", con);
            SqlDataReader a2 = d2.ExecuteReader();
            if (a2.Read())
            {
                Box4.Text = a2.GetString(0);
            }
            a2.Close();

            SqlCommand d3 = new SqlCommand("SELECT Pais from Jugador where IDJugador like '" + ID.ToString() + "'", con);
            SqlDataReader a3 = d3.ExecuteReader();
            if (a3.Read())
            {
                Box6.Text = a3.GetString(0);
            }
            a3.Close();

            SqlCommand d4 = new SqlCommand("SELECT Correo from Jugador where IDJugador like '" + ID.ToString() + "'", con);
            SqlDataReader a4 = d4.ExecuteReader();
            if (a4.Read())
            {
                Box5.Text = a4.GetString(0);
            }
            a4.Close();

            SqlCommand d5 = new SqlCommand("SELECT F_Nacimiento from Jugador where IDJugador like '" + ID.ToString() + "'", con);
            SqlDataReader a5 = d5.ExecuteReader();
            if (a5.Read())
            {
                DateTime temp = a5.GetDateTime(0).Date;
                Box2.Text = temp.ToString("dd/MM/yyyy");
            }
            a5.Close();

            SqlCommand c = new SqlCommand("SELECT COUNT(*) from Partida where IDJugador like '" + ID.ToString() + "' AND Estado like 'Ganador'", con);
            int co = (int)c.ExecuteScalar(); 
            Box7.Text = co.ToString();
            

            c = new SqlCommand("SELECT COUNT(*) from Partida where IDJugador like '" + ID.ToString() + "' AND Estado like 'Perdedor'", con);
            int co1 = (int)c.ExecuteScalar();
            Box8.Text = co1.ToString();

            c = new SqlCommand("SELECT COUNT(*) from Partida where IDJugador like '" + ID.ToString() + "' AND Estado like 'Empate'", con);
            int co2 = (int)c.ExecuteScalar();
            Box10.Text = co2.ToString();
            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx");
        }
    }
}