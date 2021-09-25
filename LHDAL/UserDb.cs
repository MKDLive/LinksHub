using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHBOL;

namespace LHDAL
{
    interface IUserDb
    {
        IEnumerable<User> GetAllUser();
        User GetUserById(int userId);
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int userId);

    }
    public class UserDb
    {
             readonly LHDBContext lhDbContext;
            public UserDb()
            {
                lhDbContext = new LHDBContext();
            }

            public bool CreateUser(User user)
            {
                lhDbContext.Add(user);
                lhDbContext.SaveChanges();
                return true;
            }

            public bool DeleteUser(int userId)
            {
                var user = lhDbContext.Users.Find(userId);
                lhDbContext.Remove(user);
                lhDbContext.SaveChanges();
                return true;
            }

            public IEnumerable<User> GetAllUser()
            {
            return lhDbContext.Users;
            }

            public User GetUserById(int userId)
            {
                return lhDbContext.Users.Find(userId);
            }

            public bool UpdateUser(User user)
            {
                var updateUser = lhDbContext.Users.Find(user);
                lhDbContext.Update(updateUser);
                return true;
            }
    }
}
