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
    public class PaymentToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PaymentType category = (PaymentType)value;
            string result = string.Empty;

            switch (category)
            {
                case PaymentType.CASH:
                    result = "현금";
                    break;

                case PaymentType.CREDIT_CARD:
                    result = "신용카드";
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
