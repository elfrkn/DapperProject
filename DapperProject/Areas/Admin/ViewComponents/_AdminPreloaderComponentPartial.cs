using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.ViewComponents
{
    public class _AdminPreloaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }


}
