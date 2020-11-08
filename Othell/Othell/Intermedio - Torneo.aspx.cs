
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Othell
{
    public partial class Intermedio___Torneo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

                MemoryStream m = new MemoryStream(Archivo);
                XmlDataDocument xml = new XmlDataDocument();
                XmlNodeList node;
                XmlNodeList node1;
               
                xml.Load(m);
                node = xml.GetElementsByTagName("nombre");
                node1 = xml.GetElementsByTagName("equipo");
               

                //Almacenar Nombre
                String nombre = null;
                nombre = node[0].ChildNodes.Item(0).InnerText.Trim();


                //Almacenar Equipos y Miembris

                var equipos = new List<String>();
                
                var J1e = new List<String>();
                var J2e = new List<String>();
                var J3e = new List<String>();
                for (int i = 0; i <= node1.Count - 1; i++)
                {
                    equipos.Add(node1[i].ChildNodes.Item(0).InnerText.Trim());
                    J1e.Add(node1[i].ChildNodes.Item(1).InnerText.Trim());
                    J2e.Add(node1[i].ChildNodes.Item(2).InnerText.Trim());
                    J3e.Add(node1[i].ChildNodes.Item(3).InnerText.Trim());
                }

                //Registrar Equipos
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                con.Open();
                for (int i = 0; i < equipos.Count; i++)
                {
                    
                    SqlCommand c = new SqlCommand("SELECT COUNT(*) from Equipos where Nombre like '" + equipos[i] + "'", con);
                    int equipo = (int)c.ExecuteScalar();
                    if(equipo == 0)
                    {
                        const string FMT = "yyyy-MM-dd";
                        DateTime hoy = DateTime.Now;
                        string nom3 = hoy.ToString(FMT);
                        SqlCommand b8 = new SqlCommand("Insert Into Equipos (Nombre, FechaCreacion) values ('" + equipos[i] + "' , '" + nom3 +"')", con);
                        b8.ExecuteNonQuery();
                        
                    }
                }
                con.Close();

                //Registrar Jugadores en equipos
                SqlConnection cono = new SqlConnection();
                cono.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                cono.Open();
                for (int i = 0; i < equipos.Count; i++)
                {
                    int IDE = 0;
                    SqlCommand d2 = new SqlCommand("SELECT IDEquipo from Equipos where Nombre like '" + equipos[i] + "'", cono);
                    SqlDataReader a2 = d2.ExecuteReader();
                    if (a2.Read())
                    {
                        IDE = a2.GetInt32(0);
                    }
                    a2.Close();

                    int ID1 = 0;
                    SqlCommand d = new SqlCommand("SELECT IDJugador from Jugador where Username like '" + J1e[i] + "'", cono);
                    SqlDataReader a = d.ExecuteReader();
                    if (a.Read())
                    {
                        ID1 = a.GetInt32(0);
                    }
                    a.Close();

                    int ID2 = 0;
                    SqlCommand d1 = new SqlCommand("SELECT IDJugador from Jugador where Username like '" + J2e[i] + "'", cono);
                    SqlDataReader a1 = d1.ExecuteReader();
                    if (a1.Read())
                    {
                        ID2 = a1.GetInt32(0);
                    }
                    a1.Close();

                    int ID3 = 0;
                    SqlCommand d3 = new SqlCommand("SELECT IDJugador from Jugador where Username like '" + J3e[i] + "'", cono);
                    SqlDataReader a3 = d3.ExecuteReader();
                    if (a3.Read())
                    {
                        ID3 = a3.GetInt32(0);
                    }
                    a3.Close();

                    SqlCommand b5 = new SqlCommand("Insert Into Jugador_Equipo (IDEquipo, IDJugador) values (" + IDE.ToString() + " , " + ID1.ToString() + ")", cono);
                    b5.ExecuteNonQuery();

                    SqlCommand b1 = new SqlCommand("Insert Into Jugador_Equipo (IDEquipo, IDJugador) values (" + IDE.ToString() + " , " + ID2.ToString() + ")", cono);
                    b1.ExecuteNonQuery();

                    SqlCommand b2 = new SqlCommand("Insert Into Jugador_Equipo (IDEquipo, IDJugador) values (" + IDE.ToString() + " , " + ID3.ToString() + ")", cono);
                    b2.ExecuteNonQuery();
                }
                cono.Close();


                //Registrar Torneo
                cono = new SqlConnection();
                cono.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                cono.Open();
                const string FMT1 = "yyyy-MM-dd";
                DateTime hoy1 = DateTime.Now;
                string nom = hoy1.ToString(FMT1);
                int noj = equipos.Count * 3;
                SqlCommand b = new SqlCommand("Insert Into Torneo (NombreTorneo, NoJugadores, FechaCreacion) values ('" + nombre + "' ,"+noj.ToString() +",'" + nom + "')", cono);
                b.ExecuteNonQuery();
                cono.Close();

                //Registrar equipo en campeonato
                cono = new SqlConnection();
                cono.ConnectionString = "Data Source =.; Initial Catalog = Othello; Integrated Security = True";
                cono.Open();
                int IDT = 0;
                SqlCommand x = new SqlCommand("SELECT IDTorneo from Torneo where NombreTorneo like '" + nombre + "'", cono);
                SqlDataReader z = x.ExecuteReader();
                if (z.Read())
                {
                    IDT = z.GetInt32(0);
                }
                z.Close();

                for (int i = 0; i < equipos.Count; i++)
                {
                    int IDE = 0;
                    SqlCommand d2 = new SqlCommand("SELECT IDEquipo from Equipos where Nombre like '" + equipos[i] + "'", cono);
                    SqlDataReader a2 = d2.ExecuteReader();
                    if (a2.Read())
                    {
                        IDE = a2.GetInt32(0);
                    }
                    a2.Close();

                    SqlCommand b5 = new SqlCommand("Insert Into Torneo_Equipo (IDEquipo, IDTorneo) values (" + IDE.ToString() + " , " + IDT.ToString() + ")", cono);
                    b5.ExecuteNonQuery();
                }
                    cono.Close();

                //Guardar datos de Sesion
                Session["NomTorneo"] = nombre;
                Session["Equipos"] = equipos;
                Session["J1e"] = J1e;
                Session["J2e"] = J2e;
                Session["J3e"] = J3e;

                Response.Redirect("~/Torneo - Diagrama.aspx");

            }
            else
            {
                MessageBox.Show(this.Page, "Seleccione un archivo primero.");
            }



        }
    }
}