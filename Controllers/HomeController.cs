using Lemoo_pos.Models;
using Lemoo_pos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lemoo_pos.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;


        public HomeController( IAuthService authService, IUserService userService)
        {
            _userService = userService;
            _authService = authService;
        }

        public IActionResult Index()
        {
            return View(_userService.GetAllUser());
        }

        
       
    }
}
