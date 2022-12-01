using Newtonsoft.Json;
using PresentationLayer.Models;
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

namespace PresentationLayer
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void customizableButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (!txtContraseñaR.Text.Equals(txtCconfirmarContraseñaR.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK);
            }
            else
            {
                RequestSignUp peticion = new RequestSignUp();
                peticion.userName = txtUsuarioR.Text;
                peticion.password = txtContraseñaR.Text;

                string url = @"http://localhost:5142/api/crearRegistro";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                string body = JsonConvert.SerializeObject(peticion);

                var streamWriter = new StreamWriter(request.GetRequestStream());

                streamWriter.Write(body);
                streamWriter.Flush();
                streamWriter.Close();

                try
                {
                    WebResponse response = request.GetResponse();
                    Stream streamReader = response.GetResponseStream();
                    StreamReader objReader = new StreamReader(streamReader);

                    string respuesta = objReader.ReadToEnd();
                    ResponseSignUp resp = JsonConvert.DeserializeObject<ResponseSignUp>(respuesta);

                    MessageBox.Show("Te has registrado exitosamente.");

                    this.Hide();
                    Record record = new Record();
                    record.Show();
                }
                catch
                {
                    MessageBox.Show("Hubo un error");
                }
            }
        }
    }
}
