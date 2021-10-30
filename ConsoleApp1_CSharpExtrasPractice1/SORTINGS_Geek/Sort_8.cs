using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.SORTINGS_Geek
{
    public class Sort_8
    {
       public  class MergeSort
        {

            // Merges two subarrays of []arr.
            // First subarray is arr[l..m]
            // Second subarray is arr[m+1..r]
         public static  void merge(int[] arr, int l, int m, int r)
            {
                // Find sizes of two
                // subarrays to be merged
                int n1 = m - l + 1;
                int n2 = r - m;

                // Create temp arrays
                int[] L = new int[n1];
                int[] R = new int[n2];
                int i, j;

                // Copy data to temp arrays
                for (i = 0; i < n1; ++i)
                    L[i] = arr[l + i];
                for (j = 0; j < n2; ++j)
                    R[j] = arr[m + 1 + j];

                // Merge the temp arrays

                // Initial indexes of first
                // and second subarrays
                i = 0;
                j = 0;

                // Initial index of merged
                // subarry array
                int k = l;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                // Copy remaining elements
                // of L[] if any
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }

                // Copy remaining elements
                // of R[] if any
                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }

            public static void Sort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int mid = (left + right) / 2;

                    Sort(arr, left, mid);
                    Sort(arr, mid + 1, right);
                    merge(arr, left, mid, right);
                }

            }

            public static void Display_MERGERSORT()
            {
                Console.WriteLine();
                Console.WriteLine(" Welcome TO the  World of MERGE SORT");
                Console.WriteLine();
                int[] arra1 = { 23, 12, 67, 89, 43, 8, 30 };
                int n = arra1.Length;
                Console.WriteLine(" The UNSORTED ARRAY BEFORE MY MERGER SORT ");
                foreach (int i in arra1)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
                Console.WriteLine(" The Sorted Array is ");
                Sort(arra1, 0, n - 1);
                foreach (int i in arra1)
                {
                    Console.Write("  " + i);
                }
                Console.WriteLine();


            }

        }



    }

}
