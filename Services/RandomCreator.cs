using System;

namespace Brighteye
{
    public static class RandomCreator
    {
        private static readonly Random _random = new Random();
        private const int _limitLower = 1;
        private const int _limitUpper = 11;

        public static int[] CreateRandomArray(int length)
        {
            var array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = _random.Next(_limitLower, _limitUpper);
            }
            return array;
        }
    }
}
