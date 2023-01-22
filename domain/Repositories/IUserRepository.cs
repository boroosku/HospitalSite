using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Repositories
{
    public interface IUserRepository
    {
        User? GetByLogin(string login);
        bool? CheckUserExists(string login, string password);
        User? CreateUser(NewUser newUser);
    }
}