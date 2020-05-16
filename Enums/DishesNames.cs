using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderApp.Enums
{
    public enum DishesNames
    {
        [Display(Name = "Zupa ogórkowa")]
        Dish1 = 1,
        [Display(Name = "Zupa pomidorowa")]
        Dish2 = 2,
        [Display(Name = "Zupa pieczarkowa")]
        Dish3 = 3,
        [Display(Name = "Kotlet schabowy z ziemniakami i bukietem surówek")]
        Dish4 = 4,
        [Display(Name = "Kotlet z piersi kurczaka z ziemniakami i bukietem surówek")]
        Dish5 = 5,
        [Display(Name = "Gołąbki z sosem pomidorowym")]
        Dish6 = 6,
        [Display(Name = "Szarlotka na ciepło z bitą śmietaną i lodami")]
        Dish7 = 7,
        [Display(Name = "Puchar lodowy")]
        Dish8 = 8

    }
    
}
