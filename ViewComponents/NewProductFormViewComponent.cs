using Microsoft.AspNetCore.Mvc;

namespace Lemoo_pos.ViewComponents
{
    public class NewProductFormViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
