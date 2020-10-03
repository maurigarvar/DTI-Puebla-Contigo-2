using PueblaContigo.Models;
using PueblaContigo.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PueblaContigo.Data
{
    public class UserRepository
    {
        //Manejo de base de datos del user
        readonly SQLiteAsyncConnection database;
        public UserRepository(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }
        #region CRUD
        public Task<List<User>> GetUsers()
        {
            return database.QueryAsync<User>("Select * From User");
        }
        public Task<List<User>> GetUserAutentification(string userName, string password)
        {
            return database.QueryAsync<User>("Select * From User where usuario={0} and password={1}", userName,password);
        }
        public Task<int> SaveUserAsync(User user)
        {
            if (database.QueryAsync<User>("Select id From User where id={0}", user.id) == null)
            {
                return database.InsertAsync(user);
            }
            else
            {
                return database.UpdateAsync(user);
            }
        }
        public Task<int> DeleteUserAsync(User user)
        {
            return database.DeleteAsync(user);
        }
        #endregion
    }
}
