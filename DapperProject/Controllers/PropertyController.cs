using DapperProject.Services;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;



namespace DapperProject.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly ILocationService _locationService;
        private readonly IPropertyTypeService _propertyTypeService;
        private readonly IStatusService _statusService;

        public PropertyController(IPropertyService propertyService, ILocationService locationService, IPropertyTypeService propertyTypeService, IStatusService statusService)
        {
            _propertyService = propertyService;
            _locationService = locationService;
            _propertyTypeService = propertyTypeService;
            _statusService = statusService;
        }

        public async Task<IActionResult> PropertyList(int page = 1)
        {
            ViewBag.location = await _locationService.GetAllLocationAsync();
            ViewBag.type = await _propertyTypeService.GetAllTypeAsync();
            ViewBag.status = await _statusService.GetAllStatusAsync();
            var values = await _propertyService.GetAllPropertyAsync();
            return View(values.ToPagedList(page,6));
        }

        public async Task<IActionResult> GetPropertyDetail(int id)
        {

            var value = await _propertyService.GetPropertyAsync(id);
            return View(value);
        }

        public async Task<IActionResult> ResultPropertyWithSearchList(int locationId, int typeId, int statusId)
        {
            ViewBag.location = await _locationService.GetAllLocationAsync();
            ViewBag.type = await _propertyTypeService.GetAllTypeAsync();
            ViewBag.status = await _statusService.GetAllStatusAsync();

            locationId = int.Parse(TempData["locationId"].ToString());
            typeId = int.Parse(TempData["typeId"].ToString());
            statusId = int.Parse(TempData["statusId"].ToString());
           
            var values = await _propertyService.ResultPropertySearchListAync(locationId, typeId, statusId);
            return View(values);
        }
    }
}
