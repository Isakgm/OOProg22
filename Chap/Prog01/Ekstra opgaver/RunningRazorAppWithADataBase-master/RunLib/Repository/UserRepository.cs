using RunLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLib.Repository
{
    public class UserRepository
    {

        private readonly List<User> _users;

        public UserRepository()
        {
            _users = new List<User>();



            _users.Add(new User("JohnDoe", "1234", "John Doe", true));
            _users.Add(new User("AliceSmi", "1234", "Alice Smith", false));
            _users.Add(new User("EmilyJohn", "1234", "Emily Johnson", false));
            _users.Add(new  User("MichBro", "1234", "Michael Brown", false));
            _users.Add(new User("SarahWil", "1234", "Sarah Wilson", false));
            _users.Add(new User("DavidLee", "1234", "David Lee", false));
            _users.Add(new User("JessMart", "1234", "Jessica Martinez", false));
            _users.Add(new User("RyanGar", "1234", "Ryan Garcia", false));
            _users.Add(new User("SamTay", "1234", "Samantha Taylor", false));
            _users.Add(new User("AndrewClark", "1234", "Andrew Clark", false));


        }
        public void Add(User user)
        {
            User newUser = new User(user.Username, user.Password, user.FullName, user.Role);
            _users.Add(newUser);
        }

        public User Delete(String userName)
        {
            User sletUser = GetByUsername(userName);
            _users.Remove(sletUser);
            return sletUser;
        }

        public User GetByUsername(string userName)
        {
            User? fundetUser = _users.Find(u => u.Username == userName);
            if (fundetUser is null)
            {
                throw new KeyNotFoundException($"User with username={userName} is not found");
            }

            return fundetUser;
        }

        public bool CheckUser(String userName, String password) 
        {
            User? fundetUser = _users.Find(u => u.Username == userName && u.Password == password);
            if (fundetUser is null)
            {
                throw new KeyNotFoundException($"User with username={userName} and password={password} is not found");
            }

            return true;
        }
    }
}
