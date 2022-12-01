using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PresentationLayer.Models;


namespace PresentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void customizableButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
           



            string url = @"http://localhost:5142/api/consultarIngreso?userName=" + tbUsuario.Text + "&password=" + tbContraseña.Text;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);


            request.Method = "GET";

            request.ContentType = "application/json";

            request.Accept = "application/json";


            try
            {
                WebResponse response = request.GetResponse();
                Stream streamReader = response.GetResponseStream();
                StreamReader objReader = new StreamReader(streamReader);
                string respuesta = objReader.ReadToEnd();
                ResponseLogin result = JsonConvert.DeserializeObject<ResponseLogin>(respuesta);
                
                System.Diagnostics.Debug.WriteLine(result.result);
                if (result.result)
                {
                    this.Hide();
                    Record record = new Record();
                    record.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña o Usuario incorrecto");
                }




            }
            catch
            {
                MessageBox.Show("Error al conectarse al sistema.");
            }
        }
    }
}
