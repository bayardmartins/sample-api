using Sample.API.Models;

namespace Sample.API.Data
{
    public class UserData
    {
        private List<User> _users;
        public UserData()
        {
            MockDB mock = new MockDB();
            _users = mock.GetUsers();
        }

        public User? GetUserByLogin(string login)
        {
            return _users.FirstOrDefault(x => x.Login == login);
        }
    }
}
