using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace Brighteye
{
    internal class SortedDataViewModel : DependencyObject
    {
        private static readonly DataDbContext _context = new DataDbContext();
        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(SortedDataViewModel), new PropertyMetadata(null));

        public SortedDataViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(_context.SortedNumbers.ToList());
        }

    }

}
