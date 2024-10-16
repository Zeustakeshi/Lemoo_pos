using Lemoo_pos.Models;
using Lemoo_pos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lemoo_pos.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController (IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(CreateStoreModel createAccountModel)
        {
            if (!ModelState.IsValid)
            {
                return View(createAccountModel);
            }

            try
            {
				_authService.CreateAccount(createAccountModel);
			}catch(Exception ex)
            {
                ViewData["Error_message"] = ex.Message;
                return View(createAccountModel);
            }

            return RedirectToAction("Login");
        }

        public IActionResult VerifyAccount (string code)
        {
           if (code == null) {
                ViewData["Error_message"] = "Mã xác nhận không hợp lệ";
				return View(); 
           }

           return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
