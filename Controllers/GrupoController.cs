using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp1_miklaski_falk.Models;

namespace tp1_miklaski_falk.Controllers;

public class GrupoController : Controller
{
    public IActionResult Index()
    {
        Grupo grupo = new Grupo();
        ViewBag.grupo = grupo;
        return View();
    }

    public IActionResult selectIntegrante(int dni)
    {
        
    }
}