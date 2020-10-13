using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Othell
{
    public partial class Intermedio___M : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Color"] = "B";
            Response.Redirect("~/Tablero - M.Dinamico.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            int x = a.Next(1, 3);
            if (x == 1)
            {
                Session["Color"] = "N";
                Response.Redirect("~/Tablero - M.Dinamico.aspx");
            }
            else
            {
                Session["Color"] = "B";
                Response.Redirect("~/Tablero - M.Dinamico.aspx");

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["Color"] = "N";
            Response.Redirect("~/Tablero - M.Dinamico.aspx");

        }
    }
}