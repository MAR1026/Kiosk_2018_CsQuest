using RestaurantKiosk.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.ViewModel
{
    public partial class StatViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Stat> Stats { get; set; }
        public ObservableCollection<Stat_Category> Stats_Categorys { get; set; }
        public ObservableCollection<Stat_Payment> Stats_Payments { get; set; }


        public StatViewModel()
        {
            Stats = new ObservableCollection<Stat>();
            Stats_Categorys = new ObservableCollection<Stat_Category>();
            Stats_Payments = new ObservableCollection<Stat_Payment>();
        }

        public void AddStat(TableInfo table, PaymentType paymentType)
        {
            foreach (Food food in table.FoodList)
            {
                Stat stat = new Stat();
                Food copyFood = food.Clone(food);

                if (copyFood.Quantity > 0)
                { 
                    stat.PaymentType = paymentType;
                    stat.Category = copyFood.Category;
                    stat.Name = copyFood.Name;
                    stat.Quantity = copyFood.Quantity;
                    stat.TotalPrice = copyFood.Price * food.Quantity;
                }
                else
                {
                    continue;
                }

                AddStat_Category(new Stat_Category
                {
                    Category = stat.Category,
                    Quantity = stat.Quantity,
                    TotalPrice = stat.TotalPrice
                });

                AddStat_Payment(new Stat_Payment
                {
                    PaymentType = stat.PaymentType,
                    TotalPrice = stat.TotalPrice
                });

                Stat existStat = Stats.FirstOrDefault(x => x.Name == stat.Name && x.PaymentType == stat.PaymentType);

                if (existStat != null)
                {
                    existStat.Quantity += stat.Quantity;
                    existStat.TotalPrice += stat.TotalPrice;
                    continue;
                }

                Stats.Add(stat);
            }
        }

        public void AddStat_Category(Stat_Category item)
        {
            Stat_Category existStat = Stats_Categorys.FirstOrDefault(x => x.Category == item.Category);

            if (existStat != null)
            {
                existStat.Quantity += item.Quantity;
                existStat.TotalPrice += item.TotalPrice;
            }
            else
            {
                Stats_Categorys.Add(item);
            }
        }

        public void AddStat_Payment(Stat_Payment item)
        {
            Stat_Payment existStat = Stats_Payments.FirstOrDefault(x => x.PaymentType == item.PaymentType);

            if (existStat != null)
            {
                existStat.TotalPrice += item.TotalPrice;
            }
            else
            {
                Stats_Payments.Add(item);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
