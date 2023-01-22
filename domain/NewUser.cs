using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class NewUser
    {
        public int Id { get; set; }
        public string PhoneNumber;
        public string Name;
        public UserRole Role;
        public string Login;
        public string Password;

        public NewUser(string phoneNumber, string name, UserRole role, string login, string password, int id)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Role = role;
            Login = login;
            Password = password;
            Id = id;
        }
    }
}