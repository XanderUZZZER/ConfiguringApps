using ConfiguringApps.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;

        public HomeController(UptimeService up)
        {
            uptime = up;
        }
        public ViewResult Index() => View(new Dictionary<string, string>
        {
            ["Message"] = "This is the Index action",
            ["Time"] = $"{uptime.Uptime}ms"
        });
    }
}
