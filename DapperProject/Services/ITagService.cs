using DapperProject.Dtos.TagDtos;

namespace DapperProject.Services
{
    public interface ITagService
    {
        Task<List<ResultTagDto>> GetAllTagAsync();
    }
}
