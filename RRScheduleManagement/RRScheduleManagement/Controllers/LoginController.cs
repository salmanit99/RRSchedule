using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RRSBLL;
using RRSBOL;

namespace RRScheduleManagement.Controllers
{
        public class LoginController : Controller
        {
            [HttpGet]
            public ActionResult UserLogin()
            {
                return View();
            }


            [HttpPost]
            public ActionResult UserLogin(UserLogin login)
            {
                if (ModelState.IsValid)
                {

                    UsersBLL usersBLL = new UsersBLL();               
                    Users usersDetails = usersBLL.UsersList().Where(s => s.Email == login.Email && s.Password == login.Password).FirstOrDefault();
                    Session["UserName"] = usersDetails.Firstname + " " + usersDetails.Lastname;
                    Session["UserRole"] = usersDetails.RuleId;
                    Session["UserActive"] = usersDetails.IsActive;
                    if (usersDetails != null)
                    {
                        return Redirect("Users/Users/UserRegistration");
                    }
                }

                return View("UserLogin");
            }
        }

    
}
