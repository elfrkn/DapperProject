using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _StatisticComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}

}
