using RRSBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using RRSBOL;
namespace RRSServices
{
    /// <summary>
    /// Summary description for UserService
    /// </summary>
    [WebService(Namespace = "http://UserService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class UserService : System.Web.Services.WebService
    {


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string JsonData()
        {
       
            UsersBLL usersBLL = new UsersBLL();
            List<RRSBOL.Users> userslist = usersBLL.UsersList().ToList();
            JavaScriptSerializer JsonResult = new JavaScriptSerializer();
            return JsonResult.Serialize(userslist);
        }

        [WebMethod(Description="This method for User registration")]
        public void AddUsers(RRSBOL.Users user)
        {
            UsersBLL usersBLL = new UsersBLL();
            bool result = usersBLL.UserRegistration(user);
        }

    }
}
