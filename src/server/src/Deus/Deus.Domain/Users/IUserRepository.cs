using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deus.Domain.Common;

namespace Deus.Domain.Users
{
    public interface IUserRepository:  IRepository<User>
    {
        IEnumerable<User> GetAllUsers();
    }
}
