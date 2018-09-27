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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        private TableInfo currentTableInfo = new TableInfo();

        public ICollectionViewLiveShaping CategoryLiveShaping { get; set; }

        public OrderControl()
        {
            InitializeComponent();

            InitMenuCollectionView();

        }

        private void InitMenuCollectionView()
        {
            ICollectionView collectionView = new CollectionViewSource { Source = App.foodViewModel.Items }.View;
            collectionView.GroupDescriptions.Add(new PropertyGroupDescription("Category"));

            CategoryLiveShaping = collectionView as ICollectionViewLiveShaping;
            if (CategoryLiveShaping.CanChangeLiveGrouping)
            {
                CategoryLiveShaping.LiveGroupingProperties.Add("Category");
                CategoryLiveShaping.IsLiveGrouping = true;
            }

            collectionView.SortDescriptions.Add(new SortDescription("Category", ListSortDirection.Ascending));

            lvFoodInfo.ItemsSource = collectionView;
            
        }

        public void setCurrentTableInfo(TableInfo selectedTable)
        {
            currentTableInfo = selectedTable;
            currentTableInfo.OrderTime = DateTime.Now;

            gdCurrentTableInfo.DataContext = currentTableInfo;
            lvOrderInfo.ItemsSource = currentTableInfo.FoodList;
        }

        private void lvFoodInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Food> selectedItem = e.AddedItems.Cast<Food>().ToList();
            App.tableViewModel.IncreaseQuantity(currentTableInfo, selectedItem[0]);
        }
    }
}
