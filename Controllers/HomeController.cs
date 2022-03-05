using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ecommerce.Models;

namespace ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyContext dbContext)
        {
            _logger = logger;
            _context = dbContext;
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("careers")]
        public IActionResult Careers()
        {
            return View("Careers");
        }

        [HttpGet("register")]
        public IActionResult SignUp()
        {
            return View("SignUp");
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpGet("locations")]
        public IActionResult Locations()
        {
            return View("Locations");
        }
        [HttpGet("compcomp")]
        public IActionResult compComp()
        {

            return View("ComputerComponents");
        }
        [HttpGet("about")]
        public IActionResult About()
        {

            return View("About");
        }
        [HttpGet("cpus")]
        public IActionResult cpus()
        {
            return View("CPUs");
        }
        [HttpGet("gpus")]
        public IActionResult gpus()
        {
            return View("GPUs");
        }
        [HttpGet("GPUs")]
        public IActionResult motherboards()
        {
            return View("Motherboards");
        }
        [HttpGet("psus")]
        public IActionResult psus()
        {
            return View("PowerSupplies");
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