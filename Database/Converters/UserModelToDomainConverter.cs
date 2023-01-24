using Database.Models;
using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Converters;
public static class UserModelToDomainConverter
{
    public static User? ToDomain(this UserModel model)
    {
        UserRole temp = null;
        temp.Id = model.Role;
        return new User
        {
            Id = model.Id,
            Login = model.Login,
            PhoneNumber = model.PhoneNumber,
            Name = model.Name,
            Role = temp
        };
    }
}