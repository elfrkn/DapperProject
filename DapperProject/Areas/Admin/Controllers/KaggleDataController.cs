using DapperProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/KaggleData")]
    public class KaggleDataController : Controller
    {
        private readonly IDataService _dataService;

        public KaggleDataController(IDataService dataService)
        {
            _dataService = dataService;
        }


        [HttpGet]
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            
            var values = await _dataService.GetAllDataAsync();
            return View(values);
        }

        [HttpPost]
        [Route("")]
        [Route("Index")]
        public IActionResult Index(string movieName)
        {
            TempData["movieName"] = movieName;
            return RedirectToAction("ResultDataWithSearchList", "DataSearch");
        }

       

        [Route("")]
        [Route("ResultDataWithSearchList")]
        public async Task<IActionResult> ResultDataWithSearchList(string movieName)
        {
            movieName = TempData["movieName"].ToString();
            var values = await _dataService.ResultDataSearchListAync(movieName);
            return View(values);
        }

    }
}
