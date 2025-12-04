using FinalProject.Models;
using SQLite;


namespace FinalProject.Respository
{
    public class AccountRepository

    {
        private readonly ISQLiteConnection _connection;
        public AccountRepository()
        {
            //init sqlite
        }
        public void Save(AccountModel account)
        {
           
        }

        public AccountModel GetByUsername(string username)
        {
           
            return null;
        }
    }
}
