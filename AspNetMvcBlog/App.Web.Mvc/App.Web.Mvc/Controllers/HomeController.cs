using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var productList = new List<ProductItemModel>
            {
                new ProductItemModel
                {
                    Title ="Macbook Air M2", StarCount = 1, OldPrice = 0, Price = 30000, ImageUrl = "/ProductImages/macbook-air.png", IsSale = true
                },
                new ProductItemModel
                {
                    Title ="Asus Zenbook ", StarCount = 0, OldPrice = 10000, Price = 15500, ImageUrl = "/ProductImages/asus.png", IsSale = false
                },
                new ProductItemModel
                {
                    Title ="Macbook Pro", StarCount = 3, OldPrice = 12000, Price = 14000, ImageUrl = "/ProductImages/macbook pro.png", IsSale = false
                },
                new ProductItemModel
                {
                    Title ="İphone 14", StarCount = 5, OldPrice = 50000, Price = 76000, ImageUrl = "/ProductImages/iphone14.1.png", IsSale = true
                },
                new ProductItemModel
                {
                    Title ="iphone 11", StarCount = 4, OldPrice = 0, Price = 25000, ImageUrl = "/ProductImages/iphone11.png", IsSale = false
                },
                new ProductItemModel
                {
                    Title ="Monster Tuplar", StarCount = 3, OldPrice = 23000, Price = 35000, ImageUrl = "/ProductImages/monster.png", IsSale = true
                },
                new ProductItemModel
                {
                    Title ="Apple studio display", StarCount = 0, OldPrice = 50000, Price = 99000, ImageUrl = "/ProductImages/studio-display.png", IsSale = true
                },
                new ProductItemModel
                {
                    Title ="Monster Aryond", StarCount = 1, OldPrice = 0, Price = 12000, ImageUrl = "/ProductImages/Aryond.png", IsSale = false
                }
            };

            return View(productList);
        }

      
    }
}