using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerAPI
{
    public class mangaRebyuDataManga
    {
        private static SqlConnection conexion;

        static mangaRebyuDataManga()
        {
            conexion = new SqlConnection(@"Password=sa;Persist Security Info=True;User ID=sa;Initial Catalog=mangaRebyu;Data Source=DESKTOP-EQLJBRJ");
        }
        public static bool createRegisterManga(string username, string manga, int rating, string coment)
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

        public static Dictionary<string, List<string>> sendDataMovil(string idManga)
        {
            conexion.Open();
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
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
                values.Add(dataReader.GetValue(3).ToString());
                values.Add(dataReader.GetValue(4).ToString());
                data.Add(dataReader.GetValue(1).ToString(),values);
            }
            conexion.Close();

            return data;
        }
        public static Dictionary<string, List<string>> sendDataDesktop(bool flag)
        {
            conexion.Open();
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            string select = string.Format(
                "SELECT * FROM Manga");
            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                if (data.ContainsKey(dataReader.GetValue(1).ToString()))
                {
                    List<string> valuesDictionary = new List<string>();
                    valuesDictionary = data[dataReader.GetValue(1).ToString()];
                    valuesDictionary.Add(dataReader.GetValue(2).ToString());
                    valuesDictionary.Add(dataReader.GetValue(3).ToString());
                    valuesDictionary.Add(dataReader.GetValue(4).ToString());
                    data[dataReader.GetValue(1).ToString()] = valuesDictionary;
                }
                else
                {
                    List<string> values = new List<string>();
                    values.Add(dataReader.GetValue(2).ToString());
                    values.Add(dataReader.GetValue(3).ToString());
                    values.Add(dataReader.GetValue(4).ToString());
                    data.Add(dataReader.GetValue(1).ToString(), values);
                }
            }
            conexion.Close();

            return data;
        }
    }
}
