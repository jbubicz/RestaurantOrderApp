using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int TableId { get; set; }
        public string OrderName { get; set; }
        public decimal FinalTotal { get; set; }
    }
}
