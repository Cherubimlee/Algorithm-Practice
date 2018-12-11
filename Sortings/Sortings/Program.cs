using System;

namespace Sortings
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 50000;

            int[] array = new int[size];

            Random r = new Random();

            for (int i = 0; i < size;i++)
            {
                array[i] = r.Next(-1*size,size);
            }

            DateTime d0 = DateTime.Now;
            var sorted = array.BubbleSort();
            var d1 = DateTime.Now;


            var sorted2 = array.QuickSort();
            var d2 = DateTime.Now;

            var sorted3 = array.QuickSort();
            var d3 = DateTime.Now;


            Console.WriteLine("Bubble: " + (d1-d0).TotalMilliseconds);
            Console.WriteLine("Merge: " + (d2 - d1).TotalMilliseconds);
            Console.WriteLine("Qucik: " + (d3 - d2).TotalMilliseconds);
        }
    }
}
