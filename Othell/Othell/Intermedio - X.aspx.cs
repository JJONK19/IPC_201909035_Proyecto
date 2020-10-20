using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                            J1.Add(J11.SelectedItem.Text);
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

                                if (c > 1)
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
    }
}