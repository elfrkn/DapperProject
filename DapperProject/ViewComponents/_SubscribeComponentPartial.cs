using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _SubscribeComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}

}
