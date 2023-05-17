using Microsoft.EntityFrameworkCore;
using System.Linq;
using ООО__Товары_для_животных_.Database;
using ООО__Товары_для_животных_.DataBaseProviders.Interfaces;

namespace ООО__Товары_для_животных_.DataBaseProviders.ClassesInterfaces
{
    public class AuthLoginProvider : IAuthLoginProvider
    {
        public void DbGetAuthWithLoginPassword(string login, string pass)
        {
            var result = DB.Instance.Users.Include("UserRoleNavigation").FirstOrDefault(s => s.UserPassword == pass & s.UserLogin == login)!;
            return;
        }
    }
}