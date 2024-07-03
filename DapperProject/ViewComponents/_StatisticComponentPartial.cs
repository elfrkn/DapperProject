using DapperProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _StatisticComponentPartial : ViewComponent
	{
		private readonly IPropertyService _propertyService;
		private readonly ILocationService _locationService;
		private readonly IAgentService _agentService;

		public _StatisticComponentPartial(IPropertyService propertyService, ILocationService locationService, IAgentService agentService)
		{
			_propertyService = propertyService;
			_locationService = locationService;
			_agentService = agentService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			ViewBag.propertyCount = await _propertyService.GetPropertyCount();
			ViewBag.locationCount = await _locationService.GetLocationCount();
			ViewBag.agentCount = await _agentService.GetAgentCount();
			ViewBag.propertyTypeCount = await _propertyService.GetPropertyTypeCount();
			return View();
		}
	}

}
