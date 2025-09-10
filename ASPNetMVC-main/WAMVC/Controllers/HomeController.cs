using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WAMVC.Models;

namespace WAMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HomeModel Mode = new HomeModel();
        Mode.Mensaje = "Hola Mundito!";
        //Mode.Destinatario = "Docentes";
        return View(Mode);
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    // GET: Home/TestClienteValidation
    public IActionResult TestClienteValidation()
    {
        return View(new ClienteModel());
    }

    // POST: Home/TestClienteValidation
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult TestClienteValidation(ClienteModel clienteModel)
    {
        if (ModelState.IsValid)
        {
            TempData["SuccessMessage"] = "¡Validación exitosa! Los datos del cliente son válidos.";
            return RedirectToAction(nameof(TestClienteValidation));
        }
        return View(clienteModel);
    }
}
