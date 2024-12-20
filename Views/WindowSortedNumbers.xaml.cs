﻿using System;
using System.Windows;

namespace Brighteye
{

    public partial class WindowSortadeNumbers : Window
    {
        
        public WindowSortadeNumbers()
        {
            InitializeComponent();
            Loaded += Window1_Loaded;
            Closed += Window1_Closed;
        }

        private void Window1_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            TableService tableService = new TableService();
            tableService.SortRandomNumbers();
            DataContext = new SortedDataViewModel();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowUnsortadeNumbers window = new WindowUnsortadeNumbers();
            window.Show();
            Hide();
        }
    }
}
