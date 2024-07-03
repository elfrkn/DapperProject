using DapperProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _FeatureComponentPartial : ViewComponent
	{
		private readonly IPropertyService _propertyService;

        public _FeatureComponentPartial(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _propertyService.GetFeaturedListPropertyAsync();
			return View(values);
		}
	}

}
