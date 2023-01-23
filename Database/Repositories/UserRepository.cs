using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Converters;
using Database.Models;
using domain;
using domain.Repositories;
using drAppointment.DAL;

public class UserRepository : IUserRepository
{
    private readonly ApplicationContext _context;

    public UserRepository(ApplicationContext context)
    {
        _context = context;
    }

    public bool? CheckUserExists(string login, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Login == login);
        return user != null;
    }

    public User? CreateUser(NewUser newUser)
    {
        UserModel user = null;
        user.Id = newUser.Id;
        user.PhoneNumber = newUser.PhoneNumber;
        user.Login = newUser.Login;
        user.Name = newUser.Name;
        user.Role = newUser.Role.Id;
        user.Password= newUser.Password;

        _context.Add(user);

        return user.ToDomain();
    }

    public User? GetByLogin(string login)
    {
        // FirstOrDefault вернет либо одну запись, либо нуль
        var user = _context.Users.FirstOrDefault(u => u.Login == login);
        return user?.ToDomain();
    }
}
