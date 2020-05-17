using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderApp.Enums
{
    public enum DishesNames
    {
        [Display(Name = "Domowy żurek staropolski")]
        Dish1 = 1,
        [Display(Name = "Rosół")]
        Dish2 = 2,
        [Display(Name = "Zapiekanka makaronowa ( Pasticcio )")]
        Dish3 = 3,
        [Display(Name = "Kotlet schabowy z ziemniakami i surówką")]
        Dish4 = 4,
        [Display(Name = "Pierogi ruskie z ziemniakami i serem")]
        Dish5 = 5,
        [Display(Name = "Kulbin chorwacki z emulsją maślaną")]
        Dish6 = 6,
        [Display(Name = "Kawa mrożona z lodami")]
        Dish7 = 7,
        [Display(Name = "Sernik z białą czekoladą. pomarańczą i wiśniowymi lodami")]
        Dish8 = 8

    }
    
}
