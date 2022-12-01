using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface setDataManga
    {
        public bool createRegisterManga(string username, string manga, int rating, string coment);

        public List<List<string>> sendDataMovil(string idManga);

        public List<List<string>> sendDataDesktop();
    }
}
