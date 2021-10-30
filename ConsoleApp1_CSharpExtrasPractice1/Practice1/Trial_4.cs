using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.Practice1
{
   public class Trial_4
    {
        public static void FindSize()
        {
            int x;
            x = sizeof(int);
            Console.WriteLine(x);
            byte[] dataBytes = BitConverter.GetBytes(x);
            int d = dataBytes.Length;
            Console.WriteLine(d);

        }

    }
}
