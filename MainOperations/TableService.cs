using System.Collections.Generic;
using System.Linq;

namespace Brighteye
{
    internal class TableService
    {
        private static readonly DataDbContext context = new DataDbContext();
        private static readonly TableOperationsManager operationsWithTables = new TableOperationsManager();
        private const int amountElements = 10;

        internal static void GenerationRandomNumbers()
        {
            operationsWithTables.FillOutTable<UnsortedNumber>(RandomCreator.CreateRandomArray(amountElements), context.UnsortedNumbers);
            context.SaveChanges();
        }
        internal static List<int> ViewRandomNumbers()
        {
            return context.UnsortedNumbers.Select(x => x.Value).ToList();
        }
        internal static void SortRandomNumbers()
        {
            operationsWithTables.FillOutTable<SortedNumber>(Sorting.GetSortedArray(operationsWithTables.GetUnsortedNumbers(context.UnsortedNumbers)), context.SortedNumbers);
            context.SaveChanges();
        }
    }
}
