﻿using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "Batman", Password = "Batman", Role = "Manager" });
            users.Add(new User { Id = 2, Username = "Robin", Password = "Robin", Role = "Employee" });

            return users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
