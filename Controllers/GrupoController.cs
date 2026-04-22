using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp1_miklaski_falk.Models;

namespace tp1_miklaski_falk.Controllers;

public class GrupoController : Controller
{
    public IActionResult Index()
    {
        Grupo grupo = new Grupo();
        grupo.CargaDatosManual();
        ViewBag.grupo = grupo;
        return View();
    }

    public IActionResult selectIntegrante(int dni)
    {
        Dictionary<int, Integrante> dicGrupo = ViewBag.grupo.devolverIntegrantes();

        if(dicGrupo.ContainsKey(dni))
        {
            Integrante integrante = dicGrupo[dni];
            ViewBag.integrante = integrante;
            return View(); 
            }
        else
        {
            return RedirectToAction("NoEncontrado", "Grupo");
        }
    }
}