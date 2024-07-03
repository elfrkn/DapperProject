using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.ProductDtos;
using DapperProject.Dtos.TestimonialDtos;

namespace DapperProject.Services
{
    public class TestimonialService : ITestimonialService
    {
        private readonly DapperContext _context;

        public TestimonialService(DapperContext context)
        {
            _context = context;
        }
        public Task CreateTestimonialAsync(CreateTestiomonialDto createTestimonialDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTestimonialAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = "Select * From TblTestimonial";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultTestimonialDto>(query);
            return values.ToList();
        }

        public Task<GetByIdTestimonialDto> GetTestimonialAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto)
        {
            throw new NotImplementedException();
        }
    }
}
