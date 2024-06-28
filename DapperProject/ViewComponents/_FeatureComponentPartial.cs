using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _FeatureComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}

}
