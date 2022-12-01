
using BusinessLayer;
using Newtonsoft.Json;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }
       
        private void Record_Load(object sender, EventArgs e)
        {
            richTextBoxHistorial.BackColor = Color.Black;
            richTextBoxHistorial.ForeColor = Color.White;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        public Negocio negocio = new Negocio();

        private void btnGet_Click(object sender, EventArgs e)
        {
           
            List<List<string>> Historial = new List<List<string>>();    
            Historial = negocio.historial();
            TextBox richText= new TextBox();
            List<string> comentarios = new List<string>();
            for (int i = 0; i<=Historial.Count-1; i++) 
            {
                 comentarios.Add(Historial[i][0] + " Ha calificado a " + Historial[i][4].ToUpper() + " con " + Historial[i][2] + " Estrellas y ha comentado  "
                    + "'"+Historial[i][3]+"'" + "\n");
                if ( !cmbHistorial.Items.Contains(Historial[i][0]) )
                {
                    cmbHistorial.Items.Add(Historial[i][0]);      
                }
            }         
            richTextBoxHistorial.Lines = comentarios.ToArray();





        }

        private void richTextBoxHistorial_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<List<string>> filtro = new List<List<string>>  ();

            filtro = negocio.historial();

            string username = cmbHistorial.Text;

            List<string> usernameComentarios = new List<string>() ;

            
         
            string mensajeMejoresMangas = "";

            int a = 0;
            int b = 0;
            int c = 0;

            string x = "";
            string y = "";
            string z = "";




            for ( int i = 0; i<=filtro.Count-1; i++) 
            {


                if (username.Equals(filtro[i][0]))
                {
                    
                    usernameComentarios.Add(filtro[i][0] + " Ha calificado a " + filtro[i][4].ToUpper() + " con " + filtro[i][2] + " Estrellas y ha comentado  "
                    + "'" + filtro[i][3] + "'" + "\n");



                    if (int.Parse(filtro[i][2]) > a || int.Parse(filtro[i][2]) > b || int.Parse(filtro[i][2]) > c)
                    {

                        if (int.Parse(filtro[i][2]) > a)
                        {
                            c = b;
                            b = a;
                            a = int.Parse(filtro[i][2]);

                            z = y;
                            y = x;
                            x = filtro[i][4];


                        }
                        else if (int.Parse(filtro[i][2]) > b)
                        {
                            c = b;
                            b = int.Parse((filtro[i][2]));

                            z = y;
                            y = filtro[i][4];


                        }
                        else if (int.Parse(filtro[i][2]) > c)
                        {
                            c = int.Parse(filtro[i][2]);

                            z = filtro[i][4];


                        }



                    }
                    System.Diagnostics.Debug.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx " + x);
                    System.Diagnostics.Debug.WriteLine("yyyyyyyyyyyyyyyyyyyyyyyyyy " + y);
                    System.Diagnostics.Debug.WriteLine("zzzzzzzzzzzzzzzzzzzzzz " + z);
                    System.Diagnostics.Debug.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" + a);
                    System.Diagnostics.Debug.WriteLine("bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb" + b);
                    System.Diagnostics.Debug.WriteLine("ccccccccccccccccccccccccccccccccccccc" + c);
                }






            }

            string mensajeFavoritos = "";

            if (b == 0 & c == 0)
            {
                mensajeFavoritos = "El manga mejor puntado de " + cmbHistorial.Text + " es: " + x + " con una puntuación de " + a + "\n";
            }
            else if (c == 0)
            {
                mensajeFavoritos = "Los mangas mejor puntuados de " + cmbHistorial.Text + " son: " + x + " con una puntuación de " + a + " y " + y + " con una puntuación de " + b + "\n";
            }

            else
            {
                mensajeFavoritos = "Los mangas mejor puntuados de " + cmbHistorial.Text + " son: " + x + " con una puntuación de " + a + ", " + y + " con una puntuación de " + b + ", y " + z + "con una puntuación de " + c + "\n";

            }

                usernameComentarios.Insert(0, mensajeFavoritos);



                richTextBoxHistorial.Clear();

                richTextBoxHistorial.Lines = usernameComentarios.ToArray();


                //int t;
                //for (int a = 1; a < usernameComentarios.Count(); a++)
                //    for (int b = usernameComentarios.Count() - 1; b >= a; b--)
                //    {
                //        if (usernameComentarios[b - 1][2] > usernameComentarios[b][2])
                //        {
                //            t = usernameComentarios[b - 1][2];
                //            usernameComentarios[b - 1][2] = usernameComentarios[b][2];
                //            usernameComentarios[b][2] = t;
                //        }
                //    }

            

        }
    }
}
