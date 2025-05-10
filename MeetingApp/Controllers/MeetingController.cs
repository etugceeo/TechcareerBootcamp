using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{

    public class MeetingController : Controller
    {


        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if (ModelState.IsValid)
            {
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
                return View("Thanks", model);
            } else {
                return View(model);
            }
        }
        /*burası model olmadan
        public IActionResult Apply(string Name, string Phone, string Email, bool WillAttend)
        {
            //ConsoleWriteLine(Name, Email, Phone, WillAttend);
            return View();
        }
        */
        public IActionResult List()
        {
            var user = Repository.Users;
            return View(user);
        }
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }


    }
}