using Brighteye.Data;
using Brighteye.DataModel;
using Brighteye.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brighteye.ennee
{
    internal class WorkWithContext
    {
        private static TestDBContext context = new TestDBContext();
        private static OperationsWithTables operationsWithTables = new OperationsWithTables();
        private static int generationVariablesAmount = 10;

        internal static void GenerationRandomNumbers()
        {
            operationsWithTables.FillOutTable<UnsortedData>(RandomCreator.CreateRandomArray(generationVariablesAmount), context.UnsortedDatas);
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
