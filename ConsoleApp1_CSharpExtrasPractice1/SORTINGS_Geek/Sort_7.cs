using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.SORTINGS_Geek
{
   public  class Sort_7
    {
        public static void Merge_Sort(int[] arr, int left, int mid, int right)
        {
            int n1_Leftsize = mid - left + 1;
            int n2_Rightsize = right - mid;

            int[] Left_subarray = new int[n1_Leftsize];
            int[] Right_subarray = new int[n2_Rightsize];

            int i, j;

            for (i=0; i<n1_Leftsize;i++)
            {
                Left_subarray[i] = arr[left + i];
            }
            for(j=0;j<n2_Rightsize;j++)
            {
                Right_subarray[j] = arr[mid + 1 + j];
            }

            i = 0;
            j = 0;
            int k = left;
            while(i<n1_Leftsize && j<n2_Rightsize)
            {
                if(Left_subarray[i]<=Right_subarray[j])
                {
                    arr[k] = Left_subarray[i];
                    i++;
                }
                else
                {
                    arr[k] = Right_subarray[j];
                    j++;
                }

                k++;
            }

            while (i<n1_Leftsize)
            {
                arr[k] = Left_subarray[i];
                i++; 
                k++;
            }
            while (i < n2_Rightsize)
            {
                arr[k] = Right_subarray[j];
                j++;
                k++;
            }

        }

        public static void Sort(int[] arr, int left, int right)
        {
            if (left<right)
            {
                int mid = (left + right) / 2;

                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);

                Merge_Sort(arr, left, mid, right); 
            }

        }

        public static void Display_MERGERSORT()
        {
            Console.WriteLine();
            Console.WriteLine("       SORT-7 ::::::: MERGE ");
            Console.WriteLine(" Welcome TO the  World of MERGE SORT");
            Console.WriteLine();
            int[] arra1 = { 23, 12, 67, 89, 43, 8, 30 };
            int n = arra1.Length;
            Console.WriteLine(" The UNSORTED ARRAY BEFORE MY MERGER SORT " );
            foreach(int i in arra1)
            {
                Console.Write(" " +i);
            }
            Console.WriteLine();
            Console.WriteLine(" The Sorted Array is ");
            Sort(arra1, 0, n - 1);
            foreach(int i in arra1)
            {
                Console.Write("  " + i);
            }
            Console.WriteLine();
            Console.ReadLine();


        }

    }
}
