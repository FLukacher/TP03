using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Catalogo.InicializarCatalogo();
        ViewBag.discos = Catalogo.discos;      
        return View();
    }
    public IActionResult SelectDisco(int id)
    {
        if (Catalogo.discos.ContainsKey(id))
        {
            ViewBag.disco = Catalogo.discos[id];
            ViewBag.id = id;
        }
        return View("datosDisco.html");
    }
}
