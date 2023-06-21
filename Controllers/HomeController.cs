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

    public IActionResult pista()
    {
        ViewBag.nombres=Escape.nombre;
        Escape.sumarPista();
        return View("pista" + Escape.GetEstadoJuego());
    }
     public IActionResult victoria()
    {
        return View();
    }
     public IActionResult noTenemos()
    {
        return View();
    }

    public IActionResult nombre()
    {
        return View();
    }
    [HttpPost] public IActionResult nombreX(string nombre)
    {
        Escape.EstadoCero();
        Escape.nombre=nombre;
        ViewBag.nombres=nombre;
        return View("habitacion" + Escape.GetEstadoJuego());
    }


public IActionResult comenzarDesdeCero()
    {
        Escape.EstadoCero();
        Escape.InicializarJuego();
        return View("habitacion" + Escape.GetEstadoJuego());

    }

public IActionResult comenzar()
    {
        ViewBag.nombres=Escape.nombre;
        Escape.InicializarJuego();
        return View("habitacion" + Escape.GetEstadoJuego());
    }

   [HttpPost] public IActionResult habitacion(int codigoSala, string respuesta)
    {
        
        bool correcto = Escape.ResolverSala(respuesta, codigoSala);
        if(Escape.GetEstadoJuego()>8){
            ViewBag.intentos = Escape.intento;
            ViewBag.creada = Escape.pistas;
            ViewBag.nombres = Escape.nombre;
            return View("victoria");
        }
        if (correcto==true){
            ViewBag.nombres = Escape.nombre;
            return View("habitacion" + Escape.GetEstadoJuego());
        }
        else{
             if(Escape.sancion>3){
            return View("incorrectoPerma");
            }
            ViewBag.nombres=Escape.nombre;
            Escape.sumarIntentos();
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
