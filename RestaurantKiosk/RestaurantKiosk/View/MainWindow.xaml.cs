﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            gdTableList.Visibility = Visibility.Collapsed;
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
            pbStatus.Visibility = Visibility.Collapsed;
            gdTableList.Visibility = Visibility.Visible;
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
            TableCtrl.Visibility = Visibility.Collapsed;
            OrderCtrl.Visibility = Visibility.Visible;
        }
    }
}
