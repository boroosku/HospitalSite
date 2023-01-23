using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.Repositories;

namespace domain.Services
{
    public class UserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public Result<User> GetUserByLogin(string login)
        {
            if (string.IsNullOrEmpty(login))
                return Result.Fail<User>("Login was not specified");

            var user = _repository.GetByLogin(login);

            return user is null ? Result.Fail<User>("User not found") : Result.Ok(user);
        }

        public Result<User> CreateUser(NewUser newUser)
        {
            var user = _repository.CreateUser(newUser);

            return user is null ? Result.Fail<User>("User not created") : Result.Ok(user);
        }

        public Result CheckUserExists(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                return Result.Fail("Login or Password was not specified");

            var isUser = _repository.CheckUserExists(login, password);

            return isUser is null ? Result.Fail("User not exists") : Result.Ok("User exists");
        }
    }
}