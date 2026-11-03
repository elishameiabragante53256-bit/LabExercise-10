
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuickPOS.Data;

namespace QuickPOS.Controllers
{
    public class CashierController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CashierController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();

            return View(products);
        }
    }
}
