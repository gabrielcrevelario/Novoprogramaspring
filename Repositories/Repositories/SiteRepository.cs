using Entities;
using IRepositorories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SiteRepository : ISiteRepository
    {
        #region Methods
        public List<User> CreateUsers(User[] Users)
        {
            User user1 = new User(1, "teste", "teste", "teste@gmail", true, true, true);
            User user2 = new User(2, "teste2", "teste2", "teste2@gmail", true, true, true);
            User user3 = new User(3, "teste3", "teste3", "teste3@gmail", true, true, true);
            List<User> listUser = new List<User>();
            listUser.Add(user1);
            listUser.Add(user2);
            listUser.Add(user3);
            foreach (User user in Users)
            {
                var result = listUser.First(x => x.IdUser == user.IdUser);
                if( !String.IsNullOrEmpty(result.IdUser.ToString())) {
                    int index = Array.FindIndex(listUser.ToArray(), x => x.IdUser == user.IdUser);
                    listUser.Remove(listUser[index]);
                }
                listUser.Add(user);
            }
            return listUser;
        }

        public List<User> GetUsersByCustumer(long IdCustumer)
        {
            User user1 = new User(1, "teste", "teste", "teste@gmail", true, true, true);
            User user2 = new User(2, "teste2", "teste2", "teste2@gmail", true, true, true);
            User user3 = new User(3, "teste3", "teste3", "teste3@gmail", true, true, true);
            List<User> listUser = new List<User>();
            listUser.Add(user1);
            listUser.Add(user2);
            listUser.Add(user3);
            return listUser;
        }
        #endregion
    }
}
