using DapperProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly IDataService _dataService;

        public DashboardController(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.movieCount = await _dataService.GetMovieCount();
            ViewBag.yearCount = await _dataService.GetMovieCount2023();
            ViewBag.maxRating = await _dataService.GetMaxRatingCount();
            ViewBag.minRating = await _dataService.GetMinRatingCount();
            ViewBag.dramaCount = await _dataService.GetGenreDramaCount();
            ViewBag.actionCount = await _dataService.GetGenreActionCount();
            ViewBag.animationCount = await _dataService.GetGenreAnimationCount();
            ViewBag.comedyCount = await _dataService.GetGenreComedyCount();
            return View();
        }
    }
}
