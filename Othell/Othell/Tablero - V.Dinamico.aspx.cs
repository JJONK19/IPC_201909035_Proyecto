using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Othell
{
    public partial class Tablero___V_Dinamico : System.Web.UI.Page
    {
        int ver = 0; //Verifica si se inicia el codigo
        public static int x = 1;  //1 para jugador 1, 2 para jugador 2 en donde x es el turno
                                  //Blancas J2, Negras J1
        Button[,] bot = null;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
                if (ver == 0)
                {
                    bot = new Button[8, 8];
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {   
                            Button b = new Button();
                            char a = (char) (65 + j);
                            int b1 = i + 1;
                            string tem = a.ToString() + b1.ToString(); 
                            b.ID = tem;
                            b.Text = "";
                            b.Click += new EventHandler(this.Evento);
                            b.Attributes.Add("class", "but");
                            bot[i, j] = b;
                        }
                    }
                    ver = 1;
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

            
            

            if (Page.IsPostBack)
            {
                bot = (Button[,])Session["Tablero"];   
            }

           
        }

        public void Evento(object sender, System.EventArgs e)
        {
            Button temp = (Button)sender;
            int b = 0;
            //Colorear Botones
            if (temp.BackColor == Color.Black || temp.BackColor == Color.White)
            {
                b = 1;
            }

            if(b == 0)
            {
                if (x == 1)
                {
                    temp.BackColor = Color.Black;
                    x = 2;
                }
                else
                {
                    temp.BackColor = Color.White;
                    x = 1;
                }
            }
            


        }


    }
}