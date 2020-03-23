using System;



namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> unsorted = new List<int>(); 
            // List<int> sorted;

            // Random random = new Random();

            int[] data = {1, 5, 7, 3, 9, 6, 7 };
            Console.WriteLine("before sort: ["+ string.Join(",", data)+ "]");

            MergeSort(data);
            Console.WriteLine("after sort: ["+ string.Join(",", data)+ "]");

        }

        //1. split the array in half, left and right
        //2. keep doing that for each subarray until you can't anymore cuz its size 1
        //3. combine your two sorted arrays, one by one through both of them 
        //      keeping the result sorted overall. 

        static void MergeSort(int[] array)
        {
            //base case
            //if size is 0 or 1 .. stop here its already sorted.
            if (array.Length < 2)
            {
                return;
            }


                //recursive case
                int middle = array.Length / 2; // for example, if length 5, middle will be 2. 

                int[] left = SubArray(array, 0, middle);
                int[] right = SubArray(array, middle, array.Length);

                MergeSort(left);
                MergeSort(right);

                //combine them
                int l = 0;
                int r = 0;
                int[] result = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    if(l >= left.Length)
                    {
                        result[i] = right[r];
                    }
                    else if (r >= right.Length)
                    {
                        result[i] = left[l];

                    }
                    else if (left[l] <= right[r])
                    {
                        result[i] = left[l];
                        l++;
                    }
                    else
                    {
                        result[i] = right[r];
                        r++;
                    }
                }
            
        }


//        0  1  2  3
// array [5, 8, 4, 8]
// start at 0 and end at 2
// result should be [8,4]
        static int[] SubArray(int[] array, int start, int end)
        {
            int length = end - start;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = array[start + i];
            }

            return result;
        }
    }
}
