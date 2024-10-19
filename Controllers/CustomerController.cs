using Microsoft.AspNetCore.Mvc;

namespace Lemoo_pos.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult NewCustomer() { return View(); }


     
    }
}
