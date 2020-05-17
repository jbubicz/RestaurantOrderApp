using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderApp.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int DishId { get; set; }
        public int Quantity { get; set; }
        public decimal FinalTotal { get; set; }
    }
}
