using Sample.API.Data;
using Sample.API.Interfaces;
using Sample.API.Models;

namespace Sample.API.Service
{
    public class UserService : IUserService
    {
        private UserData _data;
        public UserService()
        {
            this._data = new UserData();
        }

        public User? GetUserByLogin(string login)
        {
            return _data.GetUserByLogin(login);
        }
    }
}
