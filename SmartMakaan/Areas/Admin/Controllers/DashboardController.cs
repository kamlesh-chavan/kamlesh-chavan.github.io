using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartMakaan.Areas.Admin.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        // GET: Admin/Home
        [Route("Dashboard")]
        public ActionResult Index()
        {
            return View();
        }       
    }
}