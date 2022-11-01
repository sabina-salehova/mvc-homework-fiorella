using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_homework_fiorella.Models
{
    public class HomeViewModel
    {
        public List<SliderImage> SliderImages = new List<SliderImage>();

        public Slider Slider = new Slider();

        public List<Category> Categories = new List<Category>();

        public List<Product> Products = new List<Product>();
    }
}
