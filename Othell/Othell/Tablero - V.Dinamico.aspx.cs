using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Othell
{
    public partial class Tablero___V_Dinamico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if(Session["Tablero"] == null)
                {
                    Button[,] bot = new Button[50,50];
                    for(int i = 0; i < 50; i++)
                    {
                        for (int j = 0; j < 50; j++)
                        {
                            Button b = new Button();
                            b.ID = (char)(65 + j) + (i + 1).ToString();
                            b.Text = "";
                            b.Attributes.Add("class", "but");
                            bot[i, j] = b;
                        }
                    }
                    Session["Tablero"] = bot;
                    TableRow f;
                    TableCell c;

                    for(int k = 0; k<50; k++)
                    {
                        f = new TableRow();
                        for(int l =0; l<50; l++)
                        {
                            c = new TableCell();
                            c.Controls.Add(bot[k, l]);
                            f.Cells.Add(c);
                        }
                        tablero.Rows.Add(f);
                    }
                }
            }

            if (Page.IsPostBack)
            {
                Button[,] bot = (Button[,])Session["Tablero"];
                TableRow f;
                TableCell c;

                for (int k = 0; k < 50; k++)
                {
                    f = new TableRow();
                    for (int l = 0; l < 50; l++)
                    {
                        c = new TableCell();
                        c.Controls.Add(bot[k, l]);
                        f.Cells.Add(c);
                    }
                    tablero.Rows.Add(f);
                }
            }
        }
    }
}