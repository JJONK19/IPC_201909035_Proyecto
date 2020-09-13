using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Linq;


namespace Othell
{
    public static class MessageBox
    {
        public static void Show(this Page Page, String Message)
        {
            Page.ClientScript.RegisterStartupScript(
               Page.GetType(),
               "MessageBox",
               "<script language='javascript'>alert('" + Message + "');</script>"
            );
        }
    }


    public partial class Tablero : System.Web.UI.Page
    {
        public static int x = 1;  //1 para jugador 1, 2 para jugador 2 en donde x es el turno
                                  //Blancas J2, Negras J1
        public static int c1 = 0;
        public static int c2 = 0;
        public static int c3 = 0;
        public static int c4 = 0;
        public static int c5 = 0;
        public static int c6 = 0;
        public static int c7 = 0;
        public static int c8 = 0;
        public static int c9 = 0;
        public static int c10 = 0;
        public static int c11 = 0;
        public static int c12 = 0;
        public static int c13 = 0;
        public static int c14 = 0;
        public static int c15 = 0;
        public static int c16 = 0;
        public static int c17 = 0;
        public static int c18 = 0;
        public static int c19 = 0;
        public static int c20 = 0;
        public static int c21 = 0;
        public static int c22 = 0;
        public static int c23 = 0;
        public static int c24 = 0;
        public static int c25 = 0;
        public static int c26 = 0;
        public static int c27 = 0;
        public static int c28 = 0;
        public static int c29 = 0;
        public static int c30 = 0;
        public static int c31 = 0;
        public static int c32 = 0;
        public static int c33 = 0;
        public static int c34 = 0;
        public static int c35 = 0;
        public static int c36 = 0;
        public static int c37 = 0;
        public static int c38 = 0;
        public static int c39 = 0;
        public static int c40 = 0;
        public static int c41 = 0;
        public static int c42 = 0;
        public static int c43 = 0;
        public static int c44 = 0;
        public static int c45 = 0;
        public static int c46 = 0;
        public static int c47 = 0;
        public static int c48 = 0;
        public static int c49 = 0;
        public static int c50 = 0;
        public static int c51 = 0;
        public static int c52 = 0;
        public static int c53 = 0;
        public static int c54 = 0;
        public static int c55 = 0;
        public static int c56 = 0;
        public static int c57 = 0;
        public static int c58 = 0;
        public static int c59 = 0;
        public static int c60 = 0;



        //Boton A8
        protected void Button116_Click(object sender, EventArgs e)
        {
            if (c1 == 0)
            {
                if (x == 1)
                {
                    Button116.BackColor = Color.Black;
                    x = 2;
                    c1 = 1;
                }
                else
                {
                    Button116.BackColor = Color.White;
                    x = 1;
                    c1 = 1;
                }
            } 
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button121_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {

        }

        protected void Button22_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void A1_Click(object sender, EventArgs e)
        {

        }

        protected void Button88_Click(object sender, EventArgs e)
        {
            if (c3 == 0)
            {
                if (x == 1)
                {
                    Button88.BackColor = Color.Black;
                    x = 2;
                    c3 = 1;
                }
                else
                {
                    Button88.BackColor = Color.White;
                    x = 1;
                    c3 = 1;
                }
            }
        }

        protected void Button78_Click(object sender, EventArgs e)
        {
            if (c17 == 0)
            {
                if (x == 1)
                {
                    Button78.BackColor = Color.Black;
                    x = 2;
                    c17 = 1;
                }
                else
                {
                    Button78.BackColor = Color.White;
                    x = 1;
                    c17 = 1;
                }
            }
        }

        protected void Button108_Click(object sender, EventArgs e)
        {
            if (c20 == 0)
            {
                if (x == 1)
                {
                    Button108.BackColor = Color.Black;
                    x = 2;
                    c20 = 1;
                }
                else
                {
                    Button108.BackColor = Color.White;
                    x = 1;
                    c20 = 1;
                }
            }
        }

        protected void Button117_Click(object sender, EventArgs e)
        {
            if (c37 == 0)
            {
                if (x == 1)
                {
                    Button117.BackColor = Color.Black;
                    x = 2;
                    c37 = 1;
                }
                else
                {
                    Button117.BackColor = Color.White;
                    x = 1;
                    c37 = 1;
                }
            }
        }

        protected void Button81_Click(object sender, EventArgs e)
        {
            if (c37 == 0)
            {
                if (x == 1)
                {
                    Button81.BackColor = Color.Black;
                    x = 2;
                    c37 = 1;
                }
                else
                {
                    Button81.BackColor = Color.White;
                    x = 1;
                    c37 = 1;
                }
            }
        }

        protected void Button106_Click(object sender, EventArgs e)
        {
            if (c42 == 0)
            {
                if (x == 1)
                {
                    Button106.BackColor = Color.Black;
                    x = 2;
                    c42 = 1;
                }
                else
                {
                    Button106.BackColor = Color.White;
                    x = 1;
                    c42 = 1;
                }
            }
        }

        protected void Button109_Click(object sender, EventArgs e)
        {
            if (c43 == 0)
            {
                if (x == 1)
                {
                    Button109.BackColor = Color.Black;
                    x = 2;
                    c43 = 1;
                }
                else
                {
                    Button109.BackColor = Color.White;
                    x = 1;
                    c43 = 1;
                }
            }
        }

        protected void Button82_Click(object sender, EventArgs e)
        {
            if (c45 == 0)
            {
                if (x == 1)
                {
                    Button82.BackColor = Color.Black;
                    x = 2;
                    c45 = 1;
                }
                else
                {
                    Button82.BackColor = Color.White;
                    x = 1;
                    c45 = 1;
                }
            }
        }

        protected void Button120_Click(object sender, EventArgs e)
        {
            if (c52 == 0)
            {
                if (x == 1)
                {
                    Button120.BackColor = Color.Black;
                    x = 2;
                    c52 = 1;
                }
                else
                {
                    Button120.BackColor = Color.White;
                    x = 1;
                    c52 = 1;
                }
            }
        }

        protected void Button89_Click(object sender, EventArgs e)
        {
            if (c54 == 0)
            {
                if (x == 1)
                {
                    Button89.BackColor = Color.Black;
                    x = 2;
                    c54 = 1;
                }
                else
                {
                    Button89.BackColor = Color.White;
                    x = 1;
                    c54 = 1;
                }
            }
        }

        protected void Button138_Click(object sender, EventArgs e)
        {
            if (c60 == 0)
            {
                if (x == 1)
                {
                    Button138.BackColor = Color.Black;
                    x = 2;
                    c60 = 1;
                }
                else
                {
                    Button138.BackColor = Color.White;
                    x = 1;
                    c60 = 1;
                }
            }
        }

        //BOTON B8
        protected void Button75_Click(object sender, EventArgs e)
        {
            if (c2 == 0)
            {
                if (x == 1)
                {
                    Button75.BackColor = Color.Black;
                    x = 2;
                    c2 = 1;
                }
                else
                {
                    Button75.BackColor = Color.White;
                    x = 1;
                    c2 = 1;
                }
            }
        }
        

        protected void Button99_Click(object sender, EventArgs e)
        {
            if (c4 == 0)
            {
                if (x == 1)
                {
                    Button99.BackColor = Color.Black;
                    x = 2;
                    c4 = 1;
                }
                else
                {
                    Button99.BackColor = Color.White;
                    x = 1;
                    c4 = 1;
                }
            }
        }

        protected void Button103_Click(object sender, EventArgs e)
        {
            if (c5 == 0)
            {
                if (x == 1)
                {
                    Button103.BackColor = Color.Black;
                    x = 2;
                    c5 = 1;
                }
                else
                {
                    Button103.BackColor = Color.White;
                    x = 1;
                    c5 = 1;
                }
            }
        }

        protected void Button96_Click(object sender, EventArgs e)
        {
            if (c6 == 0)
            {
                if (x == 1)
                {
                    Button96.BackColor = Color.Black;
                    x = 2;
                    c6 = 1;
                }
                else
                {
                    Button96.BackColor = Color.White;
                    x = 1;
                    c6 = 1;
                }
            }
        }

        protected void Button91_Click(object sender, EventArgs e)
        {
            if (c7 == 0)
            {
                if (x == 1)
                {
                    Button91.BackColor = Color.Black;
                    x = 2;
                    c7 = 1;
                }
                else
                {
                    Button91.BackColor = Color.White;
                    x = 1;
                    c7 = 1;
                }
            }
        }

        protected void Button95_Click(object sender, EventArgs e)
        {
            if (c8 == 0)
            {
                if (x == 1)
                {
                    Button95.BackColor = Color.Black;
                    x = 2;
                    c8 = 1;
                }
                else
                {
                    Button95.BackColor = Color.White;
                    x = 1;
                    c8 = 1;
                }
            }
        }

        protected void Button133_Click(object sender, EventArgs e)
        {
            if (c16 == 0)
            {
                if (x == 1)
                {
                    Button133.BackColor = Color.Black;
                    x = 2;
                    c16 = 1;
                }
                else
                {
                    Button133.BackColor = Color.White;
                    x = 1;
                    c16= 1;
                }
            }
        }

        protected void Button123_Click(object sender, EventArgs e)
        {
            if (c15 == 0)
            {
                if (x == 1)
                {
                    Button123.BackColor = Color.Black;
                    x = 2;
                    c15 = 1;
                }
                else
                {
                    Button123.BackColor = Color.White;
                    x = 1;
                    c15 = 1;
                }
            }
        }

        protected void Button124_Click(object sender, EventArgs e)
        {
            if (c14 == 0)
            {
                if (x == 1)
                {
                    Button124.BackColor = Color.Black;
                    x = 2;
                    c14 = 1;
                }
                else
                {
                    Button124.BackColor = Color.White;
                    x = 1;
                    c14 = 1;
                }
            }
        }

        protected void Button111_Click(object sender, EventArgs e)
        {
            if (c13 == 0)
            {
                if (x == 1)
                {
                    Button111.BackColor = Color.Black;
                    x = 2;
                    c13 = 1;
                }
                else
                {
                    Button111.BackColor = Color.White;
                    x = 1;
                    c13 = 1;
                }
            }
        }

        protected void Button100_Click(object sender, EventArgs e)
        {
            if (c12 == 0)
            {
                if (x == 1)
                {
                    Button100.BackColor = Color.Black;
                    x = 2;
                    c12 = 1;
                }
                else
                {
                    Button100.BackColor = Color.White;
                    x = 1;
                    c12 = 1;
                }
            }
        }

        protected void Button93_Click(object sender, EventArgs e)
        {
            if (c11 == 0)
            {
                if (x == 1)
                {
                    Button93.BackColor = Color.Black;
                    x = 2;
                    c11 = 1;
                }
                else
                {
                    Button93.BackColor = Color.White;
                    x = 1;
                    c11 = 1;
                }
            }
        }

        protected void Button76_Click(object sender, EventArgs e)
        {
            if (c10 == 0)
            {
                if (x == 1)
                {
                    Button76.BackColor = Color.Black;
                    x = 2;
                    c10 = 1;
                }
                else
                {
                    Button76.BackColor = Color.White;
                    x = 1;
                    c10 = 1;
                }
            }
        }

        protected void Button77_Click(object sender, EventArgs e)
        {
            if (c9 == 0)
            {
                if (x == 1)
                {
                    Button77.BackColor = Color.Black;
                    x = 2;
                    c9 = 1;
                }
                else
                {
                    Button77.BackColor = Color.White;
                    x = 1;
                    c9 = 1;
                }
            }
        }

        protected void Button85_Click(object sender, EventArgs e)
        {
            if (c18 == 0)
            {
                if (x == 1)
                {
                    Button85.BackColor = Color.Black;
                    x = 2;
                    c18 = 1;
                }
                else
                {
                    Button85.BackColor = Color.White;
                    x = 1;
                    c18 = 1;
                }
            }
        }

        protected void Button92_Click(object sender, EventArgs e)
        {
            if (c19 == 0)
            {
                if (x == 1)
                {
                    Button92.BackColor = Color.Black;
                    x = 2;
                    c19 = 1;
                }
                else
                {
                    Button92.BackColor = Color.White;
                    x = 1;
                    c19 = 1;
                }
            }
        }

        protected void Button114_Click(object sender, EventArgs e)
        {
            if (c21 == 0)
            {
                if (x == 1)
                {
                    Button114.BackColor = Color.Black;
                    x = 2;
                    c21 = 1;
                }
                else
                {
                    Button114.BackColor = Color.White;
                    x = 1;
                    c21 = 1;
                }
            }
        }

        protected void Button105_Click(object sender, EventArgs e)
        {
            if (c22 == 0)
            {
                if (x == 1)
                {
                    Button105.BackColor = Color.Black;
                    x = 2;
                    c22 = 1;
                }
                else
                {
                    Button105.BackColor = Color.White;
                    x = 1;
                    c22 = 1;
                }
            }
        }

        protected void Button118_Click(object sender, EventArgs e)
        {
            if (c23 == 0)
            {
                if (x == 1)
                {
                    Button118.BackColor = Color.Black;
                    x = 2;
                    c23 = 1;
                }
                else
                {
                    Button118.BackColor = Color.White;
                    x = 1;
                    c23 = 1;
                }
            }
        }

        protected void Button131_Click(object sender, EventArgs e)
        {
            if (c24 == 0)
            {
                if (x == 1)
                {
                    Button131.BackColor = Color.Black;
                    x = 2;
                    c24 = 1;
                }
                else
                {
                    Button131.BackColor = Color.White;
                    x = 1;
                    c24 = 1;
                }
            }
        }

        protected void Button79_Click(object sender, EventArgs e)
        {
            if (c25 == 0)
            {
                if (x == 1)
                {
                    Button79.BackColor = Color.Black;
                    x = 2;
                    c25 = 1;
                }
                else
                {
                    Button79.BackColor = Color.White;
                    x = 1;
                    c25 = 1;
                }
            }
        }

        protected void Button87_Click(object sender, EventArgs e)
        {
            if (c26 == 0)
            {
                if (x == 1)
                {
                    Button87.BackColor = Color.Black;
                    x = 2;
                    c26 = 1;
                }
                else
                {
                    Button87.BackColor = Color.White;
                    x = 1;
                    c26 = 1;
                }
            }
        }

        protected void Button97_Click(object sender, EventArgs e)
        {
            if (c27 == 0)
            {
                if (x == 1)
                {
                    Button97.BackColor = Color.Black;
                    x = 2;
                    c27 = 1;
                }
                else
                {
                    Button97.BackColor = Color.White;
                    x = 1;
                    c27 = 1;
                }
            }
        }

        protected void Button122_Click(object sender, EventArgs e)
        {
            if (c1 == 0)
            {
                if (x == 1)
                {
                    Button116.BackColor = Color.Black;
                    x = 2;
                    c1 = 1;
                }
                else
                {
                    Button116.BackColor = Color.White;
                    x = 1;
                    c1 = 1;
                }
            }
        }

        protected void Button110_Click(object sender, EventArgs e)
        {

        }

        protected void Button115_Click(object sender, EventArgs e)
        {
            if (c28 == 0)
            {
                if (x == 1)
                {
                    Button115.BackColor = Color.Black;
                    x = 2;
                    c28 = 1;
                }
                else
                {
                    Button115.BackColor = Color.White;
                    x = 1;
                    c28 = 1;
                }
            }
        }

        protected void Button113_Click(object sender, EventArgs e)
        {
            if (c29 == 0)
            {
                if (x == 1)
                {
                    Button113.BackColor = Color.Black;
                    x = 2;
                    c29 = 1;
                }
                else
                {
                    Button113.BackColor = Color.White;
                    x = 1;
                    c29 = 1;
                }
            }
        }

        protected void Button127_Click(object sender, EventArgs e)
        {
            if (c30 == 0)
            {
                if (x == 1)
                {
                    Button127.BackColor = Color.Black;
                    x = 2;
                    c30 = 1;
                }
                else
                {
                    Button127.BackColor = Color.White;
                    x = 1;
                    c30 = 1;
                }
            }
        }

        protected void Button80_Click(object sender, EventArgs e)
        {
            if (c31 == 0)
            {
                if (x == 1)
                {
                    Button80.BackColor = Color.Black;
                    x = 2;
                    c31 = 1;
                }
                else
                {
                    Button80.BackColor = Color.White;
                    x = 1;
                    c31 = 1;
                }
            }
        }

        protected void Button86_Click(object sender, EventArgs e)
        {
            if (c32 == 0)
            {
                if (x == 1)
                {
                    Button86.BackColor = Color.Black;
                    x = 2;
                    c32 = 1;
                }
                else
                {
                    Button86.BackColor = Color.White;
                    x = 1;
                    c32 = 1;
                }
            }
        }

        protected void Button104_Click(object sender, EventArgs e)
        {
            if (c33 == 0)
            {
                if (x == 1)
                {
                    Button104.BackColor = Color.Black;
                    x = 2;
                    c33 = 1;
                }
                else
                {
                    Button104.BackColor = Color.White;
                    x = 1;
                    c33 = 1;
                }
            }
        }

       

        protected void Button125_Click(object sender, EventArgs e)
        {
            if (c34 == 0)
            {
                if (x == 1)
                {
                    Button125.BackColor = Color.Black;
                    x = 2;
                    c34 = 1;
                }
                else
                {
                    Button125.BackColor = Color.White;
                    x = 1;
                    c34 = 1;
                }
            }
        }

        protected void Button129_Click(object sender, EventArgs e)
        {
            if (c35 == 0)
            {
                if (x == 1)
                {
                    Button129.BackColor = Color.Black;
                    x = 2;
                    c35 = 1;
                }
                else
                {
                    Button129.BackColor = Color.White;
                    x = 1;
                    c35 = 1;
                }
            }
        }

        protected void Button132_Click(object sender, EventArgs e)
        {
            if (c36 == 0)
            {
                if (x == 1)
                {
                    Button132.BackColor = Color.Black;
                    x = 2;
                    c36 = 1;
                }
                else
                {
                    Button132.BackColor = Color.White;
                    x = 1;
                    c36 = 1;
                }
            }
        }

        protected void Button84_Click(object sender, EventArgs e)
        {
            if (c38 == 0)
            {
                if (x == 1)
                {
                    Button84.BackColor = Color.Black;
                    x = 2;
                    c38 = 1;
                }
                else
                {
                    Button84.BackColor = Color.White;
                    x = 1;
                    c38 = 1;
                }
            }
        }

        protected void Button98_Click(object sender, EventArgs e)
        {
            if (c39 == 0)
            {
                if (x == 1)
                {
                    Button98.BackColor = Color.Black;
                    x = 2;
                    c39 = 1;
                }
                else
                {
                    Button98.BackColor = Color.White;
                    x = 1;
                    c39 = 1;
                }
            }
        }

        protected void Button107_Click(object sender, EventArgs e)
        {
            if (c40 == 0)
            {
                if (x == 1)
                {
                    Button107.BackColor = Color.Black;
                    x = 2;
                    c40 = 1;
                }
                else
                {
                    Button107.BackColor = Color.White;
                    x = 1;
                    c40 = 1;
                }
            }
        }

        protected void Button134_Click(object sender, EventArgs e)
        {
            if (c41 == 0)
            {
                if (x == 1)
                {
                    Button134.BackColor = Color.Black;
                    x = 2;
                    c41 = 1;
                }
                else
                {
                    Button134.BackColor = Color.White;
                    x = 1;
                    c41 = 1;
                }
            }
        }

        protected void Button136_Click(object sender, EventArgs e)
        {
            if (c44 == 0)
            {
                if (x == 1)
                {
                    Button136.BackColor = Color.Black;
                    x = 2;
                    c44 = 1;
                }
                else
                {
                    Button136.BackColor = Color.White;
                    x = 1;
                    c44 = 1;
                }
            }
        }

        protected void Button90_Click(object sender, EventArgs e)
        {
            if (c46 == 0)
            {
                if (x == 1)
                {
                    Button90.BackColor = Color.Black;
                    x = 2;
                    c46 = 1;
                }
                else
                {
                    Button90.BackColor = Color.White;
                    x = 1;
                    c46 = 1;
                }
            }
        }

        protected void Button101_Click(object sender, EventArgs e)
        {
            if (c47 == 0)
            {
                if (x == 1)
                {
                    Button101.BackColor = Color.Black;
                    x = 2;
                    c47 = 1;
                }
                else
                {
                    Button101.BackColor = Color.White;
                    x = 1;
                    c47 = 1;
                }
            }
        }

        protected void Button102_Click(object sender, EventArgs e)
        {
            if (c48 == 0)
            {
                if (x == 1)
                {
                    Button102.BackColor = Color.Black;
                    x = 2;
                    c48 = 1;
                }
                else
                {
                    Button102.BackColor = Color.White;
                    x = 1;
                    c48 = 1;
                }
            }
        }

        protected void Button119_Click(object sender, EventArgs e)
        {
            if (c49 == 0)
            {
                if (x == 1)
                {
                    Button119.BackColor = Color.Black;
                    x = 2;
                    c49 = 1;
                }
                else
                {
                    Button119.BackColor = Color.White;
                    x = 1;
                    c49 = 1;
                }
            }
        }

        protected void Button126_Click(object sender, EventArgs e)
        {
            if (c50 == 0)
            {
                if (x == 1)
                {
                    Button126.BackColor = Color.Black;
                    x = 2;
                    c50 = 1;
                }
                else
                {
                    Button126.BackColor = Color.White;
                    x = 1;
                    c50 = 1;
                }
            }
        }

        protected void Button130_Click(object sender, EventArgs e)
        {
            if (c51 == 0)
            {
                if (x == 1)
                {
                    Button130.BackColor = Color.Black;
                    x = 2;
                    c51 = 1;
                }
                else
                {
                    Button130.BackColor = Color.White;
                    x = 1;
                    c51 = 1;
                }
            }
        }

        protected void Button83_Click(object sender, EventArgs e)
        {
            if (c53 == 0)
            {
                if (x == 1)
                {
                    Button83.BackColor = Color.Black;
                    x = 2;
                    c53 = 1;
                }
                else
                {
                    Button83.BackColor = Color.White;
                    x = 1;
                    c53 = 1;
                }
            }
        }

        protected void Button94_Click(object sender, EventArgs e)
        {
            if (c55 == 0)
            {
                if (x == 1)
                {
                    Button94.BackColor = Color.Black;
                    x = 2;
                    c55 = 1;
                }
                else
                {
                    Button94.BackColor = Color.White;
                    x = 1;
                    c55 = 1;
                }
            }
        }

        protected void Button112_Click(object sender, EventArgs e)
        {
            if (c56 == 0)
            {
                if (x == 1)
                {
                    Button112.BackColor = Color.Black;
                    x = 2;
                    c56 = 1;
                }
                else
                {
                    Button112.BackColor = Color.White;
                    x = 1;
                    c56 = 1;
                }
            }
        }

        protected void Button135_Click(object sender, EventArgs e)
        {
            if (c57 == 0)
            {
                if (x == 1)
                {
                    Button135.BackColor = Color.Black;
                    x = 2;
                    c57 = 1;
                }
                else
                {
                    Button135.BackColor = Color.White;
                    x = 1;
                    c57 = 1;
                }
            }
        }

        protected void Button139_Click(object sender, EventArgs e)
        {
            if (c58 == 0)
            {
                if (x == 1)
                {
                    Button139.BackColor = Color.Black;
                    x = 2;
                    c58 = 1;
                }
                else
                {
                    Button139.BackColor = Color.White;
                    x = 1;
                    c58 = 1;
                }
            }
        }

        protected void Button137_Click(object sender, EventArgs e)
        {
            if (c59 == 0)
            {
                if (x == 1)
                {
                    Button137.BackColor = Color.Black;
                    x = 2;
                    c59 = 1;
                }
                else
                {
                    Button137.BackColor = Color.White;
                    x = 1;
                    c59 = 1;
                }
            }
        }

        //Cargar Partida
        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" || TextBox1.Text != null)
            {
                string di = TextBox1.Text;
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;
                XmlNodeList xmlnode1;
                FileStream fs = new FileStream(di, FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("ficha");
                xmlnode1 = xmldoc.GetElementsByTagName("siguienteTiro");

                //Almacenar Tiro
                String Tiro = null;
                xmlnode1[0].ChildNodes.Item(0).InnerText.Trim();
                Tiro = xmlnode1[0].ChildNodes.Item(0).InnerText.Trim();

                //Almacenar Posiciones y colores
                int i = 0;
                var pos = new List<String>();
                var col = new List<String>(); ;
                for (i = 0; i <= xmlnode.Count - 1; i++)
                {
                    xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                    pos.Add(xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + xmlnode[i].ChildNodes.Item(2).InnerText.Trim());
                    col.Add(xmlnode[i].ChildNodes.Item(0).InnerText.Trim());
                }

                //Settear todos al color original
                Color co = ColorTranslator.FromHtml("#83CC70");
                Button116.BackColor = co;
                Button75.BackColor = co;
                Button88.BackColor = co;
                Button99.BackColor = co;
                Button103.BackColor = co;
                Button96.BackColor = co;
                Button91.BackColor = co;
                Button95.BackColor = co;

                Button77.BackColor = co;
                Button96.BackColor = co;
                Button93.BackColor = co;
                Button100.BackColor = co;
                Button111.BackColor = co;
                Button124.BackColor = co;
                Button123.BackColor = co;
                Button133.BackColor = co;

                Button78.BackColor = co;
                Button85.BackColor = co;
                Button92.BackColor = co;
                Button108.BackColor = co;
                Button114.BackColor = co;
                Button105.BackColor = co;
                Button118.BackColor = co;
                Button131.BackColor = co;

                Button79.BackColor = co;
                Button87.BackColor = co;
                Button97.BackColor = co;
                Button122.BackColor = co;
                Button110.BackColor = co;
                Button115.BackColor = co;
                Button113.BackColor = co;
                Button127.BackColor = co;

                Button80.BackColor = co;
                Button86.BackColor = co;
                Button104.BackColor = co;
                Button117.BackColor = co;
                Button121.BackColor = co;
                Button125.BackColor = co;
                Button129.BackColor = co;
                Button132.BackColor = co;

                Button81.BackColor = co;
                Button84.BackColor = co;
                Button98.BackColor = co;
                Button107.BackColor = co;
                Button134.BackColor = co;
                Button106.BackColor = co;
                Button109.BackColor = co;
                Button136.BackColor = co;

                Button82.BackColor = co;
                Button90.BackColor = co;
                Button101.BackColor = co;
                Button102.BackColor = co;
                Button119.BackColor = co;
                Button126.BackColor = co;
                Button130.BackColor = co;
                Button120.BackColor = co;

                Button83.BackColor = co;
                Button89.BackColor = co;
                Button94.BackColor = co;
                Button112.BackColor = co;
                Button135.BackColor = co;
                Button139.BackColor = co;
                Button137.BackColor = co;
                Button138.BackColor = co;

                //Cargar Datos
                if (Tiro == "negro")
                {
                    x = 1;
                }
                else
                {
                    x = 2;
                }

                for (i = 0; i <= pos.Count - 1; i++)
                {
                    String posi = pos[i];
                    String colo = col[i];

                    switch (posi)
                    {
                        case "A1":
                            if (colo == "blanco")
                            {
                                Button116.BackColor = Color.White;
                            }
                            else
                            {
                                Button116.BackColor = Color.Black;
                            }
                            break;

                        case "B1":
                            if (colo == "blanco")
                            {
                                Button75.BackColor = Color.White;
                            }
                            else
                            {
                                Button75.BackColor = Color.Black;
                            }
                            break;

                        case "C1":
                            if (colo == "blanco")
                            {
                                Button88.BackColor = Color.White;
                            }
                            else
                            {
                                Button88.BackColor = Color.Black;
                            }
                            break;

                        case "D1":
                            if (colo == "blanco")
                            {
                                Button99.BackColor = Color.White;
                            }
                            else
                            {
                                Button99.BackColor = Color.Black;
                            }
                            break;

                        case "E1":
                            if (colo == "blanco")
                            {
                                Button103.BackColor = Color.White;
                            }
                            else
                            {
                                Button103.BackColor = Color.Black;
                            }
                            break;

                        case "F1":
                            if (colo == "blanco")
                            {
                                Button96.BackColor = Color.White;
                            }
                            else
                            {
                                Button96.BackColor = Color.Black;
                            }
                            break;

                        case "G1":
                            if (colo == "blanco")
                            {
                                Button91.BackColor = Color.White;
                            }
                            else
                            {
                                Button91.BackColor = Color.Black;
                            }
                            break;

                        case "H1":
                            if (colo == "blanco")
                            {
                                Button95.BackColor = Color.White;
                            }
                            else
                            {
                                Button95.BackColor = Color.Black;
                            }
                            break;

                        //------------------------------------------
                        case "A2":
                            if (colo == "blanco")
                            {
                                Button77.BackColor = Color.White;
                            }
                            else
                            {
                                Button77.BackColor = Color.Black;
                            }
                            break;

                        case "B2":
                            if (colo == "blanco")
                            {
                                Button96.BackColor = Color.White;
                            }
                            else
                            {
                                Button96.BackColor = Color.Black;
                            }
                            break;

                        case "C2":
                            if (colo == "blanco")
                            {
                                Button93.BackColor = Color.White;
                            }
                            else
                            {
                                Button93.BackColor = Color.Black;
                            }
                            break;

                        case "D2":
                            if (colo == "blanco")
                            {
                                Button100.BackColor = Color.White;
                            }
                            else
                            {
                                Button100.BackColor = Color.Black;
                            }
                            break;

                        case "E2":
                            if (colo == "blanco")
                            {
                                Button111.BackColor = Color.White;
                            }
                            else
                            {
                                Button111.BackColor = Color.Black;
                            }
                            break;

                        case "F2":
                            if (colo == "blanco")
                            {
                                Button124.BackColor = Color.White;
                            }
                            else
                            {
                                Button124.BackColor = Color.Black;
                            }
                            break;

                        case "G2":
                            if (colo == "blanco")
                            {
                                Button123.BackColor = Color.White;
                            }
                            else
                            {
                                Button123.BackColor = Color.Black;
                            }
                            break;

                        case "H2":
                            if (colo == "blanco")
                            {
                                Button133.BackColor = Color.White;
                            }
                            else
                            {
                                Button133.BackColor = Color.Black;
                            }
                            break;

                        //------------------------------------------
                        case "A3":
                            if (colo == "blanco")
                            {
                                Button78.BackColor = Color.White;
                            }
                            else
                            {
                                Button78.BackColor = Color.Black;
                            }
                            break;

                        case "B3":
                            if (colo == "blanco")
                            {
                                Button85.BackColor = Color.White;
                            }
                            else
                            {
                                Button85.BackColor = Color.Black;
                            }
                            break;

                        case "C3":
                            if (colo == "blanco")
                            {
                                Button92.BackColor = Color.White;
                            }
                            else
                            {
                                Button92.BackColor = Color.Black;
                            }
                            break;

                        case "D3":
                            if (colo == "blanco")
                            {
                                Button108.BackColor = Color.White;
                            }
                            else
                            {
                                Button108.BackColor = Color.Black;
                            }
                            break;

                        case "E3":
                            if (colo == "blanco")
                            {
                                Button114.BackColor = Color.White;
                            }
                            else
                            {
                                Button114.BackColor = Color.Black;
                            }
                            break;

                        case "F3":
                            if (colo == "blanco")
                            {
                                Button105.BackColor = Color.White;
                            }
                            else
                            {
                                Button105.BackColor = Color.Black;
                            }
                            break;

                        case "G3":
                            if (colo == "blanco")
                            {
                                Button118.BackColor = Color.White;
                            }
                            else
                            {
                                Button118.BackColor = Color.Black;
                            }
                            break;

                        case "H3":
                            if (colo == "blanco")
                            {
                                Button131.BackColor = Color.White;
                            }
                            else
                            {
                                Button131.BackColor = Color.Black;
                            }
                            break;

                        //------------------------------------------
                        case "A4":
                            if (colo == "blanco")
                            {
                                Button79.BackColor = Color.White;
                            }
                            else
                            {
                                Button79.BackColor = Color.Black;
                            }
                            break;

                        case "B4":
                            if (colo == "blanco")
                            {
                                Button87.BackColor = Color.White;
                            }
                            else
                            {
                                Button87.BackColor = Color.Black;
                            }
                            break;

                        case "C4":
                            if (colo == "blanco")
                            {
                                Button97.BackColor = Color.White;
                            }
                            else
                            {
                                Button97.BackColor = Color.Black;
                            }
                            break;

                        case "D4":
                            if (colo == "blanco")
                            {
                                Button122.BackColor = Color.White;
                            }
                            else
                            {
                                Button122.BackColor = Color.Black;
                            }
                            break;

                        case "E4":
                            if (colo == "blanco")
                            {
                                Button110.BackColor = Color.White;
                            }
                            else
                            {
                                Button110.BackColor = Color.Black;
                            }
                            break;

                        case "F4":
                            if (colo == "blanco")
                            {
                                Button115.BackColor = Color.White;
                            }
                            else
                            {
                                Button115.BackColor = Color.Black;
                            }
                            break;

                        case "G4":
                            if (colo == "blanco")
                            {
                                Button113.BackColor = Color.White;
                            }
                            else
                            {
                                Button113.BackColor = Color.Black;
                            }
                            break;

                        case "H4":
                            if (colo == "blanco")
                            {
                                Button127.BackColor = Color.White;
                            }
                            else
                            {
                                Button127.BackColor = Color.Black;
                            }
                            break;

                        //------------------------------------------
                        case "A5":
                            if (colo == "blanco")
                            {
                                Button80.BackColor = Color.White;
                            }
                            else
                            {
                                Button80.BackColor = Color.Black;
                            }
                            break;

                        case "B5":
                            if (colo == "blanco")
                            {
                                Button86.BackColor = Color.White;
                            }
                            else
                            {
                                Button86.BackColor = Color.Black;
                            }
                            break;

                        case "C5":
                            if (colo == "blanco")
                            {
                                Button104.BackColor = Color.White;
                            }
                            else
                            {
                                Button104.BackColor = Color.Black;
                            }
                            break;

                        case "D5":
                            if (colo == "blanco")
                            {
                                Button117.BackColor = Color.White;
                            }
                            else
                            {
                                Button117.BackColor = Color.Black;
                            }
                            break;

                        case "E5":
                            if (colo == "blanco")
                            {
                                Button121.BackColor = Color.White;
                            }
                            else
                            {
                                Button121.BackColor = Color.Black;
                            }
                            break;

                        case "F5":
                            if (colo == "blanco")
                            {
                                Button125.BackColor = Color.White;
                            }
                            else
                            {
                                Button125.BackColor = Color.Black;
                            }
                            break;

                        case "G5":
                            if (colo == "blanco")
                            {
                                Button129.BackColor = Color.White;
                            }
                            else
                            {
                                Button129.BackColor = Color.Black;
                            }
                            break;

                        case "H5":
                            if (colo == "blanco")
                            {
                                Button132.BackColor = Color.White;
                            }
                            else
                            {
                                Button132.BackColor = Color.Black;
                            }
                            break;

                        //------------------------------------------
                        case "A6":
                            if (colo == "blanco")
                            {
                                Button81.BackColor = Color.White;
                            }
                            else
                            {
                                Button81.BackColor = Color.Black;
                            }
                            break;

                        case "B6":
                            if (colo == "blanco")
                            {
                                Button84.BackColor = Color.White;
                            }
                            else
                            {
                                Button84.BackColor = Color.Black;
                            }
                            break;

                        case "C6":
                            if (colo == "blanco")
                            {
                                Button98.BackColor = Color.White;
                            }
                            else
                            {
                                Button98.BackColor = Color.Black;
                            }
                            break;

                        case "D6":
                            if (colo == "blanco")
                            {
                                Button107.BackColor = Color.White;
                            }
                            else
                            {
                                Button107.BackColor = Color.Black;
                            }
                            break;

                        case "E6":
                            if (colo == "blanco")
                            {
                                Button134.BackColor = Color.White;
                            }
                            else
                            {
                                Button134.BackColor = Color.Black;
                            }
                            break;

                        case "F6":
                            if (colo == "blanco")
                            {
                                Button106.BackColor = Color.White;
                            }
                            else
                            {
                                Button106.BackColor = Color.Black;
                            }
                            break;

                        case "G6":
                            if (colo == "blanco")
                            {
                                Button109.BackColor = Color.White;
                            }
                            else
                            {
                                Button109.BackColor = Color.Black;
                            }
                            break;

                        case "H6":
                            if (colo == "blanco")
                            {
                                Button136.BackColor = Color.White;
                            }
                            else
                            {
                                Button136.BackColor = Color.Black;
                            }
                            break;

                        //-----------------------------------------
                        case "A7":
                            if (colo == "blanco")
                            {
                                Button82.BackColor = Color.White;
                            }
                            else
                            {
                                Button82.BackColor = Color.Black;
                            }
                            break;

                        case "B7":
                            if (colo == "blanco")
                            {
                                Button90.BackColor = Color.White;
                            }
                            else
                            {
                                Button90.BackColor = Color.Black;
                            }
                            break;

                        case "C7":
                            if (colo == "blanco")
                            {
                                Button101.BackColor = Color.White;
                            }
                            else
                            {
                                Button101.BackColor = Color.Black;
                            }
                            break;

                        case "D7":
                            if (colo == "blanco")
                            {
                                Button102.BackColor = Color.White;
                            }
                            else
                            {
                                Button102.BackColor = Color.Black;
                            }
                            break;

                        case "E7":
                            if (colo == "blanco")
                            {
                                Button119.BackColor = Color.White;
                            }
                            else
                            {
                                Button119.BackColor = Color.Black;
                            }
                            break;

                        case "F7":
                            if (colo == "blanco")
                            {
                                Button126.BackColor = Color.White;
                            }
                            else
                            {
                                Button126.BackColor = Color.Black;
                            }
                            break;

                        case "G7":
                            if (colo == "blanco")
                            {
                                Button130.BackColor = Color.White;
                            }
                            else
                            {
                                Button130.BackColor = Color.Black;
                            }
                            break;

                        case "H7":
                            if (colo == "blanco")
                            {
                                Button120.BackColor = Color.White;
                            }
                            else
                            {
                                Button120.BackColor = Color.Black;
                            }
                            break;

                        //------------------------------------------
                        case "A8":
                            if (colo == "blanco")
                            {
                                Button83.BackColor = Color.White;
                            }
                            else
                            {
                                Button83.BackColor = Color.Black;
                            }
                            break;

                        case "B8":
                            if (colo == "blanco")
                            {
                                Button89.BackColor = Color.White;
                            }
                            else
                            {
                                Button89.BackColor = Color.Black;
                            }
                            break;

                        case "C8":
                            if (colo == "blanco")
                            {
                                Button94.BackColor = Color.White;
                            }
                            else
                            {
                                Button94.BackColor = Color.Black;
                            }
                            break;

                        case "D8":
                            if (colo == "blanco")
                            {
                                Button112.BackColor = Color.White;
                            }
                            else
                            {
                                Button112.BackColor = Color.Black;
                            }
                            break;

                        case "E8":
                            if (colo == "blanco")
                            {
                                Button135.BackColor = Color.White;
                            }
                            else
                            {
                                Button135.BackColor = Color.Black;
                            }
                            break;

                        case "F8":
                            if (colo == "blanco")
                            {
                                Button139.BackColor = Color.White;
                            }
                            else
                            {
                                Button139.BackColor = Color.Black;
                            }
                            break;

                        case "G8":
                            if (colo == "blanco")
                            {
                                Button137.BackColor = Color.White;
                            }
                            else
                            {
                                Button137.BackColor = Color.Black;
                            }
                            break;

                        case "H8":
                            if (colo == "blanco")
                            {
                                Button138.BackColor = Color.White;
                            }
                            else
                            {
                                Button138.BackColor = Color.Black;
                            }
                            break;

                            //-----------------------------------------
                    }
                }
            }
            else
            {
                Response.Write("No hay ningun archivo seleccionado");
            }

        }
        //Guardar
        protected void Button2_Click(object sender, EventArgs e)
        {
            const string FMT = "yyyy-MM-dd-HH-mm-ss";
            DateTime hoy = DateTime.Now;
            string nom = hoy.ToString(FMT);
            using (XmlWriter a = XmlWriter.Create("C:/Users/Usuario/Desktop/T/IPC2/Proyecto/Proyecto/Othell" + nom+".xml"))
            {
                a.WriteStartDocument();
                a.WriteStartElement("tablero");
                //--------------------------------------------
                if (c1 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button116.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "A");
                    a.WriteElementString("fila", "1");
                    a.WriteEndElement();
                }

                if (c2 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button75.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "B");
                    a.WriteElementString("fila", "1");
                    a.WriteEndElement();
                }

                if (c3 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button88.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "C");
                    a.WriteElementString("fila", "1");
                    a.WriteEndElement();
                }

                if (c4 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button99.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "D");
                    a.WriteElementString("fila", "1");
                    a.WriteEndElement();
                }

                if (c5 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button103.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "E");
                    a.WriteElementString("fila", "1");
                    a.WriteEndElement();
                }

                if (c6 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button96.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "F");
                    a.WriteElementString("fila", "1");
                    a.WriteEndElement();
                }

                if (c7 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button91.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "G");
                    a.WriteElementString("fila", "1");
                    a.WriteEndElement();
                }

                if (c8 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button95.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "H");
                    a.WriteElementString("fila", "1");
                    a.WriteEndElement();
                }
                //---------------------------------------------------------------
                if (c9 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button77.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "A");
                    a.WriteElementString("fila", "2");
                    a.WriteEndElement();
                }

                if (c10 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button96.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "B");
                    a.WriteElementString("fila", "2");
                    a.WriteEndElement();
                }

                if (c11 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button93.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "C");
                    a.WriteElementString("fila", "2");
                    a.WriteEndElement();
                }

                if (c12 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button100.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "D");
                    a.WriteElementString("fila", "2");
                    a.WriteEndElement();
                }

                if (c13 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button111.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "E");
                    a.WriteElementString("fila", "2");
                    a.WriteEndElement();
                }

                if (c14 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button124.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "F");
                    a.WriteElementString("fila", "2");
                    a.WriteEndElement();
                }

                if (c15 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button123.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "G");
                    a.WriteElementString("fila", "2");
                    a.WriteEndElement();
                }

                if (c16 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button133.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "H");
                    a.WriteElementString("fila", "2");
                    a.WriteEndElement();
                }
                //---------------------------------------------------------------
                if (c17 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button78.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "A");
                    a.WriteElementString("fila", "3");
                    a.WriteEndElement();
                }

                if (c18 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button85.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "B");
                    a.WriteElementString("fila", "3");
                    a.WriteEndElement();
                }

                if (c19 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button92.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "C");
                    a.WriteElementString("fila", "3");
                    a.WriteEndElement();
                }

                if (c20 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button108.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "D");
                    a.WriteElementString("fila", "3");
                    a.WriteEndElement();
                }

                if (c21 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button114.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "E");
                    a.WriteElementString("fila", "3");
                    a.WriteEndElement();
                }

                if (c22 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button105.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "F");
                    a.WriteElementString("fila", "3");
                    a.WriteEndElement();
                }

                if (c23 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button118.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "G");
                    a.WriteElementString("fila", "3");
                    a.WriteEndElement();
                }

                if (c24 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button131.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "H");
                    a.WriteElementString("fila", "3");
                    a.WriteEndElement();
                }
                //---------------------------------------------------------------
                if (c25 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button79.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "A");
                    a.WriteElementString("fila", "4");
                    a.WriteEndElement();
                }

                if (c26 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button87.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "B");
                    a.WriteElementString("fila", "4");
                    a.WriteEndElement();
                }

                if (c27 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button97.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "C");
                    a.WriteElementString("fila", "4");
                    a.WriteEndElement();
                }

                

                if (c28 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button115.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "F");
                    a.WriteElementString("fila", "4");
                    a.WriteEndElement();
                }

                if (c29 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button113.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "G");
                    a.WriteElementString("fila", "4");
                    a.WriteEndElement();
                }

                if (c30 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button127.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "H");
                    a.WriteElementString("fila", "4");
                    a.WriteEndElement();
                }
                //---------------------------------------------------------------
                if (c31 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button80.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "A");
                    a.WriteElementString("fila", "5");
                    a.WriteEndElement();
                }

                if (c32 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button86.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "B");
                    a.WriteElementString("fila", "5");
                    a.WriteEndElement();
                }

                if (c33 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button104.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "C");
                    a.WriteElementString("fila", "5");
                    a.WriteEndElement();
                }

                
                if (c34 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button125.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "F");
                    a.WriteElementString("fila", "5");
                    a.WriteEndElement();
                }

                if (c35 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button129.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "G");
                    a.WriteElementString("fila", "5");
                    a.WriteEndElement();
                }

                if (c36 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button132.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "H");
                    a.WriteElementString("fila", "5");
                    a.WriteEndElement();
                }
                //---------------------------------------------------------------
                if (c37 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button81.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "A");
                    a.WriteElementString("fila", "6");
                    a.WriteEndElement();
                }

                if (c38 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button84.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "B");
                    a.WriteElementString("fila", "6");
                    a.WriteEndElement();
                }

                if (c39 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button98.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "C");
                    a.WriteElementString("fila", "6");
                    a.WriteEndElement();
                }

                if (c40 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button107.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "D");
                    a.WriteElementString("fila", "6");
                    a.WriteEndElement();
                }

                if (c41 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button134.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "E");
                    a.WriteElementString("fila", "6");
                    a.WriteEndElement();
                }

                if (c42 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button106.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "F");
                    a.WriteElementString("fila", "6");
                    a.WriteEndElement();
                }

                if (c43 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button109.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "G");
                    a.WriteElementString("fila", "6");
                    a.WriteEndElement();
                }

                if (c44 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button136.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "H");
                    a.WriteElementString("fila", "6");
                    a.WriteEndElement();
                }
                //---------------------------------------------------------------
                if (c45 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button82.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "A");
                    a.WriteElementString("fila", "7");
                    a.WriteEndElement();
                }

                if (c46 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button90.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "B");
                    a.WriteElementString("fila", "7");
                    a.WriteEndElement();
                }

                if (c47 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button101.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "C");
                    a.WriteElementString("fila", "7");
                    a.WriteEndElement();
                }

                if (c48 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button102.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "D");
                    a.WriteElementString("fila", "7");
                    a.WriteEndElement();
                }

                if (c49 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button119.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "E");
                    a.WriteElementString("fila", "7");
                    a.WriteEndElement();
                }

                if (c50 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button126.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "F");
                    a.WriteElementString("fila", "7");
                    a.WriteEndElement();
                }

                if (c51 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button130.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "G");
                    a.WriteElementString("fila", "7");
                    a.WriteEndElement();
                }

                if (c52 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button120.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "H");
                    a.WriteElementString("fila", "7");
                    a.WriteEndElement();
                }
                //---------------------------------------------------------------
                if (c53 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button83.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "A");
                    a.WriteElementString("fila", "8");
                    a.WriteEndElement();
                }

                if (c54 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button89.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "B");
                    a.WriteElementString("fila", "8");
                    a.WriteEndElement();
                }

                if (c55 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button94.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "C");
                    a.WriteElementString("fila", "8");
                    a.WriteEndElement();
                }

                if (c56 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button112.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "D");
                    a.WriteElementString("fila", "8");
                    a.WriteEndElement();
                }

                if (c57 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button135.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "E");
                    a.WriteElementString("fila", "8");
                    a.WriteEndElement();
                }

                if (c58 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button139.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "F");
                    a.WriteElementString("fila", "8");
                    a.WriteEndElement();
                }

                if (c59 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button137.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "G");
                    a.WriteElementString("fila", "8");
                    a.WriteEndElement();
                }

                if (c60 == 1)
                {
                    a.WriteStartElement("ficha");
                    if (Button138.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "H");
                    a.WriteElementString("fila", "8");
                    a.WriteEndElement();
                }
                //---------------------------------------------------------------
                //----------------------------------------------
                a.WriteStartElement("ficha");
                    if (Button122.BackColor == Color.Black)
                    {
                        a.WriteElementString("color", "negro");
                    }
                    else
                    {
                        a.WriteElementString("color", "blanco");
                    }
                    a.WriteElementString("columna", "D");
                    a.WriteElementString("fila", "4");
                    a.WriteEndElement();

                a.WriteStartElement("ficha");
                if (Button110.BackColor == Color.Black)
                {
                    a.WriteElementString("color", "negro");
                }
                else
                {
                    a.WriteElementString("color", "blanco");
                }
                a.WriteElementString("columna", "E");
                a.WriteElementString("fila", "4");
                a.WriteEndElement();

                a.WriteStartElement("ficha");
                if (Button117.BackColor == Color.Black)
                {
                    a.WriteElementString("color", "negro");
                }
                else
                {
                    a.WriteElementString("color", "blanco");
                }
                a.WriteElementString("columna", "D");
                a.WriteElementString("fila", "5");
                a.WriteEndElement();

                a.WriteStartElement("ficha");
                if (Button121.BackColor == Color.Black)
                {
                    a.WriteElementString("color", "negro");
                }
                else
                {
                    a.WriteElementString("color", "blanco");
                }
                a.WriteElementString("columna", "E");
                a.WriteElementString("fila", "5");
                a.WriteEndElement();


                if (x == 1)
                {
                    a.WriteStartElement("siguienteTiro");
                    a.WriteElementString("color", "blanco");
                    a.WriteEndElement();
                }
                else
                {
                    a.WriteStartElement("siguienteTiro");
                    a.WriteElementString("color", "negro");
                    a.WriteEndElement();
                }
                a.WriteEndElement();
                a.Flush();
                a.Close();
            }
        }
    }
}