using System.Data.SqlClient;
using BusinessLayer;

namespace DataLayerAPI
{
    public class mangaRebyuDataUser : setDataUser
    {
        private SqlConnection conexion;

        public mangaRebyuDataUser()
        {
            conexion = new SqlConnection(@"Password=Contraseña123;Persist Security Info=True;User ID=sa;Initial Catalog=mangaRebyu;Data Source=DESKTOP-HTIGAP3\SQLEXPRESS");
        }
        public bool createRegister(string username, string password)
        {
            conexion.Open();

            string insert = string.Format(
                "INSERT INTO Users VALUES ('{0}','{1}')",
                username,
                password);

            SqlCommand comando = new SqlCommand(insert, conexion);

            try
            {
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
            catch (System.Data.SqlClient.SqlException)
            {
                conexion.Close();
                return false;
            }
        }

        public bool searchIncome(string username, string password)
        {
            int i = 0;
            conexion.Open();
            string select = string.Format(
                "SELECT * FROM Users WHERE password = '{0}' AND username = '{1}'",
                password,
                username
                );
            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                username = dataReader.GetValue(0).ToString();
                i++;
            }

            conexion.Close();
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}