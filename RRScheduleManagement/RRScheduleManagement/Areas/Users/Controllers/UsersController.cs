using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RRSBOL;
using RRSBLL;
using Microsoft.Reporting.WebForms;
using System.Web.Script.Serialization;
using System.Web.Services;
using RRScheduleManagement.ServiceReference1;
using RRScheduleManagement.Areas.Users;
using RRScheduleManagement.Common;
namespace RRScheduleManagement.Areas.Users.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public ActionResult UsersList()
        {          
           return View();
        }
    
        public  string JsonData()
        {
            UsersBLL usersBLL = new UsersBLL();
            List<RRSBOL.Users> userslist = usersBLL.UsersList().ToList();
            JavaScriptSerializer JsonResult = new JavaScriptSerializer();
             return JsonResult.Serialize(userslist);
        }

        [HttpGet]
        public ActionResult UserRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserRegistration(RRSBOL.Users user)
        {
            bool Status = false;
            string message = "";

            //Model validation
            if (ModelState.IsValid)
            {
                //Verify the Email
                #region
                var isExist = isEmailExist(user.Email);
                if (isExist)
                {
                    ModelState.AddModelError("EmailExist", "Email ALready Exist");
                    return View("UserRegistration");
                }              
                #endregion

                //Generate Activation Code
                #region
                user.ActivationCode = Guid.NewGuid();
                #endregion

                //Password hashing
                #region
                user.Password = Crypto.Hash(user.Password);
                user.ConfirmPassword = Crypto.Hash(user.ConfirmPassword);
                #endregion

                //Saving data to the database
                UsersBLL userBLL = new UsersBLL();
                bool result = userBLL.UserRegistration(user);
                if (result)
                {
                    @ViewBag.message = "User registred successfully";
                    user.Email = string.Empty ;
                    return View();
                }
               
            }
            else
            {
                @ViewBag.message = "Invalid Argument";
            }
            return View();
        }

        public FileResult ExportTo(string ReportType)
        {
            UsersBLL usersBLL = new UsersBLL();

            LocalReport localReport = new LocalReport();
            localReport.ReportPath = Server.MapPath("~/Reports/rptUserList.rdlc");

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = usersBLL.UsersList().ToList();

            localReport.DataSources.Add(reportDataSource);

            string fileNameExtension = (ReportType == "Excel") ? "xls" : "pdf";
            byte[] renderBytes;
            renderBytes = localReport.Render(ReportType);

            Response.AddHeader("content-disposition", "attachment; filename=Urls." + fileNameExtension);
            return File(renderBytes, fileNameExtension);
        }

        [NonAction]
        public bool isEmailExist(string Email)
        {
            UsersBLL usersBLL = new UsersBLL();
            var v= usersBLL.UsersList().Where(x => x.Email == Email).FirstOrDefault();
            if (v != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      

    }
}
