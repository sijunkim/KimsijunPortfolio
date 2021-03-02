using KimsijunPortfolio.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace KimsijunPortfolio.Module.Test
{
    [TestClass]
    public class AdminControllerTests
    {
        [TestMethod]
        public void CanChangeLoginName()
        {
            User user = new User { LoginName = "KimSiJun" };
            FakeRepository fakeRepository = new FakeRepository();
            fakeRepository.Add(user);
            AdminController target = new AdminController(fakeRepository);
            string oldLogin = user.LoginName;
            string newLogin = "ParkMinSu";

            target.ChangeLoginName(oldLogin, newLogin);

            Assert.AreEqual(newLogin, user.LoginName);
            Assert.IsTrue(fakeRepository.DidSumitChanges);
        }

        class FakeRepository : IUserRepository
        {
            public List<User> users = new List<User>();
            public bool DidSumitChanges = false;

            public void Add(User user)
            {
                users.Add(user);
            }

            public User FetchByLoginName(string loginName)
            {
                return users.FirstOrDefault(x => x.LoginName.Equals(loginName)) ?? new User { LoginName = loginName };
            }

            public void SubmitChanges()
            {
                DidSumitChanges = true;
            }
        }
    }
}
