﻿using Microsoft.AspNetCore.Mvc;
using PustokAB204.Business.Services.Abstracts;
using PustokAB204.ViewModels;

namespace PustokAB204.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFeatureService _featureService;
        private readonly ISliderService _sliderService;
        public HomeController(IFeatureService featureService, ISliderService sliderService)
        {
            _featureService = featureService;
            _sliderService = sliderService;
        }
        public IActionResult Index()
        {
            var features = _featureService.GetAllFeatures();
            var sliders = _sliderService.GetAllSliders();

            HomeVm homeVm = new HomeVm
            {
                Sliders = sliders,
                Features = features
            };
            return View(homeVm);
        }
    }
}
