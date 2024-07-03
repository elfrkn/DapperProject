using DapperProject.Dtos.ImagesDtos;
using DapperProject.Dtos.ProductDtos;
using DapperProject.Dtos.PropertyDtos;
using DapperProject.Dtos.PropertyTypeDtos;

namespace DapperProject.Services
{
    public interface IPropertyService
    {
        Task<List<ResultPropertyDto>> GetAllPropertyAsync();
        Task CreatePropertyAsync(CreatePropertyDto createPropertyDto);
        Task DeletePropertyAsync(int id);
        Task UpdatePropertyAsync(UpdatePropertyDto updatePropertyDto);
        Task<GetByIdPropertyDto> GetPropertyAsync(int id);
        Task<GetByIdPropertyDto> GetAllPropertyAsync(int id);
        Task<List<ResultPropertyDto>> GetFeaturedListPropertyAsync();
        Task<List<ResultPropertyDto>> GetLast4PropertyListAsync();
        Task<List<ResultPropertyDto>> ResultPropertySearchListAync(int locationId, int typeId, int statusId);
        Task<int> GetPropertyCount();
        Task<int> GetPropertyTypeCount();

    }
}
