using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using FormsApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormsApp.Controllers;

public class HomeController : Controller
{


    public HomeController()
    {

    }

    public IActionResult Index(string searchString, string category)
    {
        //you must text data of name at tag 'select' of html to view data of url at to address stick so i wrote name="category" at index.html.
        var products = Repository.Products;
        if (!String.IsNullOrEmpty(searchString))//! determination is not
        {
            ViewBag.SearchString = searchString;
            products = products.Where(p => p.Name.ToLowerInvariant().Contains(searchString)).ToList(); //method of ToLower()  does not operate so we can ToLowerInvariant(). this method use for upper or lower turkish char   
        }
        if (!String.IsNullOrEmpty(category) && category != "0")
        {
            products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
        }

        /* ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", category); this code use for asp-items="ViewBag.Category" in tag of select  at index.cshtml 
        */
        var model = new ProductViewModel
        {
            Products = products,
            Categories = Repository.Categories,
            SelectedCategory = category
        };
        return View(model);
    }

    public IActionResult Create()
    {
        //ViewBag.Categories = Repository.Categories; without asp-items tag helper
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View();
    }
    [HttpPost]
    public IActionResult Create(Product model)
    {
        /*
        public IActionResult Create([Bind("Name","Price")]Product model) for binding data of Name and Price
        */
        if (ModelState.IsValid)
        {
            model.ProductId = Repository.Products.Count + 1;
            Repository.CreateProduct(model);
            return RedirectToAction("Index");
        }
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View(model);

    }


}
