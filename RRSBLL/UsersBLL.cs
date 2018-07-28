using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRSDAL;
using RRSBOL;

namespace RRSBLL
{
    public class UsersBLL
    {
        #region Users List
        public List<Users> UsersList()
        {
            UsersDAL usersDAL = new UsersDAL();
            return usersDAL.UsersList().ToList();
        }
        #endregion

        #region User Registration Page

        public bool UserRegistration(Users user)
        {
            UsersDAL usersDAL = new UsersDAL();
            return usersDAL.UserRegistration(user);
        }

        #endregion
    
    }
}
