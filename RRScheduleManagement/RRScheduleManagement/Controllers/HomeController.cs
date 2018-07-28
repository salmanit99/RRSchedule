using RRSBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace RRScheduleManagement.Controllers
{
    public class HomeController : Controller
    {
       [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

      [HttpGet]
       public static string JsonData()
       {
           UsersBLL usersBLL = new UsersBLL();
           List<RRSBOL.Users> userslist = usersBLL.UsersList().ToList();
           JavaScriptSerializer JsonResult = new JavaScriptSerializer();
           return JsonResult.Serialize(userslist);
       }


    }
}
