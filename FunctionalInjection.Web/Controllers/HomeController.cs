using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunctionalInjection.Web.Controllers
{
    public class HomeController : Controller
    {
        private Func<string, string> _getPerson;
        private Func<string, string> _getAddress;

        public HomeController(Func<string, string> getPerson, Func<string, string> getAddress)
        {
            _getPerson = getPerson;
            _getAddress = getAddress;
        }

        public ActionResult Index()
        {
            var personId = "1";
            ViewBag.Person = _getPerson(personId);
            ViewBag.Address = _getAddress(personId);
            return View();
        }
    }
}