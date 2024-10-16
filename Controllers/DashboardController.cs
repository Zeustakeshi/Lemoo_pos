using Lemoo_pos.Models;
using Lemoo_pos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lemoo_pos.Controllers
{
    public class DashboardController : Controller
    {
        public DashboardController( )
        {
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
