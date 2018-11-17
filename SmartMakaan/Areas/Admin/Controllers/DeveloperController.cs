using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartMakaan.Areas.Admin.Controllers
{
    public class DeveloperController : Controller
    {
        // GET: Admin/Developers
        public ActionResult Index()
        {
            return View();
        }
    }
}