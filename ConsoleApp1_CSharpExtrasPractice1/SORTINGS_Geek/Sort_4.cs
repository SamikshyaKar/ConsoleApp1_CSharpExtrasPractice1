using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1
{
    public class Sort_4
    {
        public static Random rand = new Random();

        public static void InsertionSort()
        {
      
            int[] arr = new int[10];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            Console.WriteLine();
            Console.WriteLine(" Inside Insertion Sort ");
            Console.WriteLine(" The Unsorted array as follows:");

            foreach(int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Console.WriteLine("   Insertion SORT ");
            Console.WriteLine(" The Sorted array as follows " );
            Insertion_Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
         }

        private static void Insertion_Sort(int[] arr)
        {
            for(int i=1;i<arr.Length;i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j>=0 && arr[j]>key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
             }
        }
    }
}
