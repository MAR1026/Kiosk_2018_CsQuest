using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RestaurantKiosk.Model
{
    public enum CategoryType
    {
        GIMBAP = 1,
        NOODLE = 2,
        RICE = 3,
        STEW = 4,
        FRIED = 5,
        SNACK = 6
    }

    public class Food : INotifyPropertyChanged
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

        private int price;
        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
                NotifyPropertyChanged(nameof(Price));
            }
        }

        private string image;
        public string Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
                NotifyPropertyChanged(nameof(Image));
            }
        }

        private string notice;
        public string Notice
        {
            get
            {
                return notice;
            }

            set
            {
                notice = value;
                NotifyPropertyChanged(nameof(Notice));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
