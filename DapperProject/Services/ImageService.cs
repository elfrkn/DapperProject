using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.AgentDtos;
using DapperProject.Dtos.ImagesDtos;
using DapperProject.Dtos.ProductDtos;
using DapperProject.Dtos.PropertyDtos;

namespace DapperProject.Services
{
    public class ImageService : IImageService
    {
        private readonly DapperContext _context;

        public ImageService(DapperContext context)
        {
            _context = context;
        }

        public async Task<List<ResultImageDto>> GetAllImageAsync()
        {
            string query = "Select * From TblImages";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultImageDto>(query);
            return values.ToList();
        }
    }
}
