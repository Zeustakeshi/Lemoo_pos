using Microsoft.AspNetCore.Mvc;

namespace Lemoo_pos.ViewComponents
{
    public class SalesRevenueChartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        } 
    }
}
