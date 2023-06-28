using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoTest.DAL.Interfaces;
using ToDoTest.Models;


namespace ToDoTest.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITaskRepository _taskRepository;
    
    public HomeController(ILogger<HomeController> logger, ITaskRepository taskRepository)
    {
        _logger = logger;
        _taskRepository = taskRepository;
    }

   
    public IActionResult Index()
    {
       // var response = await _taskRepository.Select();
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
}