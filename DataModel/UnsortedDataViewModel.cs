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
    internal class UnsortedDataViewModel : DependencyObject
    {



        public ICollectionView UnsorteedItems
        {
            get { return (ICollectionView)GetValue(UnsorteedItemsProperty); }
            set { SetValue(UnsorteedItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UnsorteedItems.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UnsorteedItemsProperty =
            DependencyProperty.Register("UnsorteedItems", typeof(ICollectionView), typeof(UnsortedDataViewModel), new PropertyMetadata(null));










        private static readonly DataDbContext _context = new DataDbContext();
        //public ICollectionView Items
        //{
        //    get { return (ICollectionView)GetValue(ItemsProperty); }
        //    set { SetValue(ItemsProperty, value); }
        //}

        //public static readonly DependencyProperty ItemsProperty =
        //    DependencyProperty.Register("Items", typeof(ICollectionView), typeof(UnsortedDataViewModel), new PropertyMetadata(null));

        public UnsortedDataViewModel()
        {
            UnsorteedItems = CollectionViewSource.GetDefaultView(_context.UnsortedNumbers.ToList());
        }
    }
}
