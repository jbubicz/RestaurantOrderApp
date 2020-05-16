using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantOrderApp.Enums;
using RestaurantOrderApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RestaurantOrderApp.Repositories
{
    public class DishRepository
    {
        public List<Dish> GetAllDish()
        {
            List<Dish> dishes = new List<Dish>();
            int i = 1;
            foreach (DishesNames dish in (DishesNames[]) Enum.GetValues(typeof(DishesNames)))
            {
                string enumValue = Enum.GetName(typeof(DishesNames), dish);
                MemberInfo member = typeof(DishesNames).GetMember(enumValue)[0];

                object[] attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);
                string dispName = ((DisplayAttribute)attrs[0]).Name;
                dishes.Add(new Dish() { DishId= i, DishName = dispName, DishPrice = i*10 });
                i++;
            }
            return dishes;
        }
    }
}
