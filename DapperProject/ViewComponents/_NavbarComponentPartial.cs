﻿using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
	public class _NavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}

}
