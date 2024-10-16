using Lemoo_pos.Models;
using Lemoo_pos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lemoo_pos.Controllers
{
    public class HomeController : Controller
    {
        public HomeController( )
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        
       
    }
}
