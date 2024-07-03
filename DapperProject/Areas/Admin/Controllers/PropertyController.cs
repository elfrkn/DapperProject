using DapperProject.Dtos.PropertyDtos;
using DapperProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly IAgentService _agentService;
        private readonly ILocationService _locationService;
        private readonly IImageService _imageService;
        private readonly IPropertyTypeService _propertyTypeService;
        private readonly IStatusService _statusService;
        private readonly ITagService _tagService;

        public PropertyController(IPropertyService propertyService, IAgentService agentService, ILocationService locationService, IImageService imageService, IPropertyTypeService propertyTypeService, IStatusService statusService, ITagService tagService)
        {
            _propertyService = propertyService;
            _agentService = agentService;
            _locationService = locationService;
            _imageService = imageService;
            _propertyTypeService = propertyTypeService;
            _statusService = statusService;
            _tagService = tagService;
        }

        public async Task<IActionResult> PropertyList()
        {
            var values = await _propertyService.GetAllPropertyAsync();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProperty()
        {
            ViewBag.agent = await _agentService.GetAllAgentAsync();
            ViewBag.location = await _locationService.GetAllLocationAsync();
            ViewBag.images = await _imageService.GetAllImageAsync();
            ViewBag.type = await _propertyTypeService.GetAllTypeAsync();
            ViewBag.status = await _statusService.GetAllStatusAsync();
            ViewBag.tag = await _tagService.GetAllTagAsync();
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateProperty(CreatePropertyDto createPropertyDto)
        {
            createPropertyDto.Date = DateTime.Now;
            await _propertyService.CreatePropertyAsync(createPropertyDto);
            return RedirectToAction("PropertyList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProperty(int id)
        {
            ViewBag.agent = await _agentService.GetAllAgentAsync();
            ViewBag.location = await _locationService.GetAllLocationAsync();
            ViewBag.images = await _imageService.GetAllImageAsync();
            ViewBag.type = await _propertyTypeService.GetAllTypeAsync();
            ViewBag.status = await _statusService.GetAllStatusAsync();
            ViewBag.tag = await _tagService.GetAllTagAsync();
            var values = await _propertyService.GetAllPropertyAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProperty(UpdatePropertyDto updatePropertyDto)
        {
            await _propertyService.UpdatePropertyAsync(updatePropertyDto);
            return RedirectToAction("PropertyList");
        }
    }
}
