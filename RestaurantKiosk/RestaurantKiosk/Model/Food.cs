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
        All = 0,
        GIMBAP = 1,
        NOODLE = 2,
        RICE = 3,
        STEW = 4,
        SNACK = 5
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

        public Food Clone(Food item)
        {
            Food Food = new Food();
            Food.Category = item.Category;
            Food.Image = item.Image;
            Food.Notice = item.Notice;
            Food.Quantity = item.Quantity;
            Food.Price = item.Price;
            Food.Name = item.Name;

            return Food;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
