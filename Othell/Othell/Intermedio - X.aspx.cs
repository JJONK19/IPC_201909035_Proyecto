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

                        Response.Redirect("~/Tablero - X.Dinamico.aspx");
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
    }
}