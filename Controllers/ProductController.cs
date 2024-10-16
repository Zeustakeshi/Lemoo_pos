using Microsoft.AspNetCore.Mvc;

namespace Lemoo_pos.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Categories ()
        {
            return View();
        }

        public IActionResult NewProduct () { return View(); }


        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
