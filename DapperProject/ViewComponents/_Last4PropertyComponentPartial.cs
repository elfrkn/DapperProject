using DapperProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _Last4PropertyComponentPartial : ViewComponent
	{
		private readonly IPropertyService _propertyService;

		public _Last4PropertyComponentPartial(IPropertyService propertyService)
		{
			_propertyService = propertyService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _propertyService.GetLast4PropertyListAsync();
			return View(values);
		}
	}

}
