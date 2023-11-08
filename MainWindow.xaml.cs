using Brighteye.Data;
using Brighteye.DataModel;
using Brighteye.ennee;
using Brighteye.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using System.Xml;

namespace Brighteye
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WorkWithContext www = new WorkWithContext();
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
            label.Visibility = Visibility.Collapsed;
            www.GenerationRandomNumbers();
            numberListBox1.ItemsSource = www.ViewRandomNumbers();
            SetDataContext();
            MessageBox.Show("Дані успішно згенеровані!!!");
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            Hide();
            MessageBox.Show("Дані успішно відсортовані!!!");
        }

        private void SetDataContext()
        {
            DataContext = new NumbersViewModel();
        }

    }
}
