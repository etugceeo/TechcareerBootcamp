using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            /* viewbag verilerini return a 
            int saat = DataTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın"; bu şekilde view de direkt @ViewBag.Selamlama yazıp kullan
            ViewBag.UserName = "Elif Tuğçe";
            return View();
            
            */
            /*     var selamlama = saat > 12 ? "İyi Günler":"Günaydın"; 
            return View(model : selamlama);
            bu şekilde stringi model olarak gönder
            ama view de başa bunu yaz => @model string */
            /*
            ViewData key value şeklinde olan
            view da @ViewData["Selamlama"] şklinde kullan
            */
            ViewData["Selamlama"] = saat > 12 ? "İyi Günler":"Günaydın";
            ViewData["UserName"] = "Elif";
            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = " İstanbul , Abc Kongre Merkezi",
                Date = new DateTime(2024, 12, 20, 20, 0, 0),
                NumberOfPeople = 100
            };
            return View(meetingInfo);
        }
    }
}