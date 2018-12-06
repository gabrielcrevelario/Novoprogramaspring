using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositorories
{
    public interface ISiteRepository
    {
        List<User> CreateUsers(User[] Users);
        List<User> GetUsersByCustumer(long IdCustumer);

    }
}
