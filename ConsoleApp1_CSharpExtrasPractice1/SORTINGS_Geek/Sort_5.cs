using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.SORTINGS_Geek
{
   public  class Sort_5
    {
        public static Random rand = new Random();

        public static void D_Dsiplay_Quick_Sort()
        {
            int[] arr = new int[10];
            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = rand.Next(1, 100);
            }

            Console.WriteLine();
            Console.WriteLine(" Quick SORT ");
            Console.WriteLine(" The Unsorted array " );

            foreach (int i in arr)
            {
                Console.Write(" " +i);
            }
            Console.WriteLine();
            Console.WriteLine("    The Sorted Quick Sort array " );
            Console.WriteLine();
            //int low = 0; int high = 0;

            QuickSort(arr, 0, 9);

            Console.WriteLine("             The Sorted Array Quick_Sort  array ");


            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.ReadLine();
           
            int[] arr2 = { 10, 7, 8, 9, 1, 5 };
            foreach (int i in arr2)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            int n = arr.Length;
            QuickSort(arr2, 0, n - 1);
            Console.WriteLine("sorted array ");
            printArray(arr2, n);




        }

        private static void printArray(int[] arr, int n)
        {
            Console.WriteLine(" Inside  Quick Sort PRINT ARRAY ");

            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        private static int Partition_QuickSort(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for(int j=low;j<arr.Length;j++)
            {
                if(arr[j]<pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }

            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot_position = Partition_QuickSort(arr, low, high);

                Partition_QuickSort(arr, low, pivot_position-1);
                Partition_QuickSort(arr, pivot_position+1, high);


            }

        }
    }
}
