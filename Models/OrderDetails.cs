using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderApp.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int DishId { get; set; }


        public string OrderName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
    }
}
