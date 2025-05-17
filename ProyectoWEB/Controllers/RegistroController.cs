using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ProyectoWEB.Models;
using ProyectoWEB.Servicios;

namespace ProyectoWEB.Controllers
{
    public class RegistroController : Controller
    {
        private readonly IRepositorioRegistro repositorioRegistro;

        ///  private readonly string connectionString;
        public RegistroController(IRepositorioRegistro repositorioRegistro)//IConfiguration configuration)
        {
            this.repositorioRegistro = repositorioRegistro; 
        }

        // GET: RegistroController/Create  
        [HttpGet]
        public IActionResult Create()
        {
            return View("~/Views/Home/Registro.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Persona persona)
        {
            Console.WriteLine("Entró al método Create");

            if (!ModelState.IsValid)
            {
                return View("~/Views/Home/Registro.cshtml", persona);
            }

            persona.Id = 0;
            repositorioRegistro.Create(persona);

            return RedirectToAction("Index", "Home");
        }
    }
}
