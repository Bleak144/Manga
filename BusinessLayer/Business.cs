namespace BusinessLayer
{
    public class Business
    {
        setDataManga repositorio;
        setDataUser repositorio1;
        public Business(setDataManga respositorio, setDataUser repositorio1)
        {
            this.repositorio = respositorio;
            this.repositorio1 = repositorio1;
        }
        public bool createRegister(string username, string password)
        {
            return repositorio1.createRegister(username, password);
        }

        public bool searchIncome(string username, string password)
        {
            return repositorio1.searchIncome(username, password);
        }

        public bool createRegisterManga(string username, string manga, int rating, string coment)
        {
            return repositorio.createRegisterManga(username, manga, rating, coment);
        }

        public List<List<string>> sendDataMovil(string idManga)
        {
            return repositorio.sendDataMovil(idManga);
        }

        public List<List<string>> sendDataDesktop()
        {
            return repositorio.sendDataDesktop();
        }
    }
}