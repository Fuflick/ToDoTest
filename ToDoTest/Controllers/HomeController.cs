using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoTest.Models;
using ToDoTest.Domain.Entity;
using Task = ToDoTest.Domain.Entity.Task;


namespace ToDoTest.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Task task = new Task()
        {
            Name = "test",
            Body = "TestTestTest"
        };
        return View(task);
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
}