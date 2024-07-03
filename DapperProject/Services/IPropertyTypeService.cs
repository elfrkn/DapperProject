
using DapperProject.Dtos.PropertyTypeDtos;

namespace DapperProject.Services
{
    public interface IPropertyTypeService
    {
        Task<List<ResultPropertyTypeDto>> GetAllTypeAsync();
        Task<List<GetCountPropertyType>> GetCountPropertyTypesAsync();
    }
}
