using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.Practice1
{
   public class Trial_3
    {
        public long result = 0;
        public static void PrintAsciiValus()
        {
            //int i = 0;
            //int asciivalues = 0;
            //for(asciivalues=33; asciivalues<=127;asciivalues++)
            //{
            //    if (i % 5 == 0)

            //   { Console.WriteLine("\n"); }
            //    Console.WriteLine(" " + Convert.ToChar(asciivalues));
            //}
            //i++;

            int asciiValue;
            int i = 0;
            for (asciiValue = 33; asciiValue <= 127; asciiValue++)
            {
                if ((i % 5) == 0)
                {
                    Console.Write("\n");
                }
                Console.Write(" " + Convert.ToChar(asciiValue));
                i++;
            }

        }

        public static void calculatePower()
        {
            Console.WriteLine("Enter a Base Value ");
            int basevalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a powervalue ");
            int powervalue = int.Parse(Console.ReadLine());
            int result= power(basevalue, powervalue);
            Console.WriteLine("The Result of basevalue {0} to the power {1} is {2}",basevalue,powervalue,result);

        }

        private static int power(int basevalue, int powervalue)
        {
            if(powervalue==0)

            { 
                //Console.WriteLine("Result is 1: ", 1);
                return 1;
            }

           else  if(basevalue==0)
            {
                Console.WriteLine("Result is 0 : {0}", 0);
                return 0;
            }

            else
            {
                return (basevalue * power(basevalue, powervalue - 1));

            }
        
        }
    }
}
