using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookInfoApp.Models;

namespace BookInfoApp.Controllers;

public class HomeController : Controller
{
    public HomeController(){

    }
    [HttpGet]
    public IActionResult Index(string searchString,string category)
    {
        var products = Repository.Products;
        if(!string.IsNullOrEmpty(searchString)){
            ViewBag.SearchString = searchString;
            products = products.Where(products=>products.Name.ToLower().Contains(searchString)).ToList();
        }
        if(!string.IsNullOrEmpty(category) && category != "0"){
            products = products.Where(products=>products.CategoryId == int.Parse(category)).ToList();
        }
        //ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId","Name");
        
        var model = new ProductViewModel{
            Products = products,
            Categories = Repository.Categories,
            SelectedCategory = category
        };
        return View(model);
    }
    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Categories = Repository.Categories;
        return View();
    }
    [HttpPost]
    public IActionResult Create(Product model)
    {
        return View();
    }

}
