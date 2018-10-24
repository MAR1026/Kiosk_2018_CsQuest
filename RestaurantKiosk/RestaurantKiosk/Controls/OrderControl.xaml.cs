﻿using RestaurantKiosk.Model;
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
        public delegate void BackToMainHandler(object sender, EventArgs args);
        public event BackToMainHandler OnBackToMain;

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
            lvFoodInfo.SelectedIndex = -1;

        }

        private void RefreshOrderCollectionView()
        {
            ICollectionView collectionView = new CollectionViewSource { Source = currentTableInfo.FoodList }.View;
            collectionView.Filter = QuantityFilter;
            
            lvOrderInfo.ItemsSource = collectionView;
            tbTotalPrice.DataContext = currentTableInfo;
        }

        private bool QuantityFilter(object item)
        {
            if((item as Food).Quantity <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void setCurrentTableInfo(TableInfo selectedTable)
        {
            currentTableInfo = selectedTable;
            currentTableInfo.OrderTime = DateTime.Now;

            gdCurrentTableInfo.DataContext = currentTableInfo;
            RefreshOrderCollectionView();
        }

        private void lvFoodInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (currentTableInfo.FoodList != null && lvFoodInfo.SelectedIndex != -1)
            {
                List<Food> selectedItem = e.AddedItems.Cast<Food>().ToList();
                bool isExist = App.tableViewModel.IsExist(currentTableInfo, selectedItem[0]);

                if(isExist == true)
                {
                    MessageBox.Show("이미 주문한 메뉴입니다. 왼쪽 버튼을 이용하세요.", "메뉴 추가 실패", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    App.tableViewModel.IncreaseQuantity(currentTableInfo, selectedItem[0]);
                    App.tableViewModel.IncreaseTotalPrice(currentTableInfo, selectedItem[0]);
                    RefreshOrderCollectionView();
                }

                lvFoodInfo.SelectedIndex = -1;
            }
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            var selectedTable = App.tableViewModel.Items.FirstOrDefault(x => x.Idx == currentTableInfo.Idx); 
                
            if(selectedTable != null)
            {
                selectedTable = currentTableInfo;
            }
            OnBackToMain?.Invoke(sender, e);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if(currentTableInfo.FoodList != null && lvOrderInfo.SelectedIndex != -1)
            {
                Food selectedItem = lvOrderInfo.SelectedItem as Food;
                bool isExist = App.tableViewModel.IsExist(currentTableInfo, selectedItem);

                if (isExist)
                {
                    App.tableViewModel.Delete(currentTableInfo, selectedItem);
                    RefreshOrderCollectionView();
                }
            }
        }

        private void btnCancelAll_Click(object sender, RoutedEventArgs e)
        {
            if(currentTableInfo.FoodList != null)
            {
                App.tableViewModel.DeleteAll(currentTableInfo);
                RefreshOrderCollectionView();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if(currentTableInfo.FoodList != null && lvOrderInfo.SelectedIndex != -1)
            {
                Food selectedItem = lvOrderInfo.SelectedItem as Food;
                bool isExist = App.tableViewModel.IsExist(currentTableInfo, selectedItem);

                if (isExist)
                {
                    App.tableViewModel.IncreaseQuantity(currentTableInfo, selectedItem);
                    App.tableViewModel.IncreaseTotalPrice(currentTableInfo, selectedItem);
                }
                else
                {
                    MessageBox.Show("메뉴 수량 증가에 실패하였습니다.", "수량 증가 실패", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (currentTableInfo.FoodList != null && lvOrderInfo.SelectedIndex != -1)
            {
                Food selectedItem = lvOrderInfo.SelectedItem as Food;

                bool isExist = App.tableViewModel.IsExist(currentTableInfo, selectedItem);

                if (isExist)
                {
                    App.tableViewModel.DecreaseQuantity(currentTableInfo, selectedItem);
                    App.tableViewModel.DecreaseTotalPrice(currentTableInfo, selectedItem);

                    isExist = App.tableViewModel.IsExist(currentTableInfo, selectedItem);
                    if (!isExist)
                    {
                        RefreshOrderCollectionView();
                    }
                }
                else
                {
                    MessageBox.Show("메뉴 수량 감소에 실패하였습니다.", "수량 감소 실패", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
