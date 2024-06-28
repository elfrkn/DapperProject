﻿using DapperProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _SliderComponentPartial : ViewComponent
	{

        private readonly ISliderService _sliderService;

        public _SliderComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
            var values = await _sliderService.GetAllSliderAsync();
			return View(values);
		}
	}

}
