using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.Model
{
    public class Stat_Payment : INotifyPropertyChanged
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
