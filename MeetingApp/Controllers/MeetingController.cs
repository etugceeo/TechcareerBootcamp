using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeetingApp.Controllers
{
  
    public class MeetingController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}