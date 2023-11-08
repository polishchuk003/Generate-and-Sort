using Brighteye.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Brighteye.DataModel
{
    internal class NumbersViewModel : DependencyObject
    {
        private static readonly TestDBContext _context = new TestDBContext();
        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(NumbersViewModel), new PropertyMetadata(null));

        public NumbersViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(_context.SortedDatas.ToList());
        }

    }

}
