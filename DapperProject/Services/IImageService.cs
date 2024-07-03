
using DapperProject.Dtos.ImagesDtos;

namespace DapperProject.Services
{
    public interface IImageService
    {
        Task<List<ResultImageDto>> GetAllImageAsync();
    }
}
