using System;
using System.Collections.Generic;
using CommonLib.Utils;
using System.Linq;
using System.Collections;
using CommonLib.DataStructure;

namespace Top_K
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Top K solutions");

            int[] array = { 4, 6, 3, 1, 5, 96, 34, 13, 45, 344, 12, 56, 23, 78, 
                115, 67, 23, 56, 126, 899,23423,44,542,432,546,2,4322,65565,22};

            int k = 16;

            ConsoleUtils.PrintItems<int>(array);

            IEnumerable<int> outItems = null;

            var ticks = ConsoleUtils.CalcTickForFuncCall(() =>
            {
                outItems = findTopK_nk(array, k);
            });


            ConsoleUtils.PrintItems<int>(outItems);

            Console.WriteLine("takes " + ticks);

        }

        //Search array once and find k max value in a list, get O(kn) solution
        static IEnumerable<int> findTopK_nk_api(int[] array, int k)
        {
            List<int> list = new List<int>(k);

            for (int i = 0; i < k; i++)
            {
                list.Add(array[i]);
            }

            var minItem = list.Min();

            for (int i = k; i < array.Length; i++)
            {

                if (array[i] > minItem)
                {
                    
                    list.Remove(minItem);

                    list.Add(array[i]);

                    minItem = list.Min();
                }
            }

            return list;
        }


        //Search array once and find k max values into a array, get O(kn) solution
        static IEnumerable<int> findTopK_nk(int[] array, int k)
        {
            int[] r = new int[k];

            int minIndex = 0;

            r[0] = array[0];

            for (int i = 1; i < k; i++)
            {
                r[i] = array[i];

                if (r[i] < r[minIndex])
                    minIndex = i;
            }

            for (int i = k; i < array.Length; i++)
            {
                if (array[i] > r[minIndex])
                    r[minIndex] = array[i];

                for (int j = 0; j < k; j++)
                {
                    if (r[j] < r[minIndex])
                        minIndex = j;
                }
            }

            return r;
        }

        //Search array once and find k max values into a Max, get O(nlogk) solution
        static IEnumerable<int> findTopK_nlogk(int[] array, int k)
        {
            int[] r = new int[k];

            MinHeap heap = new MinHeap();

            for (int i = 0; i < array.Length; i++)
            {
                if (heap.Size < k)
                    heap.add(array[i]);

                if (heap.peek() < array[i])
                {
                    heap.pop();
                    heap.add(array[i]);
                }
            }

            return heap.GetEnumerable();
        }

    }
}
