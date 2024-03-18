using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLib.Model
{
    public class User
    {
        public string Username { get; set; }

    
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Role {  get; set; }

        public User(): this("","","", false)
        {
            
        }

        public User(string username, string password, string fullName, bool role)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Role = role;
        }

        public override string ToString()
        {
            return $"{{{nameof(Username)}={Username}, {nameof(Password)}={Password}, {nameof(FullName)}={FullName}, {nameof(Role)}={Role}}}";
        }
    }
}
