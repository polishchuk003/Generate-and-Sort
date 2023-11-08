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
    public class WorkWithContext
    {
        public TestDBContext context = new TestDBContext();
        public OperationsWithTables operationsWithTables = new OperationsWithTables();
        private static int generationVariablesAmount = 10;

        public void GenerationRandomNumbers()
        {
            operationsWithTables.FillOutTable<UnsortedData>(RandomCreator.CreateRandomArray(generationVariablesAmount), context.UnsortedDatas);
            context.SaveChanges();
        }
        public List<int> ViewRandomNumbers()
        {
            return context.UnsortedDatas.Select(x => x.Value).ToList();
        }
        public void SortRandomNumbers() 
        {
            operationsWithTables.FillOutTable<SortedData>(Sorting.GetSortedArray(operationsWithTables.GetUnsortedNumbers(context.UnsortedDatas)), context.SortedDatas);
            context.SaveChanges();
        }

    }
}
