using KimsijunPortfolio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KimsijunPortfolio.Module
{
    public class DefaultUserRepository : IUserRepository
    {
        public void Add(User newUser)
        {

        }

        public User FetchByLoginName(string loginName)
        {
            return new User() { LoginName = loginName };
        }

        public void SubmitChanges()
        {

        }
    }
}
