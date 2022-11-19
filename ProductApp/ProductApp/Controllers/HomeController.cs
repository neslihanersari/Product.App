using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        string message = "Hello MVC";

        return View("Index", message);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GetProducts()
    {
        Product product = new Product(1, "Computer", 1000);
        Product product1 = new Product(2, "Phone", 2000);

        var products = new List<Product>();
        products.Add(product);
        products.Add(product1);

        return View("GetProduct", products);
    }

}