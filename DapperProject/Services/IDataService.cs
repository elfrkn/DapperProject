using DapperProject.Dtos.DataDtos;
using DapperProject.Dtos.PropertyDtos;

namespace DapperProject.Services
{
    public interface IDataService
    {
        Task<List<ResultDataDto>> GetAllDataAsync();
        Task<List<ResultDataDto>> ResultDataSearchListAync(string movieName);
        Task<int> GetMovieCount();

        Task<int> GetMovieCount2023();
        Task<int> GetMaxRatingCount();
        Task<int> GetMinRatingCount();
        Task<int> GetGenreDramaCount();
        Task<int> GetGenreActionCount();
        Task<int> GetGenreAnimationCount();
        Task<int> GetGenreComedyCount();
      
    }
}
