using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.Model
{

    public class TableInfo : INotifyPropertyChanged
    {
        private int idx;
        public int Idx
        {
            get
            {
                return idx;
            }

            set
            {
                idx = value;
                NotifyPropertyChanged(nameof(Idx));
            }
        }

        private int totalPrice;
        public int TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
                NotifyPropertyChanged(nameof(TotalPrice));
            }
        }

        private List<Food> foodList;
        public List<Food> FoodList
        {
            get
            {
                return foodList;
            }

            set
            {
                foodList = value;
                NotifyPropertyChanged(nameof(FoodList));
            }
        }

        private DateTime orderTime;
        public DateTime OrderTime
        {
            get
            {
                return orderTime;
            }

            set
            {
                orderTime = value;
                NotifyPropertyChanged(nameof(orderTime));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
