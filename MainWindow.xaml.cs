using System.Windows;

namespace Brighteye
{
    public partial class MainWindow : Window
    {
        private Window1 _window = new Window1();
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
            Closed += MainWindow_Closed;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MainWindow_Closed(object sender, System.EventArgs e)
        {

        }

        private void PopulateButton_Click(object sender, RoutedEventArgs e)
        {
            WorkWithContext.GenerationRandomNumbers();
            numberListBox1.ItemsSource = WorkWithContext.ViewRandomNumbers();
            SetDataContext();
            MessageBox.Show("Data has been successfully generated!!!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            _window.Show();
            Hide();
            MessageBox.Show("Data has been successfully sorted!!!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void SetDataContext()
        {
            DataContext = new NumbersViewModel();
        }

    }
}
