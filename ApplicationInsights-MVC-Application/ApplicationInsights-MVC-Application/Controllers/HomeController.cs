using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationInsights_MVC_Application.Controllers
{
    public class HomeController : Controller
    {
        TelemetryClient telemetryClient = new TelemetryClient();
        public ActionResult Index()
        {
            telemetryClient.TrackTrace("Inside index method");
            return View();
        }

        public ActionResult About()
        {
            telemetryClient.TrackTrace("Inside About method");

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            telemetryClient.TrackTrace("Inside Contact method");

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}