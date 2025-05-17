using System.Diagnostics;
using ProyectoWEB.Servicios;
using Microsoft.AspNetCore.Mvc;
using ProyectoWEB.Models;

namespace ProyectoWEB.Controllers
{
    public class HomeController : Controller
    {
            private readonly ILogger<HomeController> _logger;
            private readonly IRepositorioProyectos repositorioProyectos;
            private readonly IConfiguration configuration;
            private readonly IServicioEmail servicioEmail;

            public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos, IConfiguration configuration, IServicioEmail servicioEmail)
            {
                _logger = logger;
                this.repositorioProyectos = repositorioProyectos;
                this.configuration = configuration;
                this.servicioEmail = servicioEmail;
            }

            public IActionResult Index()
            {
                var apellido = configuration.GetValue<string>("Apellido");

                var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
                var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
                return View(modelo);
            }

            public IActionResult Proyectos()
            {
                var proyectos = repositorioProyectos.ObtenerProyectos();
                return View(proyectos);
            }

            public IActionResult Contacto()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
            {
                await servicioEmail.Enviar(contactoViewModel);
                return RedirectToAction("MensajeExitoso");
            }

            public IActionResult MensajeExitoso()
            {
                return View();
            }

            public IActionResult Privacy()
            {
                return View();
            }

            public IActionResult Registro()
            {
                return View();
            }

            public IActionResult InicioSesion()
            {
                return View();
            }


            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
