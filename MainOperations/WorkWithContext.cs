using System.Collections.Generic;
using System.Linq;

namespace Brighteye
{
    internal class WorkWithContext
    {
        private static TestDBContext _context = new TestDBContext();
        private static OperationsWithTables _operationsWithTables = new OperationsWithTables();
        private static int _amountElements = 10;

        internal static void GenerationRandomNumbers()
        {
            _operationsWithTables.FillOutTable<UnsortedData>(RandomCreator.CreateRandomArray(_amountElements), _context.UnsortedDatas);
            _context.SaveChanges();
        }
        internal static List<int> ViewRandomNumbers()
        {
            return _context.UnsortedDatas.Select(x => x.Value).ToList();
        }
        internal static void SortRandomNumbers()
        {
            _operationsWithTables.FillOutTable<SortedData>(Sorting.GetSortedArray(_operationsWithTables.GetUnsortedNumbers(_context.UnsortedDatas)), _context.SortedDatas);
            _context.SaveChanges();
        }

    }
}
