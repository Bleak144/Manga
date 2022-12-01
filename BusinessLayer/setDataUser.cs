using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface setDataUser
    {
        public bool createRegister(string username, string password);
        public bool searchIncome(string username, string password);
    }
}
