using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deus.Domain.Users;
using Deus.Persistence.Common;

namespace Deus.Persistence.User
{
    public class UserRepository : Repository<Domain.Users.User>, IUserRepository
    {
        public IEnumerable<Domain.Users.User> GetAllUsers()
        {
            return new List<Domain.Users.User>()
            {
                new Domain.Users.User() {UserId = 1, FirstName = "Kavindu", LastName = "manaram"}
            };
        }


        public UserRepository(DeusContext context) : base(context)
        {
        }
    }
}
