using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPIDemo.Controllers
{
    public class HeatmapController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Heatmap";

            return View();
        }
    }
}

