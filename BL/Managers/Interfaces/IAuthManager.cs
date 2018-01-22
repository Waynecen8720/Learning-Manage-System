using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.interfaces
{
    public interface IAuthManager
    {
        User FindUser(string userName, string passwordHash);
    }


}
