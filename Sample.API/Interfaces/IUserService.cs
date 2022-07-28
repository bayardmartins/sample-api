using Sample.API.Models;

namespace Sample.API.Interfaces
{
    public interface IUserService
    {
        public User? GetUserByLogin(string login);
    }
}
