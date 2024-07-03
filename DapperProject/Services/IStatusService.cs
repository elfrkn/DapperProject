using DapperProject.Dtos.StatusDtos;

namespace DapperProject.Services
{
    public interface IStatusService
    {
        Task<List<ResultStatusDto>> GetAllStatusAsync();
    }
}
