using KimsijunPortfolio.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KimsijunPortfolio.Module
{
    public class AdminController : Controller
    {
        private IUserRepository repository;

        public AdminController(IUserRepository repository) => this.repository = repository;

        public ActionResult ChangeLoginName(string oldName, string newName)
        {
            User user = repository.FetchByLoginName(oldName);
            user.LoginName = newName;
            repository.SubmitChanges();
            return View();
        }
    }
}
