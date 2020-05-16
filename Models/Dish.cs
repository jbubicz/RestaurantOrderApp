using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderApp.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public decimal DishPrice { get; set; }
    }
}
