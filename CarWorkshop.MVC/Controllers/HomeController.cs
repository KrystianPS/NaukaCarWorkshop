using CarWorkshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarWorkshop.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        var model = new List<Person>()
        {
            new Person()
            {
                FirstName = "Juog",
                LastName = "Yong"
            },
            new Person()
            {
                FirstName = "nguyen",
                LastName = "nguyen"
            },
         };

        return View(model);
    }

    public IActionResult About()
    {
        var model = new About()
        {
            Title = "your",
            Description = "momma",
            Tags = new List<string>() { "is", "fat" }


        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
