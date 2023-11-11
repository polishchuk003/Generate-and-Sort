using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace Brighteye.DataModel
{
    internal class UnsortedDataViewModel : DependencyObject
    {
        private static readonly DataDbContext _context = new DataDbContext();

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(UnsortedDataViewModel), new PropertyMetadata(null));

        public UnsortedDataViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(_context.UnsortedNumbers.ToList());
        }
    }
}
