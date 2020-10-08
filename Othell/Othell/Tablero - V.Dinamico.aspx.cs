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
                    Button[,] bot = new Button[8,8];
                    for(int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            Button b = new Button();
                            char a = (char) (65 + j);
                            int b1 = i + 1;
                            string tem = a.ToString() + b1.ToString(); 
                            b.ID = tem;
                            b.Text = "";

                            b.Attributes.Add("class", "but");
                            bot[i, j] = b;
                        }
                    }
                    Session["Tablero"] = bot;
                    TableRow f;
                    TableCell c;

                    for(int k = 0; k<8; k++)
                    {
                        f = new TableRow();
                        for(int l =0; l<8; l++)
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

                for (int k = 0; k < 8; k++)
                {
                    f = new TableRow();
                    for (int l = 0; l < 8; l++)
                    {
                        c = new TableCell();
                        c.Controls.Add(bot[k, l]);
                        f.Cells.Add(c);
                    }
                    tablero.Rows.Add(f);
                }
            }
        }

        protected void Cbot(object sender, EventArgs e)
        {

        }
    }
}