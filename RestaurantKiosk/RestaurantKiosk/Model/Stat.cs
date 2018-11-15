using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.Model
{
    public enum PaymentType
    {
        CASH = 0,
        CREDIT_CARD = 1
    }

    public class Stat : INotifyPropertyChanged
    {
        private PaymentType paymentType;
        public PaymentType PaymentType
        {
            get
            {
                return paymentType;
            }
            set
            {
                paymentType = value;
                NotifyPropertyChanged(nameof(PaymentType));
            }
        }

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

        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                NotifyPropertyChanged(nameof(Name));
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
