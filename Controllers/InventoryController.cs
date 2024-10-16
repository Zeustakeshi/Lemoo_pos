using Microsoft.AspNetCore.Mvc;

namespace Lemoo_pos.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
