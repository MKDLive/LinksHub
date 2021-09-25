using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHBOL;
using LHDAL;

namespace LHBLL
{
    interface IUserBL
    {
        IEnumerable<User> GetAllUser();
        User GetUserById(int userId);
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int userId);

    }
    public class UserBL : IUserBL
    {
        readonly UserDb userDb;
        public UserBL()
        {
            userDb = new UserDb();
        }
        public bool CreateUser(User user)
        {
            return userDb.CreateUser(user);
        }

        public bool DeleteUser(int userId)
        {
            return userDb.DeleteUser(userId);
        }

        public IEnumerable<User> GetAllUser()
        {
            return userDb.GetAllUser();
        }

        public User GetUserById(int userId)
        {
            return userDb.GetUserById(userId);
        }

        public bool UpdateUser(User user)
        {
            return userDb.UpdateUser(user);
        }
    }
}
