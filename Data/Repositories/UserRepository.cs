using Data.Database;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(LMSEntities context) : base(context)
        {

        }

        public override User Add(User record)
        {
            if (_context.Users.Any(x => x.UserName == record.UserName))
            {
                return null;
            }
            return base.Add(record);
        }

        //Authentication Provider class in Steps below
        public User FindUser(string userName, string passwordHash)
        {
            return _context.Users.FirstOrDefault(x => x.UserName == userName && x.PasswordHash == passwordHash);
        }
    }

}
