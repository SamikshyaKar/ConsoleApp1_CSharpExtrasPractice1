using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.SORTINGS_Geek
{
    public class Sort_1
    {
        public static Random rand = new Random();
        public static void sortbubblesort()
        {
            int[] arr = new int[10];
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            Console.WriteLine("The Unsorted Array as Follows");
            Console.BackgroundColor = ConsoleColor.Red;

            foreach (int i in arr)
            {
                Console.Write(" " +i);
            }
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" Entry to Bubble Sort");
            Console.WriteLine(" The Sorted Array with Bubble SORT as follows :: ");
            Bubble_Sort(arr);

            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

        }

        private static void Bubble_Sort(int[] arr)
        {
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=0; j<arr.Length-1-i;j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        int temp=  arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }

                }

            }
        }
    }
}
