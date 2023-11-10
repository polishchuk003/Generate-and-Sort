using System;
using System.Data.Entity;
using System.Linq;

namespace Brighteye
{
    public class OperationsWithTables
    {

        public void FillOutTable<T>(int[] array, DbSet<T> table) where T : Number
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array), "The input array cannot be null.");

            if (table == null)
                throw new ArgumentNullException(nameof(table), "The input table cannot be null.");

            if (array.Length != table.Count())
                throw new ArgumentException("The length of the array must match the number of elements in the table.", nameof(array));

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
            if (unsortedNumbers == null)
                throw new ArgumentNullException(nameof(unsortedNumbers), "The input DbSet<UnsortedData> cannot be null.");

            int[] unsortedArray = new int[unsortedNumbers.Count()];

            unsortedArray = unsortedNumbers.Select(x => x.Value).ToArray();
            return unsortedArray;
        }
        private void ClearTable<T>(DbSet<T> table) where T : Number
        {
            var itemsToRemove = table.ToList();

            foreach (var item in itemsToRemove)
            {
                table.Remove(item);
            }
        }


    }
}
