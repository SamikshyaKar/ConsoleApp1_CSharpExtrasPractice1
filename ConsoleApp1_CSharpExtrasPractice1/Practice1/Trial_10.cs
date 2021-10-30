using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.Practice1
{
   public  class Trial_10
    {
     public static void MyExperiment1()
        {
            Console.WriteLine(" The Experiments " );
            int[] arr = new int[5];
            for (int i=0; i<5; i++)
            {
                arr[i] = i;
            }
            int[] arr2 = new int[5];
            for( int p=0;p<5;p++)
            {
                arr2[p] = p * 2;

            }
            Console.WriteLine("    Console BackGround Colour {0} ", Console.BackgroundColor);
            foreach (int i in arr)
            {
                Console.Write(" " +i);
            }

            Console.WriteLine();
            Console.WriteLine("     Console BackGround Colour {0} ", Console.BackgroundColor);
            foreach (int p in arr2)
            {                              
                Console.Write(" " +p);
            }
            Console.WriteLine();
            Console.WriteLine("    Console BackGround Colour {0} ", Console.BackgroundColor);
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i=0; i<arr.Length;i++)
            {
               Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("    Console BackGround Colour {0} ", Console.BackgroundColor);
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("    Console BackGround Colour {0} ", Console.BackgroundColor);
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 0; i <= arr.Length-1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("   Console BackGround Colour {0} ", Console.BackgroundColor);
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("    Console BackGround Colour {0} ", Console.BackgroundColor);
            Console.WriteLine("            Simple array.length-1");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("                for i =arr.Length  and j= max till i  ");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("      i value is  " + i + "  ");
                Console.WriteLine();

                for (int j = 0; j < i; j++)
                {
                    Console.Write("  i value is  " + i + " ");
                    Console.WriteLine();
                    Console.Write(" j value is  " + j + " ");
                    Console.WriteLine();
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("                for i =arr.Length-1  and j= max till i  ");

            for (int i=0;i<arr.Length-1;i++)
            {
                Console.Write("      i value is  " + i + "  ");
                Console.WriteLine();

                for (int j=0;j<i;j++ )
                {
                    Console.Write("i value is  " + i + " ");
                    Console.WriteLine();
                    Console.Write(" j value is  " + j + " ");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("               for i =arr.Length - 1 and j= arr.Length " );

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write("      i value is  " + i + "  ");
                Console.WriteLine();

                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine();
                    Console.Write(" i value is ** " + i + " ");
                    Console.WriteLine();
                    Console.Write(" j value is  " + j + " ");
                    Console.WriteLine();

                }
            }
            Console.WriteLine();           
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              for i =arr.Length - 1 and j= arr.Length-1 ");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write("      i value is  " + i + "  ");
                Console.WriteLine();

                for (int j = 0; j < arr.Length-1; j++)
                {
                    Console.Write(" i value is !!** " + i + " ");
                    Console.WriteLine();
                    Console.Write(" j value is  " + j + " ");
                    Console.WriteLine();

                }
            }
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("               for i =arr.Length - 1 and j= arr.Length-2 ");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write("      i value is  " + i + "  ");
                Console.WriteLine();

                for (int j = 0; j < arr.Length-2; j++)
                {
                    Console.Write(" i value is ** " + i + " ");
                    Console.WriteLine();
                    Console.Write(" j value is  " + j + " ");
                    Console.WriteLine();

                }
            }
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();

        }



    }
}
