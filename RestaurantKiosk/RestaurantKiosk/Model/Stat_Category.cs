using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.Model
{
    public class Stat_Category : INotifyPropertyChanged
    {
        private CategoryType category;
        public CategoryType Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
                NotifyPropertyChanged(nameof(Category));
            }
        }

        private int quantity;
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
                NotifyPropertyChanged(nameof(Quantity));
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
                NotifyPropertyChanged(nameof(totalPrice));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
