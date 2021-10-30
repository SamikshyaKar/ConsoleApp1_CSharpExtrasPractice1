using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.Practice1
{
   public class Trial_2
    {
        public static void Addition()
        {
            Console.WriteLine("Enter Two numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            sum = a + b;
            Console.WriteLine("Addition of two numbers {0} and {1} is {2}: " ,a,b,sum );
        }

        public static int Addition(int a, int b)
        {
            Console.WriteLine();
            int sum = a + b;
            Console.WriteLine("Sum is " + sum);
            return sum; 

        }
         public static int Division()
        {
            int result = 0;
            Console.WriteLine("Enter two numbers ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {

                result = a / b;
                Console.WriteLine("Result of {0} and {1} is ::=  {2} ", a,b,result);
                Console.WriteLine("Result of {0:0.00} and {1:0.00} is ::=  {2:0.00} ", a, b, result);

            }


            catch (DivideByZeroException ex)
            {

                Console.WriteLine( ex.Message );

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error Occured");              

            }

            return result;

        }

    }
}
