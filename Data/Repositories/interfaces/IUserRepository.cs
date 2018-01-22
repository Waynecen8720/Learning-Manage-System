﻿using Data.Database;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User FindUser(string userName, string passwordHash);
    }


}
