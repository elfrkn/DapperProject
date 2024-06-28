using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _TestimonialComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}

}
