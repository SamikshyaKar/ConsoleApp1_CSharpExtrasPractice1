using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.SORTINGS_Geek
{
    public static class Sort_3
    {
        public static Random rand = new Random();
        public static void SelectionSort()
        {
            Console.WriteLine();
            Console.WriteLine(" Inside Selection Sort ");
            Console.WriteLine( " The Unsorted array as follows ");
            int[] arr = new int[10];
            for( int i=0;i<arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }

            foreach(int i in arr)
            {
                Console.Write(" " +i);
            }
            Console.WriteLine();
            Console.WriteLine(" The Sorted array is : ");
            Selection_Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

        }

        private static void Selection_Sort(int[] arr)
        {
            for(int i= 0; i<arr.Length-1;i++)
            {
                int min_index = i;
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[j]<arr[min_index])
                    {
                        min_index = j;
                    }

                }

                int temp = arr[min_index];
                arr[min_index] = arr[i];
                arr[i] = temp;
            }                       
        }

       
    }
}
