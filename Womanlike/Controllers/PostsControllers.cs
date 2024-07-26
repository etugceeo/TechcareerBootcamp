using Microsoft.AspNetCore.Mvc;
namespace Womanlike.Controllers{
    public class PostsController : Controller
    {
        public IActionResult Index(){
            return View();

        }
    }


}