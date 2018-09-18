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

            
        }
    }
}
