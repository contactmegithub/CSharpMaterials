using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class HttpVerbController : Controller
    {
        // GET: HttpVerb
        public ActionResult Index()
        {
            return View();
        }
        public string Addition()
        {
            return "Addition";
        }
        [HttpPost]
        public string Subraction()
        {
            return "Subraction";
        }
    }
}