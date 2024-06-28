using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _FooterComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}

}
