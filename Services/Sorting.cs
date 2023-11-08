using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brighteye.Services
{
    internal class Sorting
    {
        public static int[] GetSortedArray(int[] unsortedArray)
        {
            return MergeSort(unsortedArray, 0, unsortedArray.Length - 1);
        }

        static int[] MergeSort(int[] a, int l, int r)
        {
            if (l < r)
            {
                var m = (l + r) / 2;
                MergeSort(a, l, m);
                MergeSort(a, m + 1, r);
                Merge(a, l, m, r);
            }

            return a;
        }
        public static void Merge(int[] a, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            var b = new int[n1]; //leftArray
            var c = new int[n2]; //rightArray

            for (int i = 0; i < n1; i++)
            {
                b[i] = a[l + i];
            }
            for (int j = 0; j < n2; j++)
            {
                c[j] = a[m + 1 + j];
            }

            int x = 0, y = 0, k = l;

            while (x < n1 && y < n2)
            {
                if (b[x] <= c[y])
                {
                    a[k] = b[x];
                    x++;
                }
                else
                {
                    a[k] = c[y];
                    y++;
                }
                k++;
            }
            while (x < n1)
            {
                a[k] = b[x];
                x++;
                k++;
            }

            while (y < n2)
            {
                a[k] = c[y];
                y++;
                k++;
            }
        }
    }
}
