using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayerAPI
{
    public class mangaRebyuDataManga : setDataManga
    {
        private SqlConnection conexion;

        public mangaRebyuDataManga()
        {
            conexion = new SqlConnection(@"Password=Contraseña123;Persist Security Info=True;User ID=sa;Initial Catalog=mangaRebyu;Data Source=DESKTOP-HTIGAP3\SQLEXPRESS");
        }
        public bool createRegisterManga(string username, string manga, int rating, string coment)
        {
            conexion.Open();

            string insert = string.Format(
                "INSERT INTO Manga VALUES ('{0}','{1}', '{2}','{3}')",
                username,
                manga,
                rating,
                coment);

            SqlCommand comando = new SqlCommand(insert, conexion);

            int rows = comando.ExecuteNonQuery();

            if (rows == 0)
            {
                conexion.Close();
                return false;
            }
            else
            {
                conexion.Close();
                return true;
            }
        }

        public List<List<string>> sendDataMovil(string idManga)
        {
            conexion.Open();
            List<List<string>> data = new List<List<string>>();
            string value1;

            string select = string.Format(
                "SELECT * FROM Manga WHERE idManga = '{0}'",
                idManga
                );
            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                List<string> values = new List<string>();
                values.Add(dataReader.GetValue(0).ToString());
                values.Add(dataReader.GetValue(1).ToString());
                values.Add(dataReader.GetValue(3).ToString());
                values.Add(dataReader.GetValue(4).ToString());
                data.Add(values);
            }
            conexion.Close();

            return data;
        }
        public List<List<string>> sendDataDesktop()
        {
            conexion.Open();
            List<List<string>> data = new List<List<string>>();

            string select = string.Format(
                "SELECT * FROM Manga");
            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                
                    
                    List<string> values = new List<string>();
                    values.Add(dataReader.GetValue(1).ToString());
                    values.Add(dataReader.GetValue(2).ToString());
                    values.Add(dataReader.GetValue(3).ToString());
                    values.Add(dataReader.GetValue(4).ToString());
                    data.Add(values);
               
            }
            conexion.Close();

            return data;
        }
    }
}
