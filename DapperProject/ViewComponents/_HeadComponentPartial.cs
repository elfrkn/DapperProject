using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _HeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
	
}
