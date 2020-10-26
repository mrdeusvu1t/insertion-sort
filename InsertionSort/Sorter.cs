using System;
using System.Globalization;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace InsertionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with insertion sort algorithm.
        /// </summary>
        public static void InsertionSort(this int[] array)
        {
            // TODO #1. Implement the method using a loop statements.
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        var temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive insertion sort algorithm.
        /// </summary>
        public static void RecursiveInsertionSort(this int[] array)
        {
            // TODO #2. Implement the method using recursion algorithm.
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length <= 1)
            {
                return;
            }

            Sort(array, 0, 1);
        }

        public static void Sort(this int[] array, int i, int j)
        {
            if (j > 0)
            {
                Sort(array, i, j - 1);
            }
            else
            {
                i++;
                j = i + 1;
                if (j <= array.Length - 1)
                {
                    Sort(array, i, j);
                }
                else
                {
                    return;
                }
            }

            if (array[j - 1] > array[j])
            {
                var temp = array[j - 1];
                array[j - 1] = array[j];
                array[j] = temp;
                Sort(array, i, j - 1);
            }
        }
    }
}
