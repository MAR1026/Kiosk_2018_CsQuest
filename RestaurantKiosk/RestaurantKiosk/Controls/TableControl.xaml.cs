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
    /// Interaction logic for TableControl.xaml
    /// </summary>
    public partial class TableControl : UserControl, INotifyPropertyChanged
    {
        public event SelectionChangedEventHandler OnSelectionChanged;

        public ICollectionViewLiveShaping CategoryLiveShaping { get; set; }

        public TableControl()
        {
            InitializeComponent();
            InitTableCollectionView();
        }

        
        private void InitTableCollectionView()
        {
            ICollectionView collectionView = new CollectionViewSource { Source = App.tableViewModel.Items }.View;

            lbTableList.ItemsSource = collectionView;
            lbTableList.SelectedIndex = -1;

        }

        private void RefreshTableCollectionView()
        {
            ICollectionView collectionView = new CollectionViewSource { Source = App.tableViewModel.Items }.View;
            collectionView.Refresh();

            lbTableList.ItemsSource = collectionView;
        }

        public void RefreshTableList()
        {
            RefreshTableCollectionView();
        }

        private void lbTableList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbTableList.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                OnSelectionChanged?.Invoke(sender, e);
                lbTableList.SelectedIndex = -1;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
        }
    }
}
