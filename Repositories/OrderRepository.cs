using RestaurantOrderApp.Models;
using RestaurantOrderApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderApp.Repositories
{
    public class OrderRepository
    {
        public bool AddOrder(OrderViewModel objOrderViewModel)
        {
            Order objOrder = new Order();
            objOrder.TableId = objOrderViewModel.TableId;
            objOrder.FinalTotal = objOrderViewModel.FinalTotal;

            int OrderId = objOrder.OrderId;
            foreach (var item in objOrderViewModel.ListOfOrderDetailViewModel)
            {
                OrderDetails objOrderDetails = new OrderDetails();
                objOrderDetails.OrderId = OrderId;
                objOrderDetails.DishId= item.DishId;
                objOrderDetails.UnitPrice= item.UnitPrice;
                objOrderDetails.Quantity= item.Quantity;
                objOrderDetails.Total= item.Total;

            }
            return true;

        }
    }
}
