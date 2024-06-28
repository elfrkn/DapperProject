using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _Last4PropertyComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}

}
