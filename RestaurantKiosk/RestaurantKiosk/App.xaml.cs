using RestaurantKiosk.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RestaurantKiosk
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static FoodViewModel foodViewModel = new FoodViewModel();
        public static TableViewModel tableViewModel = new TableViewModel();
        public static TimeViewModel timeViewModel = new TimeViewModel();
        public static StatViewModel statViewModel = new StatViewModel();
    }
}
