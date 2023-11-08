using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace Brighteye
{
    internal class NumbersViewModel : DependencyObject
    {
        private static readonly TestDBContext _context = new TestDBContext();
        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(NumbersViewModel), new PropertyMetadata(null));

        public NumbersViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(_context.SortedDatas.ToList());
        }

    }

}
