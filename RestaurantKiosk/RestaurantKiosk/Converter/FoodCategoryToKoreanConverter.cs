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
                case CategoryType.All:
                    result = "전체";
                    break;

                case CategoryType.GIMBAP:
                    result = "김밥류";
                    break;

                case CategoryType.NOODLE:
                    result = "면류";
                    break;

                case CategoryType.RICE:
                    result = "밥류";
                    break;

                case CategoryType.SNACK:
                    result = "분식류";
                    break;

                case CategoryType.STEW:
                    result = "국 / 찌개류";
                    break;

                case CategoryType.DRINK:
                    result = "음료";
                    break;

                default:
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
