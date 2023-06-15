using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp_5.Models;

namespace tp_5.Controllers;

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

    public IActionResult tutorial()
    {
        return View();
    }

    public IActionResult creditos()
    {
        return View();
    }

    public IActionResult habitacion1()
    {
        return View();
    }

    public IActionResult habitacion2()
    {
        return View();
    }


    public IActionResult habitacion3()
    {
        return View();
    }
    public IActionResult habitacion4()
    {
        return View();
    }

     public IActionResult habitacion5()
    {
        return View();
    }

     public IActionResult habitacion6()
    {
        return View();
    }
    public IActionResult habitacion7()
    {
        return View();
    }

     public IActionResult habitacion8()
    {
        return View();
    }


    public IActionResult incorrecto()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
