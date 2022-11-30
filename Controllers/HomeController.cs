using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using thejohns.Models;

namespace thejohns.Controllers
{
    public class HomeController : Controller
    {
        
        private JohnTableContext _context { get; set; }
        public HomeController(JohnTableContext temp)
        {
            _context = temp;
        }
  

        public IActionResult Index()
        {
            var johns = _context.JohnTable.ToList();
            return View(johns);
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
}