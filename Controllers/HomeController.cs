using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Results;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using RestaurantOrderApp.Models;
using RestaurantOrderApp.Repositories;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;

namespace RestaurantOrderApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            TableRepository objTableRepository = new TableRepository();
            DishRepository objDishRepository = new DishRepository();
            objDishRepository.GetAllDish();
            objTableRepository.GetAllTable();
          //  var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
          //      (objTableRepository.GetAllTable(), objDishRepository.GetAllDish());

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public decimal getDishUnitPrice(int itemId)
        {
            DishRepository objDishRepository = new DishRepository();
            List<Dish> dishes = objDishRepository.GetAllDish();
            decimal UnitPrice = dishes[itemId-1].DishPrice;

            return UnitPrice;
        }

    }
}
