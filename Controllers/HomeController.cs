
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QuickPOS.Models;
using QuickPOS.Data;

namespace QuickPOS.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        ViewBag.TotalProducts = _context.Products.Count();

        ViewBag.TotalStock = _context.Products.Sum(p => p.Stock);

        ViewBag.LowStock = _context.Products.Count(p => p.Stock <= 10);

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}
