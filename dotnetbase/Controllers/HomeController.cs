using System.Diagnostics;
using dotnetbase.Data;
using dotnetbase.Models;
using dotnetbase.Repository;
using Microsoft.AspNetCore.Mvc;

namespace dotnetbase.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepository<CategoryMenu> _repositoryCategory;
    public HomeController(ILogger<HomeController> logger, IRepository<CategoryMenu> repositoryCategory)
    {
        _logger = logger;
        _repositoryCategory = repositoryCategory;
    }

    public async Task<IActionResult> Index()
    {
        ViewData["CategoryMenu"] = await _repositoryCategory.GetListAsync();
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