using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View(new Dictionary<string, string>
        {
            ["Message"] = "This is the Index action"
        });
    }
}
