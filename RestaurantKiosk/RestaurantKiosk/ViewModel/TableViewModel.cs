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
            //var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            //if(item != null)
            //{
            //    foreach(Food food in item.FoodList)
            //    {
            //        food.Quantity = 0;
            //    }

            //    item.TotalPrice = 0;
            //}

            foreach(Food food in table.FoodList)
            {
                food.Quantity = 0;
            }

            table.TotalPrice = 0;
        }

        public void Delete(TableInfo table, Food selectedFood)
        {
            //var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            //if(item != null)
            //{
            //    var food = item.FoodList.FirstOrDefault(x => x.Name == selectedFood.Name);
            //    for(int num = 0; num < food.Quantity; num++)
            //    {
            //        DecreaseTotalPrice(table, selectedFood);
            //    }

            //    food.Quantity = 0;
            //}

            var food = table.FoodList.FirstOrDefault(x => x.Name == selectedFood.Name);
            for(int num = 0; num < food.Quantity; num++)
            {
                DecreaseTotalPrice(table, selectedFood);
            }

            food.Quantity = 0;
        }

        public void IncreaseQuantity(TableInfo table, Food selectedFood)
        {
            //var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            //if(item != null)
            //{
            //    var food = item.FoodList.FirstOrDefault(x => x.Name == selectedFood.Name);
            //    food.Quantity += 1;
            //}

            var food = table.FoodList.FirstOrDefault(x => x.Name == selectedFood.Name);
            food.Quantity += 1;

        }

        public void DecreaseQuantity(TableInfo table, Food selectedFood)
        {
            //var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            //if (item != null)
            //{
            //    var food = item.FoodList.FirstOrDefault(x => x.Name == selectedFood.Name);
            //    food.Quantity -= 1;
            //}

            var food = table.FoodList.FirstOrDefault(x => x.Name == selectedFood.Name);
            food.Quantity -= 1;
        }

        public void IncreaseTotalPrice(TableInfo table, Food selectedFood)
        {
            //var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            //if (item != null)
            //{
            //    item.TotalPrice += selectedFood.Price;
            //}

            table.TotalPrice += selectedFood.Price;
        }

        public void DecreaseTotalPrice(TableInfo table, Food selectedFood)
        {
            //var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            //if (item != null)
            //{
            //    item.TotalPrice -= selectedFood.Price;
            //}

            table.TotalPrice -= selectedFood.Price;
        }

        public bool IsExist(TableInfo table, Food selectedFood)
        {
            // var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            if (table != null)
            {
                var food = table.FoodList.FirstOrDefault(x => x.Name == selectedFood.Name);

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

        public void ClearTable(TableInfo table)
        {
            var item = Items.FirstOrDefault(x => x.Idx == table.Idx);

            if (item != null)
            {
                foreach (Food food in item.FoodList)
                {
                    food.Quantity = 0;
                }

                item.TotalPrice = 0;
                item.OrderTime = new DateTime();
            }
        }

        public List<Food> Clone(TableInfo item)
        {
            List<Food> foods = new List<Food>();

            foreach(Food food in item.FoodList)
            {
                foods.Add(food.Clone(food));
            }

            return foods;
        }


        /*
         public Food SelectByName(string name)
         {
            return Items.Single(x => x.Name == name);
         } 
         */
    }
}
