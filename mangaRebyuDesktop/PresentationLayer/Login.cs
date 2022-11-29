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
            RequestLogin peticion = new RequestLogin();
            peticion.userName = tbUsuario.Text.ToString();
            peticion.password = tbContraseña.Text.ToString();

            string url = @"http://localhost:5142/api/consultarIngreso";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            

            request.Method = "GET";

            request.ContentType= "application/json";

            request.Accept= "application/json";

            string body = JsonConvert.SerializeObject(peticion);

            

            var streamWriter = new StreamWriter(request.GetRequestStream());
            streamWriter.Write(body);
            streamWriter.Flush();
            streamWriter.Close();

            //WebRequest oRequest = WebRequest.Create(url);
            //WebResponse oResponse = oRequest.GetResponse();
            //StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            //await sr.ReadToEndAsync();

            try
            {
                WebResponse response = request.GetResponse();
                Stream streamReader = response.GetResponseStream ();
                StreamReader objReader = new StreamReader(streamReader);
                string respuesta = objReader.ReadToEnd();
                ResponseLogin result = JsonConvert.DeserializeObject<ResponseLogin>(respuesta);

                MessageBox.Show("El resultado es "+ result.ToString());
                    
            }
            catch
            {
                MessageBox.Show("FEO FEO FEO");
            }
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
    }
}
