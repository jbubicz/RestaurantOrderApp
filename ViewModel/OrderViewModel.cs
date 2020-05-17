using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderApp.ViewModel
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public int TableId  { get; set; }
        public decimal FinalTotal  { get; set; }

        public IEnumerable<OrderDetailViewModel> ListOfOrderDetailViewModel { get; set; }
    }
}
