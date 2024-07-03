using DapperProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
    public class _TagCloudComponentPartial : ViewComponent
    {
        private readonly ITagService _tagService;

        public _TagCloudComponentPartial(ITagService tagService)
        {
            _tagService = tagService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _tagService.GetAllTagAsync();
            return View(values);
        }
    }

}
