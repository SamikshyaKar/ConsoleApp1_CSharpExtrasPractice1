using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.Practice1
{
   public static  class Trial_11
    {
        public static void displayarraysdifferents()
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write("  " + arr[i]);
            }
            Console.WriteLine();
            NewMethod(arr);

            NewMethod1(arr);

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" Tests for Loopings " );
            Console.WriteLine("            Exps function now ");
            exps(arr);
            exps_modified(arr);
            exps_moreexp(arr);
            exps_modified_selectionsort(arr);
        }

        private static void exps_modified_selectionsort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Find the minimum element in unsorted array 
                Console.WriteLine("         Inside exps_modified_selectionsort(int[] arr)");
                Console.WriteLine("        The i Value is" + i);
                for (int j = i + 1; j < arr.Length; j++)
                {
                    Console.WriteLine();
                    Console.Write(" The j value is {0} and (i+1) is {1} " , j, (i+1));
                    Console.WriteLine();
                    Console.ReadLine();
                }
            }
        }
        private static void exps_moreexp(int[] arr)
        {
            Console.WriteLine(" Inside exps_moreexp(arr) " );
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine();
                Console.Write("                   i value is " + i);
                for (int j = 0; j < n - 1; j++)
                {
                    Console.WriteLine(" !!!!!!!!");
                    Console.Write("    j  and (j+1) values are {0} , {1} ", j, (j + 1));
                    Console.WriteLine();

                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }

        private static void exps_modified(int[] arr)
        {

            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine();
                Console.Write("                   i value is " + i);
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.WriteLine(" !!!!!!!!");
                    Console.Write("    j  and (j+1) values are {0} , {1} " ,j, (j+1) );
                    Console.WriteLine();

                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }

        private static void NewMethod1(int[] arr)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("                  The valus of i is :::::::" +i);
                for (int j = 0; j < arr.Length-1; j++)
                {
                    Console.WriteLine( " The  j Value is  " + j );
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }

        private static void NewMethod(int[] arr)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine("                  The valus of i is :::::::{0}" + i);
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    Console.WriteLine(" The  j Value is  " + j);
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }

            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }


        public static void exps(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine();
                Console.Write("                   i value is " +i );
            for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write( " j valus is " +j);

                }
                Console.WriteLine();

                   }

        }

    }

    }



