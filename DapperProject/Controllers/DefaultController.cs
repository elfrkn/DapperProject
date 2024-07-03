using DapperProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly IPropertyTypeService _propertyTypeService;
        private readonly IStatusService _statusService;
        private readonly ILocationService _locationService;

        public DefaultController(IPropertyService propertyService, IPropertyTypeService propertyTypeService, IStatusService statusService, ILocationService locationService)
        {
            _propertyService = propertyService;
            _propertyTypeService = propertyTypeService;
            _statusService = statusService;
            _locationService = locationService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.location = await _locationService.GetAllLocationAsync();
            ViewBag.type = await _propertyTypeService.GetAllTypeAsync();
            ViewBag.status = await _statusService.GetAllStatusAsync();
            return View();
        }

        [HttpPost]
        public IActionResult Index(int locationId, int typeId, int statusId)
        {
           
            TempData["locationId"] = locationId;
            TempData["typeId"] = typeId;
            TempData["statusId"] = statusId;
            return RedirectToAction("ResultPropertyWithSearchList", "Property");
        }
    }
}
