using Brighteye.Data;
using Brighteye.DataModel;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Brighteye.ennee
{
    public class OperationsWithTables
    {

        public void ClearTable<T>(DbSet<T> table) where T : Number
        {
            var itemsToRemove = table.ToList();
            foreach (var item in itemsToRemove)
            {
                table.Remove(item);
            }
        }
        public void FillOutTable<T>(int[] array, DbSet<T> table) where T : Number
        {
            ClearTable<T>(table);
            foreach (var item in array)
            {
                var number = Activator.CreateInstance<T>();
                typeof(T).GetProperty("Value").SetValue(number, item);
                table.Add(number);
            }
        }
        public int[] GetUnsortedNumbers(DbSet<UnsortedData> unsortedNumbers)
        {
            int[] unsortedArray = new int[unsortedNumbers.ToList().Count()];

            unsortedArray = unsortedNumbers.Select(x => x.Value).ToArray();
            return unsortedArray;
        }


    }
}
