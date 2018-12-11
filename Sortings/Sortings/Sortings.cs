using System;


namespace Sortings
{
    static class Sortings
    {

        public static int[] MergeSort(this int[] array) 
        {
            return MergeSort(array, 0, array.Length - 1);

        }

        private static int[] MergeSort(int[] array, int start, int end)
        {
            if (start > end)
                return null;

            if (start == end)
                return new int[] { array[start] };

            int mid = (start + end) / 2;

            int[] left = MergeSort(array, start, mid);
            int[] right = MergeSort(array, mid + 1, end);

            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            if (left == null)
                return right;

            if (right == null)
                return left;

            int[] r = new int[left.Length + right.Length];

            int p = 0, q = 0;

            for (int i = 0; i < r.Length;i++)
            {
                if (p >= left.Length)
                {
                    r[i] = right[q];
                    q++;
                    continue;
                }

                if(q >= right.Length){
                    r[i] = left[p];
                    p++;
                    continue;
                }

                if(left[p] <= right[q])
                {
                    r[i] = left[p];
                    p++;
                }
                else
                {
                    r[i] = right[q];
                    q++;

                }
            }

            return r;
        }


        public static int[] QuickSort(this int[] array)
        {
           
            return QuickSort(array, 0, array.Length - 1);
        }

        public static int[] QuickSort(this int[] array, int p, int q)
        {
            int i = p - 1;
            int j = p;

            if (p >= q)
                return array;

            while(j != q)
            {
                if(array[j] <= array[q])
                {

                    i++;

                    if (i != j)
                    {
                        int t = array[j];
                        array[j] = array[i];
                        array[i] = t;
                    }

                    j++;
                }
                else
                {
                    j++;
                }
            }

            int t2 = array[q];

            array[q] = array[i + 1];
            array[i+1] = t2;

            QuickSort(array, p, i);
            QuickSort(array, i+2 , q);

            return array;
        }

        public static int[] BubbleSort(this int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {

                    if(array[i]>array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }

            return array;
        }


        public static bool IsSorted(this int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    return false; 
            }

            return true;
        }
    }
}
