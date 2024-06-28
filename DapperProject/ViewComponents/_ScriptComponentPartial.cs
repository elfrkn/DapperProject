using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
    public class _ScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
