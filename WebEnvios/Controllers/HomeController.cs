using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebEnvios.Models;

namespace WebEnvios.Controllers
{
    public class HomeController : Controller
    {
        private readonly B_Envio b_envio;

        public HomeController(B_Envio b_en)
        {
            b_envio = b_en;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Procesar(string tipo, string nombre, decimal peso)
        {
            try
            {
                E_Envio env = b_envio.Procesar(tipo, nombre, peso);
                return View("Index", env);
            }
            catch (ArgumentException ex)
            {
                TempData["Error"] = "Error al intentar hacer el proceso" + ex.Message;
                return View("Index");
            }
        }
    }
}
