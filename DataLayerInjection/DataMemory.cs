using BusinessLayer;
using System.Windows.Markup;

namespace DataLayerInjection
{
    public class DataMemory : setDataUser, setDataManga
    {
        List<string> MemoryTable = new List<string>();

        public DataMemory()
        {
            string id = "2";
            string username = "Sierra";
            string password = "321";
            string idManga = "14916";
            string rating = "5";
            string coment = "Muy bueno";

            MemoryTable.Add(username);
            MemoryTable.Add(password);
            MemoryTable.Add(idManga);
            MemoryTable.Add(rating);
            MemoryTable.Add(coment);
        }
        public bool createRegister(string username, string password)
        {
            if (!MemoryTable.Contains(username))
            {
                string usernameNew = username;
                string passwordNew = password;

                MemoryTable.Add(usernameNew);
                MemoryTable.Add(passwordNew);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool createRegisterManga(string username, string manga, int rating, string coment)
        {
            string usernameNew = username;
            string mangaNew = manga;
            string ratingNew = rating.ToString();
            string comentNew = coment;

            MemoryTable.Add(usernameNew);
            MemoryTable.Add(mangaNew);
            MemoryTable.Add(ratingNew);
            MemoryTable.Add(comentNew);

            return true;

        }

        public bool searchIncome(string username, string password)
        {
            for (int i = 0; i < MemoryTable.Count; i++)
            {
                if (this.MemoryTable[i].Equals(username) && this.MemoryTable[i + 1].Equals(password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public List<List<string>> sendDataDesktop()
        {
            List<List<string>> desktopMemory = new List<List<string>>();
            List<string> values = new List<string>();
            int i = 1;
            values.Add(MemoryTable[i]);
            values.Add(MemoryTable[i + 2]);
            values.Add(MemoryTable[i + 3]);
            values.Add(MemoryTable[i + 4]);
            desktopMemory.Add(values);
            return desktopMemory;
        }

        public List<List<string>> sendDataMovil(string idManga)
        {
            List<List<string>> desktopMemory = new List<List<string>>();
            List<string> values = new List<string>();
            int i = 0;
            values.Add(MemoryTable[i]);
            values.Add(MemoryTable[i + 1]);
            values.Add(MemoryTable[i + 2]);
            values.Add(MemoryTable[i + 3]);
            values.Add(MemoryTable[i + 4]);
            desktopMemory.Add(values);
            return desktopMemory;
        }
    }
}