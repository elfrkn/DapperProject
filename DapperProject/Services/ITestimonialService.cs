
using DapperProject.Dtos.TestimonialDtos;

namespace DapperProject.Services
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        Task CreateTestimonialAsync(CreateTestiomonialDto createTestimonialDto);
        Task DeleteTestimonialAsync(int id);
        Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto);
        Task<GetByIdTestimonialDto> GetTestimonialAsync(int id);
    }
}
