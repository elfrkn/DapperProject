using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.SliderDto;

namespace DapperProject.Services
{
    public class SliderService : ISliderService
    {
        private readonly DapperContext _context;

        public SliderService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            string query = "Insert Into TblProduct(ImageUrl,Address,City,Description,Price) values (@imageUrl,@address,@city,@description,@price)";
            var parameters = new DynamicParameters();
            parameters.Add("@imageUrl", createSliderDto.ImageUrl);
            parameters.Add("@address", createSliderDto.Address);
            parameters.Add("@city", createSliderDto.City);
            parameters.Add("@description", createSliderDto.Description);
            parameters.Add("@price", createSliderDto.Price);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public Task DeleteSliderAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            string query = "Select * From TblSlider";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultSliderDto>(query);
            return values.ToList();
        }

        public Task<GetByIdSliderDto> GetSliderAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSliderAsync(UpdateSliderDto updateSliderDto)
        {
            throw new NotImplementedException();
        }
    }
}
