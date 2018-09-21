using RestaurantKiosk.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RestaurantKiosk.Converter
{
    public class FoodCategoryToKoreanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CategoryType category = (CategoryType)value;
            string result = string.Empty;

            switch (category)
            {
                case CategoryType.GIMBAP:
                    result = "김밥";
                    break;

                case CategoryType.NOODLE:
                    result = "면";
                    break;

                case CategoryType.RICE:
                    result = "밥";
                    break;

                case CategoryType.SNACK:
                    result = "분식";
                    break;

                case CategoryType.STEW:
                    result = "국 / 찌개";
                    break;

                default:
                    result = "";
                    break;
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
