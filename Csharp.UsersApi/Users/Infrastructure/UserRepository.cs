using System.Collections.Generic;
using Csharp.UsersApi.Users.Domain;
namespace Csharp.UsersApi.Users.Infrastructure
{
    public interface UserRepository
    {
        User Save(User user);

        List<User> GetUsers();

        User GetUser(string id);


    }
}