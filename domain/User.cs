using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class User
    {
        private int id;
        private string phoneNumber;
        private string name;
        private UserRole role;
        public string login;
        public string password;

        public int Id { get { return id; } set { id = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Name { get { return name; } set { name = value; } }
        public UserRole Role { get { return role; } set { role = value; } }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}