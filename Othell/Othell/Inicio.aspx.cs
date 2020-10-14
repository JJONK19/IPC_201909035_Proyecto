using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Othell
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registro.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text))
            {
                Page.ClientScript.RegisterStartupScript(
               Page.GetType(),
               "Mensaje",
               "<script language='javascript'>alert('LLene ambos campos antes de continuar.');</script>");
            }
            else
            {
                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                con.Open();
                SqlCommand c = new SqlCommand("SELECT COUNT(*) from Jugador where Username like '"+TextBox1.Text+"' AND Pass like '"+TextBox2.Text+"'",con);
                int usuario = (int)c.ExecuteScalar();
                SqlCommand d = new SqlCommand("SELECT IDJugador from Jugador where Username like '" + TextBox1.Text + "' AND Pass like '" + TextBox2.Text + "'", con);
                SqlDataReader a = d.ExecuteReader();
                if (a.Read())
                {
                    Session["ID"] = a.GetInt32(0);
                }
                con.Close();
                if (usuario > 0)
                {
                    Response.Redirect("~/Menu.aspx");
                    
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(
                    Page.GetType(),
                    "Mensaje",
                    "<script language='javascript'>alert('Usuario Inexistente o Contraseña Inexistente.');</script>");
                }

            }
            
        }
    }
}