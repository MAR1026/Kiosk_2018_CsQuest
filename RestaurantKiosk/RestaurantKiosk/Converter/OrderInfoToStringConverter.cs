using RestaurantKiosk.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RestaurantKiosk.Converter
{
    public class OrderInfoToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            List<Food> OrderList = new List<Food>();
            OrderList = value as List<Food>;

            string result = string.Empty;

            if (OrderList != null)
            {
                foreach(Food item in OrderList)
                {
                    if(item.Quantity > 0)
                    {
                        result += item.Name + " × " + item.Quantity + "\n";
                    }
                    
                }
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
