using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public RedirectResult Login(Login login, string ReturnUrl)
        {
            return Redirect(ReturnUrl??"/");
        }
    }
}