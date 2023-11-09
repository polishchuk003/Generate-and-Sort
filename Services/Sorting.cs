using System;

namespace Brighteye
{
    internal class Sorting
    {
        public static int[] GetSortedArray(int[] unsortedArray)
        {
            if (unsortedArray == null)
                throw new ArgumentNullException(nameof(unsortedArray), "The input array cannot be null.");

            return MergeSort(unsortedArray, 0, unsortedArray.Length - 1);
        }

        public static int[] MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                var middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }

            return array;
        }
        public static void Merge(int[] a, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            var leftArray = new int[n1];
            var rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                leftArray[i] = a[left + i];
            }
            for (int j = 0; j < n2; j++)
            {
                rightArray[j] = a[middle + 1 + j];
            }

            int x = 0, y = 0, k = left;

            while (x < n1 && y < n2)
            {
                if (leftArray[x] <= rightArray[y])
                {
                    a[k] = leftArray[x];
                    x++;
                }
                else
                {
                    a[k] = rightArray[y];
                    y++;
                }
                k++;
            }
            while (x < n1)
            {
                a[k] = leftArray[x];
                x++;
                k++;
            }

            while (y < n2)
            {
                a[k] = rightArray[y];
                y++;
                k++;
            }
        }
    }
}
