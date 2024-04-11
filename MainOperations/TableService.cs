using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Brighteye
{
     class TableService
    {
        private static readonly DataDbContext context = new DataDbContext();
        // private static readonly TableOperationsManager operationsWithTables = new TableOperationsManager();
        private const int amountElements = 10;

        public void GenerationRandomNumbers()
        {
            //operationsWithTables.FillOutTable<UnsortedNumber>(RandomCreator.CreateRandomArray(amountElements), context.UnsortedNumbers);

            FillOutTable<UnsortedNumber>(RandomCreator.CreateRandomArray(amountElements), context.UnsortedNumbers);

            context.SaveChanges();
        }
        public List<int> ViewRandomNumbers()
        {
            return context.UnsortedNumbers.Select(x => x.Value).ToList();
        }
        public void SortRandomNumbers()
        {
            //   operationsWithTables.FillOutTable<SortedNumber>(Sorting.GetSortedArray(operationsWithTables.GetUnsortedNumbers(context.UnsortedNumbers)), context.SortedNumbers);

            FillOutTable<SortedNumber>(Sorting.GetSortedArray(GetUnsortedNumbers(context.UnsortedNumbers)), context.SortedNumbers);
            context.SaveChanges();
        }


        public void FillOutTable<T>(int[] array, DbSet<T> table) where T : Number
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array), "The input array cannot be null.");

            if (table == null)
                throw new ArgumentNullException(nameof(table), "The input table cannot be null.");

            ClearTable<T>(table);

            foreach (var item in array)
            {
                var number = Activator.CreateInstance<T>();
                typeof(T).GetProperty("Value").SetValue(number, item);
                table.Add(number);
            }
        }
        public int[] GetUnsortedNumbers(DbSet<UnsortedNumber> unsortedNumbers)
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
