using RestaurantKiosk.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace RestaurantKiosk.ViewModel
{
    public partial class TableViewModel
    {
        public ObservableCollection<TableInfo> Items { get; set; }

        public TableViewModel()
        {
            Items = new ObservableCollection<TableInfo>();
#if false
            LoadDefaultData();
#else
            LoadDummyDefaultData();
#endif
        }

        public void LoadDefaultData()
        {
            //TODO: 
        }

        public void Adds(List<TableInfo> tables)
        {
            foreach (TableInfo table in tables)
            {
                Add(table);
            }
        }

        public void Add(TableInfo table)
        {
            Items.Add(table);
        }

        public void DeleteAll(TableInfo table)
        {
            var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            if(item != null)
            {
                TableInfo refreshItem = new TableInfo();
                refreshItem.Idx = item.Idx;

                item = refreshItem;
            }
        }

        public void Delete(TableInfo table, Food food)
        {
            var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            if(item != null)
            {
                item.FoodList.Remove(food);
            }
        }

        public void IncreaseQuantity(TableInfo table, Food selectedFood)
        {
            var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            if(item != null)
            {
                var food = item.FoodList.FirstOrDefault(x => x.Name == selectedFood.Name);
                food.Quantity += 1;
            }
        }

        public void DecreaseQuantity(TableInfo table, Food selectedFood)
        {
            var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            if (item != null)
            {
                var food = item.FoodList.FirstOrDefault(x => x.Name == selectedFood.Name);
                food.Quantity -= 1;
            }
        }

        public bool IsExist(TableInfo table, Food selectedFood)
        {
            var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            if (item != null)
            {
                var food = item.FoodList.FirstOrDefault(x => x.Name == selectedFood.Name);

                if (food.Quantity > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        /*
         public Food SelectByName(string name)
         {
            return Items.Single(x => x.Name == name);
         } 
         */
    }
}
