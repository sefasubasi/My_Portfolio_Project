using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio_Project.ViewComponents.DefaultViewCompanents
{
    public class _DefaultHeaderComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
