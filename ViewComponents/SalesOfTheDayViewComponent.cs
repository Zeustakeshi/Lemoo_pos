using Microsoft.AspNetCore.Mvc;

namespace Lemoo_pos.ViewComponents
{
    public class SalesOfTheDayViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
