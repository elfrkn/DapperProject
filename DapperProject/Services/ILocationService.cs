
using DapperProject.Dtos.LocationDtos;

namespace DapperProject.Services
{
	public interface ILocationService
	{
		Task<int> GetLocationCount();

        Task<List<ResultLocationDto>> GetAllLocationAsync();
    }
}
