using RestaurantKiosk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.ViewModel
{
    public partial class TableViewModel
    {
        private void LoadDummyDefaultData()
        {
            List<TableInfo> tables = new List<TableInfo>();

            tables.Add(new TableInfo
            {
                Idx = 1,
                TotalPrice = 0,
                FoodList = null
            });

            tables.Add(new TableInfo
            {
                Idx = 2,
                TotalPrice = 0,
                FoodList = null
            });

            tables.Add(new TableInfo
            {
                Idx = 3,
                TotalPrice = 0,
                FoodList = null
            });

            tables.Add(new TableInfo
            {
                Idx = 4,
                TotalPrice = 0,
                FoodList = null
            });

            tables.Add(new TableInfo
            {
                Idx = 5,
                TotalPrice = 0,
                FoodList = null
            });

            tables.Add(new TableInfo
            {
                Idx = 6,
                TotalPrice = 0,
                FoodList = null
            });

            Adds(tables);
        }
    }
}
