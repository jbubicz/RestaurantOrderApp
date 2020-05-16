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
    public class TableRepository
    {
        public List<Table> GetAllTable()
        {
            List<Table> tables = new List<Table>();
            int i = 1;
            foreach (TablesNames table in (TablesNames[])Enum.GetValues(typeof(TablesNames)))
            {
                string enumValue = Enum.GetName(typeof(TablesNames), table);
                MemberInfo member = typeof(TablesNames).GetMember(enumValue)[0];

                object[] attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);
                string dispName = ((DisplayAttribute)attrs[0]).Name;
                tables.Add(new Table() { TableId = i, TableName = dispName });
                i++;
            }
            return tables;
        }
    }
}
