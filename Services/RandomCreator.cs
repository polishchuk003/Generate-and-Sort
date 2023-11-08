using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brighteye.Services
{
    public static class RandomCreator
    {
        private static readonly Random _random = new Random();
        private static int _min = 0;
        private static int _max = 10;

        public static int[] CreateRandomArray(int length)
        {
            var array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = _random.Next(_min, _max);
            }
            return array;
        }
    }
}
