using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IUserRepository
    {
        User GetUser(string lastName, string firstName);
        void CreateUser(User user);
    }
}
