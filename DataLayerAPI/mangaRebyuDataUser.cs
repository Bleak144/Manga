using System.Data.SqlClient;

namespace DataLayerAPI
{
    public class mangaRebyuDataUser
    {
        private static SqlConnection conexion;

        static mangaRebyuDataUser()
        {
            conexion = new SqlConnection(@"Password=sa;Persist Security Info=True;User ID=sa;Initial Catalog=mangaRebyu;Data Source=DESKTOP-EQLJBRJ");
        }
        public static bool createRegister(string username, string password)
        {
            conexion.Open();

            string insert = string.Format(
                "INSERT INTO Users VALUES ('{0}','{1}')",
                username,
                password);

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

        public static bool searchIncome(string password)
        {
            string username;
            int i = 0;
            conexion.Open();
            string select = string.Format(
                "SELECT * FROM Users WHERE password = '{0}'",
                password
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