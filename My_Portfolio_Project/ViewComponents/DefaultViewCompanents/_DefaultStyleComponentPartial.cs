using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio_Project.ViewComponents.DefaultViewCompanents
{
    public class _DefaultStyleComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
