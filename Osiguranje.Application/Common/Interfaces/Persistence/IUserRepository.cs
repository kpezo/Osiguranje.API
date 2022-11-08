using Osiguranje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Application.Common.Interfaces.Persistence
{
    public interface IUserRepository
    {
        //Fetching user by Email address, if exists
        User? GetUserByEmail(string email);

        //Adding new user
        void AddUser(User user);
    }
}
