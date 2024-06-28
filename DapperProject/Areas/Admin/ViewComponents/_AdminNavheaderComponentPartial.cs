using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.ViewComponents
{
    public class _AdminNavheaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
