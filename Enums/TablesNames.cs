using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderApp.Enums
{
    public enum TablesNames
    {
        [Display(Name = "Stolik nr 1")]
        Table1 = 1,
        [Display(Name = "Stolik nr 2")]
        Table2 = 2,
        [Display(Name = "Stolik nr 3")]
        Table3 = 3,
        [Display(Name = "Stolik nr 4")]
        Table4 = 4,
        [Display(Name = "Stolik nr 5")]
        Table5 = 5
    }

}
