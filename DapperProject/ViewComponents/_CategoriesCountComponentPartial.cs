using DapperProject.Context;
using DapperProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
    public class _CategoriesCountComponentPartial : ViewComponent
    {
        private readonly IPropertyTypeService _propertyTypeService;

        public _CategoriesCountComponentPartial(IPropertyTypeService propertyTypeService)
        {
            _propertyTypeService = propertyTypeService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _propertyTypeService.GetCountPropertyTypesAsync();
            return View(values);
        }
    }
}
