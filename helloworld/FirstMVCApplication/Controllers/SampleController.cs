using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }
        [Route("mone")]
        public string M1()
        {
            return "Hey! I am method one";
        }
        [Route("mtwo")]
        public string twodsfsgsrga()
        {
            return "Hey! I am method two";
        }
    }
}