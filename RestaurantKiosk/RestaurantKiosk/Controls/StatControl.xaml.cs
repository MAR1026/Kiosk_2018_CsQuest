using RestaurantKiosk.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestaurantKiosk.Controls
{
    /// <summary>
    /// Interaction logic for StatControl.xaml
    /// </summary>
    public partial class StatControl : UserControl
    {
        public delegate void BackToMainHandler(object sender, EventArgs args);
        public event BackToMainHandler OnBackToMain;

        public StatControl()
        {
            InitializeComponent();
            InitListViewItemsSource();
        }

        private void InitListViewItemsSource()
        {
            lvMenu.ItemsSource = App.statViewModel.Stats;
            lvCategory.ItemsSource = App.statViewModel.Stats_Categorys;
            lvPayment.ItemsSource = App.statViewModel.Stats_Payments;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            OnBackToMain?.Invoke(sender, e);
        }

        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            gdCategoryStat.Visibility = Visibility.Visible;
            gdMenuStat.Visibility = Visibility.Collapsed;
            gdPaymentStat.Visibility = Visibility.Collapsed;
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            gdMenuStat.Visibility = Visibility.Visible;
            gdCategoryStat.Visibility = Visibility.Collapsed;
            gdPaymentStat.Visibility = Visibility.Collapsed;
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            gdPaymentStat.Visibility = Visibility.Visible;
            gdCategoryStat.Visibility = Visibility.Collapsed;
            gdMenuStat.Visibility = Visibility.Collapsed;
        }
    }
}
