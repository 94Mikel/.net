using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _1.proyecto.Models;
using _1.proyecto.Servicios;
using Portafolio.Servicios;

namespace _1.proyecto.Controllers;

//HomeController hereda de la clase controller
public class HomeController : Controller
{
    private readonly IRepositorioProyectos repositorioProyectos;
    private readonly IServicioEmail servicioEmail;

    public HomeController(
        IRepositorioProyectos repositorioProyectos, IServicioEmail servicioEmail
        )
    {
        this.repositorioProyectos = repositorioProyectos;
        this.servicioEmail = servicioEmail;
    }
    //Este metodo(acciones) devuelve IActionResult
    public IActionResult Index()
    {
        /*
        VIEWBAG
        La variable name solo es accesible para la vista index.
        ViewBag no es fuertemente tipado. 
        En la vista puedo poner otro nombre de la propiedad y no me dice que hay un error.
        */
        //ViewBag.name = "Mikel 2";
        // ===============
        /*
        var persona = new Persona(){
            Nombre = "Mikel Larruzea",
            Edad = 23
        };
        */

        //Se se pasa como parametro el Index si el modelo es un string.
        var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
        var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
        return View(modelo);
    }

    public IActionResult Privacy()
    {
        return View();
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
        return RedirectToAction("Gracias");
    }

    public IActionResult Gracias()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
