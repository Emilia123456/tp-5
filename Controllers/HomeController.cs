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

    public IActionResult pista1()
    {
        return View();
    }
    public IActionResult pista2()
    {
        return View();
    }
    public IActionResult pista3()
    {
        return View();
    }
    public IActionResult pista4()
    {
        return View();
    }
    public IActionResult pista5()
    {
        return View();
    }
    public IActionResult pista6()
    {
        return View();
    }
    public IActionResult pista7()
    {
        return View();
    }
    public IActionResult pista8()
    {
        return View();
    }
     public IActionResult victoria()
    {
        return View();
    }
     public IActionResult noTenemos()
    {
        return View();
    }


public IActionResult comenzar()
    {
        Escape.InicializarJuego();
        return View("habitacion" + Escape.GetEstadoJuego());

    }

   [HttpPost] public IActionResult habitacion(int codigoSala, string respuesta)
    {
        
        bool correcto = Escape.ResolverSala(respuesta, codigoSala);
        if(Escape.sancion>3){
            return View("victoria");
        }
        if (correcto==true){
            return View("habitacion" + Escape.GetEstadoJuego());
        }
        else{
            Escape.sancion = Escape.sumarSancion();
            return View("incorrecto");
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
