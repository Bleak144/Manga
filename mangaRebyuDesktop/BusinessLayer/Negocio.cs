using BusinessLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Net.WebRequestMethods;

namespace BusinessLayer
{
    public class Negocio
    {
        public List<List<string>> historial ()
        {
            string url = @"http://localhost:5142/api/sendDataDesktop?flag=true";

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
                ResponseSendDataDesktop result = JsonConvert.DeserializeObject<ResponseSendDataDesktop>(respuesta);

                int a = 0;
                System.Diagnostics.Debug.WriteLine(result.info);
                if (result.info.Count!=0)
                {
                    System.Diagnostics.Debug.WriteLine("IF");
                    List<string> valores = new List<string>();
                    List<string> mensajes = new List<string>();

                    for (int i = 0; i<=result.info.Count-1; i++)
                    {
                        string CanonicalTitle = "";
                        valores.Add(result.info[i][1]);

                       

                        string urlManga = @"https://kitsu.io/api/edge/manga/" + valores[i];

                        HttpWebRequest requestManga = (HttpWebRequest)WebRequest.Create(urlManga);


                        requestManga.Method = "GET";

                        requestManga.ContentType = "application/vnd.api+json";

                        requestManga.Accept = "application/vnd.api+json";

                        try
                        {
                            WebResponse responseManga = requestManga.GetResponse();
                            Stream streamReaderManga = responseManga.GetResponseStream();
                            StreamReader objReaderManga = new StreamReader(streamReaderManga);
                            string respuestaManga = objReaderManga.ReadToEnd();

                            
                            var resultNombresCanonicos = JsonConvert.DeserializeObject<dynamic>(respuestaManga);

                            var bienvenido = resultNombresCanonicos.data.attributes.canonicalTitle;


                            

                            CanonicalTitle = bienvenido.ToString();

                            
                            
                            System.Diagnostics.Debug.WriteLine(CanonicalTitle);



                        }
                        catch
                        {
                            System.Diagnostics.Debug.WriteLine("CATCH MANGA");
                        }

                        System.Diagnostics.Debug.WriteLine(valores[i]);
                        System.Diagnostics.Debug.WriteLine(result.info[i][0]);
                        System.Diagnostics.Debug.WriteLine(result.info[i][1]);
                        System.Diagnostics.Debug.WriteLine(result.info[i][2]); 
                        System.Diagnostics.Debug.WriteLine(result.info[i][3]);
                        string mensaje = result.info[i][0] + " Ha calificado a "+ CanonicalTitle.ToUpper() + " con "+ result.info[i][2] + " Estrellas y ha comentado  "+ result.info[i][3];
                        mensajes.Add(mensaje);
                        result.info[i].Add(CanonicalTitle);

                        System.Diagnostics.Debug.WriteLine(result.info[i][4]);
                        System.Diagnostics.Debug.WriteLine(mensaje);

                        


                    }
                    return result.info;
                }
                else
                {
                    List<List<string>> vacio = new List<List<string>>();    
                    return vacio;
                }




            }
            catch
            {
                List<List<string>> vacio = new List<List<string>>();
                return vacio;
            }
        }

       



        

    }
}
