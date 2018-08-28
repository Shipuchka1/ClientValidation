using SearchValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchValidation.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Invoice invoice)
        {

            return Redirect("~/Content/Success.html");
        }
    }
}