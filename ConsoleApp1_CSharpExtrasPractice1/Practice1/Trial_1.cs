   using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.Practice1
{
    public class Trial_1
    {
        public static void ReverseString()
        {
            //string[] array1 = new string[10];
            //Console.WriteLine("Enter a Word");
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = Console.ReadLine();
            ////}
            //string str = Console.ReadLine();

            //Array.Reverse(array1);
            //return array1.ToString();
            string str = " ", reverse = " ";

            Console.WriteLine(" Enter a word ");
             str = Console.ReadLine();
            int length = 0;
            length = str.Length-1;
            while(length>=0)
            {
                reverse = reverse + str[length];
                length--;

            }

            Console.WriteLine("Reversed String is " +reverse);
            //Console.ReadLine();

        }

     public  static string ReverseStringSecond (string s)
        {
            // Convert to char array, then call Array.Reverse.
            // ... Finally use string constructor on array.
            char[] array = s.ToCharArray();
            Array.Reverse(array);        
            return new string(array);
            
        }

        public static void ReverseStringThird()
        {
            Console.WriteLine();
            Console.WriteLine("Enter a Word ");
            string str = Console.ReadLine();
            char[] array1 = str.ToCharArray();
            Array.Reverse(array1);
            Console.WriteLine(array1);
                    
        }

        public static void StringUpper()
        {
            Console.WriteLine();
            Console.WriteLine("Enter a string ");
            string str = Console.ReadLine();
            if (str.Length==0)
            {
                Console.WriteLine("Empty String");

            }
            else if (str.Length==1)
            {
                Console.WriteLine(char.ToUpper(str[0]));

            }
            else
            {
                Console.WriteLine(char.ToUpper(str[0])+str.Substring(1));

            }

        }
    }
}
  