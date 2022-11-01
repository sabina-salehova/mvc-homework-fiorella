using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_homework_fiorella.DAL;
using mvc_homework_fiorella.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_homework_fiorella.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var sliderImages = _dbContext.SliderImages.ToList();
            var slider = _dbContext.Sliders.SingleOrDefault();
            var categories = _dbContext.Categories.ToList();
            var products = _dbContext.Products.ToList();
            var hvm = new HomeViewModel();
            hvm.SliderImages = sliderImages;
            hvm.Slider = slider;
            hvm.Categories = categories;
            hvm.Products = products;
            return View(hvm);
        }

    }
}
