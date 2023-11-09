using System.Collections.Generic;
using System.Linq;

namespace Brighteye
{
    internal class WorkWithContext
    {
        private static readonly TestDBContext context = new TestDBContext();
        private static readonly OperationsWithTables operationsWithTables = new OperationsWithTables();
        private const int _amountElements = 10;

        internal static void GenerationRandomNumbers()
        {
            operationsWithTables.FillOutTable<UnsortedData>(RandomCreator.CreateRandomArray(_amountElements), context.UnsortedDatas);
            context.SaveChanges();
        }
        internal static List<int> ViewRandomNumbers()
        {
            return context.UnsortedDatas.Select(x => x.Value).ToList();
        }
        internal static void SortRandomNumbers()
        {
            operationsWithTables.FillOutTable<SortedData>(Sorting.GetSortedArray(operationsWithTables.GetUnsortedNumbers(context.UnsortedDatas)), context.SortedDatas);
            context.SaveChanges();
        }
    }
}
