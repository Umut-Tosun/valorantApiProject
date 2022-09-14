using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using valorantProject.Models.Class;

namespace valorantProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = c.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["Kullanici"] = values.UserName.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult logOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Default");
        }
    }
}