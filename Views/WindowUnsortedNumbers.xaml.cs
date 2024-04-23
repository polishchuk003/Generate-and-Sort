using Brighteye.DataModel;
using System.Windows;

namespace Brighteye
{
    public partial class WindowUnsortadeNumbers : Window
    {
        public WindowUnsortadeNumbers()
        {
            InitializeComponent();
            // Loaded += MainWindow_Loaded;
            Closed += MainWindow_Closed;
        }

        private void MainWindow_Closed(object sender, System.EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PopulateButton_Click(object sender, RoutedEventArgs e)
        {
            TableService tableService = new TableService();
            tableService.GenerationRandomNumbers();
            numberListBox1.ItemsSource = tableService.ViewRandomNumbers();
            SetDataContextUnsorted();
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            WindowSortadeNumbers window = new WindowSortadeNumbers();
            window.Show();
            Hide();
            MessageBox.Show("Data has been successfully sorted!!!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

        }
        private void SetDataContextUnsorted()
        {
            DataContext = new UnsortedDataViewModel();
        }

    }
}
