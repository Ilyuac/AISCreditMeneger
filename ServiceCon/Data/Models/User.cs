using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ServiceCon.Data.Models
{
    public enum Gender
    {
        Women,
        Men
    }

    public class User
    {
        public string Login { get; private set; }
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public User(string login, string name, Gender gender, string email, string password)
        {
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Gender = gender;
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = GetHash(password) ?? throw new ArgumentNullException(nameof(password));
        }
        public void UpdateLogin(string login)
        {
            Login = login;
        }
        public void UpdatePassword(string password)
        {
            Password = GetHash(password);
        }
        private string GetHash(string password)
        {
            return SHA256.Create(password).ToString();            
        }
    }
}
