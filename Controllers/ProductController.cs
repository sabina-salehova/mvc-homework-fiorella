using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_homework_fiorella.DAL;
using mvc_homework_fiorella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_homework_fiorella.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ProductController(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var products = _dbContext.Products.Include(x=>x.Category).ToList();
            var hvm = new HomeViewModel
            {
                Products = products,
            };
            return View(hvm);
        }
        public IActionResult Details(int id)
        {
            Product product = _dbContext.Products.SingleOrDefault(x => x.Id == id);
            return View(product);
        }
    }
}
