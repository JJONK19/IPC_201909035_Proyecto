using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Othell
{



    public partial class Intermedio___X : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Box1.Text) || String.IsNullOrEmpty(Box2.Text))
            {
                Page.ClientScript.RegisterStartupScript(
               Page.GetType(),
               "Mensaje",
               "<script language='javascript'>alert('Es necesario que indique el tamaño del tablero.');</script>");
            }
            else
            {
                int M = Int16.Parse(Box1.Text);
                int N = Int16.Parse(Box2.Text);
                if (M > 20 || M < 6 || N > 20 || N < 6)
                {
                    Page.ClientScript.RegisterStartupScript(
                    Page.GetType(),
                    "Mensaje",
                    "<script language='javascript'>alert('El tamaño permitido es un par entre 6 y 20.');</script>");
                }
                else
                {
                    if (M % 2 != 0 || N % 2 != 0)
                    {
                        Page.ClientScript.RegisterStartupScript(
                        Page.GetType(),
                        "Mensaje",
                        "<script language='javascript'>alert('El tamaño permitido es un par entre 6 y 20.');</script>");
                    }
                    else
                    {
                        Session["M"] = M;
                        Session["N"] = N;
                        Session["Color"] = "N";
                        if (Check.Checked)
                        {
                            Session["RI"] = 1;
                        }
                        else
                        {
                            Session["RI"] = 0;
                        }

                        if (Check0.Checked)
                        {
                            Session["AP"] = 1;
                        }
                        else
                        {
                            Session["AP"] = 0;
                        }
                        //Agregar Colores J1
                        List<string> J1 = new List<string>();  //Lista de Colores 1
                        if(J11.SelectedItem.Text == "Vacio")
                        {

                        }
                        else
                        {
                            J1.Add(J11.SelectedItem.Text);
                        }

                        if (J12.SelectedItem.Text == "Vacio")
                        {

                        }
                        else
                        {
                            J1.Add(J12.SelectedItem.Text);
                        }

                        if (J13.SelectedItem.Text == "Vacio")
                        {

                        }
                        else
                        {
                            J1.Add(J13.SelectedItem.Text);
                        }

                        if (J14.SelectedItem.Text == "Vacio")
                        {

                        }
                        else
                        {
                            J1.Add(J14.SelectedItem.Text);
                        }

                        if (J15.SelectedItem.Text == "Vacio")
                        {

                        }
                        else
                        {
                            J1.Add(J15.SelectedItem.Text);
                        }
                        //Agregar Colores J2
                        List<string> J2 = new List<string>();  //Lista de Colores 1
                        if (J21.SelectedItem.Text == "Vacio")
                        {

                        }
                        else
                        {
                            J2.Add(J21.SelectedItem.Text);
                        }

                        if (J22.SelectedItem.Text == "Vacio")
                        {

                        }
                        else
                        {
                            J2.Add(J22.SelectedItem.Text);
                        }

                        if (J23.SelectedItem.Text == "Vacio")
                        {

                        }
                        else
                        {
                            J2.Add(J23.SelectedItem.Text);
                        }

                        if (J24.SelectedItem.Text == "Vacio")
                        {

                        }
                        else
                        {
                            J2.Add(J24.SelectedItem.Text);
                        }

                        if (J25.SelectedItem.Text == "Vacio")
                        {

                        }
                        else
                        {
                            J2.Add(J25.SelectedItem.Text);
                        }

                        int ban1 = 0;
                        int ban2 = 0;
                        int ban3 = 0;
                        int ban4 = 0;
                        int ban5 = 0;

                        //Ban1
                        for (int i = 0; i < J1.Count;i++)
                        {
                            int c = 0;
                            String temp = J1[i];
                            for (int j = 0; j < J1.Count; j++)
                            {
                                if(temp == J1[j])
                                {
                                    c = c + 1;
                                }

                                if(c > 1)
                                {
                                    ban1 = 1;
                                }
                            }
                        }

                        //Ban2
                        for (int i = 0; i < J2.Count; i++)
                        {
                            int c = 0;
                            String temp = J2[i];
                            for (int j = 0; j < J2.Count; j++)
                            {
                                if (temp == J2[j])
                                {
                                    c = c + 1;
                                }

                                if (c > 1)
                                {
                                    ban2 = 1;
                                }
                            }
                        }

                        //Ban3
                        for (int i = 0; i < J1.Count; i++)
                        {
                            int c = 0;
                            String temp = J1[i];
                            for (int j = 0; j < J2.Count; j++)
                            {
                                if (temp == J2[j])
                                {
                                    c = c + 1;
                                }

                                if (c >= 1)
                                {
                                    ban3 = 1;
                                }
                            }
                        }

                        //Ban4
                        int a1 = J1.Count;
                        if(a1 == 0)
                        {
                            ban4 = 1;
                        }

                        //Ban5
                        int a2 = J2.Count;
                        if (a2 == 0)
                        {
                            ban4 = 1;
                        }

                        if (ban1 == 1 || ban2 ==1 || ban3 == 1 || ban4 == 1 || ban5 == 1)
                        {
                            Page.ClientScript.RegisterStartupScript(
                            Page.GetType(),
                            "Mensaje",
                            "<script language='javascript'>alert('Los colores deben de ser diferentes para ambos jugadores. Tampoco es posible avanzar sin que ambos jugadores no tomen un color.');</script>");
                        }
                        else
                        {
                            Session["J1"] = J1;
                            Session["J2"] = J2;
                            Session["xml"] = 0;
                            Response.Redirect("~/Tablero - X.Dinamico.aspx");
                        }
                       
                    }
                }
            }

        }

        protected void Box2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
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
                XmlNodeList nodo2; //Sirve para separar filas
                XmlNodeList nodo3; //Sirve para separar columnas
                XmlNodeList nodo4; //Sirve para separar Modo
                XmlNodeList nodo5; //Sirve para lista de colores de J1
                XmlNodeList nodo6; //Sirve para lista de colores de J2
                xml.Load(m);
                node = xml.GetElementsByTagName("ficha");
                node1 = xml.GetElementsByTagName("siguienteTiro");
                nodo2 = xml.GetElementsByTagName("filas");
                nodo3 = xml.GetElementsByTagName("columnas");
                nodo4 = xml.GetElementsByTagName("Modalidad");
                nodo5 = xml.GetElementsByTagName("Jugador1");
                nodo6 = xml.GetElementsByTagName("Jugador2");

                //Almacenar Tiro
                String Tiro = null;
                node1[0].ChildNodes.Item(0).InnerText.Trim();
                Tiro = node1[0].ChildNodes.Item(0).InnerText.Trim();
                

                //Almacenar Filas
                String filas = null;
                filas = nodo2[0].ChildNodes.Item(0).InnerText.Trim();

                //Almacenar Columnas
                String columnas = null;
                columnas = nodo3[0].ChildNodes.Item(0).InnerText.Trim();

                //Almacenar Modo
                String modo = null;
                modo = nodo4[0].ChildNodes.Item(0).InnerText.Trim();

                //Almacenar colores J1

                var J1x = new List<String>();
                for (int i = 0; i <= (nodo5[0].ChildNodes.Count - 1); i++)
                {
                    String temp = nodo5[0].ChildNodes.Item(i).InnerText.Trim();
                    switch (temp)
                    {
                        case "rojo":
                            J1x.Add("Rojo");
                            break;

                        case "amarillo":
                            J1x.Add("Amarillo");
                            break;

                        case "azul":
                            J1x.Add("Azul");
                            break;

                        case "naranja":
                            J1x.Add("Naranja");
                            break;

                        case "verde":
                            J1x.Add("Verde");
                            break;

                        case "violeta":
                            J1x.Add("Violeta");
                            break;

                        case "blanco":
                            J1x.Add("Blanco");
                            break;

                        case "negro":
                            J1x.Add("Negro");
                            break;

                        case "Celeste":
                            J1x.Add("celeste");
                            break;

                        case "gris":
                            J1x.Add("Gris");
                            break;

                    }
                }


                //Almacenar colores J2

                var J2x = new List<String>();
                for (int i = 0; i <= (nodo6[0].ChildNodes.Count - 1); i++)
                {
                    String temp = nodo6[0].ChildNodes.Item(i).InnerText.Trim();
                    switch (temp)
                    {
                        case "rojo":
                            J2x.Add("Rojo");
                            break;

                        case "amarillo":
                            J2x.Add("Amarillo");
                            break;

                        case "azul":
                            J2x.Add("Azul");
                            break;

                        case "naranja":
                            J2x.Add("Naranja");
                            break;

                        case "verde":
                            J2x.Add("Verde");
                            break;

                        case "violeta":
                            J2x.Add("Violeta");
                            break;

                        case "blanco":
                            J2x.Add("Blanco");
                            break;

                        case "negro":
                            J2x.Add("Negro");
                            break;

                        case "Celeste":
                            J2x.Add("celeste");
                            break;

                        case "gris":
                            J2x.Add("Gris");
                            break;

                    }
                }

                //Almacenar Posiciones y colores

                var pos = new List<String>();
                var col = new List<String>(); 
                for (int i = 0; i <= node.Count - 1; i++)
                {
                    node[i].ChildNodes.Item(0).InnerText.Trim();
                    pos.Add(node[i].ChildNodes.Item(1).InnerText.Trim() + node[i].ChildNodes.Item(2).InnerText.Trim());
                    col.Add(node[i].ChildNodes.Item(0).InnerText.Trim());
                }
                Session["pos"] = pos;
                Session["col"] = col;
                Session["xml"] = 1;
                //Cargar Datos
                Session["M"] = Int32.Parse(filas);
                

                Session["N"] = Int32.Parse(columnas);
               

                if (modo.Equals("Normal"))
                {
                    Session["RI"] = 0;
                    
                }
                else
                {
                    Session["RI"] = 1;
                   
                }

                Session["J1"] = J1x; 

                Session["J2"] = J2x;

                Session["AP"] = 0;

                //Hallar Tiro
                switch (Tiro)
                {
                    case "rojo":
                        Tiro = "Rojo";
                        break;

                    case "amarillo":
                        Tiro ="Amarillo";
                        break;

                    case "azul":
                        Tiro = "Azul";
                        break;

                    case "naranja":
                        Tiro = "Naranja";
                        break;

                    case "verde":
                        Tiro = "Verde";
                        break;

                    case "violeta":
                        Tiro ="Violeta";
                        break;

                    case "blanco":
                        Tiro = "Blanco";
                        break;

                    case "negro":
                        Tiro = "Negro";
                        break;

                    case "Celeste":
                        Tiro = "celeste";
                        break;

                    case "gris":
                        Tiro = "Gris";
                        break;

                }

                int ti = 0;
                int PBC = -1;
                int PNC = -1;
                for(int k = 0; k < J1x.Count; k++)
                {
                    if (Tiro.Equals(J1x[k]))
                    {
                        ti = 1;
                        PNC = k;
                    }
                }

                for (int k = 0; k < J2x.Count; k++)
                {
                    if (Tiro.Equals(J2x[k]))
                    {
                        
                        ti = 2;
                        PBC = k;
                    }
                }

                if(PBC == -1)
                {
                    PBC = 0;
                }
                if (PNC == -1)
                {
                    PNC = 0;
                }
                Session["PBC"] = PBC;
                Session["PNC"] = PNC;
                Session["X"] = ti;
                Response.Redirect("~/Tablero - X.Dinamico.aspx");
            }
            else
            {
                MessageBox.Show(this.Page, "Seleccione un archivo primero.");
            }



        }
    }
}