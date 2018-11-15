using RestaurantKiosk.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.ViewModel
{
    partial class FoodViewModel
    {
        public ObservableCollection<Stat> Stats { get; set; }

        public void AddStat(TableInfo table, PaymentType paymentType)
        {
            foreach (Food food in table.FoodList)
            {
                Stat stat = new Stat();
                Food copyFood = food.Clone(food);

                stat.PaymentType = paymentType;
                stat.Category = copyFood.Category;
                stat.Name = copyFood.Name;
                stat.Quantity = copyFood.Quantity;
                stat.TotalPrice = copyFood.Price * food.Quantity;

                Stat existStat = Stats.FirstOrDefault(x => x.Name == stat.Name && x.PaymentType == stat.PaymentType);

                if(existStat != null)
                {
                    existStat.Quantity += stat.Quantity;
                    existStat.TotalPrice += stat.TotalPrice;
                    continue;
                }

                Stats.Add(stat);
            }
        }
    }
}
