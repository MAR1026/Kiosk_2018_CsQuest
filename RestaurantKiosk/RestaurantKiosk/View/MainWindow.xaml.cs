using RestaurantKiosk.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace RestaurantKiosk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void SetControlsVisibility(bool isVisible)
        {
            if (isVisible)
            {
                TableCtrl.Visibility = Visibility.Visible;
            } else
            {
                TableCtrl.Visibility = Visibility.Collapsed;
            }
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            SetControlsVisibility(false);
        }
        
        #region 로딩 관련 메소드들
        private void Window_ContentRenderd(object sender, EventArgs e)
        {
            
            gdProgress.Visibility = Visibility.Visible;

            BackgroundWorker thread = new BackgroundWorker();
            thread.WorkerReportsProgress = true;
            thread.DoWork += thread_DoWork;
            thread.ProgressChanged += thread_ProgressChanged;
            thread.RunWorkerCompleted += thread_RunWorkerCompleted;

            thread.RunWorkerAsync();
        }

        private void thread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gdProgress.Visibility = Visibility.Collapsed;
            SetControlsVisibility(true);
            gdCurTime.DataContext = App.timeViewModel.Time;
        }

        private void thread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbStatus.Value = e.ProgressPercentage;
        }

        private void thread_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(30);
            }
        }
        #endregion

        private void TableControl_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<TableInfo> item = e.AddedItems.Cast<TableInfo>().ToList();

            OrderCtrl.setCurrentTableInfo(item[0]);

            TableCtrl.Visibility = Visibility.Collapsed;
            OrderCtrl.Visibility = Visibility.Visible;
        }

        private void OrderCtrl_OnBackToMain(object sender, EventArgs args)
        {
            TableCtrl.RefreshTableList();

            TableCtrl.Visibility = Visibility.Visible;
            OrderCtrl.Visibility = Visibility.Collapsed;
        }
    }
}
