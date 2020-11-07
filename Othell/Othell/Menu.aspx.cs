using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Othell
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Intermedio - M.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("~/Intermedio.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Intermedio - X.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Intermedio - XM.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Intermedio - X.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Perfil.aspx");
        }
    }
}