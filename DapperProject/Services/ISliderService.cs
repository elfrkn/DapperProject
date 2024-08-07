﻿using DapperProject.Dtos.SliderDto;

namespace DapperProject.Services
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();
        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task DeleteSliderAsync(int id);
        Task UpdateSliderAsync(UpdateSliderDto updateSliderDto);
        Task<GetByIdSliderDto> GetSliderAsync(int id);
    }
}
